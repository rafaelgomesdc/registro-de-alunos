namespace csharp;

public class Aluno
{
    int codigo;
    string? nome;
    double nota1;
    double nota2;
    double media;
    public void CalcularMedia()
    { media = (nota1 + nota2) / 2; }
    public void Visualizar()
    { Console.WriteLine("Aluno: " + codigo + "\nNome: " + nome + "\nNota 1: " + nota1 + "\nNota 2: " + nota2 + "\nMédia: " + media); }
}
