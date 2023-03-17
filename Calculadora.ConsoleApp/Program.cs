namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        { //abre escopo


            { //abre escopo 1
                Console.WriteLine();

                Console.WriteLine("Digite o primeiro número: ");

                int primeiroNumero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");

                int segundoNumero = Convert.ToInt32(Console.ReadLine());

                int resultado = primeiroNumero + segundoNumero;

                Console.WriteLine("O resultado da operação é: " + resultado);

                Console.ReadLine();
            } //fecha escopo 1

            ///////////////////////////////////

            { //abre escopo 2

                Console.WriteLine("Digite o número desejado de operações: ");
                int numeroDesejadoOperacoes = Convert.ToInt32(Console.ReadLine());
                int numeroRealizadoOperacoes = 0;
                bool ehParaContinuar;
                do {
                    Console.WriteLine();

                    Console.WriteLine("Digite o primeiro número: ");

                    int primeiroNumero = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número: ");

                    int segundoNumero = Convert.ToInt32(Console.ReadLine());

                    int resultado = primeiroNumero + segundoNumero;

                    Console.WriteLine("O resultado da operação é: " + resultado);

                    numeroRealizadoOperacoes = numeroRealizadoOperacoes + 1;

                    Console.ReadLine();

                    ehParaContinuar = numeroRealizadoOperacoes < numeroDesejadoOperacoes;

                } while (ehParaContinuar);

            } //fecha escopo 2

        } // fechamento escopo metodo main
    }
}