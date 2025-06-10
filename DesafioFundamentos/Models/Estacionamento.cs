//é este arquivo que vamos modificar
//é para codificar onde está escrito todo e implement aqui
//quando fizer o codigo e ele estiver funcionando pode apagar os comentários todo e implement aqui, ams sód epois de tudo funcionando

using System.Runtime.InteropServices;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine(); 

            veiculos.Add(placa);
            Console.Clear();
            Console.WriteLine($"Veículo {placa} estacionado com sucesso!");
            Console.ReadKey(); // Aguarda antes de voltar ao menu
        }

        
        public void RemoverVeiculo()
        {
            Console.WriteLine("Deseja exibir a lista de veículos? (Y/N)");
            string escolha = Console.ReadLine().ToUpper();

            if (escolha == "Y")
            {
                Console.Clear();
                ListarVeiculos();                
            }

            if (escolha == "N")
            {
                Console.Clear();

            }
            
            Console.WriteLine("Qual veículo quer remover?");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * (horas - 1));

                veiculos.Remove(placa);
                Console.Clear();

                Console.WriteLine($"O veículo {placa} permaneceu por {horas}, já foi removido e o preço total é de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Placa não encontrada! Deseja tentar novamente? (Y/N)");
                string tentativa = Console.ReadLine().ToUpper();

                if (tentativa == "Y") RemoverVeiculo();
                if (tentativa == "N")
                {
                Console.Clear();
                Console.WriteLine("Voltando ao menu...");
                Thread.Sleep(1500); // Aguarda 1,5 segundos antes de voltar ao menu
                return;
                }
            }

            Console.ReadKey();
        }



        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

            Console.ReadKey();
        }

    }
}



/* original
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = "";

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
*/
