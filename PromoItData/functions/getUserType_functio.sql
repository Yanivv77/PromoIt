CREATE DEFINER=`root`@`%` FUNCTION `getUserType_function`(Username varchar(45)) RETURNS varchar(45) CHARSET utf8mb3
    DETERMINISTIC
BEGIN
DECLARE userType varchar(45);

set userType  = 
(SELECT u.UserType
FROM Users u
 WHERE u.UserName = Username
 );
 
RETURN userType ; 

END