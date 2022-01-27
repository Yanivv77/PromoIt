CREATE DEFINER=`root`@`%` PROCEDURE `AddNonProfit_procedure`(NUsername varchar(45),NPassword varchar(45),NUserType varchar(45)
,NName varchar(45), NEmail varchar(255), NWebsite mediumtext)
BEGIN
INSERT INTO `PromoIt`.`Users` (`UserName`,`Password`,`UserType`)
VALUES(NUsername ,NPassword,NUserType);

INSERT INTO `PromoIt`.`NonProfit` (`ID`,`Name`,`Email`,`Website`)
VALUES(LAST_INSERT_ID() , NName , NEmail , NWebsite);



END