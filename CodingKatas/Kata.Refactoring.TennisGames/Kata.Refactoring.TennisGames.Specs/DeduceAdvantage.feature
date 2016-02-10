Feature: DeduceAdvantage
		As a library user
		I want deuce and advantage to be scored correctly
		So that I can display the score correctly

@DeduceAdvantage
Scenario:Advantage
    Given the score is 40:40
    When the receiver wins a point
    Then the score should be 40:A

Scenario:Deduce
	Given the score is A:40
    When the receiver wins a point
    Then the score should be 40:40

	







