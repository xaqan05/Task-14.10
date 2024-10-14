/*namespace Task_14._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human xaqan = new Human();

            xaqan.GetFullName();
            xaqan.ShowFullData();
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
        public Human(string name)
        {
            Name = name;
        }
        public Human(string name, string surname) : this(name)
        {
            Surname = surname;
        }
        public Human(string name, string surname, byte age) : this(name, surname)
        {
            Age = age;
        }
        public void ShowFullData()
        {
            Console.WriteLine(Name + " " + Surname + " " + Age);
        }
        public void GetFullName()
        {
            Console.WriteLine(Name + " " + Surname);
        }
    }
}
*/