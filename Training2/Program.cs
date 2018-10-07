using System;

namespace Training2
{
    class ProgramShed
    {
        static void Main()
        {
            Shed myShed = new Shed();
            myShed._heigh = 7;
            myShed._width = 6;
            myShed._lengthwise = 10;
            Console.WriteLine("Vysota: " + myShed._heigh);
            Console.WriteLine("Shirina: " + myShed._width);
            Console.WriteLine("Glubina: " + myShed._lengthwise);
            int resultSize = myShed.GetSize();
            Console.Write("Vvedite chislo dlya izmeneniya Vysoty: "); 
            int heighAdd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite chislo dlya izmeneniya Shiriny: ");
            int widthAdd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite chislo dlya izmeneniya glubiny: ");
            int lengthwiseAdd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Shed's standart ob'em: " + resultSize);
            myShed.ExpandSize(heighAdd, widthAdd, lengthwiseAdd);
            Console.WriteLine("Shed's custom ob'em: " + myShed.GetSize());
            Console.ReadKey();
        }
    }
}

