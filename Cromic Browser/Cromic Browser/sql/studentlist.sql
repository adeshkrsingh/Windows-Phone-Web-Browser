-- phpMyAdmin SQL Dump
-- version 4.0.10.7
-- http://www.phpmyadmin.net
--
-- Host: localhost:3306
-- Generation Time: Oct 18, 2016 at 12:40 PM
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
-- Table structure for table `studentlist`
--

CREATE TABLE IF NOT EXISTS `studentlist` (
  `SNo` int(11) NOT NULL AUTO_INCREMENT,
  `RollNo` bigint(20) NOT NULL,
  `Semester` int(5) NOT NULL DEFAULT '1',
  `Name` varchar(200) NOT NULL,
  PRIMARY KEY (`SNo`),
  UNIQUE KEY `RollNo` (`RollNo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=77 ;

--
-- Dumping data for table `studentlist`
--

INSERT INTO `studentlist` (`SNo`, `RollNo`, `Semester`, `Name`) VALUES
(1, 1404313001, 5, 'Aarohan'),
(2, 1404313002, 5, 'Aayushi'),
(3, 1404313003, 5, 'Abhay'),
(4, 1404313004, 5, 'Abhishek'),
(5, 1404313005, 5, 'Abhishek'),
(6, 1404313006, 5, 'Adesh'),
(7, 1404313007, 5, 'Akash'),
(8, 1404313008, 5, 'Anchal'),
(9, 1404313009, 5, 'Anil'),
(10, 1404313010, 5, 'Anirudh'),
(11, 1404313011, 5, 'Antriksh'),
(12, 1404313012, 5, 'Anuraj'),
(13, 1404313013, 5, 'Aparna'),
(14, 1404313014, 5, 'Arihant'),
(15, 1404313015, 5, 'Ashish'),
(16, 1404313016, 5, 'Divya'),
(17, 1404313017, 5, 'Harshul'),
(18, 1404313018, 5, 'Hukum'),
(19, 1404313019, 5, 'Kamlesh'),
(20, 1404313020, 5, 'Nitin'),
(21, 1404313021, 5, 'Prachi'),
(22, 1404313023, 5, 'Priyanshul'),
(23, 1404313024, 5, 'Rakesh'),
(24, 1404313026, 5, 'Ravi'),
(25, 1404313027, 5, 'Rishab'),
(26, 1404313028, 5, 'Sandeep'),
(27, 1404313029, 5, 'Shaila'),
(28, 1404313030, 5, 'Shivam'),
(29, 1404313031, 5, 'Shubham'),
(30, 1404313032, 5, 'Shubham'),
(31, 1404313033, 5, 'Siddharth'),
(32, 1404313034, 5, 'Sunil'),
(33, 1404313035, 5, 'Tanya'),
(34, 1404313036, 5, 'Vikash'),
(35, 1504313901, 5, 'Neelam'),
(36, 1504313902, 5, 'Rupesh'),
(37, 1504313903, 5, 'Shabnam'),
(38, 1504313904, 5, 'Sadhvi'),
(39, 1304313001, 7, 'Amit Sachan'),
(40, 1304313002, 7, 'Amit Tiwari'),
(41, 1304313003, 7, 'Anil Singh'),
(42, 1304313004, 7, 'Anshul Sharma'),
(43, 1304313005, 7, 'Anuj Kumar'),
(44, 1304313006, 7, 'Avinash Kumar'),
(45, 1304313007, 7, 'Ayushi Singhal'),
(46, 1304313008, 7, 'Bhoopendra Rajput'),
(47, 1304313009, 7, 'Brijesh Kumar'),
(48, 1304313010, 7, 'Deepak Sharma'),
(49, 1304313011, 7, 'Himanshu'),
(50, 1304313012, 7, 'Himanshu Chaudhary'),
(51, 1304313013, 7, 'Jitendra Kumar'),
(52, 1304313014, 7, 'Jitendra Kr. Kushwaha'),
(53, 1304313015, 7, 'Kartik Sharma'),
(54, 1304313016, 7, 'Kriti Mehrotra'),
(55, 1304313017, 7, 'Lakshmi Nivas Gupta'),
(56, 1304313018, 7, 'Lalit Parmar'),
(57, 1304313019, 7, 'Manisha Agarwal'),
(58, 1304313020, 7, 'Mohd. Arsalaan Hamid'),
(59, 1304313021, 7, 'Ojas Srivastava'),
(60, 1304313022, 7, 'Priya Singh'),
(61, 1304313023, 7, 'Priyank Singh'),
(62, 1304313024, 7, 'Sanju Kumar'),
(63, 1304313025, 7, 'Satyam Pradeep'),
(64, 1304313026, 7, 'Shivam Upadhyay'),
(65, 1304313027, 7, 'Shubha Mitra'),
(66, 1304313028, 7, 'Saurabh Gautam'),
(67, 1304313029, 7, 'Utkarsh Rathore'),
(68, 1304313030, 7, 'Varun Gupta'),
(69, 1304313031, 7, 'Veerpratap Singh'),
(70, 1404313901, 7, 'Anamika Rawat'),
(71, 1404313902, 7, 'Anil Kr. Yadav'),
(72, 1404313903, 7, 'Piyush Varshney'),
(73, 1404313904, 7, 'Pradeep Kumar'),
(74, 1404313905, 7, 'Rubi Gautam'),
(75, 1404313906, 7, 'Sheila Kumari'),
(76, 1404313907, 7, 'Shivam Varshney');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
