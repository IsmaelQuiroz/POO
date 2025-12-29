using System.Diagnostics;

namespace WebApi.InyeccionDeDependencias.Loggers
{

    public interface IMilogger
    {
        void Log(string mensaje);
    }

    public class LoggerConsola : IMilogger
    { 
        public void Log(string mensaje)
        {
            Debug.WriteLine($"{DateTime.Now} : {mensaje}");
        }
    }

    public class LoggerEnArchivo : IMilogger
    {
        public void Log(string mensaje)
        {
            using (StreamWriter writetext = new StreamWriter($@"{Directory.GetCurrentDirectory()}\log.txt", append: true))
            {
                writetext.WriteLine($"{DateTime.Now}:{mensaje}");
            }
        }
    }
}
