CREATE DEFINER=`root`@`%` PROCEDURE `DisplayDonationsBYBusiness_procedure`(BusinessID int)
BEGIN

SELECT b.Name as "Business Name" , p.CampaignName ,p.ProductName, p.DotationID, p.ProductValue , p.Quantity
FROM ProductsDonated p join Business b on BusinessID = b.ID ;

END