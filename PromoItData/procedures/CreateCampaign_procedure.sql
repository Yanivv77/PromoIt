CREATE DEFINER=`root`@`%` PROCEDURE `CreateCampaign_procedure`(CampaignName varchar(255),NonProfitUserID int,Hashtag varchar(45),Url mediumtext)
BEGIN

INSERT INTO `PromoIt`.`Campaigns`
(`CampaignName`,
`NonProfitUserID`,
`Hashtag`,
`Url`)
VALUES
(CampaignName, NonProfitUserID, Hashtag, Url);







END