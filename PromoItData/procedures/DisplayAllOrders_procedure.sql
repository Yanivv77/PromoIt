CREATE DEFINER=`root`@`%` PROCEDURE `DisplayAllOrders_procedure`()
BEGIN
SELECT a.TwitterName ,a.Email , a.Adress , p.ProductName , p.ProductValue , b.Name
FROM PromoIt.Order o join Activist a on o.ActivistUserID = a.ID 
 join ProductsDonated p on o.ProductID =p.DotationID 
 join Business b on p.BusinessID = b.ID;
END