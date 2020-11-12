Feature: skills
	
	As a seller
	I would like to add my Skills
	@AddUpdatedelete

	Scenario: Add new skills as a seller
	Given I login to the website with valid credentials
	When  I add skills 
	Then  Seller is able to verify the skills in the profile details

	Scenario: Update skills
	Given I login to the website with valid credentials
	When I edit the existing skills
	Then I am able to verify the updated skills

	Scenario: Delete skills
	Given I Login to the website with valid UserId and Password
	When I try to delete existing skills
	When I am able to delete the skills


