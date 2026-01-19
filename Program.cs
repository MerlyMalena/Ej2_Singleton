using System;

class Program
{

    public class SettingsManager
    {
        private static SettingsManager? instancia; // El ? es para indicar que instancia puede estar null al inicio

        public int volumen {get;set;}
        public String resolucion {get;set;}

        public SettingsManager()
        {
            volumen=0;
            resolucion="HD";
        }

        public static SettingsManager ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new SettingsManager();
            }

            return instancia;
        }
    }

    static void Main(string[] args) //svm
    {
        var accesoMenu = SettingsManager.ObtenerInstancia();
        accesoMenu.volumen=100;
        
        var accesoSonido = SettingsManager.ObtenerInstancia();
        Console.WriteLine(accesoSonido.volumen);
    }
}
