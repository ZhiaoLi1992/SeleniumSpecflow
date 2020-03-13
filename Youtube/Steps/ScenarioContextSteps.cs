using System;
using TechTalk.SpecFlow;

namespace Youtube.Steps
{
    [Binding]
    public class ScenarioContextSteps
    {
        [Given(@"I have entered (.*) into the  calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            ScenarioContext.Current["FirstNumber"] = number;
        }

        [Given(@"I also entered (.*) into the  calculator")]
        public void GivenIAlsoEnteredIntoTheCalculator(int number)
        {
            ScenarioContext.Current["SecondNumber"] = number;
        }

        [When(@"I press  add")]
        public void WhenIPressAdd()
        {
            var firstNumber = (int)ScenarioContext.Current["FirstNumber"];
            var secondNumber = (int)ScenarioContext.Current["SecondNumber"];
            ScenarioContext.Current["Result"] = firstNumber + secondNumber;
        }
        
        [Then(@"the result should be (.*) on  the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int total)
        {
            var result = ScenarioContext.Current["Result"];
            if (!result.Equals(total))
            {
                throw new Exception("Total is not correct");
            }
            Console.WriteLine("Test Passed");
        }
    }
}
