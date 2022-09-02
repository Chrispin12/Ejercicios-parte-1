namespace ejercicios
{
    public class Program
    {


        public static void Main()
        {
            int num1;
            int num2;
            int num3;
            int num4;
            int Sum;
            double Media;
            int produc;
            Console.WriteLine("ingresa el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa el tercer numero");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa el cuarto numero");
            num4 = int.Parse(Console.ReadLine());
            produc = num1 * num2 * num3 * num4;
            Sum = num1 + num2 + num3 + num4;
            Media = Sum / 4;
            Console.WriteLine($"el resultado de la suma es:{Sum} , el del producto es {produc} y  el de la media es {Media}");
        }
    }
}