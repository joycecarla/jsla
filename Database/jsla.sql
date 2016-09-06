/*
Navicat MySQL Data Transfer

Source Server         : ROOT
Source Server Version : 100113
Source Host           : localhost:3306
Source Database       : jsla

Target Server Type    : MYSQL
Target Server Version : 100113
File Encoding         : 65001

Date: 2016-09-01 01:55:34
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for meta_file
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
-- Table structure for tblquizinfo
-- ----------------------------
DROP TABLE IF EXISTS `tblquizinfo`;
CREATE TABLE `tblquizinfo` (
  `QuizID` varchar(9) NOT NULL,
  `QuizTitle` varchar(255) DEFAULT NULL,
  `SubjectID` varchar(9) DEFAULT NULL,
  `TeacherID` varchar(9) DEFAULT NULL,
  `quizType` varchar(255) DEFAULT NULL,
  `Year` varchar(255) DEFAULT NULL,
  `SectionID` varchar(9) DEFAULT NULL,
  `No.ofItem` int(11) DEFAULT NULL,
  `Points` int(11) DEFAULT NULL,
  PRIMARY KEY (`QuizID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tblquizinfo
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_academicstaff
-- ----------------------------
DROP TABLE IF EXISTS `tbl_academicstaff`;
CREATE TABLE `tbl_academicstaff` (
  `Staff_ID` varchar(9) NOT NULL,
  `LastName` varchar(25) NOT NULL,
  `FirstName` varchar(25) NOT NULL,
  `MiddleInitial` varchar(3) DEFAULT NULL,
  `Avatar` varchar(255) DEFAULT NULL,
  `Status` varchar(10) NOT NULL,
  PRIMARY KEY (`Staff_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tbl_academicstaff
-- ----------------------------
INSERT INTO `tbl_academicstaff` VALUES ('202020', 'balabis', 'joyce', 'm', null, '');
INSERT INTO `tbl_academicstaff` VALUES ('303030', 'albania', 'eman', 'l', null, '');

-- ----------------------------
-- Table structure for tbl_accounts
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
-- Table structure for tbl_class
-- ----------------------------
DROP TABLE IF EXISTS `tbl_class`;
CREATE TABLE `tbl_class` (
  `Class_ID` varchar(9) NOT NULL,
  `SubjectID` varchar(25) DEFAULT NULL,
  `SectionID` varchar(25) DEFAULT NULL,
  `Teacher` varchar(9) DEFAULT NULL,
  `Room` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`Class_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_class
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_classlist
-- ----------------------------
DROP TABLE IF EXISTS `tbl_classlist`;
CREATE TABLE `tbl_classlist` (
  `List_ID` varchar(9) NOT NULL,
  `Section_ID` varchar(9) DEFAULT NULL,
  `Student_ID` varchar(9) DEFAULT NULL,
  `School_Year` varchar(9) DEFAULT NULL,
  `Course_ID` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`List_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_classlist
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_course
-- ----------------------------
DROP TABLE IF EXISTS `tbl_course`;
CREATE TABLE `tbl_course` (
  `CourseID` varchar(9) NOT NULL,
  `Course` varchar(255) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CourseID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_course
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_homeroom
-- ----------------------------
DROP TABLE IF EXISTS `tbl_homeroom`;
CREATE TABLE `tbl_homeroom` (
  `HomeRoomID` varchar(9) NOT NULL,
  `SectionID` varchar(9) DEFAULT NULL,
  `Year` varchar(25) DEFAULT NULL,
  `Adviser` varchar(255) DEFAULT NULL,
  `Room` varchar(5) DEFAULT NULL,
  `No.ofStudent` int(11) DEFAULT NULL,
  PRIMARY KEY (`HomeRoomID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_homeroom
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_notes
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
-- Table structure for tbl_sections
-- ----------------------------
DROP TABLE IF EXISTS `tbl_sections`;
CREATE TABLE `tbl_sections` (
  `Section_ID` varchar(9) NOT NULL,
  `Section` varchar(255) DEFAULT NULL,
  `Year` int(11) DEFAULT NULL,
  PRIMARY KEY (`Section_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_sections
-- ----------------------------
INSERT INTO `tbl_sections` VALUES ('0001', 'Integrity', '9');
INSERT INTO `tbl_sections` VALUES ('0002', 'Fortitude', '10');
INSERT INTO `tbl_sections` VALUES ('0003', 'Piety', '10');

-- ----------------------------
-- Table structure for tbl_student
-- ----------------------------
DROP TABLE IF EXISTS `tbl_student`;
CREATE TABLE `tbl_student` (
  `Stud_ID` varchar(9) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `MiddleName` varchar(255) DEFAULT NULL,
  `Section_ID` varchar(9) NOT NULL,
  `Avatar` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Stud_ID`),
  KEY `Section_ID` (`Section_ID`),
  CONSTRAINT `tbl_student_ibfk_1` FOREIGN KEY (`Section_ID`) REFERENCES `tbl_sections` (`Section_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_student
-- ----------------------------
INSERT INTO `tbl_student` VALUES ('#####-###', 'aga', 'gaga', 'gaga', '0001', 'avatars/');
INSERT INTO `tbl_student` VALUES ('000000000', 'Ortiz', 'Patricia', null, '0001', null);
INSERT INTO `tbl_student` VALUES ('000000123', 'Okura', 'Ryota', 'Borja', '0001', null);
INSERT INTO `tbl_student` VALUES ('101010101', 'Balabis', 'Joyce', 'Mir', '0001', null);

-- ----------------------------
-- Table structure for tbl_subject
-- ----------------------------
DROP TABLE IF EXISTS `tbl_subject`;
CREATE TABLE `tbl_subject` (
  `Subject_ID` varchar(9) NOT NULL,
  `Subject_Name` varchar(25) DEFAULT NULL,
  `Year` varchar(25) DEFAULT NULL,
  `CourseID` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`Subject_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_subject
-- ----------------------------
SET FOREIGN_KEY_CHECKS=1;
