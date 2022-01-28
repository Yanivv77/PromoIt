# PromoIt Thoar and Yaniv Project for Zionet

## poject overview
System that promotes social campaigns in Twitter
Main functions of the system :
Nonprofit Organization can open campaigns with url and hashtage they want to promote
Business can donate items for specific campaigns to to encourage activists to promote the campaigns to gain a currency for them to buy the items
Activists can specific campaigns by tweet the campaigns hashtage and get thier tweet shared for every tweet that promotes a campaign activists will gain a currency
SystemOwners will get report about all the user in system all items sent and all that tweets that promotes a campaign

## how we implemented a project
to implemented the project we used IDesign method to create a services with 3 layers Accessors Layer Engines Layer and Business Logic Layer 
we used MySQL for a database that we run in docker container so we can easily later upload it to Azure 
to send http request we use OpenAPI with Swagger in Azure functions that send in a queue to the userinterface
we divided the services to several responsibilities that every service responsibleto a specific component in the system

## Main components that implemented and Works in the project 
* MySQL in a docker container
* CI pipeline In Github actions 
* IDesign method - Accessors Layer Engines Layer and Business Logic Layer
* Azure functions
* http request we use OpenAPI with Swagger
* Http Trigger Queue (from Alon's project)
* Http Trigger Queue test (from Alon's project)
* User Registration
* User Service - users login
* Shop Service - donate items and order items
* Campaign Service
* Winform User interface

## Main components that Not implemented yet
* User Balance engine 
* Ilogger
* Twitter API Service (has suspended few times)
* Unit Tests



## MainScreen

## RegisterForm 

## NonProfitScreen

## BusinessScreen

## AdminScreen

## ActivistsScreen





