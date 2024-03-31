using DotNet.Common.Models;

// Criando Listas
// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("GO");
// listaString.Add("MG");


// Console.WriteLine("Percorrendo a Lista com o For");
// for(int i = 0; i < listaString.Count; i++){
//     Console.WriteLine($"Posição N° {i} - {listaString[i]}");
// }

// Console.WriteLine("Percorrendo a Lista com o Foreach");
// int iForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N° {iForeach} - {item}");
//     iForeach++;
// }

// // Criando Array
// int[] arrayInteiros = new int[4];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// Clonando e Aumentando a capacidade
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);
// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// //Percorrendo Array com o For
// for(int i = 0; i < arrayInteiros.Length ; i++)
// {
//     Console.WriteLine($"Posição N° {i}. Valor {arrayInteiros[i]}");
// }

//Percorrendo Array com o Foreach
// int iForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {iForeach} - {valor}");
//     iForeach++;
// }



// Chamando Model
// Pessoa p = new Pessoa();
// p.Nome = "Matheus";
// p.Idade = 16;
// p.Apresentar();


// //WHILE
// int numero = 5;
// int contador = 0;

// while(contador <=10){
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
//     contador++;
// }

// //FOR
// int x = 7;

// for (int contador = 1; contador <= 10; contador++)
// {
//     Console.WriteLine($"{x} X {contador} = {x * contador}");
// }

// Calculadora calc = new Calculadora();
// Console.WriteLine("DIGITE O PRIMEIRO NÚMERO: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("DIGITE O SEGUNDO NÚMERO: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("");
// Console.WriteLine("O QUE DESEJA FAZER?");
// Console.WriteLine("1 - SOMAR");
// Console.WriteLine("2 - SUBTRAIR");
// Console.WriteLine("3 - MULTIPLICAR");
// Console.WriteLine("4 - DIVIDIR");
// Console.WriteLine("");
// Console.WriteLine("DIGITE SUA ESCOLHA: ");
// int escolha = Convert.ToInt32(Console.ReadLine());

// switch (escolha)
// {
//     case 1:
//         calc.Somar(a, b);
//         break;
//     case 2:
//         calc.Subtrair(a, b);
//         break;
//     case 3:
//         calc.Multiplicar(a, b);
//         break;
//     case 4:
//         calc.Dividir(a, b);
//         break;
//     default:
//         Console.WriteLine("DIGITE UMA OPÇÂO VÁLIDA");
//         break;
// }

// NOT !
// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde) {
//     Console.WriteLine("VOU PEDALAR");
// }
// else {
//     Console.WriteLine("VOU PEDALAR OUTRO DIA");
// }

// AND &&
// bool presencaMinima = true;
// double media = 8;

// if (presencaMinima && media >= 7)
// {
//     Console.WriteLine("APROVADO");
// }
// else
// {
//     Console.WriteLine("REPROVADO");
// }


// OR ||
// bool maiorDeIdade = false;
// bool autorizacaoDosPais = false;

// if(maiorDeIdade || autorizacaoDosPais){
//     Console.WriteLine("ENTRADA LIBERADA");
// }
// else {
//     Console.WriteLine("ENTRADA NEGADA");
// }

// SWITCH CASE
// Console.WriteLine("DIGITE UMA LETRA: ");
// string letra = Console.ReadLine();

// if (letra.Length >= 2)
// {
//     Console.WriteLine("DIGITE SOMENTE UMA LETRA!");
// }
// else
// {
//     switch (letra){
//         case "a":
//         case "e":
//         case "i":
//         case "o":
//         case "u":
//             Console.WriteLine("VOGAL");
//             break;
//         default:
//             Console.WriteLine("CONSOANTE");
//             break;
//     }
// }


//IF ELSE
// int qntdEstoque = 12;
// int qntdCompra = 5;
// bool possivelCompra = (qntdEstoque >= qntdCompra);

// if (possivelCompra)
// {
//     Console.WriteLine($"Compra de {qntdCompra} produtos realizada com sucesso!");
// }
// else
// {
//     Console.WriteLine($"Desculpe. Estoque Insuficiente.");
// }


// double a = 4 / 2 + 2;
// Console.WriteLine(a);


//Cast Implícito
// int a = 12;
// double b = a;
// long a = 4;
// int b = Convert.ToInt32(a);
// Console.WriteLine(b);

//Converter para String
// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);


//Cast - Casting (Converter Para Inteiro)
// int a = Convert.ToInt32(null);
// // int a = int.Parse("5");
// Console.WriteLine(a);

//Operadores de Atribuição
// =,  +=,  -=,  *=,  /=
// int a = 10;
// int b = 20;
// int c = a + b;
// Console.WriteLine(c);

//Date Time
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);

//Tipos de Variáveis
// string apresentacao = "Olá, Seja bem-vindo!";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 2.50M;
// bool condicao = true;
// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade:" + quantidade);
// Console.WriteLine("Valor da variável altura:" +  altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco:" + preco);
// Console.WriteLine("Valor da variável condicao:" + condicao);


