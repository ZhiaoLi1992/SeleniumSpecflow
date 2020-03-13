using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace Youtube.Steps
{
    [Binding]
    public class TableToDictSteps
    {
        private Dictionary<int, string> dictionary;
        [Given(@"I have a table")]
        public void GivenIHaveATable(Dictionary<int, string> dict)
        {
            foreach(var pair in dict)
            {
                Console.WriteLine("My student id is {0}, first name is {1}", pair.Key, pair.Value);
            }
            dictionary = dict;
        }
        
        [Then(@"transfer table to dictionary")]
        public void ThenTransferTableToDictionary()
        {
            Console.WriteLine(dictionary.Count());
        }
    }
}
