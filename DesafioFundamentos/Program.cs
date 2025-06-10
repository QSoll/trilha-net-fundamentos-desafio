using DesafioFundamentos.Models;

//neste arquivo não precisa modificar nada, apenas se quiser
// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("\nWEX - Trilha .Net\n" +
                  "\nSeja bem-vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:"); //R$5,00
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Clear();

Console.WriteLine("Agora digite o preço por hora:"); //R$2,00
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Console.Clear();

// Instancia a classe Estacionamento com os valores informados
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Loop principal do menu
while (exibirMenu)
{
    Console.Clear(); // Mantém a tela limpa antes de exibir o menu

    // Exibe o menu sempre após qualquer ação
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    string opcao = Console.ReadLine();
    Console.Clear();

    switch (opcao)
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false; // Encerra o loop
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            Console.ReadKey(); // Aguarda antes de limpar a tela
            break;
    }

    // Sempre limpa a tela depois de uma opção ser executada
    Console.Clear();


}

Console.WriteLine("O programa se encerrou.");








/*
// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

//Preço da primeira hora do estacionamento é de R$ 5,00 e após será acrscentado por hora R$ 2,00
Console.WriteLine("\nWEX - Trilha .Net\n" + "Sistema de estacionamento\n\n" + "Seja bem vindo ao sistema de estacionamento!\n" + "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());


// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");

*/
