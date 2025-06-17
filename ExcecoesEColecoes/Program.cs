// Realizando a leitura de um arquivo
// Tratando uma execeção
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivos.txt");

//     foreach (string linha in linhas)
//     {
//         System.Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     System.Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado" + ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     System.Console.WriteLine("Chegou até aqui");
// }

// Erros que ocorrem dentro de um try-catch, se mantém naquele escopo e mantém o código rodando logo após a exceção ser tratada

// Utilizando o throw !

// using ExcecoesEColecoes.Models;

// new ExemploExcecao().Metodo1();

// Introdução ao método dictionary

Dictionary<string, string> estados = new Dictionary<string, string>();


estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

// Percorrendo todo o dicionário
foreach (var item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Acessando o dicionário
System.Console.WriteLine(estados["MG"]);

System.Console.WriteLine("---------");

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach (var item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Verificando se a chave BA existe após retirá-la
string chave = "BA";
System.Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    System.Console.WriteLine($"Valor existente: {chave}");
}
else
{
    System.Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}

