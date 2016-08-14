/*
Navicat MySQL Data Transfer

Source Server         : ROOT
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : jsla

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2016-08-14 23:05:23
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `meta_file`
-- ----------------------------
DROP TABLE IF EXISTS `meta_file`;
CREATE TABLE `meta_file` (
  `File_ID` varchar(9) NOT NULL,
  `Title` varchar(20) NOT NULL,
  `SubjectIID` varchar(9) NOT NULL,
  `Description` text NOT NULL,
  `UploadedBy` varchar(9) NOT NULL,
  `UploadedTo` varchar(9) NOT NULL,
  `FilePath` text NOT NULL,
  PRIMARY KEY (`File_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of meta_file
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_academicstaff`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_academicstaff`;
CREATE TABLE `tbl_academicstaff` (
  `Staff_ID` varchar(9) NOT NULL,
  `LastName` varchar(25) NOT NULL,
  `FirstName` varchar(25) NOT NULL,
  `MiddleInitial` varchar(3) DEFAULT NULL,
  `Birthday` varchar(8) NOT NULL,
  `BirthMonth` varchar(10) NOT NULL,
  `BirthYear` int(4) NOT NULL,
  `Avatar` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Staff_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tbl_academicstaff
-- ----------------------------
INSERT INTO `tbl_academicstaff` VALUES ('202020', 'balabis', 'joyce', 'm', '', '', '0', null);
INSERT INTO `tbl_academicstaff` VALUES ('303030', 'albania', 'eman', 'l', '', '', '0', null);

-- ----------------------------
-- Table structure for `tbl_accounts`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_accounts`;
CREATE TABLE `tbl_accounts` (
  `UserID` varchar(9) NOT NULL,
  `Password` varchar(10) DEFAULT NULL,
  `AccType` varchar(25) DEFAULT NULL,
  `Status` enum('inactive','active') DEFAULT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_accounts
-- ----------------------------
INSERT INTO `tbl_accounts` VALUES ('101010', '111111', 'Student', null);
INSERT INTO `tbl_accounts` VALUES ('202020', '222222', 'Teacher', null);
INSERT INTO `tbl_accounts` VALUES ('303030', '333333', 'Admin', null);

-- ----------------------------
-- Table structure for `tbl_class`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_class`;
CREATE TABLE `tbl_class` (
  `Class_ID` varchar(9) NOT NULL,
  `ClassName` varchar(25) DEFAULT NULL,
  `Section` varchar(25) DEFAULT NULL,
  `No.ofStud` varchar(25) DEFAULT NULL,
  `Adviser` varchar(9) DEFAULT NULL,
  `Room` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`Class_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_class
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_classlist`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_classlist`;
CREATE TABLE `tbl_classlist` (
  `List_ID` varchar(9) NOT NULL,
  `Class_ID` varchar(9) DEFAULT NULL,
  `Student_ID` varchar(9) DEFAULT NULL,
  `School_Year` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`List_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_classlist
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_notes`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_notes`;
CREATE TABLE `tbl_notes` (
  `Note_ID` varchar(9) NOT NULL,
  `Subject_ID` varchar(9) DEFAULT NULL,
  `Stud_ID` varchar(9) DEFAULT NULL,
  `Note` text,
  PRIMARY KEY (`Note_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_notes
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_student`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_student`;
CREATE TABLE `tbl_student` (
  `Stud_ID` varchar(9) NOT NULL,
  `LastName` varchar(25) NOT NULL,
  `FirstName` varchar(25) NOT NULL,
  `MiddleName` varchar(3) DEFAULT NULL,
  `Birthday` varchar(8) NOT NULL,
  `BirthMonth` varchar(10) NOT NULL,
  `BirthYear` int(4) NOT NULL,
  `Avatar` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Stud_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_student
-- ----------------------------
INSERT INTO `tbl_student` VALUES ('101010', 'balabis', 'joyce ', 'mir', '16', 'october', '1997', null);

-- ----------------------------
-- Table structure for `tbl_subject`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_subject`;
CREATE TABLE `tbl_subject` (
  `Subject_ID` varchar(9) NOT NULL,
  `Subject_Name` varchar(25) DEFAULT NULL,
  `Teacher` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`Subject_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_subject
-- ----------------------------
