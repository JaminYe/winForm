/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50562
Source Host           : localhost:3306
Source Database       : test

Target Server Type    : MYSQL
Target Server Version : 50562
File Encoding         : 65001

Date: 2019-08-01 14:22:03
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for customer
-- ----------------------------
DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `sex` int(1) DEFAULT NULL,
  `customerType` int(1) DEFAULT NULL,
  `phone` varchar(12) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `contactAdress` varchar(255) DEFAULT NULL,
  `lat` float(255,0) DEFAULT NULL,
  `lng` float(255,0) DEFAULT NULL,
  `postalcode` varchar(10) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of customer
-- ----------------------------
INSERT INTO `customer` VALUES ('3', '张三', '0', '0', '13112345678', '11@qq.com', '安徽省xx市xx区', '11', '11234', '15465', '备注');
INSERT INTO `customer` VALUES ('5', '李四', '1', '0', '131156454655', '22@qq.com', '江苏南京', '156', '156', '15566', '无');
