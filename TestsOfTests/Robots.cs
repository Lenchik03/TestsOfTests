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

        [Test]
        public void WasCreateNewStudent()
        {
            var count1 = menu.GetRobots().Count();
            string title = "MAUV256";
            string serialNumber = "10000045c63b";
            int statusId = 1;
            var count2 = menu.GetRobots().Count();
            menu.Create(title, serialNumber, statusId);
            Assert.That(count1, Is.EqualTo(count1));
        }

        [Test]
        public void WasUpdateStudent()
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
        }

        [Test]
        public void WasDeleteStudent()
        {
            var count1 = menu.GetRobots().Count();
            Robot robot = menu.GetRobots().FirstOrDefault(s => s.Title == "MAUV256");
            menu.Delete(robot.Id);
            var count2 = menu.GetRobots().Count();
            Assert.That(count1, Is.Not.EqualTo(count2));
        }
    }
}