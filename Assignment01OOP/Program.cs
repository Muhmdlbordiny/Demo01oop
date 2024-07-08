using System;

namespace Assignment01OOP
{
    public class Employee
    {
        public int X;
        public int Y;
        public Permission permission;
        public decimal Salary;
    }
    public enum Color
    {
        red =1,
        green =2,
        blue =4
    }
    public enum WeekDays
    {
        Monday, Tuesday, Wednesday,thursday ,Friday,saturday ,Sunday
    }
    public enum Seassons
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    [Flags]
    public enum Permission
    {
        Read =1,
        Write =2,
        Delete =4,
        Execute =8
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
             * Then, write a C# program that prints out all the days of the week using this enum.*/
            for (WeekDays item = WeekDays.Monday; item <= WeekDays.Sunday; ++item)
            {
                Console.WriteLine($"{item} == {(int)item}");
            }
            #endregion
            #region Q2
            /*2.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
             * Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
             * Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)*/


            
            //bool flag = Enum.TryParse<Seassons>(Console.ReadLine(), true, out Seassons result);

            FindSeason();
            #endregion
            #region Q3
            /*3.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            ⮚ Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
             */
            Employee employee = new Employee();
            employee.permission = Permission.Read;
            if((employee.permission&Permission.Write)== Permission.Write)
            {
                Console.WriteLine("Write is Exisited");
            }
            else
            {
                Console.WriteLine("write is not exisits");
                employee.permission = employee.permission ^ Permission.Write;
                Console.WriteLine(employee.permission);
            }
            if((employee.permission & Permission.Delete) == Permission.Delete)
            {
                Console.WriteLine("Delete is Exisits ");
            }
            else
            {
                Console.WriteLine("Delete is not exisits");
                employee.permission = employee.permission ^ Permission.Delete;
                Console.WriteLine(employee.permission);
            }
            if((employee.permission & Permission.Execute) == Permission.Execute)
            {
                Console.WriteLine("Execute is Exisits ");
            }
            else
            {
                Console.WriteLine("Execute is not exisits");
                employee.permission = employee.permission ^ Permission.Execute;
                Console.WriteLine(employee.permission);
            }
            #endregion
            #region Q4
            /*4.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. 
             * Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.*/
            Console.WriteLine("Enter your Color Flag");
            bool Flag = Enum.TryParse<Color>(Console.ReadLine(), true, out Color result);
            Console.WriteLine(result);
                switch (result)
                {
                    case Color.red :
                    case Color.green:
                    case Color.blue :
                        Console.WriteLine("ciolor is a primary");
                        break;
                    default:
                        Console.WriteLine("color not primary");
                        break;
                }
            #endregion
            #region Q5
            /*5.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". 
             * Write a C# program that takes two points as input from the user and calculates the distance between them.*/
            Console.WriteLine("enter your point 1 X: ");
            double dot1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your point 1 y:");
            double dot2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter your point X2:");
            double dot3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your point Y2 :");
            double dot4 = double.Parse(Console.ReadLine());
            Point p1;
            p1 = new Point(dot1, dot2);
            Console.WriteLine(p1);
            //p1 = new Point(dot1,dot2,dot3, dot4);
            double Res = Point.Distance(dot1 , dot2, dot2 ,dot3);
            Console.WriteLine($"Result is a {Res}");
            #endregion

        }
       
        public static void FindSeason()
        {
            Console.WriteLine("Enter your Number Month:");
            int Month = int.Parse(Console.ReadLine());
            switch (Month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine($"Seasson is a :{Seassons.Winter}");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"Seasson is a :{Seassons.Spring}");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine($"Seasson is a :{Seassons.Summer}");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine($"Seasson is a :{Seassons.Autumn}");
                    break;
                default:
                    Console.WriteLine("Invaild Month Number");
                    break;
            }
        }
    }
    
}
