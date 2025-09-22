using csharp;

internal class Program
{
    private static void Main()
    {
        List<Aluno> lista_alunos = new List<Aluno>();

        while (true)
        {
            switch (Menu())
            {
                case 4:
                    break;
            }
        }
    }

    private static void Cadastrar()
    {}

    private static void Consultar()
    {}

    private static void VisualizarTodos()
    {}

    private static int Menu()
    {
        Console.WriteLine("*MENU DE OPÇÕES*");
        Console.WriteLine("\n1 - Cadastrar aluno\n2 - Consultar aluno\n3 - Visualizar todos os alunos\n4 - Encerrar execução\n");
        Console.Write("Digite a opção desejada: ");

        return
            Convert.ToInt32(Console.ReadLine());
    }
}