using ExemplosFundamentos.Common.Models;

Pessoa pessoa1 = new Pessoa();

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//         Console.WriteLine("1 - Cadastrar cliente");
//         break;

//         case "2":
//         Console.WriteLine("2 - Buscar cliente");
//         break;

//         case "3":
//         Console.WriteLine("3 - Apagar cliente");
//         break;

//         case "4":
//         Console.WriteLine("Encerrar");
//         exibirMenu = false;
//         break;

//         default:
//         Console.WriteLine("Opção invalida");
//         break;

//     }
// }

// int soma =0, numero = 0;

// do{
//     Console.WriteLine("Digite um numero");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;

// }while(numero != 0);

// Console.WriteLine($"A soma dos numero é {soma}");


// int numero = 5;
// int contador = 0;

// while(contador >=10)
// {
//     Console.WriteLine($"{contador + 1}° Execução = {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (numero == 8)
//     {
//         break;
//     }
// }


// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x 1 = {numero * contador}");
// }


// Calculadora calc = new Calculadora();

// calc.RaizQuadrada(9);

// calc.coseno(30);
// calc.tangete(30);
// calc.seno(30);

//calc.potencia(3,3);

// calc.somar(10,20);
// calc.subtrair(10,50);
// calc.multiplicar(15,45);
// calc.dividir(2,2);


// //OPERADORES LOGICOS
// // NOT (!)
// bool choveu = true;
// bool estaTarde = true;

// if(!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }



// //AND (&&)
// bool possuiPresencaMinima = true;
// double media = 6.5;

// if(possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!"); 
// }

// //OR (||)
// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//    Console.WriteLine("Entrada não liberada.");
// }



// //OPERADORES CONDICIONAIS

// //SWITCH
// Console.WriteLine("Digite uma letra");
// string letra =  Console.ReadLine();

// switch (letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("Vogal");
//     break;

//     default:
//     Console.WriteLine("Não é uma Vgal");
//     break;
// }

// //IF
// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }



// //OPERADORES DE ATRIBUIÇÃO

// //cast

// string a = "15-";
// int b = 0
// int.TryParce(a, out b);
// int a = 5;
// double b = a;
// Console.WriteLine(b);

// int inteiro = 5;
// string a = inteiro.ToString(); // CONVERTER PARA STRING

//int a = Convert.ToInt32("5");
//int a = Convert.ToInt32(null); //ACEITA NULL

//int a = int.Parse("5"); //NÃO ACEITA NULL
// int a = 10;
// int b = 20;

// int c = a + b;

// //c = c + 5; // 30 + 5

// c += 5;
// //c -= 5;
// Console.WriteLine(c);



// //DATA EM .NET
//DateTime dataAtual = DateTime.Now.AddDays(5);
//Console.WriteLine(dataAtual.ToString("dd/mm/yyyy HH:mm"));

// string apresentacao = "Olá seja bem vindo";



// //TIPOS DE DADOS
// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade:" + quantidade);
// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade:" + quantidade);

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;
// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade:" + quantidade);
// Console.WriteLine("Valor da variável altura:" + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco:" + preco);
// Console.WriteLine("Valor da variável condicao:" + condicao);



// //UTILIZANDO CLASSE
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Maicon";
// pessoa1.Idade = 24;
// pessoa1.Apresentar();
// Pessoa pessoaFisicaRepresentacao = new Pessoa();

