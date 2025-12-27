using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillarsPOO
{
    public abstract class Animal
    {
        public abstract void HacerRuido();
    }

    public class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("auf auf");
        }
    }

    public class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("miau miau");
        }
    }

    public static class RunPolimorfismo
    {
        public static void ProcesarAnimal(Animal animal)
        {
            animal.HacerRuido();
        }
    } 


}
