-- -----------------------------------------------------
-- Table `user`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `user` ;

CREATE TABLE IF NOT EXISTS `user` (
  `id` INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  `username` VARCHAR(16) NOT NULL,
  `email` VARCHAR(255) NOT NULL,
  `password` VARCHAR(32) NOT NULL,
  `type` TINYINT(6) NOT NULL,
  );


-- -----------------------------------------------------
-- Table `active`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `active` ;

CREATE TABLE IF NOT EXISTS `active` (
  `ticker` VARCHAR(16) NOT NULL,
  `amount` INT NOT NULL DEFAULT 0,
  `price` DECIMAL NOT NULL DEFAULT 0,
  `description` VARCHAR(255) NULL DEFAULT 'This is the default description.',
  PRIMARY KEY (`ticker`)
);


-- -----------------------------------------------------
-- Table `wallet`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `wallet` ;

CREATE TABLE IF NOT EXISTS `wallet` (
  `id` INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  `amount` INT NOT NULL DEFAULT 0,
  `user_id` INT NOT NULL,
  `ticker` VARCHAR(16) NOT NULL,
  CONSTRAINT `fk_wallet_user`
    FOREIGN KEY (`user_id`)
    REFERENCES `user` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_wallet_active1`
    FOREIGN KEY (`ticker`)
    REFERENCES `active` (`ticker`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `transactions`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `transactions` ;

CREATE TABLE IF NOT EXISTS `transactions` (
  `id` INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
  `ticker` VARCHAR(16) NOT NULL,
  `amount` INT NULL,
  `price` DECIMAL NULL,
  `user_id` INT NOT NULL,
  `date` VARCHAR(16) NOT NULL,
);

-- Creating default user (admin)
INSERT INTO user (username, email, password, type) VALUES ('admin', 'admin@admin.com', 'admin', 1);