/*
Navicat MySQL Data Transfer

Source Server         : ROOT
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : juan

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2016-09-11 23:21:52
*/

SET FOREIGN_KEY_CHECKS=0;

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
  PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_sectioninfo
-- ----------------------------
INSERT INTO `tbl_sectioninfo` VALUES ('1', 'STEM101', '11', null, null);
INSERT INTO `tbl_sectioninfo` VALUES ('2', 'STEM102', '11', null, null);
INSERT INTO `tbl_sectioninfo` VALUES ('3', 'STEM103', '11', null, null);
INSERT INTO `tbl_sectioninfo` VALUES ('4', 'GAS101', '11', null, null);
INSERT INTO `tbl_sectioninfo` VALUES ('5', 'ABM101', '11', null, null);
INSERT INTO `tbl_sectioninfo` VALUES ('6', 'ABM102', '11', null, null);
INSERT INTO `tbl_sectioninfo` VALUES ('7', 'HE101', '11', null, null);
INSERT INTO `tbl_sectioninfo` VALUES ('8', 'ICT101', '11', null, null);

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
INSERT INTO `tbl_studentinfo` VALUES ('1', 'Alde', 'Alken', 'Abadiez', 'Male', 'Alde', 'Leonila', null, '903245698', 'Active', null);
INSERT INTO `tbl_studentinfo` VALUES ('2', 'Anchuelo', 'Avy Liezel', 'Bonavente', 'Female', 'Anchuelo', 'Roda', null, '6659784', 'Active', null);
INSERT INTO `tbl_studentinfo` VALUES ('3', 'Andres', 'Jan Ashley', 'Villegas', 'Male', 'Andres', 'Joel', 'Cruz', '906202425', 'Active', null);
INSERT INTO `tbl_studentinfo` VALUES ('4', 'Aquino', 'Eugene', 'Saniel', 'Male', 'Aquino', 'Rene', null, '6619874', 'Active', null);
INSERT INTO `tbl_studentinfo` VALUES ('5', 'Buendia', 'Ram Andrew', 'Guibani', 'Male', 'Buendia', 'Carla ', 'Santos', '6548791', 'Active', null);
INSERT INTO `tbl_studentinfo` VALUES ('6', 'Buenviaje', 'John Andrei', 'Bas', 'Male', 'Buenviaje', 'Susan', 'Deso', '6978456', 'Active', null);
INSERT INTO `tbl_studentinfo` VALUES ('7', ' Bulan', 'Alyssa Mae', 'Aquino', 'Female', 'Bulan', 'Bituin', 'Aquino', '917999656', 'Active', null);
INSERT INTO `tbl_studentinfo` VALUES ('8', 'Cansino', 'Lyyana Kayle', 'Borja', 'Female', 'Cansino', 'Bueno', null, '6349785', 'Active', null);
INSERT INTO `tbl_studentinfo` VALUES ('9', 'Cruz', 'Irine Claire', 'Borja', 'Female', 'Cruz', 'Henry', 'Vallestero', '926555689', 'Active', null);
INSERT INTO `tbl_studentinfo` VALUES ('10', 'Dael', 'Dave John', 'Zabala', 'Male', 'Zabala', 'Ana Marie ', 'Trinio', '905942080', 'Active', null);

-- ----------------------------
-- Table structure for tbl_subjectinfo
-- ----------------------------
DROP TABLE IF EXISTS `tbl_subjectinfo`;
CREATE TABLE `tbl_subjectinfo` (
  `_id` int(11) NOT NULL,
  `Subject` varchar(255) DEFAULT NULL,
  `Yearlevel` varchar(255) DEFAULT NULL,
  `Track_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`_id`),
  KEY `Track_id` (`Track_id`),
  CONSTRAINT `tbl_subjectinfo_ibfk_1` FOREIGN KEY (`Track_id`) REFERENCES `tbl_trackinfo` (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_subjectinfo
-- ----------------------------
INSERT INTO `tbl_subjectinfo` VALUES ('1', 'General Mathematics', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('2', '21st Century Literary from the Philippines and the World', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('3', 'Media Information and Literacy', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('4', 'Introduction to the Philosophy of the Human Person', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('5', 'Earth and Life Science', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('6', 'Physical Education and Health 1', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('7', 'Organization and Management', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('8', 'Business Mathematics', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('9', 'Pre-Calculus', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('10', 'Elective 1 (Animation)', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('11', 'Elective 1* HUMS- Introduction to the World Religions and Belief Systems', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('12', 'Programming C++', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('13', 'Cookery 1', '11', null);
INSERT INTO `tbl_subjectinfo` VALUES ('14', 'Bread and Pastry', '11', null);

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
INSERT INTO `tbl_teacherinfo` VALUES ('1', 'Del Rosario', 'Michelle', 'F', 'Female', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('2', 'Libramonte', 'Roel', null, 'Male', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('3', 'Almocera', 'Florence Nicole', null, null, null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('4', 'Pajarillo', 'Jose Alfredo', null, 'Male', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('5', 'Rondilla', 'Carizza', null, 'Female', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('6', 'Bendana', 'Arleth', 'A', 'Female', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('7', 'Chua', 'Denis', null, 'Female', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('8', 'Antonil', 'Norman', null, 'Male', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('9', 'Apid', 'Alwen', null, 'Male', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('10', 'Camacho', 'Marvin', null, 'Male', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('11', 'Francisco', 'John Paul', null, 'Male', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('12', 'Quintal', 'Enrico', null, 'Male', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('13', 'Ojeda', 'Dominic', null, 'Male', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('14', 'De Vera', 'Ma. Jocelyn', 'A', 'Female', null, 'Active');
INSERT INTO `tbl_teacherinfo` VALUES ('15', 'Domiguez', 'Brian Tracy', null, 'Male', null, 'Active');

-- ----------------------------
-- Table structure for tbl_trackinfo
-- ----------------------------
DROP TABLE IF EXISTS `tbl_trackinfo`;
CREATE TABLE `tbl_trackinfo` (
  `_id` int(11) NOT NULL,
  `Track` varchar(255) DEFAULT NULL,
  `Branch_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`_id`),
  KEY `Branch_id` (`Branch_id`),
  CONSTRAINT `tbl_trackinfo_ibfk_1` FOREIGN KEY (`Branch_id`) REFERENCES `tbl_branchinfo` (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_trackinfo
-- ----------------------------
INSERT INTO `tbl_trackinfo` VALUES ('1', 'Accounting, Business and Management', null);
INSERT INTO `tbl_trackinfo` VALUES ('2', 'Science, Technology and Engineering Math', null);
INSERT INTO `tbl_trackinfo` VALUES ('3', 'General Academic Strands', null);
INSERT INTO `tbl_trackinfo` VALUES ('4', 'TVL-ICT(Programming and Hardware Servicing)', null);
INSERT INTO `tbl_trackinfo` VALUES ('5', 'TVL-Home Economics:Culinary Arts', null);
