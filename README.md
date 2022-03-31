# RobotApocalypse
/api/Robot/GetRobots ->Fetch all robots from database

/api/survivors(Post) ->Create new survivor

/api/survivors(put) ->Update survivor location

/api/survivors/ListofInfectedSurvivor->get list of infected survivor

/api/survivors/ListofNonInfectedSurvivor->>get list of not infected survivor

/api/survivors/percentageofinfectedsurvivor->get percenteage of infected survivor

/api/survivors/percentageofinfectedsurvivor->get percenteage of non infected survivor

Table structure

CREATE TABLE `robots` (
  `id` int NOT NULL AUTO_INCREMENT,
  `modal` varchar(45) NOT NULL,
  `serialNumber` varchar(35) NOT NULL,
  `manufacturedDate` datetime NOT NULL,
  `category` varchar(35) NOT NULL,
  PRIMARY KEY (`id`)
) 

CREATE TABLE `survivors` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `gender` varchar(35) NOT NULL,
  `age` int NOT NULL,
  `lastlocation` varchar(35) NOT NULL,
  `resources` varchar(35) NOT NULL,
  `status` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
)
