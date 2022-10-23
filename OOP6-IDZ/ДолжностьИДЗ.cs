using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_IDZ
{
    internal class ДолжностьИДЗ<T> where T : Должность
    {
        public static float GetZP(T geo)
        {
            return geo.stavka ;
        }

        public static float GetKvartPremia(T geo)
        {
            return geo.stavka * 1.3f;
        }

        public static float GetPremia(T geo, float premia)
        {
            return geo.stavka * premia;
        }
    }
}
