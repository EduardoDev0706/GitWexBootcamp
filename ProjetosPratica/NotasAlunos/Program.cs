using System.Diagnostics;
using NotasAlunos.Models;

public class Program
{
    public static void Main(string[] args)
    {
        PlanilhaAlunos planilha = new PlanilhaAlunos();
        int opcao;

        do
        {

            LimparConsole();

            Console.WriteLine("====================================");
            Console.WriteLine("Controle e Gerenciamento de Alunos");
            Console.WriteLine("====================================");
            Console.WriteLine("1 - Adicionar aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Remover alunos");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = -1; // Opcao invalida se a conversao falhar
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do aluno: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite a matrícula do aluno: ");
                    string matricula = Console.ReadLine();
                    Aluno aluno = new Aluno(nome, matricula);

                    Notas notasObj = new Notas();
                    while (true)
                    {
                        Console.Write("Digite uma nota (ou 'fim' para terminar): ");
                        string notaStr = Console.ReadLine();
                        if (notaStr.ToLower() == "fim")
                        {
                            break;
                        }
                        try
                        {
                            double nota = double.Parse(notaStr); // Tenta converter para double
                            notasObj.AdicionarNota(nota);
                        }
                        catch (FormatException) // Captura erro se a string não for um número
                        {
                            Console.WriteLine("Nota inválida. Digite um número ou 'fim'.");
                        }
                    }
                    planilha.AdicionarAluno(aluno, notasObj);
                    break;
                case 2:
                    ListarAluno();
                    break;
                case 3:
                    RemoverAluno();
                    break;
                case 4:
                    Console.WriteLine("Encerrando...");
                    break;
                default:
                    Console.WriteLine("Opcao Invalida.");
                    break;
            }

            if (opcao != 4)
            {
                Console.Write("\nPressione ENTER para continuar...");
                Console.ReadLine();
            }

        } while (opcao != 4);
    }
    public static void LimparConsole()
    {
        try
        {
            if (OperatingSystem.IsWindows()) // Verifica se é Windows
            {
                Process.Start("cmd.exe", "/c cls").WaitForExit();
            }
            else // Para sistemas Unix-like (Linux, macOS)
            {
                Process.Start("clear").WaitForExit();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Não foi possível limpar o console: {ex.Message}");
        }
    }

}