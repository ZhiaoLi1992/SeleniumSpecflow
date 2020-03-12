using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Youtube.Class;

namespace Youtube.Steps
{
    [Binding]
    public class StudentInfoTransferFeatureSteps
    {
        private List<Student> students;
        [Given(@"I have entered following info for Student")]
        public void GivenIHaveEnteredFollowingInfoForStudent(Table table)
        {
            students = table.CreateSet<Student>().ToList<Student>();
        }
        
        [Then(@"Student info should be displayed")]
        public void ThenStudentInfoShouldBeDisplayed()
        {
           foreach(Student s in students)
            {
                Console.WriteLine(s.LastName + "," + s.FirstName + " " + s.Age + " " + s.Nationality);
            }
        }
    }
}
