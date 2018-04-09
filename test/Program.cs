using System;


namespace test
{
    class MainClass
    {
        public static void Main_prog(string[] args)
        {
           // Console.WriteLine("Hello World!");
           // object o = 20;
            //o = new object();
           // modify(o);
           // Console.Write(o);
            test.Properties.CrackingTheCoding audible = new Properties.CrackingTheCoding();
            Console.WriteLine("Unique char in a string {0}",audible.isUniqueChar("azAb"));
            Console.WriteLine("Enter the word to reverse");
            string str = Console.ReadLine();
            Console.WriteLine("Reverse the string {0}",audible.reverseString(str));

        }

        public static void modify(object i)
        {
            i = 10;
        }
    }
}
