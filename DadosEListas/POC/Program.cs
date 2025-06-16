// Estudo de Propriedades, Métodos e construtores

// Propriedades - Definição
/*
    Uma propriedade é um membro que possui um mecanismo flexível,
    para ler, gravar ou calcular o valor de um campo de dados.
    As propriedades aparecem como membros de dados públicos, mas são 
    implementadas como métodos especiais chamados acessadores.
*/

// Propriedades - Prática
// Uso de Modificadores de acesso, Body Expressions, Validações GET e SET

/*
using POC.Models;

Pessoa p = new Pessoa();

p.Nome = "Eduardo";
p.Sobrenome = "Do Carmo";
p.Idade = 19;
p.Apresentar();

*/

// Métodos - Definição
/*
    Um método é um bloco de código que contém uma série de instruções.
    Um programa faz com que as instruções sejam executadas chamando
    o método e especificando os argumentos de método necessários.
    No C#, todas as instruções executadas são realizadas no contexto de um método.
*/

// Métodos - Prática

using POC.Models;

Pessoa p = new Pessoa("Eduardo", "Do Carmo");
Pessoa p1 = new Pessoa("Jose","Saramago");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p);
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.ListarAlunos();

// Construtores - Definição
/* 
    Um construtor é um método chamado pelo runtime quando é
    criada uma instância de uma classe ou de uma struct. Uma
    classe ou struct pode ter vários construtores que têm argumentos
    diferentes. Os construtores permitem que você garanta que as intâncias
    do tipo sejam válidas quando criadas.
*/



