Feature: Task1SpecFlowFeature
	AddProfileSpecFlowFeature
	As a Seller
	I want the feature to add my profile details
	so that
	the people seeking some skills can look into my details

@Profile
    Scenario: Join as a Seller
	Given I clcik on join button to register
	And i signinto website with valid credentials
	
	Scenario: I log into website as a seller
	Given I click on sign button 
	And  I entered valid Email Id and Password
	Then I am able to login successfully

	Scenario: Sign in as a seller with invalid Email address and valid password
	Given  I entered invalid email and valid password
	Then   I am not able to login sucessfully

	Scenario: Sign in as a seller with valid Email Address and invalid password
	Given  I entered valid email and invalid password
	Then   I am not able to login successfully

	Scenario: Sign in as a seller with valid email and forgot password
	Given I entered Valid Email but forgot password
	When  I am ble to reset my password with getting code in email Id
	Then  I am able to login successfully


	Scenario: Add maximum 4 language in profile details as a seller
	Given  I login with valid credentials
	When   I try to add new maximum 4 language
	Then   I am able to see language added successfully

	Scenario: Add more than 4 language in profile details as a seller
	Given I Entered valid credentials
	When  I trying to add more than 4 languages 
	Then  I am ble to see warning message and not able to add existing language

	Scenario:  Delete new language in the profile detail as a seller
	Given I Entered valid credentials to login 
	When  I Delete existing language
	Then I am able to delete existing language successfully

	Scenario: Update existing language as a seller
	Given I Entered valid credentials to sign in
	When I update existing language
	Then  I am able see existing language updated sucessfully

	Scenario: Add new skill as a seller in profile detail
	Given I entered Valid credential and login
	When  I add new skill 
	Then  I am able to see skill successfully

	Scenario: Update existing skill as a seller in profile detail
	Given I entered Valid credential and login
	When  I update skill 
	Then  I am able to see existing skill updated successfully

	Scenario: Delete existing skill in the profile detail as a seller
	Given I Entered valid credentials to login 
	When  I Delete existing skill
	Then I am able to delete existing skill successfully

	Scenario: Add Education Detail
	Given  I login the website with valid credentials
	When  I add Education details 
	Then  seller should able to add Education details successfully

	Scenario: Update the Education Details
	Given  I login to website with valid login And password
	When  I Update the Education detail'<Title>'
	Then  I should able to update Education details successfully

	Scenario: Add Certificate in the profile detail
	Given  I login to website with valid login And password
	When  I add the certification on the profile detail
	Then  I should able to add Education details successfully

	Scenario: Update Certificate in the profile detail
	Given  I login to website with valid login And password
	When  I update the existing  certificte on the profile detail
	Then  I should able to update exsisting certificate details successfully

	Scenario: Delete existing certificate in the profile detail as a seller
	Given I Entered valid credentials to login 
	When  I Delete existing certificate
	Then I am able to delete existing certificate successfully

	Scenario:the people seeking some skills can look into my details
	Given login in to website
	When I Try to search for skill under category
	Then seller should able to see sellers detail sucessfully



