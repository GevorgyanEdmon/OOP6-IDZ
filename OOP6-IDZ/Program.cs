using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_IDZ
{
    class Programm
    {
        static void Main(string[] args)
        {
            var Рабочий = new Должность("Техник", 15000);
            Console.WriteLine("Стандартная ЗП "+ДолжностьИДЗ<Должность>.GetZP(Рабочий));
            Console.WriteLine("Премия "+ДолжностьИДЗ<Должность>.GetPremia(Рабочий, 1.2f));
            Console.WriteLine("Квартальная премя "+ДолжностьИДЗ<Должность>.GetKvartPremia(Рабочий));
        }
    }
}
