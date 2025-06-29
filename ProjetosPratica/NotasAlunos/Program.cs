﻿using System.Diagnostics;
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

                    Console.Write("Defina um limite de notas máximo");
                    int limiteNotas;
                    if (!int.TryParse(Console.ReadLine(), out limiteNotas) || limiteNotas <= 0)
                    {
                        Console.WriteLine("Limite de notas inválido. Usando o limite padrão de 4.");
                        limiteNotas = 4;
                    }

                    Notas notasObj = new Notas(limiteNotas);

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
                            double nota = double.Parse(notaStr);
                            notasObj.AdicionarNota(nota); // A classe Notas agora gerencia o limite
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Nota inválida. Digite um número ou 'fim'.");
                        }
                    }
                    planilha.AdicionarAluno(aluno, notasObj);
                    break;
                case 2:
                    planilha.ListarAlunos();
                    break;
                case 3:
                    Console.Write("Digite a matrícula do aluno a ser removido:");
                    string matriculaRemover = Console.ReadLine();
                    planilha.RemoverAluno(matriculaRemover);
                    break;
                case 4:
                    Console.WriteLine("Encerrando...");
                    break;
                default:
                    Console.WriteLine("Opcao Invalida.");
                    break;
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