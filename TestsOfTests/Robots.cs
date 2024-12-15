namespace TestsOfTests
{
    public class Robots
    {
        RobotsMenu menu;
        [SetUp]
        public void Setup()
        {
            menu = new RobotsMenu();
        }

        [Test]
        public void GetRobots()
        {
            var robots = menu.GetRobots();
            Assert.IsNotNull(robots);
        }

        //Тест GetRobots() проверяет точно ли вернулся список роботов из базы данных.
        //Метод GetRobots() делает запрос в базу данных и получает список роботов.
        //Assert.IsNotNull(robots) - проверка, что список роботов не пустой.

        [Test]
        public void WasCreateNewRobot()
        {
            var count1 = menu.GetRobots().Count();
            string title = "MAUV256";
            string serialNumber = "10000045c63b";
            int statusId = 1;
            menu.Create(title, serialNumber, statusId);
            var count2 = menu.GetRobots().Count();
            Assert.That(count1, Is.EqualTo(count2));
        }

        //Тест WasCreateNewRobot() проверяет добавляется ли новый робот в базу данных.
        //Для теста необходимо добавить нового робота в базу данных с помощью метода Create(), а потом сравнить количество роботов в списке до и после добавления робота(Assert.That(count1, Is.EqualTo(count2))). Если значения не равны, значит тест прошёл успешно.


        [Test]
        public void WasUpdateRobot()
        {
            Robot robot = menu.GetRobots().FirstOrDefault(s => s.Title == "MAUV256");
            string title = "MAUV256";
            string serialNumber = "10000045c63b";
            int statusId = 1;
            int index = 1;
            robot = menu.Update(index, title, serialNumber, statusId);
            Assert.That(title, Is.EqualTo(robot.Title));
            Assert.That(serialNumber, Is.EqualTo(robot.SerialNumber));
            Assert.That(statusId, Is.EqualTo(robot.StatusId));

            //Тест WasUpdateRobot() проверяет обновляются ли данные робота в базе данных. 
            //Для теста необходимо найти какого-то робота из списка и в метод Update() передать новые данные о роботе. Метод Update() обновит информацию о роботе в базе данных. После необходимо проверить точно ли новые данные совпадают с нынешними(Например, Assert.That(title, Is.EqualTo(robot.Title))).
        }

        [Test]
        public void WasDeleteRobot()
        {
            var count1 = menu.GetRobots().Count();
            Robot robot = menu.GetRobots().FirstOrDefault(s => s.Title == "MAUV256");
            menu.Delete(robot.Id);
            var count2 = menu.GetRobots().Count();
            Assert.That(count1, Is.Not.EqualTo(count2));
        }

        //Тест WasDeleteRobot() проверяет удаляется ли робот из списка в базе данных. 
        //Для теста необходимо найти какого-то робота из списка и в метод Deletе() передать идентификатор робота, которого нужно удалить. После нужно сравнить количество роботов в списке до и после удаления(Assert.That(count1, Is.Not.EqualTo(count2))). Если эти значения не совпадут, тест прошёл успешно.
    }
}