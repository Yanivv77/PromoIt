use PromoIt;

call AddTweet_procedure(2,"hello world");
call AddTweet_procedure(2,"good day every one");
call AddTweet_procedure(2,"c# is the best");
call AddTweet_procedure(2,"Workin on hard project");
call DisplayAllTweets_procedure();

call AddAdmin_procedure("Yaniv","12345","Admin");
call AddAdmin_procedure("Tohar","12345","Admin");

call AddActivist_procedure("Leo77","12345","Activist","leo77@gmail.com","Pardasshana 6","0584411223","leo77");
call AddActivist_procedure("ben77","12345","Activist","ben77@gmail.com","Phansa 6","058441341223","ben77");
call AddActivist_procedure("avu77","12345","Activist","avi77@gmail.com","Shadas 8","058441341223","avi77");


call AddNonProfit_procedure("Turtles77","12345","NonProfit","Save the Turtles","Turtles@gmail.com","Turtles.com");
call AddNonProfit_procedure("Sealions77","12345","NonProfit","Save the Sea Lions","Sealion@gmail.com","Sealion.com");
call AddNonProfit_procedure("Dolphins77","12345","NonProfit","Save the Sea Dolphins","Dolphins@gmail.com","Dolphins.com");

call AddBusiness_procedure("Sony77","12345","Business","Sony");
call AddBusiness_procedure("lgL77","12345","Business","LG");
call AddBusiness_procedure("Apple77","12345","Business","Apple");

call DisplayAllActivists_procedure();
call DisplayAllAdmins_procedure();
call DisplayAllBusiness_procedure();
call DisplayAllNonProfit_procedure(); 

call CreateCampaign_procedure ("Save the turtles", 3, "#SaveTurtles", "SaveTurtles.com");
call CreateCampaign_procedure ("turtles turtles turtles", 3, "#SaveTurtles", "SaveTurtles.com");
call CreateCampaign_procedure ("i love turtles", 3, "#SaveTurtles", "SaveTurtles.com");
call DisplayAllCampaigns_procedure();
call DisplayCampaignsBYNonProfit_procedure(3);

call ProductDonation_procedure(6,'Save the turtles',"TV",1000,5);
call ProductDonation_procedure(6,'Save the turtles',"Phone",2000,1);
call ProductDonation_procedure(6,'Save the turtles',"Refrigerator",2000,1);

call DisplayAllDonations_procedure();
call DisplayDonationsBYBusiness_procedure(6);
call DisplayOrdersBYActivist_procedure(2);

call CreateOrder_procedure(2,1);
call CreateOrder_procedure(2,2);
call CreateOrder_procedure(2,3);

call DisplayAllOrders_procedure();
call DisplayOrdersBYBusiness_procedure(6);

SELECT checkPassword_function("Yaniv","12345");
SELECT checkPassword_function("leo77","1234543243242");

SELECT getUserType_function("leo77");
