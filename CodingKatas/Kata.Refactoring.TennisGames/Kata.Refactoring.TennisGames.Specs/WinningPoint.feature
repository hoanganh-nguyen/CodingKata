Feature: Winning Points are Scored Correctly
	As a library user
	I want the winning point to be scored correctly
	So that I can display the winner

@WinningPoint
Scenario: WinWith2PointsSeparated
	Given the score is 40:30
	When the server wins a point
	Then the server should win

Scenario:WinInAdvantageCase
	Given the score is 40:A
	When the receiver wins a point
	Then the receiver should win