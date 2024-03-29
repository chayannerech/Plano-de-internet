namespace Plano_de_internet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int consumo = 0, X = 10000, N = 10000;
                Console.Clear();
                Console.WriteLine("Informe o valor mensal, o número de meses e os consumos:");

                X = ValidaValor(100, consumo, X);
                N = ValidaValor(100, consumo, X);
                int[] M = new int[N];

                consumo = RealizaCalculos(consumo, X, N, M);

                Console.WriteLine($"\n{consumo + X}\nDeseja repetir? [S,N]");
                if (DeveContinuar()) break;
            }
        }
        static int ValidaValor(int limite, int consumo, int X)
        {
            int valor;
            int validacaoConsumo;

            do
            {
                valor = Convert.ToInt32(Console.ReadLine());
                validacaoConsumo = consumo + X - valor;
                if (valor < 1 || valor > limite || validacaoConsumo < 0) Console.WriteLine("Inválido. Repita:");
            }
            while (valor < 1 || valor > limite || validacaoConsumo < 0);

            return valor;
        }        
        static int RealizaCalculos(int consumo, int X, int N, int[] M)
        {
            for (int i = 0; i < N; i++)
            {
                M[i] = ValidaValor(10000, consumo, X);
                consumo = consumo + X - M[i];
            }

            return consumo;
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return continua == "N" || continua == "n";
        }
    }
}
