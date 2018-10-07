using System;


namespace HelloApp
{
    class Program
    {
        int test = 1;
        /// <summary>
        /// Для доступа к переменной
        /// </summary>
        public int _test1
        {
            get {return test+1; }
            set { test = value; }
        }
        /// <summary>
        /// КОнсолька
        /// </summary>
        static void Main()
        {
            Program obj = new Program();
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, fkn {name}");
            Console.WriteLine(obj._test1);
            int newValue = Convert.ToInt32(Console.ReadLine());
            obj._test1 = newValue;
            Console.WriteLine(obj._test1);
            Console.ReadLine();
        }
    }
}

