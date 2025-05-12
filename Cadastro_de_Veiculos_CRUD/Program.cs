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
             int id = nextId;
            nextId++;
            string? mark = "", model = "", yearManufacture;
            
            bool exit = false;

            while(!exit){
                Console.Clear();
                Console.WriteLine("=== MENU - CADASTRO DE CARRO 🚗 ===");
                Console.WriteLine("Escolha a marca do veículo: ");
                Console.WriteLine("[1] - Fiat");
                Console.WriteLine("[2] - Volkswagen");
                Console.WriteLine("[3] - Chevrolet");
                Console.WriteLine("[4] - Hyundai");
                Console.WriteLine("[5] - Toyota");
                Console.WriteLine("[6] - Jeep");
                Console.WriteLine("[7] - Nissan");
                Console.WriteLine("[8] - Renault");
                Console.WriteLine("[9] - Honda");
                Console.WriteLine("[10] - BYD");
                Console.WriteLine("[11] - Outro");
                string? choice = Console.ReadLine();

                switch(choice){
                    case "1":
                        mark = "Fiat";
                        bool exitWhile = false;
                        while(!exitWhile){
                            Console.Clear();
                            Console.WriteLine("=== MENU - CADASTRO DE CARRO 🚗 ===");
                            Console.WriteLine("Escolha o modelo do veículo: ");
                            Console.WriteLine("[1] - Strada");
                            Console.WriteLine("[2] - Argo");
                            Console.WriteLine("[3] - Mobi");
                            Console.WriteLine("[4] - Toro");
                            Console.WriteLine("[5] - Fastback");
                            string? choiceModel = Console.ReadLine();
                            switch (choiceModel){
                                case "1":
                                    model = "Strada";
                                    exitWhile = true;
                                    break;
                                case "2":
                                    model = "Argo";
                                    exitWhile = true;
                                    break;
                                case "3":
                                    model = "Mobi";
                                    exitWhile = true;
                                    break;
                                case "4":
                                    model = "Toro";
                                    exitWhile = true;
                                    break;
                                case "5":
                                    model = "Fastback";
                                    exitWhile = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida, por favor escolha uma das opções");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;

                    case "2":
                        mark = "Volkswagen";
                        exitWhile = false;
                        while(!exitWhile){
                            Console.Clear();
                            Console.WriteLine("=== MENU - CADASTRO DE CARRO 🚗 ===");
                            Console.WriteLine("Escolha o modelo do veículo: ");
                            Console.WriteLine("[1] - Polo");
                            Console.WriteLine("[2] - T-Cross");
                            Console.WriteLine("[3] - Saveiro");
                            Console.WriteLine("[4] - Nivus");
                            Console.WriteLine("[5] - Taos");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel){
                                case "1":
                                    model = "Polo";
                                    exitWhile = true;
                                    break;
                                case "2":
                                    model = "T-Cross";
                                    exitWhile = true;
                                    break;
                                case "3":
                                    model = "Saveiro";
                                    exitWhile = true;
                                    break;
                                case "4":
                                    model = "Nivus";
                                    exitWhile = true;
                                    break;
                                case "5":
                                    model = "Taos";
                                    exitWhile = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida, por favor escolha uma das opções");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;

                    case "3":
                        mark = "Chevrolet";
                        exitWhile = false;
                        while(!exitWhile){
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo do veículo:");
                            Console.WriteLine("[1] - Onix");
                            Console.WriteLine("[2] - Tracker");
                            Console.WriteLine("[3] - Onix Plus");
                            Console.WriteLine("[4] - S10");
                            Console.WriteLine("[5] - Spin");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel){
                                case "1":
                                    model = "Onix";
                                    exitWhile = true;
                                    break;
                                case "2":
                                    model = "Tracker";
                                    exitWhile = true;
                                    break;
                                case "3":
                                    model = "Onix Plus";
                                    exitWhile = true;
                                    break;
                                case "4":
                                    model = "S10";
                                    exitWhile = true;
                                    break;
                                case "5":
                                    model = "Spin";
                                    exitWhile = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;

                    case "4":
                        mark = "Hyundai";
                        exitWhile = false;
                        while(!exitWhile){
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - HB20");
                            Console.WriteLine("[2] - Creta");
                            Console.WriteLine("[3] - HB20S");
                            Console.WriteLine("[4] - Tucson");
                            Console.WriteLine("[5] - Santa Fe");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel){
                                case "1":
                                    model = "HB20";
                                    exitWhile = true;
                                    break;
                                case "2":
                                    model = "Creta";
                                    exitWhile = true;
                                    break;
                                case "3":
                                    model = "HB20S";
                                    exitWhile = true;
                                    break;
                                case "4":
                                    model = "Tucson";
                                    exitWhile = true;
                                    break;
                                case "5":
                                    model = "Santa Fe";
                                    exitWhile = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;

                    case "5":
                        mark = "Toyota";
                        exitWhile = false;
                        while(!exitWhile){
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - Corolla");
                            Console.WriteLine("[2] - Corolla Cross");
                            Console.WriteLine("[3] - Hilux");
                            Console.WriteLine("[4] - Yaris Sedan");
                            Console.WriteLine("[5] - SW4");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel){
                                case "1":
                                    model = "Corolla";
                                    exitWhile = true;
                                    break;
                                case "2":
                                    model = "Corolla Cross";
                                    exitWhile = true;
                                    break;
                                case "3":
                                    model = "Hilux";
                                    exitWhile = true;
                                    break;
                                case "4":
                                    model = "Yaris Sedan";
                                    exitWhile = true;
                                    break;
                                case "5":
                                    model = "SW4";
                                    exitWhile = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;

                    case "6":
                        mark = "Jeep";
                        exitWhile = false;
                        while(!exitWhile){
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - Renegade");
                            Console.WriteLine("[2] - Compass");
                            Console.WriteLine("[3] - Commander");
                            Console.WriteLine("[4] - Wrangler");
                            Console.WriteLine("[5] - Grand Cherokee");
                            string choiceModel = Console.ReadLine();

                            switch (choiceModel){
                                case "1":
                                    model = "Renegade";
                                    exitWhile = true;
                                    break;
                                case "2":
                                    model = "Compass";
                                    exitWhile = true;
                                    break;
                                case "3":
                                    model = "Commander";
                                    exitWhile = true;
                                    break;
                                case "4":
                                    model = "Wrangler";
                                    exitWhile = true;
                                    break;
                                case "5":
                                    model = "Grand Cherokee";
                                    exitWhile = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;

                    case "7":
                        mark = "Nissan";
                        exitWhile = false;
                        while(!exitWhile){
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - Kicks");
                            Console.WriteLine("[2] - Versa");
                            Console.WriteLine("[3] - Sentra");
                            Console.WriteLine("[4] - Frontier");
                            Console.WriteLine("[5] - Leaf");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel){
                                case "1":
                                    model = "Kicks";
                                    exitWhile = true;
                                    break;
                                case "2":
                                    model = "Versa";
                                    exitWhile = true;
                                    break;
                                case "3":
                                    model = "Sentra";
                                    exitWhile = true;
                                    break;
                                case "4":
                                    model = "Frontier";
                                    exitWhile = true;
                                    break;
                                case "5":
                                    model = "Leaf";
                                    exitWhile = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;

                    case "8":
                        mark = "Renault";
                        exitWhile = false;
                        while(!exitWhile){
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - Kwid");
                            Console.WriteLine("[2] - Duster");
                            Console.WriteLine("[3] - Stepway");
                            Console.WriteLine("[4] - Oroch");
                            Console.WriteLine("[5] - Logan");
                            string? choiceModel = Console.ReadLine();
                            switch (choiceModel){
                                case "1":
                                    model = "Kwid";
                                    exitWhile = true;
                                    break;
                                case "2":
                                    model = "Duster";
                                    exitWhile = true;
                                    break;
                                case "3":
                                    model = "Stepway";
                                    exitWhile = true;
                                    break;
                                case "4":
                                    model = "Oroch";
                                    exitWhile = true;
                                    break;
                                case "5":
                                    model = "Logan";
                                    exitWhile = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;

                    case "9":
                        mark = "Honda";
                        exitWhile = false;
                        while(!exitWhile){
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - HR-V");
                            Console.WriteLine("[2] - City Sedan");
                            Console.WriteLine("[3] - City Hatch");
                            Console.WriteLine("[4] - Civic");
                            Console.WriteLine("[5] - Accord");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel){
                                case "1":
                                    model = "HR-V";
                                    exitWhile = true;
                                    break;
                                case "2":
                                    model = "City Sedan";
                                    exitWhile = true;
                                    break;
                                case "3":
                                    model = "City Hatch";
                                    exitWhile = true;
                                    break;
                                case "4":
                                    model = "Civic";
                                    exitWhile = true;
                                    break;
                                case "5":
                                    model = "Accord";
                                    exitWhile = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;

                    case "10":
                        mark = "BYD";
                        exitWhile = false;
                        while(!exitWhile){
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - Dolphin");
                            Console.WriteLine("[2] - Yuan Plus");
                            Console.WriteLine("[3] - Dolphin Mini");
                            Console.WriteLine("[4] - Seal");
                            Console.WriteLine("[5] - Song Plus");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel){
                                case "1":
                                    model = "Dolphin";
                                    exitWhile = true;
                                    break;
                                case "2":
                                    model = "Yuan Plus";
                                    exitWhile = true;
                                    break;
                                case "3":
                                    model = "Dolphin Mini";
                                    exitWhile = true;
                                    break;
                                case "4":
                                    model = "Seal";
                                    exitWhile = true;
                                    break;
                                case "5":
                                    model = "Song Plus";
                                    exitWhile = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;

                    case "11":
                        Console.Write("Digite a marca do veículo: ");
                        mark = Console.ReadLine();
                        Console.Write("Digite o modelo do veículo: ");
                        model = Console.ReadLine();
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida, por favor escolha uma das opções");
                        await Task.Delay(2000);
                        break;
                    }
                }

            DateTime dataConvert;
            string formato = "dd/MM/yyyy";

            while(true){
                Console.Write("Digite o ano de fabricação do veículo dd/MM/yyyy: ");
                yearManufacture = Console.ReadLine();

                if(DateTime.TryParseExact(yearManufacture, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataConvert)){
                    break; 
                } else {
                    Console.WriteLine("O campo: 'Ano de Fabricação' foi preenchido incorretamente, por favor preencha com tipo de dados do campo");
                }
            }
            
            Console.WriteLine($"ID = {id}");
            Console.WriteLine($"Marca = {mark}");
            Console.WriteLine($"Modelo = {model}");
            Console.WriteLine($"Quilometragem = {km.ToString("F2", CultureInfo.InvariantCulture)}km");
            Console.WriteLine($"Ano de Fabricação = {dataConvert.ToString("dd/MM/yyyy")}");
            
            Dictionary<string, object> newCar = new Dictionary<string, object>();
            newCar["id"] = id;
            newCar["marca"] = mark;
            newCar["modelo"] = model;
            newCar["dataDeFabricacao"] = dataConvert;
            newCar["quilometragem"] = km;

            car.Add(newCar);

            Console.WriteLine($"Carro cadastrado com sucesso no banco de dados! {DateTime.Now}");

            await Task.Delay(5000);
            return;
        }

        static async Task Motorcycle(double km = 0){
           
        }

        static int nextId = 1;
        static List<Dictionary<string, object>> motorcycle = new List<Dictionary<string, object>>();
        static List<Dictionary<string, object>> car = new List<Dictionary<string, object>>();
    }
}