-- Table: active
DROP TABLE IF EXISTS active;
CREATE TABLE `active` (
  `ticker` VARCHAR(6) NOT NULL,
  `amount` INT NULL,
  `price` INT NULL,
  `description` VARCHAR(255) NULL,
  PRIMARY KEY (`ticker`)
);

-- Table: advertise
DROP TABLE IF EXISTS advertise;
CREATE TABLE `advertise` (
  `id` INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  `amount` INT NULL,
  `price` INT NULL,
  `type` TINYINT(6) NULL,
  `ticker` VARCHAR(6) NOT NULL,
  `wallet_id` INT NOT NULL,
  CONSTRAINT `fk_advertise_wallet1`
    FOREIGN KEY (`wallet_id`)
    REFERENCES `wallet` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

-- Table: history
DROP TABLE IF EXISTS history;
CREATE TABLE `history` (
  `id` INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  `amount` INT NULL,
  `price` INT NULL,
  `type` TINYINT(6) NULL,
  `date` TIMESTAMP(6) NULL
  );

-- Table: user
DROP TABLE IF EXISTS user;
CREATE TABLE `user` (
  `id` INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  `username` VARCHAR(16) NULL,
  `email` VARCHAR(255) NULL,
  `password` VARCHAR(32) NULL,
  `type` TINYINT(6) NULL,
  `balance` DECIMAL(10) NULL
);

-- Creating default user (admin)
INSERT INTO user (username, email, password, type, balance) VALUES ('admin', 'admin@admin.com', 'admin', 1, 8000);

-- Table: wallet
DROP TABLE IF EXISTS wallet;
CREATE TABLE `wallet` (
  `id` INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  `amount` INT NULL,
  `user_id` INT NOT NULL,
  `actives_ticker` VARCHAR(6) NOT NULL,
  CONSTRAINT `fk_user_actives_user`
    FOREIGN KEY (`user_id`)
    REFERENCES `user` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_user_actives_actives1`
    FOREIGN KEY (`actives_ticker`)
    REFERENCES `active` (`ticker`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);
