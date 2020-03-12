using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Youtube.Class;

namespace Youtube
{
    [Binding]
    public class SATSteps
    {
        [Given(@"The original user was created over (.* days ago)")]
        public void GivenTheOriginalUserWasCreatedOverDaysAgo(DateTime userCreatedDate)
        {
            Console.WriteLine(userCreatedDate);
        }
        
        [When(@"I update the users password to ""(.*)""")]
        public void WhenIUpdateTheUsersPasswordTo(string p0)
        {
            Console.WriteLine(p0);
        }
        
        [Then(@"I should see the following errors")]
        public void ThenIShouldSeeTheFollowingErrors(IEnumerable<Error> errors)
        {
           foreach(Error e in errors)
            {
                Console.Write(e.ErrorCode + " ");
                Console.WriteLine(e.ErrorDescription);
            }
        }
    }
}
