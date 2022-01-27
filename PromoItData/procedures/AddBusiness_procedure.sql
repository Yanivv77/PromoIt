CREATE DEFINER=`root`@`%` PROCEDURE `AddBusiness_procedure`(BUsername varchar(45),BPassword varchar(45),BUserType varchar(45)
,BName varchar(45) )
BEGIN
INSERT INTO `PromoIt`.`Users` (`UserName`,`Password`,`UserType`)
VALUES(BUsername ,BPassword,BUserType);

INSERT INTO `PromoIt`.`NonProfit` (`ID`,`Name`)
VALUES(LAST_INSERT_ID() , BName);



END