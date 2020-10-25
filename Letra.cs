using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Calculo_Letra_DNI
{
    public class Letras
    {
        private int dni;
        private string letra;


        public int Dni { get => dni; }
        public string Letra { get => letra; }

        private string CalculoLetra(int dni)
        {
            Dictionary<int, string> tabla = new Dictionary<int, string>();
            tabla.Add(0, "T");
            tabla.Add(1, "R");
            tabla.Add(2, "W");
            tabla.Add(3, "A");
            tabla.Add(4, "G");
            tabla.Add(5, "M");
            tabla.Add(6, "Y");
            tabla.Add(7, "F");
            tabla.Add(8, "P");
            tabla.Add(9, "D");
            tabla.Add(10, "X");
            tabla.Add(11, "B");
            tabla.Add(12, "N");
            tabla.Add(13, "J");
            tabla.Add(14, "Z");
            tabla.Add(15, "S");
            tabla.Add(16, "Q");
            tabla.Add(17, "V");
            tabla.Add(18, "H");
            tabla.Add(19, "L");
            tabla.Add(20, "C");
            tabla.Add(21, "K");
            tabla.Add(22, "E");
            
            int restodni = dni % 23;

            string letra = tabla[restodni];
            return letra;

        }
        public Letras(int dni)
        {
            this.dni = dni;
            letra = CalculoLetra(dni);
        }

    }



}
