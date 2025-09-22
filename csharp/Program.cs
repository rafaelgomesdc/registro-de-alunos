using csharp;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Aluno> lista_alunos = new List<Aluno>();
        int opcao = 0;

        while (opcao != 4)
        {
            opcao = Menu();
            switch (opcao)
            {
                case 1:
                    Cadastrar(lista_alunos);
                    break;
                case 2:
                    Consultar(lista_alunos);
                    break;
                case 3:
                    VisualizarTodos(lista_alunos);
                    break;
                case 4:
                    break;
            }
        }

        Console.WriteLine("Fim da execução");
    }

    private static void Cadastrar(List<Aluno> lista)
    {
        Aluno a = new Aluno();
        a.codigo = lista.Count + 1;
        Console.Write("\nNome: ");
        a.nome = Console.ReadLine();
        Console.Write("Nota 1: ");
        a.nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nota 2: ");
        a.nota2 = Convert.ToDouble(Console.ReadLine());
        a.CalcularMedia();

        lista.Add(a);
    }

    private static void Consultar(List<Aluno> lista)
    {
        string? nome = Console.ReadLine();
        foreach (Aluno a in lista)
        {
            Console.WriteLine("CONSULTAR ALUNO POR NOME");
            Console.Write("Digite o nome: ");
            if (a.nome == nome)
                a.Visualizar();
        }
    }

    private static void VisualizarTodos(List<Aluno> lista)
    {
        foreach (Aluno a in lista)
            a.Visualizar();
    }

    private static int Menu()
    {
        Console.WriteLine("*MENU DE OPÇÕES*");
        Console.WriteLine("\n1 - Cadastrar aluno\n2 - Consultar aluno\n3 - Visualizar todos os alunos\n4 - Encerrar execução\n");
        Console.Write("Digite a opção desejada: ");

        return
            Convert.ToInt32(Console.ReadLine());
    }
}