using System;
using System.IO;

class Program
{
    static void Main()
    {

        string[] lines = File.ReadAllLines("input.txt"); // чтение данных из файла и запись в массим
        int[] conditions = lines[0].Split(' ').Select(int.Parse).ToArray(); // получение чисел организатора по 1 строчке и запись в массив
        int n = int.Parse(lines[1]); // кол-во билетов по 2 строчке
        string[] tickets = lines.Skip(2).ToArray(); // пропуск первых 2-х строк. получение чисел с каждого билета, запись в массив

        // проверка билетов и вывод инфы
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            foreach (var i in tickets) // проверяем
            {
                int[] ticketNumbers = i.Split(' ').Select(int.Parse).ToArray(); // получение чисел с лотерейного билета, запись в массив
                int count = ticketNumbers.Count(num => conditions.Contains(num)); // подсчет числа выбранных организаторами чисел

                if (count >= 3)
                    writer.WriteLine("Lucky"); // вывод победы
                else
                    writer.WriteLine("Unlucky"); // вывод проигрыша
            }
        }
    }
}
