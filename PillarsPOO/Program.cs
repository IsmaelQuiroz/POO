using PillarsPOO;


PolimorfismoI();
PolimorfismoH();
//Encapsulamiento();


void PolimorfismoI()
{
    PolimorfismoInterface pInt = new PolimorfismoInterface();
    pInt.ProcesarRepositorio(new RepositorioPersonasDB());
    pInt.ProcesarRepositorio(new RepositorioPersonasEnMemoria());
}

static void PolimorfismoH()
{
    RunPolimorfismo.ProcesarAnimal(new Perro());
    RunPolimorfismo.ProcesarAnimal(new Gato());
}


static void Encapsulamiento()
{
    var vector1 = new Vector(new int[] { 1, 4 });
    var vector2 = new Vector(new int[] { 2, 5 });

    //Encapsulamiento: Ordena no Pidas
    var VectorSuma = vector1 + vector2;


    #region Sin Encapsular Pide  en lugar de solo Ordenar
    ////Sumar los vectores
    //if (vector1.Dimension != vector2.Dimension)
    //{
    //    throw new ApplicationException("No puedes sumar vectores de dimensiones distintas");
    //}

    //int[] resultado = new int[vector1.Dimension];
    //for (int i = 0; i < vector1.Dimension; i++)
    //{
    //    resultado[i] = vector1[i] + vector2[i];
    //}
    //var vectorSuma = new Vector(resultado);
    #endregion

}


