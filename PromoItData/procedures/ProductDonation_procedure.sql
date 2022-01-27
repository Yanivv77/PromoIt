CREATE DEFINER=`root`@`%` PROCEDURE `ProductDonation_procedure`(BusinessUserID int, CampaignName varchar(255) 
,ProductName varchar(255) ,ProductValue int, Quantity int)
BEGIN

INSERT INTO `PromoIt`.`ProductsDonated`
(
`BusinessID`,
`CampaignName`,
`ProductName`,
`ProductValue`,
`Quantity`)
VALUES
(BusinessUserID, CampaignName, ProductName, ProductValue, Quantity);


END