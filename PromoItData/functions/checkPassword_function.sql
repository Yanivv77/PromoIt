CREATE DEFINER=`root`@`%` FUNCTION `checkPassword_function`(UserName varchar(45),userPassword varchar(45)) RETURNS int
    DETERMINISTIC
BEGIN
DECLARE Valid int;

set Valid =
(SELECT COUNT(UserName)
  FROM Users
 WHERE UserName = UserName AND
       Password = userPassword
 LIMIT 0, 1);
 
RETURN Valid; 

END