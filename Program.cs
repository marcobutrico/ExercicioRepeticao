//*** Básicos**
//  **1. Contagem de 1 a 20**
//  Crie um programa que exiba os números de 1 a 20 na tela.
//int numero = 1;
//while (numero <= 20)
//{
//    Console.WriteLine(numero);
//    numero++;
//}

//### **2. Validação de senha**
// Peça ao usuário para inserir a senha "1234". Continue pedindo até que ele acerte.
//int senha;
//do
//{
//    Console.WriteLine("Digita a senha: ");
//    senha = int.Parse(Console.ReadLine()); 
//} while (senha != 1234) ;
//### **3. Tabuada de um número**
//Peça ao usuário um número e exiba a tabuada dele de 1 a 10.
//for (int i = 1; i <= 10; i++)
//{
//	for (int j = 0; j <= 10; j++)
//	{
//		Console.WriteLine($"{i} x {j} = {i * j}");
//	}
//	Console.WriteLine("");
//}
//Intermediários
//### **4. Contagem regressiva**
// Peça um número ao usuário e faça uma contagem regressiva até 0.
//int contagem;

//Console.WriteLine("Digita o valor a iniciar a contagem regressiva: ");
//contagem = int.Parse(Console.ReadLine());

//for (int i = contagem; i >= 0; i--)
//{
//    Console.WriteLine($"{i}");
//}

//### **5. Média de notas**

//Solicite notas ao usuário (entre 0 e 10) até que ele insira um número inválido.
//Depois, exiba a média das notas.
//double nota = 0;
//double media = 0;
//double soma = 0;
//double valor = 0.0;

//while ((nota >= 0) && (nota <= 10))
//{
//    Console.WriteLine($"Digita a nota: ");
//    nota = int.Parse(Console.ReadLine());
//    if ((nota >= 0) && (nota <= 10))
//    {
//        soma = soma + nota;
//        valor++;
//    }
//}

//media = (soma / valor);
//Console.WriteLine($"Media: {media}");

//Tratamento de excecoes
//int numero = int.Parse(Console.ReadLine());

//Exception
//IOException - Erro de entrada e saída
//FormatException
//try
//{
//int num = int.Parse(Console.ReadLine());
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Erro: informe apenas numeros. ");
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Erro: numero muito grande. ");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Erro: tentativa de divisão por 0. ");
//}

//int idade = int.Parse(Console.ReadLine());

//if (idade > 120)
//{
//    throw new ArgumentNullException("Idade invalida");
//

StreamReader reader = null;
try
{
    reader = new StreamReader("arquivo.txt");
    Console.WriteLine(reader.ReadToEnd());
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("Erro: Arquivo não encontrado.");
}
finally
{
    if (reader != null)
    {
        reader.Close();
        Console.WriteLine("Arquivo fechado.");
    }
}