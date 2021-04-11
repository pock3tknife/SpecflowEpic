Feature: Home 

Background: 
	Given I navigate to URl
	And I click to Input form

#Scenario: Open Simple form demo
#	Given I click to Simple demo form
#	Then : I can see Simple demo form

#Scenario: : Show and verify message
#	Given : I click to Simple demo form
#	And I enter "Yow What$$$uppp!!" in input
#	When I click to Show Message Button
#	Then : I can see "Yow What$$$uppp!!"

#Scenario Outline: Login as Admin
#Given I Navigate to the login page
#And I Enter <username> and <password>
#When I click to login button
#Then I can see admin is able to login
#Examples:
#| Username       | Pass@123 |
#| Asd@gmail.com  | Pass@123 |
#| User@gmail.com | Pass@123 |
#| Div@gmail.com  | Pass@123 |

#Scenario Outline: Fill the Input form
#Given User is on the input form Page
#When User enter <Msg> in input
#And User click to Show button
#Then User can see the text
#Examples: 
#| Msg                |
#| Yow What$$$uppp!?! |
#| Codebun |
#| CodeDec |


	#Examnples of Tables in Specflow
#Scenario Outline: Fill the Input form using Tables
#Given User is on the input form Page
#When User enter Msg in input
#| Msg                | msg2            |
#| Yow What$$$uppp!?! | How$ iT Goin!?! |
#| Codebun            | CodeBun         |
#| CodeDec            | CodeDec         |
#And User click to Show button
#Then User can see the text

#Examnple of Param in Specflow
Scenario Outline: Fill the Input form using Param
Given User is on the input form Page
When User enter "Yow Wh@t$$$upp!?" in input
And User click to Show button
Then User can see the text