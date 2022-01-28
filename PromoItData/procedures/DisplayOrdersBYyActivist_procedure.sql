CREATE DEFINER=`root`@`%` PROCEDURE `DisplayOrdersBYyActivist_procedure`( activist_ID int)
BEGIN

SELECT p.ProductName, p.ProductValue,b.Name
FROM PromoIt.Order o join ProductsDonated p on
o.ProductID = p.DotationID join Business b on
p.BusinessID = b.ID
where o.ActivistUserID = activist_ID;

END