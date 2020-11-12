Feature: Educational details
	As a seller
	I would like to add my educational details
@Education
	Scenario: Add Education Detail
	Given  I login the website with valid credentials
	When  I add Education details '<Country>', '<Title>', '<Year>'
	Then  seller should able to add Education details successfully
	Examples: 
	 | Country |   Title  | Year |
	 | India   |   B.Tech | 2011 |

	Scenario: Update the Education Details
	Given  I login to Mars portal with valid login And password
	When  I Update the Education detail'<Title>'
	Then  seller should able to update Education details successfully
	Examples: 
	| Title |
	| M.Tech |

	Scenario Outline: Delete the exsisting Education details
	Given I gotto website with valid login And password
	When  I delete the Education details
	Then  Seller should able to delete Education details successfully