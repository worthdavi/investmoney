using Dapper;
using investmoney.src.Controllers;
using investmoney.src.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investmoney.src.DAO
{
    class TransactionDao
    {
        public List<TransactionModel> LoadUserTransactions(User user)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                //  id, ticker, amount, price, user_id, date
                string query = "select id, ticker, amount, price, user_id, date, type from transactions where user_id = " + user.getId() + ";";
                var output = connection.Query<TransactionModel>(query, new DynamicParameters());
                return output.ToList();
            }
        }

        public int calculateMaked(List<Wallet> wallet, int user, string dia, string mes, string ano)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var dateStart = $"{ano}-{mes}-{dia}";
                var dateEnd = $"{ano}-{mes}-30";
                var valueTotal = 0.0;

                var l = 0.0;
                //string sqlV = "SELECT ticker, SUM(amount) as soma, SUM((price * amount)) as vendido, date FROM transactions GROUP BY ticker HAVING DATE(substr(date,7,4)||'-'||substr(date,4,2)||'-'||substr(date,1,2)) BETWEEN DATE('" + dateStart + "') AND DATE('" + dateEnd + "')  and type = 'V' and user_id = '" + user + "' ;";
                // string sqlC = "SELECT ticker, SUM(amount) as soma, SUM((price * amount)) as vendido, date FROM transactions GROUP BY ticker HAVING DATE(substr(date,7,4)||'-'||substr(date,4,2)||'-'||substr(date,1,2)) BETWEEN DATE('" + dateStart + "') AND DATE('" + dateEnd + "')  and type = 'C' and user_id = '" + user + "' ;";
                // var vend = connection.Query(sqlV, new DynamicParameters()).AsList();

                //var comp = connection.Query(sqlC, new DynamicParameters()).AsList();
                ActiveDao activeDa = new ActiveDao();
                var activesNames = activeDa.GetActivesNames();

                foreach (var item in activesNames)
                {
                    string totalVenda = "SELECT SUM((price * amount)) as soma, SUM(amount) as amount FROM transactions WHERE DATE(substr(date,7,4)||'-'||substr(date,4,2)||'-'||substr(date,1,2)) BETWEEN DATE('" + dateStart + "') AND DATE('" + dateEnd + "') and  type = 'V' and user_id = '" + user + "' and ticker = '" + item + "' ;";
                    var totalVendaImposto = connection.Query<dynamic>(totalVenda, new DynamicParameters());
                    valueTotal = valueTotal + Convert.ToDouble(totalVendaImposto.First().soma);

                    string consultaTotal = "SELECT SUM((price * amount)) as soma FROM transactions WHERE DATE(substr(date,7,4)||'-'||substr(date,4,2)||'-'||substr(date,1,2)) BETWEEN DATE('" + dateStart + "') AND DATE('" + dateEnd + "') and  type = 'C' and user_id = '" + user + "' and ticker = '" + item + "' ;";
                    var custoTotal1 = connection.Query<dynamic>(consultaTotal, new DynamicParameters());

                    var price_medio = custoTotal1.First().soma / totalVendaImposto.First().soma;
                    ActiveController activeController = new ActiveController();
                    var ticker = activeController.GetActiveByTicker(item);
                    var cotacao = Convert.ToDouble(ticker.price); // Convert.ToDouble(ticker.price);
                    var total = price_medio * totalVendaImposto.First().amount;
                    var valorMercado = totalVendaImposto.First().amount * cotacao;
                    var Lucro_prejuizo = Convert.ToDouble(valorMercado) - Convert.ToDouble(total);
                    l = Lucro_prejuizo + l;

                }
                if ((valueTotal) > 20000)
                {
                    var imposto = l - (l * 0.15);

                    return Convert.ToInt32(imposto);
                }
                else
                {
                    return Convert.ToInt32(l);
                }
                return Convert.ToInt32(l);
                /*
                 * if (wallet.Count() > 0)
                {
                    
                    foreach (var item in wallet)
                    {
                        string consultaCompra = "SELECT SUM(amount) as soma, date FROM transactions WHERE DATE(substr(date,7,4)||'-'||substr(date,4,2)||'-'||substr(date,1,2)) BETWEEN DATE('" + dateStart + "') AND DATE('" + dateEnd + "')  and type = 'C' and user_id = '" + user + "' and ticker = '" + item.ticker + "' ;";
                        string consultaVenda = "SELECT SUM(amount) as soma FROM transactions WHERE DATE(substr(date,7,4)||'-'||substr(date,4,2)||'-'||substr(date,1,2)) BETWEEN DATE('" + dateStart + "') AND DATE('" + dateEnd + "') and  type = 'V' and user_id = '" + user + "' and ticker = '" + item.ticker + "' ;";
                        string consultaTotal = "SELECT SUM((price * amount)) as soma FROM transactions WHERE DATE(substr(date,7,4)||'-'||substr(date,4,2)||'-'||substr(date,1,2)) BETWEEN DATE('" + dateStart + "') AND DATE('" + dateEnd + "') and  type = 'C' and user_id = '" + user + "' and ticker = '" + item.ticker + "' ;";
                        string totalVenda = "SELECT SUM((price * amount)) as soma FROM transactions WHERE DATE(substr(date,7,4)||'-'||substr(date,4,2)||'-'||substr(date,1,2)) BETWEEN DATE('" + dateStart + "') AND DATE('" + dateEnd + "') and  type = 'V' and user_id = '" + user + "' and ticker = '" + item.ticker + "' ;";
                        var totalVendaImposto = connection.Query<dynamic>(totalVenda, new DynamicParameters());
                        
                        var qtdVend = connection.Query<dynamic>(consultaVenda, new DynamicParameters());
                        var v = qtdVend.First();
                        if (v.soma == null || totalVendaImposto.First().soma == null)
                        {
                            Console.WriteLine(v);
                        }
                        else {
                            valueTotal = valueTotal + totalVendaImposto.First().soma;
                            var qtdComp = connection.Query<dynamic>(consultaCompra, new DynamicParameters());
                            var custoTotal1 = connection.Query<dynamic>(consultaTotal, new DynamicParameters());

                            var price_medio = custoTotal1.First().soma / qtdComp.First().soma;
                            ActiveController activeController = new ActiveController();
                            var ticker = activeController.GetActiveByTicker(item.ticker);
                            var cotacao = Convert.ToDouble(ticker.price); // Convert.ToDouble(ticker.price);
                            var total = price_medio * qtdVend.First().soma;
                            var valorMercado = qtdVend.First().soma * cotacao;
                            var Lucro_prejuizo = Convert.ToDouble(valorMercado) - Convert.ToDouble(total);
                            l = Lucro_prejuizo + l;
                        }
                        
                        
                    }
                    if((-1*valueTotal) > 20000)
                    {
                       // Console.WriteLine(valueTotal);
                       // Console.WriteLine(l);
                        var imposto = l - (l * 0.15);
                        //Console.WriteLine(imposto);
                        return Convert.ToInt32(imposto);
                    }
                    else
                    {
                        //Console.WriteLine(valueTotal);
                        //Console.WriteLine(l);
                        var imposto = l - (l * 0.15);
                        //Console.WriteLine(imposto);
                        return Convert.ToInt32(l);
                    }
                    

                }*/


            }
        }



        public int calculateMakedNotRealizado(List<Wallet> wallet, int user, string dia, string mes, string ano)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var dateStart = $"{ano}-{mes}-{dia}";
                var dateEnd = $"{ano}-{mes}-30";
                var l = 0.0;
                var valueTotal = 0.0;


                if (wallet.Count() > 0)
                {

                    foreach (var item in wallet)
                    {
                        string consultaCompra = "SELECT SUM(amount) as soma, date FROM transactions WHERE DATE(substr(date,7,4)||'-'||substr(date,4,2)||'-'||substr(date,1,2)) BETWEEN DATE('" + dateStart + "') AND DATE('" + dateEnd + "')  and type = 'C' and user_id = '" + user + "' and ticker = '" + item.ticker + "' ;";
                        string consultaTotal = "SELECT SUM((price * amount)) as soma FROM transactions WHERE DATE(substr(date,7,4)||'-'||substr(date,4,2)||'-'||substr(date,1,2)) BETWEEN DATE('" + dateStart + "') AND DATE('" + dateEnd + "') and  type = 'C' and user_id = '" + user + "' and ticker = '" + item.ticker + "' ;";

                        var qtdComp = connection.Query<dynamic>(consultaCompra, new DynamicParameters());
                        var valorTotal = connection.Query<dynamic>(consultaTotal, new DynamicParameters());
                        valueTotal = valueTotal + Convert.ToDouble(valorTotal.First().soma);

                        var price_medio = valorTotal.First().soma / qtdComp.First().soma;
                        ActiveController activeController = new ActiveController();
                        var ticker = activeController.GetActiveByTicker(item.ticker);
                        var cotacao = Convert.ToDouble(ticker.price); // Convert.ToDouble(ticker.price);
                        // var cotacao = 40;
                        var custoTotal = price_medio * item.amount;
                        var valorMercado = item.amount * cotacao;
                        Console.WriteLine(valorMercado);
                        var Lucro_prejuizo = valorMercado - custoTotal;
                        if (Lucro_prejuizo == null)
                        {
                            l = l + l;
                        }
                        else
                        {
                            l = Lucro_prejuizo + l;
                        }
                    }
                    if ((1 * valueTotal) > 20000)
                    {
                        var value = l - (l * 0.15);
                        //Console.WriteLine(imposto);
                        return Convert.ToInt32(value);
                    }
                    else
                    {
                        return Convert.ToInt32(l);
                    }


                }

                return Convert.ToInt32(l);



            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}