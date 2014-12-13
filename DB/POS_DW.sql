-- phpMyAdmin SQL Dump
-- version 4.1.6
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 17, 2014 at 06:01 AM
-- Server version: 5.6.16
-- PHP Version: 5.5.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `POS_DW`
--
CREATE DATABASE IF NOT EXISTS `POS_DW` DEFAULT CHARACTER SET utf8 COLLATE utf8_croatian_ci;
USE `POS_DW`;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_Catagory`
--

DROP TABLE IF EXISTS `tbl_Catagory`;
CREATE TABLE IF NOT EXISTS `tbl_Catagory` (
  `CatNoAuto` int(8) NOT NULL AUTO_INCREMENT,
  `CatNo` varchar(20) COLLATE utf8_croatian_ci NOT NULL,
  `CatDescription` varchar(500) COLLATE utf8_croatian_ci NOT NULL,
  `CatDescriptionHtml` varchar(500) COLLATE utf8_croatian_ci NOT NULL,
  `CatName` varchar(200) COLLATE utf8_croatian_ci NOT NULL,
  `CatNameHtml` varchar(200) COLLATE utf8_croatian_ci NOT NULL,
  `CatImagePath` varchar(500) COLLATE utf8_croatian_ci NOT NULL,
  `CatImagePathHtml` varchar(500) COLLATE utf8_croatian_ci NOT NULL,
  PRIMARY KEY (`CatNoAuto`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_croatian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_Items`
--

DROP TABLE IF EXISTS `tbl_Items`;
CREATE TABLE IF NOT EXISTS `tbl_Items` (
  `ItemNoAuto` int(8) NOT NULL AUTO_INCREMENT,
  `ItemNo` varchar(20) COLLATE utf8_croatian_ci NOT NULL,
  `ItemName` varchar(200) COLLATE utf8_croatian_ci NOT NULL,
  `ItemDescription` varchar(200) COLLATE utf8_croatian_ci NOT NULL,
  `ItemDetail` varchar(200) COLLATE utf8_croatian_ci NOT NULL,
  `ItemImagePath` varchar(500) COLLATE utf8_croatian_ci NOT NULL,
  `CatNoAuto` int(20) NOT NULL,
  `CatName` varchar(200) COLLATE utf8_croatian_ci NOT NULL,
  `BarcodeNo1` varchar(50) COLLATE utf8_croatian_ci NOT NULL,
  `BarcodeNo2` varchar(50) COLLATE utf8_croatian_ci NOT NULL,
  `BarcodeNo3` varchar(50) COLLATE utf8_croatian_ci NOT NULL,
  `BarcodeNo4` varchar(50) COLLATE utf8_croatian_ci NOT NULL,
  `ItemUnitAuto` int(2) NOT NULL,
  `ItemUnitName` varchar(200) COLLATE utf8_croatian_ci NOT NULL,
  `ItemPrice` varchar(12) COLLATE utf8_croatian_ci NOT NULL,
  `ItemCost` varchar(12) COLLATE utf8_croatian_ci NOT NULL,
  `ItemOrder` varchar(12) COLLATE utf8_croatian_ci NOT NULL,
  `ItemOnhand` varchar(12) COLLATE utf8_croatian_ci NOT NULL,
  `ItemCostType` varchar(50) COLLATE utf8_croatian_ci NOT NULL,
  `ItemNameHtml` varchar(1000) COLLATE utf8_croatian_ci NOT NULL,
  `ItemDescriptionHtml` varchar(1000) COLLATE utf8_croatian_ci NOT NULL,
  `ItemDetailHtml` varchar(1000) COLLATE utf8_croatian_ci NOT NULL,
  `ItemImagePathHtml` varchar(1000) COLLATE utf8_croatian_ci NOT NULL,
  `ItemPriceHtml` varchar(200) COLLATE utf8_croatian_ci NOT NULL,
  `ItemIsStock` int(1) NOT NULL,
  `ItemIsNew` int(1) NOT NULL,
  `ItemIsDisplayWeb` int(1) NOT NULL,
  PRIMARY KEY (`ItemNoAuto`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_croatian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_Unit`
--

DROP TABLE IF EXISTS `tbl_Unit`;
CREATE TABLE IF NOT EXISTS `tbl_Unit` (
  `UnitNoAuto` int(2) NOT NULL AUTO_INCREMENT,
  `UnitName` varchar(200) COLLATE utf8_croatian_ci NOT NULL,
  `UnitQty` varchar(200) COLLATE utf8_croatian_ci NOT NULL,
  PRIMARY KEY (`UnitNoAuto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_croatian_ci AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
