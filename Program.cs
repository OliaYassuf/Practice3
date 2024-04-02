using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class City
    {
        private string cityName;
        private string countryName;
        private int population;
        private string phoneCode;
        private string[] districts;

        public string CityName { get; set; }
        public string CountryName { get; set; }
        public int Population { get; set; }
        public string PhoneCode { get; set; }
        public string[] Districts { get; set; }

        public void InputData()
        {
            Console.WriteLine("Enter city name:");
            CityName = Console.ReadLine();

            Console.WriteLine("Enter country name:");
            CountryName = Console.ReadLine();

            Console.WriteLine("Enter population:");
            Population = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter phone code:");
            PhoneCode = Console.ReadLine();

            Console.WriteLine("Enter number of districts:");
            int numDistricts = int.Parse(Console.ReadLine());
            Districts = new string[numDistricts];
            Console.WriteLine("Enter district names:");
            for (int i = 0; i < numDistricts; i++)
            {
                Console.Write($"District {i + 1}: ");
                Districts[i] = Console.ReadLine();
            }
        }
        public void DisplayData()
        {
            Console.WriteLine($"City Name: {CityName}");
            Console.WriteLine($"Country Name: {CountryName}");
            Console.WriteLine($"Population: {Population}");
            Console.WriteLine($"Phone Code: {PhoneCode}");
            Console.WriteLine("Districts:");
            foreach (var district in Districts)
            {
                Console.WriteLine(district);
            }
        }



    }

    class Employee 
    {
        private string fullName;
        private DateTime dateOfBirth;
        private string phoneNumber;
        private string email;
        private string position;
        private string jobDescription;

        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string JobDescription { get; set; }

        public Employee()
        {
        }

        public Employee(string fullName, DateTime dateOfBirth, string phoneNumber, string email, string position, string jobDescription)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            Position = position;
            JobDescription = jobDescription;
        }

        public void InputData()
        {
            Console.WriteLine("Enter full name:");
            fullName = Console.ReadLine();

            Console.WriteLine("Enter date of birth (YYYY-MM-DD):");
            dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter phone number:");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter email:");
            email = Console.ReadLine();

            Console.WriteLine("Enter position:");
            position = Console.ReadLine();

            Console.WriteLine("Enter job description:");
            jobDescription = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Date of Birth: {DateOfBirth:yyyy-MM-dd}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Job Description: {JobDescription}");
        }


    }

    class Plane 
    {
        private string planeName;
        private string manufacturer;
        private int yearOfProduction;
        private string type;

        public string PlaneName { get; set; }
        public string Manufacturer { get; set; }
        public int YearOfProduction { get; set; }
        public string Type { get; set; }

        public Plane(string planeName, string manufacturer, int yearOfProduction, string type)
        {
            PlaneName = planeName;
            Manufacturer = manufacturer;
            YearOfProduction = yearOfProduction;
            Type = type;
        }

        public Plane(string planeName, string manufacturer, int yearOfProduction) : this(planeName, manufacturer, yearOfProduction, "")
        {
        }

        public Plane(string planeName, string manufacturer) : this(planeName, manufacturer, 0)
        {
        }

        public Plane(string planeName, string manufacturer, string type) : this(planeName, manufacturer, 0, type)
        {
        }

        public void InputData()
        {
            Console.WriteLine("Enter plane name:");
            PlaneName = Console.ReadLine();

            Console.WriteLine("Enter manufacturer:");
            Manufacturer = Console.ReadLine();

            Console.WriteLine("Enter year of production:");
            YearOfProduction = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter type:");
            Type = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"Plane Name: {PlaneName}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year of Production: {YearOfProduction}");
            Console.WriteLine($"Type: {Type}");
        }
    }

    class Matrix
    {

        private int[,] data;

        public Matrix(int rows, int columns)
        {
            data = new int[rows, columns];
        }

        public void InputData()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter element at position [{i + 1},{j + 1}]:");
                    data[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("Matrix:");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int CalculateMaximum()
        {
            int max = data[0, 0];

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j] > max)
                    {
                        max = data[i, j];
                    }
                }
            }

            return max;
        }

        public int CalculateMinimum()
        {
            int min = data[0, 0];

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j] < min)
                    {
                        min = data[i, j];
                    }
                }
            }

            return min;
        }
    }
    internal class Program
    {
        static int GetProductOfRange(int min, int max)
        {
            int result = 1;
            for (int i = min; i <= max; i++)
            {
                result = result * i;
            }
            return result;
        }
        static bool IsFibonacci(int num) 
        {
            int a = 0;
            int b = 1;

            while (a < num)
            {
                int temp = a;
                a = b;
                b = temp + b;

                if (a == num)
                    return true;
            }

            return false;

        }
        static void BubbleSortAscending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void BubbleSortDescending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }


    static void Main(string[] args)
        {
            //1
            int res = GetProductOfRange(3, 5);
            Console.WriteLine(res);

            //2
            int number = 17;
            Console.WriteLine($"Is {number} a Fibonacci number? {IsFibonacci(number)}");

            //3
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Enter 'asc' for ascending order or 'desc' for descending order:");
            string sortOrder = Console.ReadLine().ToLower();

            if (sortOrder == "asc")
                BubbleSortAscending(arr);
            else if (sortOrder == "desc")
                BubbleSortDescending(arr);
            else
                Console.WriteLine("Invalid input");

            Console.WriteLine("Sorted array:");
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }

            //4
            //City city1 = new City();
            City city = new City();
            city.CityName = "Braunschweig";
            city.CountryName = "Deutschland";
            city.Population = 300_000;
            city.PhoneCode = "+490";
            city.Districts = new string[] { "District1", "District2", "District3" };
            //city1.InputData();
            Console.WriteLine();
            city.DisplayData();

            //5
            Employee employee1 = new Employee();
            employee1.DisplayData();
            Console.WriteLine();

            Employee employee2 = new Employee("Olia Yassuf", new DateTime(2005, 4, 16), "`01752870153", "yassufo@gmail.com", "Manager", "Managing staff and operations");
            employee2.DisplayData();

            //6
            Plane plane1 = new Plane("Boeing 747", "Boeing", 1995, "Passenger");
            Plane plane2 = new Plane("Airbus A380", "Airbus", 2007);
            Plane plane3 = new Plane("Cessna 172", "Cessna");
            Plane plane4 = new Plane("Jet Fighter", "Military", "Fighter");

            Console.WriteLine("Plane 1:");
            plane1.DisplayData();
            Console.WriteLine();

            Console.WriteLine("Plane 2:");
            plane2.DisplayData();
            Console.WriteLine();

            Console.WriteLine("Plane 3:");
            plane3.DisplayData();
            Console.WriteLine();

            Console.WriteLine("Plane 4:");
            plane4.DisplayData();

            //7
            //Console.WriteLine("Enter the number of rows:");
            //int rows = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the number of columns:");
            //int columns = int.Parse(Console.ReadLine());

            int rows = 5;
            int columns = 3;

            Matrix matrix = new Matrix(rows, columns);

            matrix.InputData();

            matrix.DisplayData();

            Console.WriteLine($"Maximum value in the matrix: {matrix.CalculateMaximum()}");
            Console.WriteLine($"Minimum value in the matrix: {matrix.CalculateMinimum()}");
        }
    }
}
