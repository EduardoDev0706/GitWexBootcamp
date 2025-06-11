using System;
using System.IO;
using System.Diagnostics; // Necessário para Process

public class Biblioteca
{
    public static void Main(string[] args)
    {
        int opcao;
        // Usa Console.ReadLine() para entrada de dados em C#
        // Não é necessário criar um objeto Scanner como em Java
        
        do
        {
            LimparConsole();

            Console.WriteLine("====================================");
            Console.WriteLine("Bem-vindo a Biblioteca de Alexandria");
            Console.WriteLine("====================================");
            Console.WriteLine("1 - Cadastrar livro");
            Console.WriteLine("2 - Listar livros");
            Console.WriteLine("3 - Buscar livros ");
            Console.WriteLine("4 - Remover livros");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção");

            // Tenta converter a entrada do usuário para um inteiro
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = -1; // Opção inválida se a conversão falhar
            }

            switch (opcao)
            {
                case 1:
                    CadastrarLivro();
                    break;
                case 2:
                    ListarLivros();
                    break;
                case 3:
                    BuscarLivro();
                    break;
                case 4:
                    RemoverLivro();
                    break;
                case 5:
                    Console.WriteLine("Encerrando...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break; // Adicionado break para o default
            }

            if (opcao != 5)
            {
                Console.Write("\nPressione ENTER para continuar...");
                Console.ReadLine(); // Espera o usuário pressionar ENTER
            }

        } while (opcao != 5);
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

    public static void CadastrarLivro()
    {
        try
        {
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Ano: ");
            string ano = Console.ReadLine();

            Console.Write("Nota(0 - 5): ");
            string nota = Console.ReadLine();

            // Formata a linha para salvar no arquivo
            string linha = $"{titulo};{autor};{ano};{nota}";

            // Usa StreamWriter para escrever no arquivo, "true" para adicionar ao final
            using (StreamWriter sw = new StreamWriter("livros.txt", true))
            {
                sw.WriteLine(linha);
            }

            Console.WriteLine("Livro cadastrado com sucesso!");

        }
        catch (IOException e)
        {
            Console.WriteLine($"Erro ao salvar o livro: {e.Message}");
        }
    }

    public static void ListarLivros()
    {
        try
        {
            // Verifica se o arquivo existe antes de tentar ler
            if (!File.Exists("livros.txt"))
            {
                Console.WriteLine("Nenhum livro cadastrado ainda.");
                return;
            }

            using (StreamReader sr = new StreamReader("livros.txt"))
            {
                string linha;
                int contador = 1;

                Console.WriteLine("\n--- Livros Cadastrados ---");
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] partes = linha.Split(';');

                    if (partes.Length == 4)
                    {
                        Console.WriteLine($"{contador++}. Título: {partes[0]} | Autor: {partes[1]} | Ano: {partes[2]} | Nota: {partes[3]}");
                    }
                    else
                    {
                        Console.WriteLine($"Linha mal formatada: {linha}");
                    }
                }
                Console.WriteLine("--------------------------");
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Erro ao ler o arquivo: {e.Message}");
        }
    }

    public static void BuscarLivro()
    {
        try
        {
            // Verifica se o arquivo existe
            if (!File.Exists("livros.txt"))
            {
                Console.WriteLine("Nenhum livro cadastrado para buscar.");
                return;
            }

            Console.Write("Digite o título ou o nome do autor para buscar: ");
            string busca = Console.ReadLine().ToLower();

            using (StreamReader sr = new StreamReader("livros.txt"))
            {
                string linha;
                bool encontrado = false;

                Console.WriteLine("\n--- Resultados da Busca ---");
                while ((linha = sr.ReadLine()) != null)
                {
                    if (linha.ToLower().Contains(busca))
                    {
                        string[] partes = linha.Split(';');
                        Console.WriteLine($"Encontrado: Título: {partes[0]} | Autor: {partes[1]} | Ano: {partes[2]} | Nota: {partes[3]}");
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("Livro não encontrado.");
                }
                Console.WriteLine("---------------------------");
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Erro na busca: {e.Message}");
        }
    }

    public static void RemoverLivro()
    {
        try
        {
            // Verifica se o arquivo existe
            if (!File.Exists("livros.txt"))
            {
                Console.WriteLine("Nenhum livro cadastrado para remover.");
                return;
            }

            Console.Write("Digite o nome do livro a remover: ");
            string nomeRemover = Console.ReadLine();

            string inputFile = "livros.txt";
            string tempFile = "livros_temp.txt";

            bool removido = false;

            // Lê do arquivo original e escreve para o arquivo temporário
            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    // Se a linha não contém o nome a ser removido, escreve no arquivo temporário
                    if (!linha.Contains(nomeRemover))
                    {
                        writer.WriteLine(linha);
                    }
                    else
                    {
                        removido = true;
                    }
                }
            } // Os using blocks garantem que reader e writer são fechados automaticamente

            // Deleta o arquivo original
            File.Delete(inputFile);
            // Renomeia o arquivo temporário para o nome do arquivo original
            File.Move(tempFile, inputFile);

            if (removido)
            {
                Console.WriteLine("Livro removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Um livro com este nome não foi encontrado.");
            }

        }
        catch (IOException e)
        {
            Console.WriteLine($"Erro ao remover o livro: {e.Message}");
        }
    }
}