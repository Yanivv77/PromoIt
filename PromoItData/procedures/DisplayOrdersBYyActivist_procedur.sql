CREATE DEFINER=`root`@`%` PROCEDURE `DisplayOrdersBYyActivist_procedure`( activistID int)
BEGIN

SELECT o.OrderID ,b.Name ,p.ProductName
FROM PromoIt.Order o join Activist a on o.ActivistUserID = activistID
join ProductsDonated p on o.ProductID =p.DotationID 
join Business b on p.BusinessID = BusinessID;

END