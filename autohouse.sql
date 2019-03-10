-- --------------------------------------------------------
-- Хост:                         127.0.0.1
-- Версия на сървъра:            8.0.13 - MySQL Community Server - GPL
-- ОС на сървъра:                Win64
-- HeidiSQL Версия:              9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for autohouse
CREATE DATABASE IF NOT EXISTS `autohouse` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `autohouse`;

-- Дъмп структура за таблица autohouse.autohouses
CREATE TABLE IF NOT EXISTS `autohouses` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `adress` varchar(50) NOT NULL,
  `id_owner` int(11) NOT NULL,
  `town` varchar(50) NOT NULL,
  `id_vip` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`,`adress`),
  KEY `FK_idOwnerAutoHouses_idUsers` (`id_owner`),
  KEY `FK_idVipAutoHouses_idVipAH` (`id_vip`),
  CONSTRAINT `FK_idOwnerAutoHouses_idUsers` FOREIGN KEY (`id_owner`) REFERENCES `users` (`id`),
  CONSTRAINT `FK_idVipAutoHouses_idVipAH` FOREIGN KEY (`id_vip`) REFERENCES `vipah` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.carforsell
CREATE TABLE IF NOT EXISTS `carforsell` (
  `id_car` int(11) NOT NULL,
  `id_ah` int(11) NOT NULL,
  KEY `FK_idCarCarForSell_idCarCars` (`id_car`),
  KEY `FK_idAHCarForSell_idAutoHouses` (`id_ah`),
  CONSTRAINT `FK_idAHCarForSell_idAutoHouses` FOREIGN KEY (`id_ah`) REFERENCES `autohouses` (`id`),
  CONSTRAINT `FK_idCarCarForSell_idCarCars` FOREIGN KEY (`id_car`) REFERENCES `cars` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.cars
CREATE TABLE IF NOT EXISTS `cars` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `model` varchar(50) NOT NULL,
  `brand` varchar(50) NOT NULL,
  `color` varchar(50) NOT NULL,
  `price` decimal(12,2) NOT NULL,
  `year` varchar(50) NOT NULL,
  `probeg` varchar(50) NOT NULL,
  `image` blob NOT NULL,
  `bool_rent_car` enum('true','false') NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.grafik
CREATE TABLE IF NOT EXISTS `grafik` (
  `id_user` int(11) NOT NULL,
  `id_cars` int(11) NOT NULL,
  `time_take` datetime NOT NULL,
  `time_return` datetime NOT NULL,
  KEY `FK_grafikIdUser_usersId` (`id_user`),
  KEY `FK_grafikIdCars_carsId` (`id_cars`),
  CONSTRAINT `FK_grafikIdCars_carsId` FOREIGN KEY (`id_cars`) REFERENCES `cars` (`id`),
  CONSTRAINT `FK_grafikIdUser_usersId` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.images
CREATE TABLE IF NOT EXISTS `images` (
  `idCar` int(11) NOT NULL,
  `image` blob NOT NULL,
  KEY `FK_imageIdCar_idCar` (`idCar`),
  CONSTRAINT `FK_imageIdCar_idCar` FOREIGN KEY (`idCar`) REFERENCES `cars` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.permission
CREATE TABLE IF NOT EXISTS `permission` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `addAH` enum('Y','N') NOT NULL,
  `delAH` enum('Y','N') NOT NULL,
  `addUser` enum('Y','N') NOT NULL,
  `delUser` enum('Y','N') NOT NULL,
  `viewStatistic` enum('Y','N') NOT NULL,
  `addCars` enum('Y','N') NOT NULL,
  `delCars` enum('Y','N') NOT NULL,
  `buyCar` enum('Y','N') NOT NULL,
  `rentCar` enum('Y','N') NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.rent_car
CREATE TABLE IF NOT EXISTS `rent_car` (
  `id_autoH` int(11) NOT NULL,
  `id_cars` int(11) NOT NULL,
  `price_day` varchar(50) NOT NULL,
  KEY `FK_RentIdAutoHouse_autohouseID` (`id_autoH`),
  KEY `FK_RentIdCars_carsID` (`id_cars`),
  CONSTRAINT `FK_RentIdAutoHouse_autohouseID` FOREIGN KEY (`id_autoH`) REFERENCES `autohouses` (`id`),
  CONSTRAINT `FK_RentIdCars_carsID` FOREIGN KEY (`id_cars`) REFERENCES `cars` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.sold_car
CREATE TABLE IF NOT EXISTS `sold_car` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `model` varchar(50) NOT NULL,
  `brand` varchar(50) NOT NULL,
  `color` varchar(50) NOT NULL,
  `year` varchar(50) NOT NULL,
  `probeg` varchar(50) NOT NULL,
  `image` blob NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.statistic_rent
CREATE TABLE IF NOT EXISTS `statistic_rent` (
  `id_user` int(11) NOT NULL,
  `id_cars` int(11) NOT NULL,
  `id_AH` int(11) NOT NULL,
  `time_take` date NOT NULL,
  `time_return` date NOT NULL,
  `moneyForRent` varchar(50) NOT NULL,
  KEY `FK_statisticIdUser_userId` (`id_user`),
  KEY `FK_statisticIdCars_CarsId` (`id_cars`),
  KEY `FK_statisticIdAh_autohousesId` (`id_AH`),
  CONSTRAINT `FK_statisticIdAh_autohousesId` FOREIGN KEY (`id_AH`) REFERENCES `autohouses` (`id`),
  CONSTRAINT `FK_statisticIdCars_CarsId` FOREIGN KEY (`id_cars`) REFERENCES `cars` (`id`),
  CONSTRAINT `FK_statisticIdUser_userId` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.statistic_sell
CREATE TABLE IF NOT EXISTS `statistic_sell` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_user` int(11) NOT NULL,
  `id_soldCar` int(11) NOT NULL,
  `id_AH` int(11) NOT NULL,
  `moneyForSell` varchar(50) NOT NULL,
  `soldDate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `FK_idUserSellStatisticSell_idUser` (`id_user`),
  KEY `FK_idSoldCarSellStatistic_idSoldCar` (`id_soldCar`),
  KEY `FK_idAhStatisticSell_idAutohouse` (`id_AH`),
  CONSTRAINT `FK_idAhStatisticSell_idAutohouse` FOREIGN KEY (`id_AH`) REFERENCES `autohouses` (`id`),
  CONSTRAINT `FK_idSoldCarSellStatistic_idSoldCar` FOREIGN KEY (`id_soldCar`) REFERENCES `sold_car` (`id`),
  CONSTRAINT `FK_idUserSellStatisticSell_idUser` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user` varchar(50) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `id_permission` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `User` (`user`),
  KEY `FK_idPremissionUsers_idPremission` (`id_permission`),
  CONSTRAINT `FK_idPremissionUsers_idPremission` FOREIGN KEY (`id_permission`) REFERENCES `permission` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.users_ah
CREATE TABLE IF NOT EXISTS `users_ah` (
  `id_users` int(11) NOT NULL,
  `id_ah` int(11) NOT NULL,
  KEY `FK_idUsers_users` (`id_ah`),
  KEY `FK_idAH_autohouse` (`id_users`),
  CONSTRAINT `FK_idAH_autohouse` FOREIGN KEY (`id_users`) REFERENCES `users` (`id`),
  CONSTRAINT `FK_idUsers_users` FOREIGN KEY (`id_ah`) REFERENCES `autohouses` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
-- Дъмп структура за таблица autohouse.vipah
CREATE TABLE IF NOT EXISTS `vipah` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `vip` enum('Y','N') NOT NULL,
  `VipTime` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Data exporting was unselected.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
