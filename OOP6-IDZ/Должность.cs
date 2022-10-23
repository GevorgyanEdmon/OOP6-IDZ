using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_IDZ
{
    internal class Должность
    {
        protected string name;
        public int stavka;
        public Должность (string pName, int pStavka)
        {
            name = pName;
            stavka = pStavka;
        }
    }
}
