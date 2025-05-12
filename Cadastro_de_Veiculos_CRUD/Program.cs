using System;
using System.Globalization;
using System.Net;
using System.Threading.Tasks;

namespace Cadastro_de_Veiculos{
    class Program{
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

                switch(choice)
                {
                    case "1":
                        await RegisterVehicle();
                        break;
                    case "2":
                        await ListVehicles();
                        break;
                    case "3":
                        await EditVehicle();
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

        static async Task RegisterVehicle()
        {
            bool exit = false;

            while(!exit)
            {
            Console.Clear();
            Console.WriteLine("=== 🚗 MENU - CADASTRO DE AUTOMÓVEIS 🏍️ ===");
            Console.WriteLine("[1] - Automóvel novo");
            Console.WriteLine("[2] - Automóvel usado");
            Console.WriteLine("[3] - Voltar o Menu");
            string? choice = Console.ReadLine();

                switch(choice)
                {
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
        
        static async Task NewVehicle()
        {
            bool exit = false;

            while(!exit)
            {
            Console.Clear();
            Console.WriteLine("=== 🚗 MENU - CADASTRO DE AUTOMÓVEIS 🏍️ ===");
            Console.WriteLine("[1] - Carro");
            Console.WriteLine("[2] - Moto");
            Console.WriteLine("[3] - Voltar o Menu");
            string? choice = Console.ReadLine();

                switch(choice)
                {
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

        static async Task UsedVehicle()
        {
            bool exit = false;
            double km;

            Console.Clear();
            Console.WriteLine("=== 🚗 MENU - CADASTRO DE AUTOMÓVEIS 🏍️ ===");
            Console.Write("Digite a quantidade de km rodados: ");
            string mileage = Console.ReadLine();
            while (true)
            {
                if(double.TryParse(mileage, out km))
                {
                    km = double.Parse(mileage, CultureInfo.InvariantCulture);
                    break;
                }
                else
                {
                    Console.WriteLine("O campo: 'KM' foi preenchido incorretamente, por favor preencha com tipo de dados do campo");
                    await Task.Delay(2000);
                    Console.Clear();
                    Console.Write("Digite a quantidade de km rodados: ");
                    mileage = Console.ReadLine();
                }
            }
            while(!exit)
            {
            Console.Clear();
            Console.WriteLine("=== 🚗 MENU - CADASTRO DE AUTOMÓVEIS 🏍️ ===");
            Console.WriteLine("[1] - Carro");
            Console.WriteLine("[2] - Moto");
            Console.WriteLine("[3] - Voltar o Menu");
            string? choice = Console.ReadLine();

                switch(choice)
                {
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

        static async Task Car(double km = 0.0)
        {
             int id = nextId;
            nextId++;
            string? mark = "", model = "", yearManufacture;
            
            bool exit = false;

            while(!exit)
            {
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

                switch(choice)
                {
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

                            switch (choiceModel)
                            {
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
                        while(!exitWhile)
                        {
                            Console.Clear();
                            Console.WriteLine("=== MENU - CADASTRO DE CARRO 🚗 ===");
                            Console.WriteLine("Escolha o modelo do veículo: ");
                            Console.WriteLine("[1] - Polo");
                            Console.WriteLine("[2] - T-Cross");
                            Console.WriteLine("[3] - Saveiro");
                            Console.WriteLine("[4] - Nivus");
                            Console.WriteLine("[5] - Taos");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
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
                        while(!exitWhile)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo do veículo:");
                            Console.WriteLine("[1] - Onix");
                            Console.WriteLine("[2] - Tracker");
                            Console.WriteLine("[3] - Onix Plus");
                            Console.WriteLine("[4] - S10");
                            Console.WriteLine("[5] - Spin");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
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
                        while(!exitWhile)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - HB20");
                            Console.WriteLine("[2] - Creta");
                            Console.WriteLine("[3] - HB20S");
                            Console.WriteLine("[4] - Tucson");
                            Console.WriteLine("[5] - Santa Fe");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
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
                        while(!exitWhile)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - Corolla");
                            Console.WriteLine("[2] - Corolla Cross");
                            Console.WriteLine("[3] - Hilux");
                            Console.WriteLine("[4] - Yaris Sedan");
                            Console.WriteLine("[5] - SW4");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
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
                        while(!exitWhile)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - Renegade");
                            Console.WriteLine("[2] - Compass");
                            Console.WriteLine("[3] - Commander");
                            Console.WriteLine("[4] - Wrangler");
                            Console.WriteLine("[5] - Grand Cherokee");
                            string choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
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
                        while(!exitWhile)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - Kicks");
                            Console.WriteLine("[2] - Versa");
                            Console.WriteLine("[3] - Sentra");
                            Console.WriteLine("[4] - Frontier");
                            Console.WriteLine("[5] - Leaf");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
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
                        while(!exitWhile)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - Kwid");
                            Console.WriteLine("[2] - Duster");
                            Console.WriteLine("[3] - Stepway");
                            Console.WriteLine("[4] - Oroch");
                            Console.WriteLine("[5] - Logan");
                            string? choiceModel = Console.ReadLine();
                            switch (choiceModel)
                            {
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
                        while(!exitWhile)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - HR-V");
                            Console.WriteLine("[2] - City Sedan");
                            Console.WriteLine("[3] - City Hatch");
                            Console.WriteLine("[4] - Civic");
                            Console.WriteLine("[5] - Accord");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
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
                        while(!exitWhile)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo:");
                            Console.WriteLine("[1] - Dolphin");
                            Console.WriteLine("[2] - Yuan Plus");
                            Console.WriteLine("[3] - Dolphin Mini");
                            Console.WriteLine("[4] - Seal");
                            Console.WriteLine("[5] - Song Plus");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
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

            while(true)
            {
                Console.Write("Digite o ano de fabricação do veículo dd/MM/yyyy: ");
                yearManufacture = Console.ReadLine();

                if(DateTime.TryParseExact(yearManufacture, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataConvert))
                {
                    break; 
                } 
                else
                {
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
            newCar["dataDeFabricao"] = dataConvert;
            newCar["quilometragem"] = km;

            car.Add(newCar);

            Console.WriteLine($"Carro cadastrado com sucesso no banco de dados! {DateTime.Now}");

            await Task.Delay(5000);
            return;
        }

        static async Task Motorcycle(double km = 0)
        {
           int id = nextId;
            nextId++;
            string? mark = "", model = "", yearManufacture;

            bool exit = false;

            while(!exit)
            {
                Console.Clear();
                Console.WriteLine("=== MENU - CADASTRO DE MOTO 🏍️ ===");
                Console.WriteLine("Escolha a marca da moto: ");
                Console.WriteLine("[1] - Honda");
                Console.WriteLine("[2] - Yamaha");
                Console.WriteLine("[3] - Mottu (Shineray)");
                Console.WriteLine("[4] - Haojue");
                Console.WriteLine("[5] - BMW");
                Console.WriteLine("[6] - Bajaj");
                Console.WriteLine("[7] - Dafra");
                Console.WriteLine("[8] - Royal Enfield");
                Console.WriteLine("[9] - Triumph");
                Console.WriteLine("[10] - Harley-Davidson");
                Console.WriteLine("[11] - Outro");
                string? choiceMoto = Console.ReadLine();

                bool exitModel = false;
                switch (choiceMoto)
                {
                    case "1":
                        mark = "Honda";
                        while(!exitModel)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo da Honda:");
                            Console.WriteLine("[1] - CG 160");
                            Console.WriteLine("[2] - Biz");
                            Console.WriteLine("[3] - Pop 110i");
                            Console.WriteLine("[4] - CB 300F Twister");
                            Console.WriteLine("[5] - XRE 300 Sahara");
                            string? choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "1": 
                                    model = "CG 160"; 
                                    exitModel = true; 
                                    break;
                                case "2":
                                    model = "Biz";
                                    exitModel = true;
                                    break;
                                case "3":
                                    model = "Pop 110i";
                                    exitModel = true;
                                    break;
                                case "4":
                                    model = "CB 300F Twister";
                                    exitModel = true;
                                    break;
                                case "5":
                                    model = "XRE 300 Sahara";
                                    exitModel = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;

                    case "2":
                        mark = "Yamaha";
                        while (!exitModel)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo da Yamaha:");
                            Console.WriteLine("[1] - Fazer 250");
                            Console.WriteLine("[2] - Factor 150");
                            Console.WriteLine("[3] - Lander 250");
                            Console.WriteLine("[4] - NMax 160");
                            Console.WriteLine("[5] - MT-03");
                            string? choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "1":
                                    model = "Fazer 250";
                                    exitModel = true;
                                    break;
                                case "2":
                                    model = "Factor 150";
                                    exitModel = true;
                                    break;
                                case "3":
                                    model = "Lander 250";
                                    exitModel = true;
                                    break;
                                case "4":
                                    model = "NMax 160";
                                    exitModel = true;
                                    break;
                                case "5":
                                    model = "MT-03";
                                    exitModel = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    await Task.Delay(2000);
                                    break;
                            }
                        }
                        exit = true;
                        break;
                    case "3":
                        mark = "Yamaha";
                        exitModel = false;
                        while (!exitModel)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo da moto:");
                            Console.WriteLine("[1] - Fazer 250");
                            Console.WriteLine("[2] - XTZ 250 Lander");
                            Console.WriteLine("[3] - MT-03");
                            Console.WriteLine("[4] - NMAX 160");
                            Console.WriteLine("[5] - Crosser 150");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
                                case "1":
                                    model = "Fazer 250";
                                    exitModel = true;
                                    break;
                                case "2":
                                    model = "XTZ 250 Lander";
                                    exitModel = true;
                                    break;
                                case "3":
                                    model = "MT-03";
                                    exitModel = true;
                                    break;
                                case "4":
                                    model = "NMAX 160";
                                    exitModel = true;
                                    break;
                                case "5":
                                    model = "Crosser 150";
                                    exitModel = true;
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
                        mark = "Shineray";
                        exitModel = false;
                        while (!exitModel)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo da moto:");
                            Console.WriteLine("[1] - Jet 50");
                            Console.WriteLine("[2] - Phoenix 50");
                            Console.WriteLine("[3] - XY 50 Q Phoenix");
                            Console.WriteLine("[4] - Worker 125");
                            Console.WriteLine("[5] - Jet 125 SS");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
                                case "1":
                                    model = "Jet 50";
                                    exitModel = true;
                                    break;
                                case "2":
                                    model = "Phoenix 50";
                                    exitModel = true;
                                    break;
                                case "3":
                                    model = "XY 50 Q Phoenix";
                                    exitModel = true;
                                    break;
                                case "4":
                                    model = "Worker 125";
                                    exitModel = true;
                                    break;
                                case "5":
                                    model = "Jet 125 SS";
                                    exitModel = true;
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
                        mark = "BMW";
                        exitModel = false;
                        while (!exitModel)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo da moto:");
                            Console.WriteLine("[1] - G 310 R");
                            Console.WriteLine("[2] - G 310 GS");
                            Console.WriteLine("[3] - F 850 GS");
                            Console.WriteLine("[4] - R 1250 GS");
                            Console.WriteLine("[5] - S 1000 RR");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
                                case "1":
                                    model = "G 310 R";
                                    exitModel = true;
                                    break;
                                case "2":
                                    model = "G 310 GS";
                                    exitModel = true;
                                    break;
                                case "3":
                                    model = "F 850 GS";
                                    exitModel = true;
                                    break;
                                case "4":
                                    model = "R 1250 GS";
                                    exitModel = true;
                                    break;
                                case "5":
                                    model = "S 1000 RR";
                                    exitModel = true;
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
                        mark = "Kawasaki";
                        exitModel = false;
                        while (!exitModel)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo da moto:");
                            Console.WriteLine("[1] - Ninja 400");
                            Console.WriteLine("[2] - Z400");
                            Console.WriteLine("[3] - Z900");
                            Console.WriteLine("[4] - Versys 650");
                            Console.WriteLine("[5] - Vulcan S");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
                                case "1":
                                    model = "Ninja 400";
                                    exitModel = true;
                                    break;
                                case "2":
                                    model = "Z400";
                                    exitModel = true;
                                    break;
                                case "3":
                                    model = "Z900";
                                    exitModel = true;
                                    break;
                                case "4":
                                    model = "Versys 650";
                                    exitModel = true;
                                    break;
                                case "5":
                                    model = "Vulcan S";
                                    exitModel = true;
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
                        mark = "Dafra";
                        exitModel = false;
                        while (!exitModel)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo da moto:");
                            Console.WriteLine("[1] - Citycom 300i");
                            Console.WriteLine("[2] - Horizon 150");
                            Console.WriteLine("[3] - Apache RTR 200");
                            Console.WriteLine("[4] - NH 190");
                            Console.WriteLine("[5] - Next 300");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
                                case "1":
                                    model = "Citycom 300i";
                                    exitModel = true;
                                    break;
                                case "2":
                                    model = "Horizon 150";
                                    exitModel = true;
                                    break;
                                case "3":
                                    model = "Apache RTR 200";
                                    exitModel = true;
                                    break;
                                case "4":
                                    model = "NH 190";
                                    exitModel = true;
                                    break;
                                case "5":
                                    model = "Next 300";
                                    exitModel = true;
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
                        mark = "Royal Enfield";
                        exitModel = false;
                        while (!exitModel)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo da moto:");
                            Console.WriteLine("[1] - Meteor 350");
                            Console.WriteLine("[2] - Classic 350");
                            Console.WriteLine("[3] - Himalayan");
                            Console.WriteLine("[4] - Scram 411");
                            Console.WriteLine("[5] - Interceptor 650");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
                                case "1":
                                    model = "Meteor 350";
                                    exitModel = true;
                                    break;
                                case "2":
                                    model = "Classic 350";
                                    exitModel = true;
                                    break;
                                case "3":
                                    model = "Himalayan";
                                    exitModel = true;
                                    break;
                                case "4":
                                    model = "Scram 411";
                                    exitModel = true;
                                    break;
                                case "5":
                                    model = "Interceptor 650";
                                    exitModel = true;
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
                        mark = "Harley-Davidson";
                        exitModel = false;
                        while (!exitModel)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo da moto:");
                            Console.WriteLine("[1] - Iron 883");
                            Console.WriteLine("[2] - Forty-Eight");
                            Console.WriteLine("[3] - Street Glide");
                            Console.WriteLine("[4] - Fat Boy 114");
                            Console.WriteLine("[5] - Road King Special");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
                                case "1":
                                    model = "Iron 883";
                                    exitModel = true;
                                    break;
                                case "2":
                                    model = "Forty-Eight";
                                    exitModel = true;
                                    break;
                                case "3":
                                    model = "Street Glide";
                                    exitModel = true;
                                    break;
                                case "4":
                                    model = "Fat Boy 114";
                                    exitModel = true;
                                    break;
                                case "5":
                                    model = "Road King Special";
                                    exitModel = true;
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
                        mark = "Suzuki";
                        exitModel = false;
                        while (!exitModel)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha o modelo da moto:");
                            Console.WriteLine("[1] - GSX-S750");
                            Console.WriteLine("[2] - V-Strom 650");
                            Console.WriteLine("[3] - Burgman 400");
                            Console.WriteLine("[4] - Intruder 125");
                            Console.WriteLine("[5] - GSR 750");
                            string? choiceModel = Console.ReadLine();

                            switch (choiceModel)
                            {
                                case "1":
                                    model = "GSX-S750";
                                    exitModel = true;
                                    break;
                                case "2":
                                    model = "V-Strom 650";
                                    exitModel = true;
                                    break;
                                case "3":
                                    model = "Burgman 400";
                                    exitModel = true;
                                    break;
                                case "4":
                                    model = "Intruder 125";
                                    exitModel = true;
                                    break;
                                case "5":
                                    model = "GSR 750";
                                    exitModel = true;
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

            while(true)
            {
                Console.Write("Digite o ano de fabricação do veículo dd/MM/yyyy: ");
                yearManufacture = Console.ReadLine();

                if(DateTime.TryParseExact(yearManufacture, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataConvert))
                {
                    break; 
                } 
                else
                {
                    Console.WriteLine("O campo: 'Ano de Fabricação' foi preenchido incorretamente, por favor preencha com tipo de dados do campo");
                }
            }
            
            Console.WriteLine($"ID = {id}");
            Console.WriteLine($"Marca = {mark}");
            Console.WriteLine($"Modelo = {model}");
            Console.WriteLine($"Quilometragem = {km.ToString("F2", CultureInfo.InvariantCulture)}km");
            Console.WriteLine($"Ano de Fabricação = {dataConvert.ToString("dd/MM/yyyy")}");
            
            Dictionary<string, object> newMotorcycle = new Dictionary<string, object>();
            newMotorcycle["id"] = id;
            newMotorcycle["marca"] = mark;
            newMotorcycle["modelo"] = model;
            newMotorcycle["dataDeFabricao"] = dataConvert;
            newMotorcycle["quilometragem"] = km;

            motorcycle.Add(newMotorcycle);

            Console.WriteLine($"Moto cadastrado com sucesso no banco de dados! {DateTime.Now}");
            await Task.Delay(5000);
            return;
        }

        static async Task ListVehicles()
        {
            bool exit = false;

            while(!exit)
            {
                Console.Clear();
                Console.WriteLine("=== 🚗 MENU - LISTAR VEÍCULOS 🏍️ ===");
                Console.WriteLine("[1] - LISTAR TODOS OS VEÍCULOS");
                Console.WriteLine("[2] - LISTAR OS CARROS");
                Console.WriteLine("[3] - LISTAR AS MOTOS");
                Console.WriteLine("[4] - VOLTAR");
                string? choice = Console.ReadLine();
                Console.Clear();

                switch(choice)
                {
                    case "1":
                        ListCar();
                        ListMotorcycle();
                        Console.WriteLine($"Total de veículos : {car.Count + motorcycle.Count}");
                        await Task.Delay(10000);
                        break;
                    case "2":
                        ListCar();
                        Console.WriteLine($"Total de carros : {car.Count}");
                        await Task.Delay(10000);
                        break;
                    case "3":
                        ListMotorcycle();
                        Console.WriteLine($"Total de motos: {motorcycle.Count}");
                        await Task.Delay(10000);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, por favor escolha uma das opções");
                        await Task.Delay(2000);
                        break;
                }

            }
        }
        
        static void ListCar()
        {
            Console.WriteLine("=== CARROS CADASTRADOS NO SISTEMA 🚗  ===");
            
            if(car.Count == 0)
            {
                Console.WriteLine("Não há carros cadastrados!");
                Console.WriteLine();
            }
            else
            {
                foreach (var obj in car)
                {
                    foreach (var item in obj)
                    {
                        if(item.Value is DateTime data)
                        {
                            Console.WriteLine($"{item.Key} : {data.ToString("dd/MM/yyyy")}");
                        }
                        else
                        {
                            Console.WriteLine($"{item.Key} : {item.Value}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        static void ListMotorcycle()
        {
            Console.WriteLine("=== MOTOS CADASTRADOS NO SISTEMA 🏍️  ===");
            
            if(motorcycle.Count == 0)
            {
                Console.WriteLine("Não há motos cadastradas!");
                Console.WriteLine();
            }
            else
            {    
                foreach (var obj in motorcycle)
                {
                    foreach (var item in obj)
                    {
                        if(item.Value is DateTime data)
                        {
                            Console.WriteLine($"{item.Key} : {data.ToString("dd/MM/yyyy")}");
                        }
                        else
                        {
                            Console.WriteLine($"{item.Key} : {item.Value}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        static async Task EditVehicle()
        {
            bool exit = false;
            while(!exit)
            {
            Console.Clear();
            Console.WriteLine("=== 🚗 MENU - EDITAR AUTOMÓVEIS 🏍️ ===");
            Console.WriteLine("[1] - Editar Carro");
            Console.WriteLine("[2] - Editar Moto");
            Console.WriteLine("[3] - Voltar ao menu");
            string? choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        await EditCar();
                        exit = true;
                        break;
                    case "2":
                        await EditMotorcycle();
                        exit = true;
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, por favor escolha uma das opções");
                        await Task.Delay(3000);
                        break;
                }
            }
        }

        static async Task EditCar()
        {
            Console.Clear();
            bool exit = false;
            Console.WriteLine("=== MENU - EDITAR CARRO 🚗 ===");
            Console.Write("Digite o 'ID' do carro: ");
            string? id = Console.ReadLine();

            var objCar = car.Find(p => p["id"].Equals(int.Parse(id)));

            while(!exit)
            {
                if (objCar == null)
                {
                    Console.WriteLine("O 'ID' digitado não consta no banco de dados");
                    await Task.Delay(2000);
                    exit = true;
                }
                else
                {
                    string choice = MenuEdit();
                    switch(choice)
                    {
                        case "1":
                            Console.Write("Digite a nova marca: ");
                            objCar["marca"] = Console.ReadLine();
                            Console.WriteLine("Marca modificada com sucesso!");
                            await Task.Delay(2000);
                            exit = true;
                            break;
                        case "2":
                            Console.Write("Digite o novo modelo: ");
                            objCar["modelo"] =Console.ReadLine();
                            Console.WriteLine("Modelo modificado com sucesso!");
                            await Task.Delay(2000);
                            exit = true;
                            break;
                        case "3":
                            Console.Write("Digite a nova Quilometragem: ");
                            objCar["quilometragem"] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.WriteLine("Quilometragem modificada com sucesso!");
                            await Task.Delay(2000);
                            exit = true;
                            break;
                        case "4":
                            Console.Write("Digite a nova Data de Fabricação: ");
                            DateTime dataConvert; 
                            string formato = "dd/MM/yyyy";

                            while(true)
                            {
                                Console.Write("Digite o ano de fabricação do veículo dd/MM/yyyy: ");
                                string dateInput = Console.ReadLine();

                                if(DateTime.TryParseExact(dateInput, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataConvert))
                                {
                                    objCar["dataDeFabricao"] = dataConvert;
                                    break; 
                                } 
                                else
                                {
                                    Console.WriteLine("O campo: 'Ano de Fabricação' foi preenchido incorretamente, por favor preencha com tipo de dados do campo");
                                }
                            }

                            Console.WriteLine("Data de fabricação modificado com sucesso!");
                            await Task.Delay(2000);
                            exit = true;
                            break;
                        case "5":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Opção inválida, por favor escolha uma das opções");
                            await Task.Delay(2000);
                            break;
                    }
                }
            }
        }
        static async Task EditMotorcycle()
        {
            Console.Clear();
            bool exit = false;
            Console.WriteLine("=== MENU - EDITAR MOTO 🏍️ ===");
            Console.Write("Digite o 'ID' do moto: ");
            string? id = Console.ReadLine();

            var objMotorcycle = motorcycle.Find(p => p["id"].Equals(int.Parse(id)));

            while(!exit)
            {
                if (objMotorcycle == null)
                {
                    Console.WriteLine("O 'ID' digitado não consta no banco de dados");
                    await Task.Delay(2000);
                    exit = true;
                }
                else
                {
                    string choice = MenuEdit();
                    switch(choice)
                    {
                        case "1":
                            Console.Write("Digite a nova marca: ");
                            objMotorcycle["marca"] = Console.ReadLine();
                            Console.WriteLine("Marca modificada com sucesso!");
                            await Task.Delay(2000);
                            exit = true;
                            break;
                        case "2":
                            Console.Write("Digite o novo modelo: ");
                            objMotorcycle["modelo"] = Console.ReadLine();
                            Console.WriteLine("Modelo modificado com sucesso!");
                            await Task.Delay(2000);
                            exit = true;
                            break;
                        case "3":
                            Console.Write("Digite a nova Quilometragem: ");
                            objMotorcycle["quilometragem"] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.WriteLine("Quilometragem modificada com sucesso!");
                            await Task.Delay(2000);
                            exit = true;
                            break;
                        case "4":
                            Console.Write("Digite a nova Data de Fabricação: ");
                            DateTime dataConvert; 
                            string formato = "dd/MM/yyyy";

                            while(true)
                            {
                                Console.Write("Digite o ano de fabricação do veículo dd/MM/yyyy: ");
                                string dateInput = Console.ReadLine();

                                if(DateTime.TryParseExact(dateInput, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataConvert))
                                {
                                    objMotorcycle["dataDeFabricao"] = dataConvert;
                                    break; 
                                } 
                                else
                                {
                                    Console.WriteLine("O campo: 'Ano de Fabricação' foi preenchido incorretamente, por favor preencha com tipo de dados do campo");
                                }
                            }

                            Console.WriteLine("Data de fabricação modificado com sucesso!");
                            await Task.Delay(2000);
                            exit = true;
                            break;
                        case "5":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Opção inválida, por favor escolha uma das opções");
                            await Task.Delay(2000);
                            break;
                    }
                }
            }
        }
        static string MenuEdit()
        {
            Console.WriteLine();
            Console.WriteLine("O que você deseja modificar?");
            Console.WriteLine("[1] - Marca");
            Console.WriteLine("[2] - Modelo");
            Console.WriteLine("[3] - Quilometragem");
            Console.WriteLine("[4] - Data de fabricação");
            Console.WriteLine("[5] - Voltar ao menu");
            string? choice = Console.ReadLine();

            return choice;                
        }
        static int nextId = 1; 
        static List<Dictionary<string, object>> motorcycle = new List<Dictionary<string, object>>();
        static List<Dictionary<string, object>> car = new List<Dictionary<string, object>>();
    }
}