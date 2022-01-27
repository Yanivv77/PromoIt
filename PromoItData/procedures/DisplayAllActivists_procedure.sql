CREATE DEFINER=`root`@`%` PROCEDURE `DisplayAllActivists_procedure`()
BEGIN

select *
from Activist;

END