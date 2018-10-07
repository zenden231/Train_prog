using System;

namespace training1
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
            Console.WriteLine("Shed's ob'jom: " + resultSize);
        }
    }
    class Shed
    {
        int heigh;
        /// <summary>
        /// Сокращенное объявление свойстава без переменной
        /// </summary>
        public int _width
        {
            get;
            set;
        }
        /// <summary>
        /// Свойство переменной в полном виде
        /// </summary>
        public int _heigh
        {
            get { return heigh; }
            set { heigh = value; }
        }
        /// <summary>
        /// Сокращенное объявление свойстава без переменной (жоское сокращение!11)
        /// </summary>
        public int _lengthwise { get; set; }
        /// <summary>
        /// Считает объем объекта Shed(сарай)
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            int size = _width * heigh * _lengthwise;
            return size;
        }
    }
}
