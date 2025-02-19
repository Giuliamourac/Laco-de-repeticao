using System;

Console.WriteLine("Escreva uma palavra");

String palavra= Console.ReadLine();

for (int i = 0; i < 6; i++) 
{

    Console.WriteLine(palavra);

}

int numero;

do
{

    Console.WriteLine("Digite um numero maior que 10");
    numero= Convert.ToInt32 (Console.ReadLine());    

}
while (numero < 11);

Console.WriteLine($"Seu numero e {numero}");

int numero2;

Console.WriteLine("Escreva um numero maior que 20");

numero2= Convert.ToInt32 (Console.ReadLine());

while (numero2 <= 20)
{

    Console.WriteLine("Escreva um numero maior que 20");

    numero2 = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine($"Seu numero e {numero2}");