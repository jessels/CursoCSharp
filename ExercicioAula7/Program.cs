using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de carros");
            int qtCarros = int.Parse(Console.ReadLine());


            var carros = new Carro[qtCarros];
            for (int i = 0; i < carros.Length; i++)
            {
                var carro = new Carro();
                var motor = new Motor();

                Console.WriteLine("Informe o modelo do carro");
                carro.Modelo = Console.ReadLine();
                Console.WriteLine("Informe a marca do carro");
                carro.Marca = Console.ReadLine();
                Console.WriteLine("Informe a cor do carro");
                carro.Cor = Console.ReadLine();
                Console.WriteLine("Informe o tipo de compustivel");
                motor.Combustivel = Console.ReadLine();
                Console.WriteLine("Informe a quantidade de cavalos");
                motor.QuantidadeCavalos = int.Parse(Console.ReadLine());
                carro.motor = motor;
                carros[i] = carro;
            }
            Console.WriteLine("Carros com motor de mais de 100 cavalos");
            for (int i = 0; i < carros.Length; i++)
            {

                if (carros[i].motor.QuantidadeCavalos >= 100)
                {
                    Console.WriteLine("Modelo: " + carros[i].Modelo + "\n Marca: " + carros[i].Marca + "\n Cor: " + carros[i].Cor + "\n Tipo de combustivel: " + carros[i].motor.Combustivel);

                }
            }
            Console.ReadKey();
        }
    }
}
