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
        //nuevas cosas 
        public void evaluardatos()
        {
            int valorTemporal = 0;

            //Validamos el valor superior a donde presionamos si está el cero
            if (posicionFila > 0)
            {
                if (matrizValores[posicionFila - 1, posicionColumna] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila - 1, posicionColumna] = valorTemporal;
                }
            }

            //Validamos el valor inferior a donde presionamos si está el cero
            if (posicionFila < 3)
            {
                if (matrizValores[posicionFila + 1, posicionColumna] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila + 1, posicionColumna] = valorTemporal;
                }
            }

            //Validamos el valor izquierdo a donde presionamos si está el cero
            if (posicionColumna > 0)
            {
                if (matrizValores[posicionFila, posicionColumna - 1] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila, posicionColumna - 1] = valorTemporal;
                }
            }

            //Validamos el valor derecho a donde presionamos si está el cero
            if (posicionColumna < 3)
            {
                if (matrizValores[posicionFila, posicionColumna + 1] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila, posicionColumna + 1] = valorTemporal;
                }
            }
        }
    }
}
