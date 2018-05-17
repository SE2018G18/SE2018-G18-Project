-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: se2018g18
-- ------------------------------------------------------
-- Server version	5.6.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `g18_map`
--

DROP TABLE IF EXISTS `g18_map`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `g18_map` (
  `mid` int(11) NOT NULL,
  `mname` varchar(10) NOT NULL,
  PRIMARY KEY (`mid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `g18_map`
--

LOCK TABLES `g18_map` WRITE;
/*!40000 ALTER TABLE `g18_map` DISABLE KEYS */;
/*!40000 ALTER TABLE `g18_map` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `g18_role`
--

DROP TABLE IF EXISTS `g18_role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `g18_role` (
  `rid` int(11) NOT NULL,
  `rname` varchar(10) NOT NULL,
  `rfeatures` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`rid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `g18_role`
--

LOCK TABLES `g18_role` WRITE;
/*!40000 ALTER TABLE `g18_role` DISABLE KEYS */;
/*!40000 ALTER TABLE `g18_role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `g18_tools`
--

DROP TABLE IF EXISTS `g18_tools`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `g18_tools` (
  `tid` int(11) NOT NULL,
  `tname` varchar(10) NOT NULL,
  `tfeatures` varchar(100) NOT NULL,
  PRIMARY KEY (`tid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `g18_tools`
--

LOCK TABLES `g18_tools` WRITE;
/*!40000 ALTER TABLE `g18_tools` DISABLE KEYS */;
/*!40000 ALTER TABLE `g18_tools` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `g18_user`
--

DROP TABLE IF EXISTS `g18_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `g18_user` (
  `uid` varchar(20) NOT NULL,
  `ucode` varchar(50) NOT NULL,
  `uname` varchar(10) NOT NULL,
  `uscore` int(11) DEFAULT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `g18_user`
--

LOCK TABLES `g18_user` WRITE;
/*!40000 ALTER TABLE `g18_user` DISABLE KEYS */;
/*!40000 ALTER TABLE `g18_user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-05-17 12:45:15
