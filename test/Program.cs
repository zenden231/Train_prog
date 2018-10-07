using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace ReadExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel.Application ObjWorkExcel = new Excel.Application(); //открыть эксель
            Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(@"C:\Users\Uzzer\Desktop\test.xlsx"); //открыть файл
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1]; //получить 1 лист
            var lastCell = ObjWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);//1 ячейку
            //-------------------------------------
            int lastColumn = (int)lastCell.Column;//!сохраним непосредственно требующееся в дальнейшем
            int lastRow = (int)lastCell.Row;
            //-------------------------------------
            string[,] list = new string[lastCell.Column, lastCell.Row]; // массив значений с листа равен по размеру листу
            for (int i = 0; i < (int)lastCell.Column; i++) //по всем колонкам
                for (int j = 0; j < (int)lastCell.Row; j++) // по всем строкам
                    list[i, j] = ObjWorkSheet.Cells[j + 1, i + 1].Text.ToString();//считываем текст в строку
            ObjWorkBook.Close(false, Type.Missing, Type.Missing); //закрыть не сохраняя
            ObjWorkExcel.Quit(); // выйти из экселя
            GC.Collect(); // убрать за собой -- в том числе не используемые явно объекты !
            for (int i = 0; i < lastColumn; i++) //по всем колонкам
                for (int j = 0; j < lastRow; j++) // по всем строкам 
                    Console.Write(list[i, j]);//выводим строку
            Console.ReadLine();
        }
    }
}

