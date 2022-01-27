CREATE DEFINER=`root`@`%` PROCEDURE `DisplayAllDonations_procedure`()
BEGIN

SELECT b.Name as "Business Name" , p.CampaignName ,p.ProductName, p.DotationID, p.ProductValue , p.Quantity
FROM ProductsDonated p join Business b on p.BusinessID=b.ID ;

END