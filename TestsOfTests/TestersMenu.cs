using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsOfTests
{
    public class TestersMenu
    {
        public List<Tester> GetTesters()
        {
            List<Tester> list = new List<Tester>();
            return list;
        }

        internal object Autorize(string login, string password)
        {
            throw new NotImplementedException();
        }

        internal void Registration(string firsname, string lastname, string patronymic, DateOnly birthday, string login, string password, string email, int roleId)
        {
            throw new NotImplementedException();
        }
    }
}
