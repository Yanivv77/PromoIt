CREATE DEFINER=`root`@`%` PROCEDURE `AddActivist_procedure`(AUserName varchar(45),APassword varchar(45),AUserType varchar(45)
, AEmail varchar(255), AAdress varchar(45), APhone varchar(45), ATwitterName varchar(45))
BEGIN
INSERT INTO `PromoIt`.`Users` (`UserName`,`Password`,`UserType`)
VALUES(AUserName ,APassword,AUserType);

INSERT INTO `PromoIt`.`Activist` (ID,`Email`,`Adress`,`Phone`,`TwitterName`,`Balance`)
VALUES(LAST_INSERT_ID(),AEmail,AAdress,APhone,ATwitterName,0);



END