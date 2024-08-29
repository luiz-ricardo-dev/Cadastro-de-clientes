
using System.IO.Compression;

string opcao;

while(true)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente.");
    Console.WriteLine("2 - Buscar Cliente.");
    Console.WriteLine("3 - Apagar Cliente.");
    Console.WriteLine("4 - Encerrar.");
    
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente...");
            break;
        case "2":
            Console.WriteLine("Buscar Cliente...");
            break;
        case "3":
            Console.WriteLine("Apagar cliente...");
            break;
        case "4":
            Console.WriteLine("Encerrar...");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Invalida!");
            break;
    }
}