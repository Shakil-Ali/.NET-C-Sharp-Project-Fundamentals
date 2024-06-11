using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Security.AccessControl;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add("1");
            myArrayList.Add("2");
            myArrayList.Add("3");

            foreach(int i in myArrayList)
            {
                Console.WriteLine(i);
            }

        }

    }
}
