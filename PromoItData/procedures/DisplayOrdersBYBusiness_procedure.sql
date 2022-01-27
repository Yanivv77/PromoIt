CREATE DEFINER=`root`@`%` PROCEDURE `DisplayOrdersBYBusiness_procedure`(BusinessID int)
BEGIN


SELECT a.TwitterName ,a.Email , a.Adress , p.ProductName , p.ProductValue 
FROM PromoIt.Order o join Activist a on o.ActivistUserID = a.ID 
 join ProductsDonated p on o.ProductID =p.DotationID 
 join Business b on p.BusinessID = BusinessID;
 
END