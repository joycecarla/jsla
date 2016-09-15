/*
Navicat MySQL Data Transfer

Source Server         : ROOT
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : juan

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2016-09-15 13:46:57
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for tbl_accounts
-- ----------------------------
DROP TABLE IF EXISTS `tbl_accounts`;
CREATE TABLE `tbl_accounts` (
  `_id` int(11) NOT NULL,
  `password` varchar(255) DEFAULT NULL,
  `user_level` varchar(255) DEFAULT NULL,
  `attempts` varchar(255) DEFAULT NULL,
  `reference_id` int(11) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_accounts
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_announcement
-- ----------------------------
DROP TABLE IF EXISTS `tbl_announcement`;
CREATE TABLE `tbl_announcement` (
  `_id` int(11) NOT NULL,
  `DatePosted` datetime DEFAULT NULL,
  `Title` varchar(255) DEFAULT NULL,
  `Poster` blob,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_announcement
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_branchinfo
-- ----------------------------
DROP TABLE IF EXISTS `tbl_branchinfo`;
CREATE TABLE `tbl_branchinfo` (
  `_id` int(11) NOT NULL,
  `Branch` varchar(255) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_branchinfo
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_classlist
-- ----------------------------
DROP TABLE IF EXISTS `tbl_classlist`;
CREATE TABLE `tbl_classlist` (
  `_id` int(11) NOT NULL,
  `Section_id` int(11) DEFAULT NULL,
  `Student_no` int(11) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_classlist
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_homework
-- ----------------------------
DROP TABLE IF EXISTS `tbl_homework`;
CREATE TABLE `tbl_homework` (
  `_id` int(11) NOT NULL,
  `Title` varchar(255) DEFAULT NULL,
  `Content` varchar(255) DEFAULT NULL,
  `DatePosted` varchar(255) DEFAULT NULL,
  `DateDue` datetime DEFAULT NULL,
  `TeacherClass_id` int(11) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_homework
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_homeworkpassed
-- ----------------------------
DROP TABLE IF EXISTS `tbl_homeworkpassed`;
CREATE TABLE `tbl_homeworkpassed` (
  `_id` int(11) NOT NULL,
  `Homework_id` int(11) DEFAULT NULL,
  `Student_id` int(11) DEFAULT NULL,
  `ContentFile` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_homeworkpassed
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_priviledge
-- ----------------------------
DROP TABLE IF EXISTS `tbl_priviledge`;
CREATE TABLE `tbl_priviledge` (
  `_id` int(11) NOT NULL,
  `Priviledge` varchar(255) DEFAULT NULL,
  `User_id` int(11) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_priviledge
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_quizanswer
-- ----------------------------
DROP TABLE IF EXISTS `tbl_quizanswer`;
CREATE TABLE `tbl_quizanswer` (
  `_id` int(11) NOT NULL,
  `Quiz_id` int(11) DEFAULT NULL,
  `Student_id` int(11) DEFAULT NULL,
  `Score` varchar(255) DEFAULT NULL,
  `Answers` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_quizanswer
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_quizcontent
-- ----------------------------
DROP TABLE IF EXISTS `tbl_quizcontent`;
CREATE TABLE `tbl_quizcontent` (
  `_id` int(11) NOT NULL,
  `Question` varchar(255) DEFAULT NULL,
  `CorrectAnswer` varchar(255) DEFAULT NULL,
  `QuestionType` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_quizcontent
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_quizinfo
-- ----------------------------
DROP TABLE IF EXISTS `tbl_quizinfo`;
CREATE TABLE `tbl_quizinfo` (
  `_id` int(11) NOT NULL,
  `Title` varchar(255) DEFAULT NULL,
  `Class_id` int(11) DEFAULT NULL,
  `QuizType` varchar(255) DEFAULT NULL,
  `No.ofItem` varchar(255) DEFAULT NULL,
  `Points` varchar(255) DEFAULT NULL,
  `DatePosted` datetime DEFAULT NULL,
  `DateDue` datetime DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_quizinfo
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_sectioninfo
-- ----------------------------
DROP TABLE IF EXISTS `tbl_sectioninfo`;
CREATE TABLE `tbl_sectioninfo` (
  `_id` int(11) NOT NULL,
  `Section` varchar(255) DEFAULT NULL,
  `Yearlevel` varchar(255) DEFAULT NULL,
  `Track_ID` varchar(255) DEFAULT NULL,
  `Branch` varchar(255) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_sectioninfo
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_studentinfo
-- ----------------------------
DROP TABLE IF EXISTS `tbl_studentinfo`;
CREATE TABLE `tbl_studentinfo` (
  `_id` int(11) NOT NULL,
  `Lastname` varchar(255) DEFAULT NULL,
  `Firstname` varchar(255) DEFAULT NULL,
  `Middlename` varchar(255) DEFAULT NULL,
  `Gender` varchar(255) DEFAULT NULL,
  `GLastname` varchar(255) DEFAULT NULL,
  `GFirstname` varchar(255) DEFAULT NULL,
  `GMiddlename` varchar(255) DEFAULT NULL,
  `GContact` int(11) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  `Avatar` blob,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_studentinfo
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_studentupload
-- ----------------------------
DROP TABLE IF EXISTS `tbl_studentupload`;
CREATE TABLE `tbl_studentupload` (
  `_id` int(11) NOT NULL,
  `FileName` varchar(255) DEFAULT NULL,
  `Subject_id` int(11) DEFAULT NULL,
  `Section_id` int(11) DEFAULT NULL,
  `FileAddress` varchar(255) DEFAULT NULL,
  `Staff_id` int(11) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tbl_studentupload
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_subjectinfo
-- ----------------------------
DROP TABLE IF EXISTS `tbl_subjectinfo`;
CREATE TABLE `tbl_subjectinfo` (
  `_id` int(11) NOT NULL,
  `Subject` varchar(255) DEFAULT NULL,
  `Yearlevel` varchar(255) DEFAULT NULL,
  `Track_id` int(11) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_subjectinfo
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_teacherclass
-- ----------------------------
DROP TABLE IF EXISTS `tbl_teacherclass`;
CREATE TABLE `tbl_teacherclass` (
  `_ID` int(11) NOT NULL,
  `Subject_id` int(11) DEFAULT NULL,
  `Section_id` int(11) DEFAULT NULL,
  `Faculty_id` int(11) DEFAULT NULL,
  `SchoolYear` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_teacherclass
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_teacherinfo
-- ----------------------------
DROP TABLE IF EXISTS `tbl_teacherinfo`;
CREATE TABLE `tbl_teacherinfo` (
  `_id` int(11) NOT NULL,
  `Lastname` varchar(255) DEFAULT NULL,
  `Firstname` varchar(255) DEFAULT NULL,
  `Middlename` varchar(255) DEFAULT NULL,
  `Gender` varchar(255) DEFAULT NULL,
  `Avatar` varchar(255) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_teacherinfo
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_teacherupload
-- ----------------------------
DROP TABLE IF EXISTS `tbl_teacherupload`;
CREATE TABLE `tbl_teacherupload` (
  `_id` int(11) NOT NULL,
  `FileName` varchar(255) DEFAULT NULL,
  `Subject_id` int(11) DEFAULT NULL,
  `Section_id` int(11) DEFAULT NULL,
  `FileAddress` varchar(255) DEFAULT NULL,
  `Staff_id` int(11) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_teacherupload
-- ----------------------------

-- ----------------------------
-- Table structure for tbl_trackinfo
-- ----------------------------
DROP TABLE IF EXISTS `tbl_trackinfo`;
CREATE TABLE `tbl_trackinfo` (
  `_id` int(11) NOT NULL,
  `Track` varchar(255) DEFAULT NULL,
  `Branch_id` int(11) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_trackinfo
-- ----------------------------
