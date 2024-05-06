using System.ComponentModel;
using System.Data.Common;
using DesafioFundamentos.src.model;

internal class Program
{
    private static void Main(string[] args)
    {        
        Cars auto = new Cars();
       
         



string opcao = string.Empty;
bool exibirMenu = true;
// Realiza o loop do menu
while (exibirMenu)
{
    

    
    
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            auto.VehicleAdd();
            break;
        case "2":
            auto.VehicleRemove();
            exibirMenu = true;
            break;
        case "3":
            auto.VehicleList();
            
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


       }   
    }

