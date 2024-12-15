using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsOfTests
{
    public class Testers
    {
        TestersMenu menu;
        [SetUp]
        public void SetUp()
        {
            menu = new TestersMenu();
        }

        [Test]
        public void WasRegistrationUser()
        {
            var count1 = menu.GetTesters().Count;
            string firsname = "Пётр";
            string lastname = "Петров";
            string patronymic = "Петрович";
            DateOnly birthday = new DateOnly(2025, 3, 2);
            string login = "login";
            string password = "password";
            string email = "email@gmail.com";
            int roleId = 1;
            menu.Registration(firsname, lastname, patronymic, birthday, login, password, email, roleId);
            var count2 = menu.GetTesters().Count;
            Assert.That(count1, Is.Not.EqualTo(count2));
        }

        //Тест WasRegistrationUser() проверяет регистрируется ли новый пользователь в базе данных.
        //Для теста необходимо добавить нового сотрудника в базу данных с помощью метода Registration(), а потом сравнить количество сотрудников в списке до и после добавления(Assert.That(count1, Is.EqualTo(count2))). Если значения не равны, значит тест прошёл успешно.

        [Test]
        public void WasUserAutorize()
        {
            string login = "login";
            string password = "password";
            var user = menu.Autorize(login, password);
            Assert.IsNotNull(user);
        }

        [Test]
        public void GetUsers()
        {
            var users = menu.GetTesters();
            Assert.IsNotNull(users);
        }

        //Тест GetUsers() проверяет точно ли вернулся список сотрудников из базы данных.
        //Метод GetUsers() делает запрос в базу данных и получает список пользователей.
        //Assert.IsNotNull(users) - проверка, что список пользователей не пустой.
    }
}
