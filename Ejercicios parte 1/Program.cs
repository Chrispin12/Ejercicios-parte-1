namespace ejercicios
{
    public class Program
    {


        public static void Main()
        {
            int numero;
            int resultado;
            int Doblado;
            Console.WriteLine("por favor ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            Doblado = numero*2;
            resultado = Doblado * 25;
            Console.WriteLine($"el resultado de la operacion es:{resultado}");
        }
    }
}