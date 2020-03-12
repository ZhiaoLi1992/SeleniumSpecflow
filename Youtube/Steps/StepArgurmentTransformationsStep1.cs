using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Youtube.Steps
{
    [Binding]
    public class StepArgurmentTransformationsSteps
    {
        private double convertedResult;
        private TimeSpan ts;

        [Given(@"I have entered (.*) into the timestamp to minute converter")]
        public void GivenIHaveEnteredDaysIntoTheTimestampToMinuteConverter(TimeSpan tsTransformed)
        {
            ts = tsTransformed;
        }
        
        [When(@"I press calculate")]
        public void WhenIPressCalculate()
        {
            Class.TimestampoMinuteConverter tsConverter = new Class.TimestampoMinuteConverter();
            convertedResult = tsConverter.ConvertToMinutes(ts);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(Decimal p0)
        {
            Console.WriteLine("Test Result");
            Assert.AreEqual(p0, convertedResult);
        }


        [StepArgumentTransformation(@"(?:(\d*) day(?:s)?(?:, )?)?(?:(\d*) hour(?:s)?(?:, )?)?(?:(\d*) minute(?:s)?(?:, )?)?(?:(\d*) second(?:s)?(?:, )?)?")]
        public TimeSpan convertToTimeSpan(String days, String hours, String minutes, String seconds)
        {
            int daysValue;
            int hoursValue;
            int minutesValue;
            int secondsValue;

            int.TryParse(days, out daysValue);
            int.TryParse(hours, out hoursValue);
            int.TryParse(minutes, out minutesValue);
            int.TryParse(seconds, out secondsValue);

            return new TimeSpan(daysValue, hoursValue, minutesValue, secondsValue);
        }


    }
}
