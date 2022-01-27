use PromoIt;

call AddTweet_procedure(2,"hello world");
call AddTweet_procedure(2,"good day every one");
call AddTweet_procedure(2,"c# is the best");
call DisplayAllTweets_procedure();

call AddAdmin_procedure("Yaniv","12345","Admin");
call AddAdmin_procedure("Tohar","12345","Admin");
call AddActivist_procedure("Leo77","12345","Activist","leo77@gmail.com","Pardasshana 6","0584411223","leo77");
call AddNonProfit_procedure("Turtles77","12345","NonProfit","Save the Turtles","Turtles@gmail.com","Turtles.com");
call AddBusiness_procedure("Sony77","12345","Business","Sony");


call DisplayAllActivists_procedure();
call DisplayAllAdmins_procedure();
call DisplayAllBusiness_procedure();
call DisplayAllNonProfit_procedure(); 

call CreateCampaign_procedure ("Save the turtles", 3, "#SaveTurtles", "SaveTurtles.com");
call DisplayAllCampaigns_procedure();
call DisplayCampaignsBYNonProfit_procedure(3);

call ProductDonation_procedure(6,'Save the turtles',"TV",1000,5);
call DisplayAllDonations_procedure();
call DisplayDonationsBYBusiness_procedure(6);

call CreateOrder_procedure(2,1);
call DisplayAllOrders_procedure();
call DisplayOrdersBYBusiness_procedure(6);

SELECT checkPassword_function("Yaniv","12345");
SELECT checkPassword_function("leo77","1234543243242");

SELECT getUserType_function("leo77");
