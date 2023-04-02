//declara as variáveis do tipo double
double n1, uni, dez, cen;

//exibe a mensagem '---Decomposição Decimal---' no console
Console.WriteLine("---Decomposição Decimal---");

// linha em branco, quebra de linha
Console.WriteLine();

// Exibe a mensagem "Digite seu Primeiro Nome:" no console
Console.WriteLine("Digite um número inteiro: ");
// Lê o valor digitado pelo usuário e converte para o tipo double
//atribuindo-o a variável 'n1'
n1 = Convert.ToDouble(Console.ReadLine());

//exibe a mensagem "O número n1 possui:" (onde n1 é
//o número que o usuário digitou)
Console.WriteLine($"O número {n1} possui:");
Console.WriteLine();


//calcula o resto da divisão do 'n1' por 10, o resultado é
//atribuído a variável 'uni'
uni = n1 % 10;
//exibe o valor da unidade no console
Console.WriteLine($"{uni} unidade(s)");


//calcula o resultado da divisão inteira do 'n1' por 10
//o resultado é atribuído a variável dez
dez = n1 / 10;
//exibe o valor da dezena no console
Console.WriteLine($"{dez} dezena(s)");


//calcula o resultado da divisão inteira do 'n1' por 100
//o resultado é atribuído a variável cen
cen = n1 / 100;
//exibe o valor da centena no console
Console.WriteLine($"{cen} centena(s)");