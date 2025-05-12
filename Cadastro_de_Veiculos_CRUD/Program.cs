//############################ HOMOLOG ############################

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CadastroDeAutomoveis;

class Program
{
    static async Task Main(string[] args)
    {
        await Menu();
    }
     static async Task Menu()
     {

        bool exit = false;

        while(!exit)
        {
            Console.Clear();
            Console.WriteLine("=== 🚗 MENU - CADASTRO DE AUTOMÓVEIS 🏍️ ===");
            Console.WriteLine("[1] - Cadastrar novos automóveis");
            Console.WriteLine("[2] - Listar todos os automóveis cadastrados ");
            Console.WriteLine("[3] - Editar informações de um automóvel");
            Console.WriteLine("[4] - Excluir automóveis do sistema");
            Console.WriteLine("[5] - Buscar automóvel");
            Console.WriteLine("[6] - Sair");
            string? choice = Console.ReadLine();

            switch(choice){
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    exit = true;
                    Console.Clear();
                    Console.WriteLine("Obrigado por usar nosso sistema de cadastro!");
                    break;
                default:
                    Console.WriteLine("Opção inválida, por favor escolha uma das opções");
                    await Task.Delay(2000);
                    break;
            }
        }
    }
}