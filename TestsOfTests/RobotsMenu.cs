using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsOfTests
{
    public class RobotsMenu
    {
        public List<Robot> GetRobots()
        {
            List<Robot> students = new List<Robot>();
            return students;
        }

        internal void Create(string title, string serialNumber, int statusId)
        {
            throw new NotImplementedException();
        }

        internal void Delete(object id)
        {
            throw new NotImplementedException();
        }

        internal Robot? Update(int index, string title, string serialNumber, int statusId)
        {
            throw new NotImplementedException();
        }
    }
}
