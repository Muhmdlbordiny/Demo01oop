using Common;
using System;

namespace Demo01oop
{
    public enum days
    {
        saturday,sunday,Monday,tuesday,wednesday,thrushday,friday
    }
    public enum Grades:int //[default]
     {
        A,
        B,
        C,
        D ,
        F
    }
    public enum Gender { Male =1,Female=2} 
    public enum Roles { Admin =10,Editor =20,Viewer=30}
    enum Branches:byte // 8bit 0-255
    {
        Dokki,
        NasrCity,
        Maddi,
        Alex,
        SmartVillage,
    }
    [Flags]
    public enum permission:byte
    {
        Delete =1,
        Execute =2,
        Read =4,
        Write =8
    }
   public class Employee
    {
       
       public string Name;
       public int Age;
       public Gender Gender; //0-1
       public decimal Salary;
       public Roles roles; // Admin -Editor - Viewer 10-20-30
       public permission permission;
    }
    internal class Program
    {
        //what you can write inside Nampspace?
        //class
        //interface
        //enum
        //struct
        // Access Modifier Allowed inside Namespace?
        // 1-internal[default]
        // 2-public
        

        static void Main(string[] args)
        {
            #region Exception
            //Exception
            //SystemExceptions
            //// 1.1 Format Exception
            //// 1.2 Index Out Of Range Exception
            //// 1.3 Null Reference Exception
            //// 1.4 Invalid Operation Exception
            //// 1.5 Arithmetic Exception
            ////  1.5.1 Divided By Zero Exception
            ////  1.5.2 Overflow Exception
            // 2. Application Exception
            // DosomeCode(); //RunTimes error (Exception)
            //try
            //{
            //    DosomeProtectiveCode();
            //    throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //Close| Delete | Release |Deallocate UnManged Resources
            //    // open file 
            //    //connection Database
            //    Console.WriteLine("Finally");
            //}
            //    Console.WriteLine("After Try Catch");

            #endregion
            #region Access Modifier
            //TypeA typeA = new TypeA();
            //TypeB obj2 = new TypeB(); //Invaild// typeB is inAccessable due to its protection
            //typeA.X = 10;//Invaild X is inaccessable due to its protection level X is a private
            //typeA.Y = 10; // Invaild Y i internal
            //typeA.Z = 10;// vaild
            #endregion
            #region Enum
            //days days = days.friday;
            #region Ex01
            //Grades X = Grades.A;
            //if (X==Grades.A)
            //{
            //    Console.WriteLine(":)");

            //}
            //else { Console.WriteLine(":("); }
            //Grades Y = (Grades) 2; // Explicit Casting
            //Console.WriteLine(Y);
            #endregion
            #region Ex02
            //Console.WriteLine("please enter your Grade");
            //Grades X = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());// waste case  unSafe .. converting from value type to ref type  and ref type to value type Action Boxing & UnBoxing 
            //bool Result = Enum.TryParse(typeof(Grades), Console.ReadLine(), out object X);

            // Console.WriteLine($"Your Grade is {X}");
            // Console.WriteLine($"Your Result is {Result}");
            #endregion
            #region Ex03
            //Gender G1 = Gender.Male;
            //Console.WriteLine(G1);//Male
            //Gender G2 = (Gender)1;
            //Console.WriteLine(G2);//Male
            //  string gender = "male";
            //  //Enum.TryParse(typeof(Gender), gender, out object Result);
            ////bool Flag =  Enum.TryParse<Gender>(gender, out Gender Result);
            //bool Flag =  Enum.TryParse<Gender>(gender, true,out Gender Result);
            //  Console.WriteLine(Flag);
            //  Console.WriteLine(Result);
            //  Gender X = new Gender();// Take Default Value of Enum =0
            //  Console.WriteLine(X);
            #endregion
            #region Ex04
            Employee employee = new Employee();
            //employee.Name = "Mohamed";
            //employee.Gender =Gender.Male;
            ////employee.permission = permission.Delete;
            //employee.permission = (permission)7;
            //Console.WriteLine(employee.permission); // Delete ,Execute,Read
            //if you wand add to permission (Read)
            //Do Xor Operation
            ////| ,&,^
            //employee.permission = employee.permission ^ permission.Read;
            //Console.WriteLine(employee.permission); // Delete ,Execute
            //employee.permission = employee.permission ^ permission.Read;
            //Console.WriteLine(employee.permission); // Delete ,Execute,Read
            //&  id you want to check if delete is exists or Not
            //employee.permission & permission.Delete;
            // id Delete is Exists =>return Delete
            // if Delete is not exists =>return random Value
            //if ((employee.permission & permission.Read) == permission.Read)
            //{
            //    Console.WriteLine("Delete is Exists");
            //}
            //else
            //{
            //    Console.WriteLine("Delete is not Exists");
            //    employee.permission = employee.permission ^ permission.Read;
            //}
            // if you want to check permission is Exisits or Not 
            // if Exisits => Do Nothing
            //if Not Exisits =>Add
            //Do Or Operation
            //employee.permission = employee.permission | permission.Read;
            //Console.WriteLine(employee.permission);




            #endregion

            #endregion
            #region Struct
            //Point p1;// Declare to varible  from type point  .. Clr allocate    8 bytes Stack Unintialize
            //Console.WriteLine(p1.X);//Invaild
            //p1.X = 20;
            //p1.Y = 10;
            //Console.WriteLine(p1.X);
            //Console.WriteLine(p1.Y);
            //p1 = new Point(10,20); //new => is just only for constructor selection 
            //                       // that will Initalized attributes of struct
            //Console.WriteLine(p1.X);
            //Console.WriteLine(p1.Y);
            //Console.WriteLine(p1);
            //Console.WriteLine(p1.ToString());
            //Point p02 = new();
            //Console.WriteLine(p02.X);
            //Console.WriteLine(p02.Y);
            #endregion

        }
        static void DosomeCode()
        {
            //try
            //{
            //    int X, Y, Z;
            //    X = int.Parse(Console.ReadLine());
            //    Y = int.Parse(Console.ReadLine());
            //    Z = X / Y;//Divided By Zero Exception
            //    int[] Numbers = { 1, 2, 3 };
            //    Numbers[10] = 100; // size =3 =>> out of range ind
            //    }
            // if any exception Happend in Try Block
            //ClR will create object from class of Exception of 
            // throw in catch block
                //catch(Exception ex) 
                //{
                //    Console.WriteLine(ex.Message); // log in file ,// store in database
                //}
        }
        static void DosomeProtectiveCode()
        {
            bool Flag;
            int X, Y, Z;


            //X = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter your Number :");
               Flag= int.TryParse(Console.ReadLine(), out X);
                // tryparse => true
                // tryparse => false
            } while (!Flag);
            do
            {
                Console.WriteLine("Enter your second Number :");
               Flag= int.TryParse(Console.ReadLine(), out Y);
                // tryparse => true
                // tryparse => false
            } while (!Flag || Y == 0);


            Z = X / Y;//Divided By Zero Exception
            int[] Numbers = null;/*{ 1, 2, 3 };*/
            if (Numbers?.Length > 10) //System.NullReferenceException
            {
                // Numbers = null =>return null
                //Numbers != null =>Return Length
                Numbers[10] = 100; // size =3 =>> out of range ind
            }
        }
    }
   
}
