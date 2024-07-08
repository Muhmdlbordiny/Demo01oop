using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB
    {
        // TypeB accessible within its project only
        //public TypeB()
        //{
        //    TypeA typeA = new TypeA();
        //    //Vaild =>TypeA accessible With in its project and With in external project if import to library in project
        //    //typeA.X = 10;//Invaild X is inaccessable due to its protection level X is a private
        //    typeA.Y = 10;// Vaild Accessable with in its scope and its project
        //    typeA.Z = 20; //Vaild Accessable with in its scope and  project
        //}
    }
}
