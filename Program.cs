using System;

namespace cs_1._3_CalculaProduto
{
    class Program
    {
        static void Main(string[] args) //comando de início do programa
        {
            double Num1, Num2, Mult;  //declaração das variáveis do programa
            Console.Clear(); //comando "LimpaTela" limpa a tela do monitor de vídeo
            //{Entrada de dado}
            Console.Write("Digite o primeiro número: "); // mensagem para digitar o primeiro número
            Num1 = Double.Parse(Console.ReadLine()); //leitura do primeiro número para a memória
            Console.Write("Digite o segundo número: "); // mensagem para digitar o segundo número
            Num2 = Double.Parse(Console.ReadLine()); // leitura do segundo número para a memória
            //{Processamento}
            Mult = Num1 * Num2;//calcula o produto e armazena o resultado na variável Mult
            //{Saída da informação}
            Console.WriteLine(); //apenas salta uma linha na tela do monitor de vídeo
            Console.WriteLine($"A multiplicação de {Num1} por {Num2} é {Mult}");            
        }//comando de fim do programa
    }
}
