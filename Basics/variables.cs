using System;

namespace vars{
    class Program{
        static void Main(string[] args){
            // Variables Basics
            int mynum = 5;
            double mydub = 5.9;
            char myletter = 'E';
            bool mybool = true;
            string mytext = "Text";

            Console.WriteLine(mytext);

            int unassigned_num;
            unassigned_num = 15;

            mydub = 20.26;
            Console.WriteLine(mydub);

            // Constants
            const int constVal = 25;

            // Display Variables
            string name = "John";
            Console.WriteLine("Hell0 " + name);

            string fname = "John ";
            string lname = "Doe";
            string full_name = fname + lname;
            Console.WriteLine(full_name);

            // Multiple Variables
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            int a, b, c;
            a = b = c = 50;
            Console.WriteLine(a + b + c);

        }
    }
}