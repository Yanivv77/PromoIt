CREATE DEFINER=`root`@`%` PROCEDURE `DisplayAllNonProfit_procedure`()
BEGIN

select *
from NonProfit;

END