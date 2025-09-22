using csharp;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Aluno> lista_alunos = new List<Aluno>();

        while (true)
        {
            switch (Menu())
            {
                case 1:
                    Cadastrar(lista_alunos);
                case 2:
                    Consultar(lista_alunos);
                case 3:
                    VisualizarTodos(lista_alunos);
                case 4:
                    break;
            }
        }
    }

    private static void Cadastrar(List lista)
    {
        Aluno a = new Aluno();
        a.codigo = lista.Length + 1;
        Console.Write("\nNome: ");
        a.nome = Console.ReadLine();
        Console.Write("Nota 1: ");
        a.nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nota 2: ");
        a.nota2 = Convert.ToDouble(Console.ReadLine());
        a.CalcularMedia();
    }

    private static void Consultar(List lista)
    {
        foreach (Aluno a in lista)
        {
            Console.WriteLine("CONSULTAR ALUNO POR NOME");
            Console.Write("Digite o nome: ");
            if (a.nome == Console.ReadLine())
                a.Visualizar();
        }
    }

    private static void VisualizarTodos(List lista)
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