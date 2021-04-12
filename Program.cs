using System;
using System.Collections.Generic;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> cadastrado = new List<Pessoa>(); 
            int select = 0;
            do
            {
                Console.WriteLine("Escolha uma alternativa");
                Console.WriteLine("[1] Efetuar Cadastro ");
                Console.WriteLine("[2] Exibir Cadastro ");
                Console.WriteLine("[0] Sair");

                select = Convert.ToInt32(Console.ReadLine());

                if (select == 1)
                
                    cadastrado.Add(Cadastro());
                
                else if (select == 2)

                    Exibir(cadastrado);

                else if (select < 2 || select > 0)
                    Console.WriteLine("Introduza um caractere válido");
                               
            } while (select != 0);
        }

        public static Pessoa Cadastro()
        {
            Console.WriteLine("Cadastramento:");
            Pessoa newPessoa = new Pessoa();
            Console.WriteLine("Entre com seu nome");
            newPessoa.Nome = Console.ReadLine();
            Console.WriteLine("Entre com a cor de seu cabelo");
            newPessoa.CorCabelo = Console.ReadLine();
            Console.WriteLine("Entre com sua altura (cm)");
            newPessoa.Altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite seu CPF");
            newPessoa.Cpf = Convert.ToInt32(Console.ReadLine());
            return newPessoa;
        }
        public static void Exibir(List<Pessoa> exibir)
        {
            Console.WriteLine("Dados:");
            foreach(var dado in exibir)
            {
                Console.WriteLine("Nome:" + dado.Nome);
                Console.WriteLine("Cor do Cabelo:" + dado.CorCabelo);
                Console.WriteLine("Altura:" + dado.Altura);
                Console.WriteLine("CPF:" + dado.Cpf);
            }
        }
    }
}
