namespace csharp;

public class Aluno
{
    public int codigo;
    public string? nome;
    public double nota1;
    public double nota2;
    public double media;
    public void CalcularMedia()
    { media = (nota1 + nota2) / 2; }
    public void Visualizar()
    { Console.WriteLine("Aluno: " + codigo + "\nNome: " + nome + "\nNota 1: " + nota1 + "\nNota 2: " + nota2 + "\nMédia: " + media); }
}
