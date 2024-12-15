using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsOfTests
{
    public class TestsMenu
    {
        internal void CreateTest(int robotId, int testerId, DateTime date, string reportPath, int status)
        {
            throw new NotImplementedException();
        }

        internal void DeleteTest(int id)
        {
            throw new NotImplementedException();
        }

        internal List<Test> GetTests()
        {
            List<Test> tests = new List<Test>();
            return tests;
        }

        internal Test? UpdateTest(int index, int robotId, int testerId, DateTime date, string reportPath, int statusId)
        {
            throw new NotImplementedException();
        }
    }
}
