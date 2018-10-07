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
            int vx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite chislo dlya izmeneniya Shiriny: ");
            int vy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite chislo dlya izmeneniya glubiny: ");
            int vz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Shed's standart ob'em: " + resultSize);
            myShed.GetAndExpandSize(ref vx, ref vy, ref vz);
            Console.WriteLine("new dlina: " + vx + "; new shirina: " + vy + "; new glubina: " + vz);
            Console.WriteLine("Shed's new ob'em: " + myShed.GetSize());

        }
    }
}

