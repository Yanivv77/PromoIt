CREATE DEFINER=`root`@`%` PROCEDURE `DisplayAllCampaigns_procedure`()
BEGIN
SELECT c.CampaignName , c.Hashtag , c.Url, n.Name as "Organization name"
FROM Campaigns c join  NonProfit n on c.NonProfitUserID = n.ID;
END