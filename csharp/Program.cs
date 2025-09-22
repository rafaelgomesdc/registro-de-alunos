using csharp;

internal class Program
{
    private static void Main()
    { }

    private static int Menu()
    {
        Console.WriteLine("*MENU DE OPÇÕES*");
        Console.WriteLine("\n1 - Cadastrar aluno\n2 - Consultar aluno\n3 - Visualizar todos os alunos\n4 - Encerrar execução\n");
        Console.Write("Digite a opção desejada: ");

        return
            Convert.ToInt32(Console.ReadLine());
    }
}