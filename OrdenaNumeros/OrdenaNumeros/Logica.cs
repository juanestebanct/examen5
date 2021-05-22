using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaNumeros
{
    class Logica
    {
        private int[,] matrizValores;
        private int posicionFila, posicionColumna;

        public int Posicionfila
        {
            get
            {
                return posicionFila;
            }
            set
            {
                posicionFila = value;
            }
        }
        public int PosicionColumna
        {
            get
            {
                return posicionColumna;
            }
            set
            {
                posicionColumna = value;
            }
        }
        public int[,] MatrizValoresposicionfila
        {
            get
            {
                return matrizValores;
            }
        }

        public Logica()
        {
            iniciavariables();
        }

        private void iniciavariables()
        {
            posicionFila = 0;
            posicionColumna = 0;
            matrizValores = new int[4, 4];
        }

    }
}
