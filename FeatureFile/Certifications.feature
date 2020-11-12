Feature: Certifications
	As a seller
	I would like to add my certificates
	@AddEditDelete

	Scenario: I Add new Certificate as a seller
	Given I login to the website with valid email id and password
	When  I add certificate
	Then  Seller is able to verify the certificate in the profile details

	Scenario: Update certificate
	Given I login to the Mars Portal with valid email id and password
	When I edit the existing certificates
	Then I am able to verify the updated certificates

	Scenario: Delete certificate
	Given I Login to the website with valid credentials
	When I try to delete existing certificate
	When I am able to delete the exsisting certificate
