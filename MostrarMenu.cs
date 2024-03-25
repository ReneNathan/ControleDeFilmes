
using Alura.Filmes;
using System.Runtime.CompilerServices;

class MostrarMenu()
{
    public static void Mostrar(List<Filme> filmes)
    {
        int opcao;
        Filme filmeToAdd = new();

        Console.WriteLine("*******MENU DE OPÇÕES*******");
        Console.WriteLine("1-Cadastrar um filme");
        Console.WriteLine("2-Ver lista de filmes");
        Console.WriteLine("3-Ver lista de atores");
        Console.WriteLine("4-Sair");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Digite o nome do filme:");
                filmeToAdd.Titulo= Console.ReadLine();
                Console.WriteLine("Digite a duração do filme em minutos");
                filmeToAdd.Duracao = int.Parse(Console.ReadLine());
                string atores = "";
                List<string> atoresList = new List<string>();
                Console.WriteLine("Digite o elenco do filme(digite sair para finalizar)");
                while (atores != "sair")
                {
                    atores = Console.ReadLine();
                    if (atores != "sair")
                    {
                        atoresList.Add(atores);
                    }
                }
                filmeToAdd.Elenco = atoresList;
                
                filmes.Add(filmeToAdd);
                Console.Clear();
                Mostrar(filmes);
                break;

            case 2:
               Console.Clear();
               foreach(var filme in filmes)
                {
                    Console.WriteLine($"Filme {filme.Titulo} com duração de {filme.Duracao} e elenco formado por:");

                    foreach(var ator in filme.Elenco)
                    {
                        Console.WriteLine(ator);
                    }

                    Console.WriteLine("******************************************************");
                };

                Console.WriteLine("Aperte qualquer botão para retornr ao menu principal");
                Console.ReadLine();
                Console.Clear();
                Mostrar(filmes);
                break;

            case 3:
                break;

            case 4:
                Environment.Exit(0);
                break;

             default: 
                Console.Clear() ;
                Console.WriteLine("Opção invalida");
                Console.WriteLine("Retornando ao menu principal...");
                Thread.Sleep(3000);
                Console.Clear();
                Mostrar(filmes);

                break;
        }
    }
}