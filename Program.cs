namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] profe = { -8, 4, 5, 9, 12, 18, 25, 40, 60 };
            int inicio = 0;
            int fin = 8;
            int centro = 0;
            bool centinela=false;
            Console.WriteLine("Ingrese el elemento a buscar");
            int numerto=Convert.ToInt32(Console.ReadLine());

            while (inicio<=fin)
            {
                centro=(inicio+fin)/2;
                
                if (profe[centro]==numerto)
                    Console.WriteLine("El resultado eesta en "+centro);
                    centinela=true;
                
                if (profe[centro] > numerto)
                    fin = centro - 1;
                else
                    inicio = centro + 1;
            }
            if (centinela==false)
                Console.WriteLine("El elemento no existe");

        }
    }
}