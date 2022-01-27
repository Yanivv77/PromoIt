CREATE DEFINER=`root`@`%` PROCEDURE `DisplyUserTypeByUsername_procedure`(Usernamee varchar(45))
BEGIN

SELECT * 
FROM Users 
where UserName = Usernamee ;

END