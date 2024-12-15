using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsOfTests
{
    public class Tests
    {
        TestsMenu menu;
        [SetUp]
        public void Setup()
        {
            menu = new TestsMenu();
        }

        [Test]
        public void GetTests()
        {
            var tests = menu.GetTests();
            Assert.IsNotNull(tests);
        }

        //Тест GetTests() проверяет точно ли вернулся список тестов из базы данных.
        //Метод GetTests() делает запрос в базу данных и получает список тестов.
        //Assert.IsNotNull(tests) - проверка, что список тестов не путой.

        [Test]
        public void WasCreateNewTest()
        {
            var count1 = menu.GetTests().Count();
            int robotId = 2;
            int testerId = 1;
            DateTime date = DateTime.Now;
            string reportPath = "/tests/reports/" + robotId;
            int statusId = 1;
            menu.CreateTest(robotId, testerId, date, reportPath, statusId);
            var count2 = menu.GetTests().Count();
            Assert.That(count1, Is.EqualTo(count2));
        }

        //Тест WasCreateNewTest() проверяет добавляется ли новое тестирование в базу данных.
        //Для теста необходимо добавить новое тестирование в базу данных с помощью метода CreateTest(), а потом сравнить количество тестирований в списке до и после добавления тестирования(Assert.That(count1, Is.EqualTo(count2))). Если значения не равны, значит тест прошёл успешно.

        [Test]
        public void WasUpdateRobot()
        {
            Test test = menu.GetTests().FirstOrDefault(s => s.Id == 2);
            int robotId = 2;
            int testerId = 1;
            DateTime date = DateTime.Now;
            string reportPath = "/tests/reports/" + robotId;
            int statusId = 1;
            int index = 2;
            test = menu.UpdateTest(index, robotId, testerId, date, reportPath, statusId);
            Assert.That(robotId, Is.EqualTo(test.RobotId));
            Assert.That(testerId, Is.EqualTo(test.TesterId));
            Assert.That(date, Is.EqualTo(test.Date));
            Assert.That(reportPath, Is.EqualTo(test.ReportPath));
            Assert.That(statusId, Is.EqualTo(test.StatusId));
        }

        //Тест WasUpdateRobot() проверяет обновляются ли данные тестирования в базе данных. 
        //Для теста необходимо найти какое-то тестирование из списка и в метод UpdateTest() передать новые данные о тестировании. Метод UpdateTest() обновит информацию о тестировании в базе данных. После необходимо проверить точно ли новые данные совпадают с нынешними(Например, Assert.That(robotId, Is.EqualTo(test.RobotId))).

        [Test]
        public void WasDeleteRobot()
        {
            var count1 = menu.GetTests().Count();
            Test test = menu.GetTests().FirstOrDefault(s => s.Id == 2);
            menu.DeleteTest(test.Id);
            var count2 = menu.GetTests().Count();
            Assert.That(count1, Is.Not.EqualTo(count2));
        }

        //Тест WasDeleteRobot() проверяет удаляется ли тестирование из списка в базе данных. 
        //Для теста необходимо найти какое-то тестирование из списка и в метод DeleteTest() передать идентификатор тестирования, которое нужно удалить. После нужно сравнить количество тестирований в списке до и после удаления(Assert.That(count1, Is.Not.EqualTo(count2))). Если эти значения не совпадут, тест прошёл успешно.
    }
}
