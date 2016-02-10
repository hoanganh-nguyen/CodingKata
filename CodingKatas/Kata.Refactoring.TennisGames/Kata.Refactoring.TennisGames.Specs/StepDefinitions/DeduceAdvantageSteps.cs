using System;
using TechTalk.SpecFlow;

namespace Kata.Refactoring.TennisGames.Specs.StepDefinitions
{
    [Binding]
    public class DeduceAdvantageSteps
    {
        [Given(@"the score is (.*)")]
        public void GivenTheScoreIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the score is A:(.*)")]
        public void GivenTheScoreIsA(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the receiver wins a point")]
        public void WhenTheReceiverWinsAPoint()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the score should be (.*):A")]
        public void ThenTheScoreShouldBeA(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the score should be (.*)")]
        public void ThenTheScoreShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
