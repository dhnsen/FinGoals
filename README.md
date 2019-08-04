# FinGoals

This is a tool to allow a user to enter a number of financial Savigns Goals, then simply update the amount they have saved to see their current progress

The project runs on ASP.NET Core MVC and API. I makes use of Razor views and is fairly basic in configuration. 

There are really only three models that interact to make this work:
 - User
 - Goal
 - SavingsAmount
 
A user can have many Goals but only one SavingsAmount. In the dashboard, the SavingsAmount is distributed across the various goals using inline C#.
