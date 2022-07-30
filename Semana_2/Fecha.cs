using System;
using System.Collections.Generic;
using System.Text;

namespace Semana_2
{
    internal class Fecha
    {
        private int mes = 2;

        public int Mes
        {
            get
            {
                return mes;
            }
            set
            {
                if ((value > 0) && (value < 13))
                {
                    mes = value;
                }
            }
        }
    }
}
