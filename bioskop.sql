-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               10.4.24-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             12.0.0.6468
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for bioskop
CREATE DATABASE IF NOT EXISTS `bioskop` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `bioskop`;

-- Dumping structure for table bioskop.film
CREATE TABLE IF NOT EXISTS `film` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama_film` varchar(255) NOT NULL,
  `genre` varchar(255) NOT NULL,
  `deskripsi` longtext NOT NULL,
  `director` varchar(255) NOT NULL,
  `duration` int(11) NOT NULL,
  `date_release` date NOT NULL,
  `bahasa` varchar(255) NOT NULL,
  `harga_film` int(11) NOT NULL,
  `foto` text NOT NULL,
  `rating_usia` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table bioskop.jadwal_tayang
CREATE TABLE IF NOT EXISTS `jadwal_tayang` (
  `id_jadwal_tayang` int(11) NOT NULL AUTO_INCREMENT,
  `id_film` int(11) NOT NULL,
  `id_studio` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  `waktu_mulai` time NOT NULL,
  `waktu_selesai` time NOT NULL,
  PRIMARY KEY (`id_jadwal_tayang`),
  KEY `fk_film` (`id_film`),
  KEY `fk_studio` (`id_studio`),
  CONSTRAINT `fk_film` FOREIGN KEY (`id_film`) REFERENCES `film` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_studio` FOREIGN KEY (`id_studio`) REFERENCES `studio` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table bioskop.studio
CREATE TABLE IF NOT EXISTS `studio` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama_studio` varchar(255) NOT NULL DEFAULT '0',
  `jenis_studio` varchar(255) NOT NULL DEFAULT '0',
  `kapasitas` int(11) NOT NULL,
  `harga_kursi` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table bioskop.tiket
CREATE TABLE IF NOT EXISTS `tiket` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_jadwal_tayang` int(11) NOT NULL,
  `total_harga` int(20) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_jadwal_tayang` (`id_jadwal_tayang`),
  CONSTRAINT `fk_jadwal_tayang` FOREIGN KEY (`id_jadwal_tayang`) REFERENCES `jadwal_tayang` (`id_jadwal_tayang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table bioskop.user
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `registered_at` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
