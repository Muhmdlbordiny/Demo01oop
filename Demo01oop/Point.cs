using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01oop
{
    internal struct Point
    {
        public int X;
        public int Y;
        //Constructor .. is a special type of Function
        //always Naamed With Same name of struct or class
        //has no return
        //By Default => Compiler will Always Generate ParameterLess Constructor
        //that Intialized Attributes of struct with Default value of its datatype
        public Point(int _x,int _y)
        {
            //X = 10;
            //Y = 20;
            //// vaild from C# 10 .net6
            X= _x;
            Y= _y;
        }
        public Point(int Number)
        {
           X=Y=Number;
        }
        public override string ToString()
        {
            return $"{this.X},{this.Y}";
        }
    }
}
