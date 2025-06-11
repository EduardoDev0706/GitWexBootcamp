// Não é preciso definir uma capacidade máxima para a lista
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("GO");

for (int contador = 0; contador < listaString.Count; contador++)
{
    System.Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

System.Console.WriteLine();

int contadorForeach = 0;
foreach (string item in listaString)
{
    System.Console.WriteLine($"Posição N° {contadorForeach} - {item}");
    contadorForeach++;
}






// Declarando um array com inteiros
/*
int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 62;
arrayInteiros[2] = 54;

// Copiando um Array para o outro
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Redimensionando um Array -> Cria um novo array e copia os elementos antigos
// para o novo array
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Percorrendo o array com o FOR
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    System.Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

// Percorrendo o array com o FOREACH
int contadorForeach = 0;
foreach (int valor in arrayInteiros)
{
    System.Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
    contadorForeach++;
}
*/