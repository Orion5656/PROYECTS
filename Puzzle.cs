using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleDGV
{
    class Puzzle
    {
        int[] posiciones;
        public int[] Posiciones
        {
            get { return posiciones; }
            set { posiciones = value; }
        }
        static Random rnd = new Random();
        public Puzzle()
        {
            int aux;
            bool band = false;
            posiciones = new int[16];
            for (int i = 0; i < 15; i++)
            {
                aux = rnd.Next(1,16);
                band = false;
                for (int j = 0; j < i;j++ )
                    if (posiciones[j] == aux)
                    {
                        band = true;
                        break;
                    }
                if (band == false)
                    posiciones[i] = aux;
                else
                    i--;
            }
            posiciones[15]=0;//Asigno cuadro en blanco a la última posición
        }
    }
}
