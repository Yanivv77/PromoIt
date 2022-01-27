CREATE DEFINER=`root`@`%` PROCEDURE `DisplayAllAdmins_procedure`()
BEGIN

select u.Username
from Admin join Users u using(ID);

END