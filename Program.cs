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
int senha;
do
{
    Console.WriteLine("Digita a senha: ");
    senha = int.Parse(Console.ReadLine()); 
} while (senha != "1234") ;