/*using System.Runtime.Intrinsics.X86;

namespace Task_14._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Username = "admin";
            user1.Age = 30;
            user1.Name = "Xaqan";
            user1.Password = "ad1000";
            user1.Surname = "Ismayilov";
            user1.ShowFullData();
        }
    }

    class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
        public Human()
        {

        }
        public Human(string name, string surname, byte age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
    }

    class User : Human
    {
        public string Username;
        public string Password;
        public User()
        {

        }
        public User(string username, string password, string name, string surname, byte age) : base(name, surname, age)
        {
            this.Username = username;
            this.Password = password;
        }

        public void ShowFullData()
        {
            Console.WriteLine($"Username: {Username}, Name: {Name}, Surname: {Surname},  Age: {Age}");
        }
    }
}
*//*




namespace BP215ClassTask
{





    //    Human class:
    //============
    //string Name
    //string Surname;
    //byte Age 



    //User class:Human
    //===========
    // - UserName - istifadəçinin istifadəçi adını ifadə edir
    // - Password - İstifadəçinin şifrə dəyərini ifadə edir



    //User classi Human'dan miras alir. Name, Surname, UserName dəyəri təyin olunmamış User obyekti yaradıla bilinməməlidir


    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human(surname: "Balaca", name: "Anar");

            human.ShowFullData();

            human.age = 24;

            Human[] humen = { human };

            User user = new User("Anar", "Balaca", "Balaca24");

            user.ShowFullData();







        }

    }


    public class User : Human
    {
        public string username;
        public string password;

        public User(string name, string surname) : base(name, surname)
        {
            username = name + surname;
        }
        public User(string name, string surname, string password) : base(name, surname)
        {
            this.password = password;
            username = name + surname;
        }

        public void ShowFullData()
        {
            Console.WriteLine($"name: {name} , surname : {surname} , username: {username} , password:{password}");

        }
    }



    public class Human
    {
        public string name;
        public string surname;
        public byte age;
        public string eyeColor;


        public Human()
        {

        }

        public Human(string name)
        {
            this.name = name;
        }
        public Human(string name, string surname) : this(name)
        {
            this.surname = surname;

        }

        public Human(string name, byte age) : this(name)
        {
            this.age = age;
        }

        public Human(string name, string surname, byte age) : this(name, surname)
        {
            this.age = age;
        }


        public void ShowFullData()
        {
            Console.WriteLine($"name: {name} , surname : {surname} , age: {age} , eyecolor:{eyeColor}");

        }
        public void GetFullName()
        {
            Console.WriteLine($"name: {name} , surname : {surname}  ");

        }



    }





}*/