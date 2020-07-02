Feature: Feature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Authorize by entering username and password
    Given Open authorize page
	And User authorized
	| Login     | Password  |
	| testadmin | password002 |

	When I enter <Name>  in FullName field, <Course> in Course field, <Login> in login field, <eMail> in email field, <Password> in password field, <Number> in PhoneNumber  field, <Birthday> in Birthday field, <Status> in Status field
	And I press ADD Button
	And I press last lead
	Then Name with <Name> in field, Course with <Course> in field, Login with <Login> in field, eMail with <eMail> in field, Number with <Number> in PhoneNumber  field, Birthday with <Birthday> in field, Status with <Status> in field

	Examples: 
	| Name     | Course | Login      | eMail              | Password          | Number        | Birthday | Status  |
	| New User | Mobile | mobileuser | mobileuser0001@gmail.com | passwordmobile001 | +994553212121 | 08051995 | Student |
	
