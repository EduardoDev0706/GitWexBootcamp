# Documento de Requisitos de Projeto (DRP)
## Visão Geral

Este documento detalha dois projetos práticos em C# .NET, focados em fortalecer a sintaxe básica, o controle de exceções e a manipulação de listas e dados, antes de aprofundar em conceitos de Orientação a Objetos. Ambos os projetos são aplicações de console simples, projetadas para oferecer experiência prática nos fundamentos da linguagem.
Projeto 1: Sistema Simplificado de Gestão de Notas de Alunos
1. Visão Geral do Projeto

Este projeto visa criar uma aplicação de console para auxiliar no gerenciamento básico de notas de alunos. Ele permitirá adicionar alunos com suas respectivas notas, visualizar um resumo das médias e remover alunos do sistema. O foco principal é a prática de manipulação de listas e tratamento de exceções na entrada de dados.
2. Funcionalidades Detalhadas
2.1. Adicionar Aluno e Notas

    O programa deverá solicitar o nome do aluno.
    Em seguida, deverá solicitar 3 notas para o aluno (ou mais, se desejar estender o desafio).
    As notas devem ser armazenadas em uma estrutura de dados de lista (ex: List<double>) associada a cada aluno (inicialmente, pode-se pensar em armazenar nomes e listas de notas em listas separadas ou em dicionários, antes de entrar em classes mais complexas).
    Controle de Exceções/Validação:
        Ao solicitar as notas, o sistema deve validar se o input é um número válido (double).
        As notas devem estar em um intervalo lógico (ex: entre 0 e 10).
        Em caso de entrada inválida (não numérica ou fora do intervalo), o programa deve capturar a exceção (usando try-catch ou verificando com TryParse) e solicitar que o usuário insira a nota novamente, exibindo uma mensagem de erro clara e amigável.

2.2. Listar Alunos e Médias

    O programa deve exibir uma listagem de todos os alunos cadastrados, apresentando seus nomes e a média aritmética de suas notas.
    Se não houver alunos registrados, uma mensagem apropriada ("Nenhum aluno cadastrado.") deve ser exibida.

2.3. Remover Aluno

    O programa deve permitir que o usuário digite o nome de um aluno para removê-lo do sistema.
    Validação: Se o aluno não for encontrado na lista, uma mensagem informativa deve ser exibida ("Aluno não encontrado.").

2.4. Menu de Opções

    Implementar um menu interativo no console com as seguintes opções:
        Adicionar Aluno
        Listar Alunos
        Remover Aluno
        Sair
    A navegação do menu deve ser controlada usando um loop (while) e uma estrutura condicional (switch ou if/else if) para executar a funcionalidade selecionada.

3. Conceitos-Chave para Praticar

    Tipos de Dados Primitivos: string, double.
    Variáveis e Constantes.
    Entrada e Saída de Dados: Console.ReadLine(), Console.WriteLine().
    Estruturas de Controle: if/else, while, for (para iteração de listas), switch.
    Coleções: Uso da classe List<T> (ex: List<string> para nomes, List<List<double>> para notas, ou Dictionary<string, List<double>>).
    Conversão de Tipos: Métodos como double.Parse() e, preferencialmente, double.TryParse().
    Controle de Exceções: Implementação de blocos try-catch para gerenciar erros de conversão (FormatException) e outras validações.

Projeto 2: Calculadora de Custos de Viagem
1. Visão Geral do Projeto

Este projeto consiste em uma aplicação de console que calcula os custos estimados de uma viagem com base em informações fornecidas pelo usuário. O foco principal é a interação com o usuário, cálculos aritméticos e validação robusta de entrada de dados com tratamento de exceções.
2. Funcionalidades Detalhadas
2.1. Entrada de Dados da Viagem

    O programa deve solicitar e capturar os seguintes dados do usuário:
        Distância total da viagem (em KM).
        Consumo médio do veículo (em KM/Litro).
        Preço do combustível por litro.
        Número de pedágios.
        Valor médio por pedágio.
    Controle de Exceções/Validação:
        Para todas as entradas numéricas, o sistema deve garantir que o usuário digitou um número válido. Usar TryParse é altamente recomendado para evitar FormatException.
        Todos os valores numéricos inseridos (distância, consumo, preço, número de pedágios, valor do pedágio) devem ser positivos e diferentes de zero quando aplicável (ex: consumo e preço do combustível não podem ser zero).
        Se a entrada for inválida (não numérica, zero ou negativa), o programa deve exibir uma mensagem de erro e solicitar a entrada novamente até que um valor válido seja fornecido.

2.2. Cálculo dos Custos

    Realizar os seguintes cálculos com base nas entradas:
        Quantidade de combustível necessária: Distância / Consumo.
        Custo total do combustível: Quantidade de Combustível * Preço do Combustível.
        Custo total dos pedágios: Número de Pedágios * Valor Médio por Pedágio.
        Custo total da viagem: Custo Combustível + Custo Pedágios.

2.3. Exibição dos Resultados

    Apresentar um resumo claro e formatado dos custos calculados, incluindo:
        Distância: X km
        Consumo: Y km/l
        Preço Combustível: R$ Z/l
        Total Combustível: R$ A (formatado com 2 casas decimais)
        Total Pedágios: R$ B (formatado com 2 casas decimais)
        Custo Total da Viagem: R$ C (em destaque e formatado com 2 casas decimais)

2.4. Opção de Repetir

    Após exibir os resultados, o programa deve perguntar ao usuário se ele deseja calcular outra viagem.
    Se a resposta for afirmativa (ex: 'S' ou 's'), o processo de solicitação de dados e cálculo deve ser reiniciado.
    Caso contrário (ex: 'N' ou 'n'), o programa deve ser encerrado. Isso pode ser implementado com um loop do-while.

3. Conceitos-Chave para Praticar

    Tipos de Dados Primitivos: double ou decimal (para valores monetários), int, string, bool.
    Variáveis e Operadores Aritméticos.
    Entrada e Saída de Dados: Console.ReadLine(), Console.WriteLine(), e uso de formatação de strings para exibir os resultados (ex: valor.ToString("F2")).
    Estruturas de Controle: do-while (para o loop principal), if/else (para validações).
    Conversão de Tipos: Métodos como double.TryParse(), decimal.TryParse(), int.TryParse().
    Controle de Exceções: Uso de try-catch para lidar com entradas numéricas inválidas, embora TryParse seja mais adequado para validação direta de entrada do usuário.
    Métodos Auxiliares/Estáticos: Praticar a criação de pequenos métodos static para modularizar o código, como um método para ler uma entrada numérica positiva e validá-la.