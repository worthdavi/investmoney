DROP TABLE IF EXISTS user ;

CREATE TABLE IF NOT EXISTS user (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  username VARCHAR(16) NOT NULL,
  email VARCHAR(255) NULL,
  password VARCHAR(32) NOT NULL,
  type TINYINT(6) NULL DEFAULT 1,
  balance DECIMAL(10) NULL
  );

-- -----------------------------------------------------
-- Creating the main administrator user
-- -----------------------------------------------------

INSERT INTO user (username, email, password, type, balance) VALUES ('admin', 'admin@admin.com', 'admin', 1, 8000);

-- -----------------------------------------------------
-- Table actives
-- -----------------------------------------------------
DROP TABLE IF EXISTS actives ;

CREATE TABLE IF NOT EXISTS actives (
  ticker VARCHAR(6) NOT NULL,
  share_amount INT NOT NULL,
  share_price INT NOT NULL,
  description VARCHAR(45) NULL,
  PRIMARY KEY (ticker));


-- -----------------------------------------------------
-- Table users_actives
-- -----------------------------------------------------
DROP TABLE IF EXISTS users_actives ;

CREATE TABLE IF NOT EXISTS users_actives (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  user_id INT NOT NULL,
  actives_ticker VARCHAR(6) NOT NULL,
  share_amount INT NULL,
  CONSTRAINT fk_users_actives_users
    FOREIGN KEY (user_id)
    REFERENCES user (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_users_actives_actives1
    FOREIGN KEY (actives_ticker)
    REFERENCES actives (ticker)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table advertising
-- -----------------------------------------------------
DROP TABLE IF EXISTS advertising ;

CREATE TABLE IF NOT EXISTS advertising (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  user_id INT NOT NULL,
  share_amount INT NOT NULL,
  share_price INT NOT NULL,
  type TINYINT(6) NOT NULL,
  CONSTRAINT fk_user_selling_user1
    FOREIGN KEY (user_id)
    REFERENCES user (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table advertising_historic
-- -----------------------------------------------------
DROP TABLE IF EXISTS advertising_historic ;

CREATE TABLE IF NOT EXISTS advertising_historic (
  id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  share_amount INT NOT NULL,
  share_price INT NOT NULL,
  type TINYINT(6) NOT NULL,
  date TIMESTAMP(6) NULL
  );
