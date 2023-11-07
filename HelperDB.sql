-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 07, 2023 at 05:41 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `helperdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `event_date`
--

CREATE TABLE `event_date` (
  `Date` varchar(10) NOT NULL,
  `Event` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `list`
--

CREATE TABLE `list` (
  `Title` varchar(24) NOT NULL,
  `Description` varchar(50) NOT NULL,
  `DueDate` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `list`
--

INSERT INTO `list` (`Title`, `Description`, `DueDate`) VALUES
('Testing', 'gotta test stuff and add things', '15-11-2023');

-- --------------------------------------------------------

--
-- Table structure for table `notes`
--

CREATE TABLE `notes` (
  `ID` int(2) NOT NULL,
  `judul` varchar(24) NOT NULL,
  `tanggal` varchar(10) NOT NULL,
  `Description` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `notes`
--

INSERT INTO `notes` (`ID`, `judul`, `tanggal`, `Description`) VALUES
(4, 'New Note', '07/11/2023', ''),
(7, 'Mate', '07/11/2023', ''),
(8, 'IPS', '07/11/2023', ''),
(10, 'Test', '07/11/2023', ''),
(12, 'Comp', '07/11/2023', ''),
(13, 'New Note', '07/11/2023', '');

-- --------------------------------------------------------

--
-- Table structure for table `schedule_table`
--

CREATE TABLE `schedule_table` (
  `Monday` varchar(16) NOT NULL,
  `Tuesday` varchar(16) NOT NULL,
  `Wednesday` varchar(16) NOT NULL,
  `Thursday` varchar(16) NOT NULL,
  `Friday` varchar(16) NOT NULL,
  `Saturday` varchar(16) NOT NULL,
  `Sunday` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `User_ID` int(3) DEFAULT NULL,
  `Username` varchar(16) NOT NULL,
  `Password` varchar(24) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `notes`
--
ALTER TABLE `notes`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `notes`
--
ALTER TABLE `notes`
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
