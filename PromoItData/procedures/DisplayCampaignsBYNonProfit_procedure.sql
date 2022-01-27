CREATE DEFINER=`root`@`%` PROCEDURE `DisplayCampaignsBYNonProfit_procedure`(NonProfitID int)
BEGIN
SELECT c.CampaignName , c.Hashtag , c.Url, n.Name as "Organization name"
FROM Campaigns c join  NonProfit n on c.NonProfitUserID = n.ID
where n.ID = NonProfitID ;
END