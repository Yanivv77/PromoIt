CREATE DEFINER=`root`@`%` PROCEDURE `AddAdmin_procedure`(AdUsername varchar(45),AdPassword varchar(45),AdUserType varchar(45)
 )
BEGIN
INSERT INTO `PromoIt`.`Users` (`UserName`,`Password`,`UserType`)
VALUES(AdUsername ,AdPassword,AdUserType);

INSERT INTO `PromoIt`.`Admin` (`ID`)
VALUES(LAST_INSERT_ID());



END