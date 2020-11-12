Feature:Feature: Add Profile Details
	     as a seller
	     I would like to update my profile details
		 so that people seeking for skills able to see my profile details
		
		@AddDeleteLanguage
Scenario: I add new language in the profile detail page
	Given I login to website with valid login And password
	When  I add new language on the profile detail
	Then  I should able to add new language successfully
	 
Scenario: Delete exsisting language in the profile detail
Given I login to website with valid credentials
	When  I Delete existing language
	Then  I am able to delete existing language successfully

Scenario: Update existing language in the profile detail
Given I login to mars portal with valid login And password
When I click on update existing language
Then I am able to update existing language

