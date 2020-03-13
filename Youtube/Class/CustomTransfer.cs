using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Youtube.Class
{
    [Binding]
    public class CustomTransfer
    {
        [StepArgumentTransformation(@"(\d+) days ago")]
        public DateTime DaysAgoTransform(int daysAgo)
        {
            return DateTime.Today.AddDays(-daysAgo);
        }
        [StepArgumentTransformation]
        public IEnumerable<Error> ErrorsTransform (Table table)
        {
            return table.CreateSet<Error>();
        }
        [StepArgumentTransformation]
        public Dictionary<int,string> SnowboardTransform(Table table)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            foreach(var row in table.Rows)
            {
                d.Add(Int32.Parse(row[0]), row[1]);
            }
            return d;
        }

    }
}
