namespace ejercicio3
{
    public class Program
    {


        public static void Main()
        {
            int contador;
            int limite;
            int sumatoria;
            sumatoria = 0;
            contador = 1;
            limite = 10;
         
            for (contador=1; contador <= limite; contador++)
            {
                sumatoria = sumatoria + contador;

            }
            Console.WriteLine($"el resultado de la sumatoria es:{sumatoria}");
        }
    }
}