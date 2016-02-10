Feature: Winning a Point Increases Score Correctly
	As a library user
	I want the score to increase when a player wins a point
	So that I can display the current score correctly

@WinningAPoint
Scenario: ScorePoint15
	Given the score is 0:0
	When the server wins a point
	Then the score is 15:0
Scenario: ScorePoint30
	Given the score is 15:15
	When the receiver wins a point
	Then the score is 15:30
Scenario: ScorePoint40
	Given the score is 30:30
	When the server wins a point
	Then the score is 40:30
