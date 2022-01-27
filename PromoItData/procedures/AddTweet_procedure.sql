CREATE DEFINER=`root`@`%` PROCEDURE `AddTweet_procedure`( Activist_ID int , tweetText varchar(280))
BEGIN

INSERT INTO `PromoIt`.`Tweets`(Activist_ID,Text)
VALUES(Activist_ID ,tweetText);




END