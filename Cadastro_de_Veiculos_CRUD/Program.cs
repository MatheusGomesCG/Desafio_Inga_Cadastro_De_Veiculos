﻿using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Cadastro_de_Veiculos{
    class Program{
        static async Task Main(string[] args){
            
            await Menu();
        }

        static async Task Menu(){

            bool exit = false;

            while(!exit){
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
                        await RegisterVehicle();
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

        static async Task RegisterVehicle(){
        
            bool exit = false;

            while(!exit){
            Console.Clear();
            Console.WriteLine("=== 🚗 MENU - CADASTRO DE AUTOMÓVEIS 🏍️ ===");
            Console.WriteLine("[1] - Automóvel novo");
            Console.WriteLine("[2] - Automóvel usado");
            Console.WriteLine("[3] - Voltar o Menu");
            string? choice = Console.ReadLine();

                switch(choice){
                    case "1":
                        await NewVehicle();
                        exit = true;
                        break;
                    case "2":
                        await UsedVehicle();
                        exit = true;
                        break;
                    case "3":
                        exit = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, por favor escolha uma das opções");
                        await Task.Delay(2000);
                        break;
                }
            }

        }
        
        static async Task NewVehicle(){
            bool exit = false;

            while(!exit){
            Console.Clear();
            Console.WriteLine("=== 🚗 MENU - CADASTRO DE AUTOMÓVEIS 🏍️ ===");
            Console.WriteLine("[1] - Carro");
            Console.WriteLine("[2] - Moto");
            Console.WriteLine("[3] - Voltar o Menu");
            string? choice = Console.ReadLine();

                switch(choice){
                    case "1":
                        await Car();
                        exit = true;
                        break;
                    case "2":
                        await Motorcycle();
                        exit = true;
                        break;
                    case "3":
                        exit = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, por favor escolha uma das opções");
                        await Task.Delay(2000);
                        break;
                }
            }
        }

        static async Task UsedVehicle(){
            bool exit = false;
            double km;

            Console.Clear();
            Console.WriteLine("=== 🚗 MENU - CADASTRO DE AUTOMÓVEIS 🏍️ ===");
            Console.Write("Digite a quantidade de km rodados: ");
            string mileage = Console.ReadLine();
            while (true){
                if(double.TryParse(mileage, out km)){
                    km = double.Parse(mileage, CultureInfo.InvariantCulture);
                    break;
                } else {
                    Console.WriteLine("O campo: 'KM' foi preenchido incorretamente, por favor preencha com tipo de dados do campo");
                    await Task.Delay(2000);
                    Console.Clear();
                    Console.Write("Digite a quantidade de km rodados: ");
                    mileage = Console.ReadLine();
                }
            }
            while(!exit){
            Console.Clear();
            Console.WriteLine("=== 🚗 MENU - CADASTRO DE AUTOMÓVEIS 🏍️ ===");
            Console.WriteLine("[1] - Carro");
            Console.WriteLine("[2] - Moto");
            Console.WriteLine("[3] - Voltar o Menu");
            string? choice = Console.ReadLine();

                switch(choice){
                    case "1":
                        await Car(km);
                        exit = true;
                        break;
                    case "2":
                        await Motorcycle(km);
                        exit = true;
                        break;
                    case "3":
                        exit = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, por favor escolha uma das opções");
                        await Task.Delay(2000);
                        break;
                }
            }
        }

        static async Task Car(double km = 0.0){
            
        }

        static async Task Motorcycle(double km = 0){
           
        }

        static int nextId = 1;
        static List<Dictionary<string, object>> motorcycle = new List<Dictionary<string, object>>();
        static List<Dictionary<string, object>> car = new List<Dictionary<string, object>>();
    }
}