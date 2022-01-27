CREATE DEFINER=`root`@`%` PROCEDURE `DisplayAllTweets_procedure`()
BEGIN
select t.Text ,a.TwitterName as "User"
from Tweets t Join  Activist a on t.Activist_ID = a.ID ;

END