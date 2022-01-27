CREATE DEFINER=`root`@`%` PROCEDURE `DisplayAllBusiness_procedure`()
BEGIN

select *
from Business;

END