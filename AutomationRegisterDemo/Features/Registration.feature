Feature:  Registration
		In order to use the website
		I will need to first register

@mytag
Scenario: Valid Registration
	Given I navigate to the website
	And I enter my first name
	And i enter my last name
	And I enter my Address
	And I enter my email address
	And I enter my phone number 
	And i choose my gender
	And I select my hobby
	And I click on textbox
	And I select my language
	And I select my skill
	And I select my country
	#And I click on country textbox
	#And I select another country
	And I enter my year of birth
	And I enter my month of birth
	And i enter my day of birth
	And I enter my password
	And i Confirm my password
 	When I click on submit
	#Then I should be able to register