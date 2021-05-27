Feature: SecondFeature
	Simple calculator for adding two numbers

@mytag
Scenario: Navigte to external source
	Given I navigate to application
	And I click the VisitNow link
	And I enter SomeText to search
	  | SomeText |
	  | sometext    |
	Then I should see result of search