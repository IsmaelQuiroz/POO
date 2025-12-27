using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillarsPOO
{

        public class Vector
        {
            private int[] vector { get; set; }

            public Vector(int[] valores)
            {
                vector = valores;
            }

            public int Dimension { get { return vector.Length; } }

            public int this[int i]
            {
                get { return vector[i]; }
                set { vector[i] = value; }
            }

            public static Vector operator +(Vector a, Vector b)
            {
                return Sumar(a, b);
            }


            public static Vector Sumar(Vector vector1, Vector vector2)
            {
                //Sumar los vectores
                if (vector1.Dimension != vector2.Dimension)
                {
                    throw new ApplicationException("No puedes sumar vectores de dimensiones distintas");
                }

                int[] resultado = new int[vector1.Dimension];
                for (int i = 0; i < vector1.Dimension; i++)
                {
                    resultado[i] = vector1[i] + vector2[i];
                }
                var vectorSuma = new Vector(resultado);
                return vectorSuma;
            }


        }


}
