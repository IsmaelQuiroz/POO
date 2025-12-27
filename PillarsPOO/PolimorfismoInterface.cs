using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillarsPOO
{

    public class PolimorfismoInterface()
    {
        public void ProcesarRepositorio(IRepositorioPersonas repositorio)
        {
            repositorio.ObtenerPersonas();
        }
    }

    public interface IRepositorioPersonas
    {
        void ObtenerPersonas();
    }

    public class RepositorioPersonasDB : IRepositorioPersonas
    {
        public void ObtenerPersonas()
        {
            Console.WriteLine("Obteniendo personas de la Base de Datos");
        }
    }

    public class RepositorioPersonasEnMemoria : IRepositorioPersonas
    {
        public void ObtenerPersonas()
        {
            Console.WriteLine("Obtener Personas de la Memoria");
        }
    }
    
}
