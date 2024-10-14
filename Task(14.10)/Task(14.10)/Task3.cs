namespace Task_14._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Hyundai","Elantra",155000,4);
/*            car.ShowFullInfo();

            Bicycle bike = new Bicycle("Hyundai", "Elantra", 155000, 2);
            bike.ShowFullInfo();*/

            Car[] Cars = new Car[0];

            addCar(ref Cars, car);

            for(int i = 0; i < Cars.Length; i++)
            {
                Console.WriteLine(Cars[i]);
            }
        }

        public static Car[] addCar(ref Car[] cars , Car car)
        {
            Array.Resize(ref cars, cars.Length + 1);

            cars[cars.Length-1] = car; 

            return cars;

        }
    }

    class Vehicle
    {
        public string Brand;
        public string Model;
        public double Mile;


        public Vehicle(string brand, string model, double mile)
        {
            this.Brand = brand;
            this.Model = model;
            this.Mile = mile;
        }

    }

    class Car : Vehicle
    {
        public int DoorsNum;



        public Car(string brand, string model, double mile, int doorsNum) : base(brand, model, mile)
        {
            this.DoorsNum = doorsNum;
        }
        public void ShowFullInfo()
        {
            Console.WriteLine("Brand:" + Brand + " " + "Model:" + Model + " " + "Mile:" + Mile + " " + "Doors Num:" + DoorsNum);
        }
    }

    class Bicycle : Vehicle
    {
        public int WheelNum;

        public Bicycle(string brand, string model, double mile, int wheelNum) : base(brand, model, mile)
        {
            this.WheelNum = wheelNum;
        }
        public void ShowFullInfo()
        {
            Console.WriteLine("Brand:" + Brand + " " + "Model:" + Model + " " + "Mile:" + Mile + " " + "Wheel Num:" + WheelNum);

        }
    }

}
