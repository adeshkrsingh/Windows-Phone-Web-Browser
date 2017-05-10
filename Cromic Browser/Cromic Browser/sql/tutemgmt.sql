-- phpMyAdmin SQL Dump
-- version 4.0.10.7
-- http://www.phpmyadmin.net
--
-- Host: localhost:3306
-- Generation Time: Oct 18, 2016 at 12:44 PM
-- Server version: 5.6.32-78.0-log
-- PHP Version: 5.4.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `risinola_it_2016_2017`
--

-- --------------------------------------------------------

--
-- Table structure for table `tutemgmt`
--

CREATE TABLE IF NOT EXISTS `tutemgmt` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `userid` varchar(50) NOT NULL,
  `subcode` varchar(50) NOT NULL,
  `semester` int(11) NOT NULL,
  `date` date NOT NULL,
  `time` time NOT NULL,
  `nooftute` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `subcode` (`subcode`),
  UNIQUE KEY `subcode_2` (`subcode`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `tutemgmt`
--

INSERT INTO `tutemgmt` (`id`, `userid`, `subcode`, `semester`, `date`, `time`, `nooftute`) VALUES
(6, 'raushan#sir', 'ECS502_tut1', 5, '2016-10-17', '18:20:48', 2),
(5, 'raushan#sir', 'ECS501_lect', 5, '2016-10-17', '13:49:13', 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
