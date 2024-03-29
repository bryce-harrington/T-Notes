-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: t-notes
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `note`
--

DROP TABLE IF EXISTS `note`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `note` (
  `note_id` int(11) NOT NULL,
  `note_title` varchar(45) DEFAULT NULL,
  `chapter` int(11) DEFAULT NULL,
  `Section` int(11) DEFAULT NULL,
  `Summary` varchar(1000) DEFAULT NULL,
  `Date` date NOT NULL,
  `notes` longtext NOT NULL,
  PRIMARY KEY (`note_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `note`
--

LOCK TABLES `note` WRITE;
/*!40000 ALTER TABLE `note` DISABLE KEYS */;
INSERT INTO `note` VALUES (36157,'The Heavenly Sword and Dragon Saber',8,10,'Boy with Luv','0000-00-00','Uptown girl'),(36248,'The Deer and the Cauldron',5,7,'Without me','0000-00-00','Who let the dogs out?'),(36948,'White Horse Neighs in the Western Wind',10,8,'Please me','0000-00-00','The battle of pigs'),(45686,'The Book and the Sword',1,3,'Old Town Road','0000-00-00','A lot of homework'),(59463,'The Legend of the Condor Heroes',3,9,'Sun Flower','0000-00-00','Please don\'t let me study it'),(59874,'Fox Volant of the Snowy Mountain',4,1,'7 rings','0000-00-00','I really like it'),(65157,'The Smiling, Proud Wanderer',7,4,'Dancing with a stranger','0000-00-00','Gangnam style'),(82427,'Sword Stained with Royal Blood',2,2,'Wow','0000-00-00','I hate the instructor'),(97518,'Blade-dance of the Two Lovers',9,6,'Bad guy','0000-00-00','The day of Judgement'),(97845,'Demi-Gods and Semi-Devils',6,5,'Sucker','0000-00-00','For whom the bell tolls?');
/*!40000 ALTER TABLE `note` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-04-27  0:41:28
