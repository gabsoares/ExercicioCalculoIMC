﻿char genero;
double altura, peso, IMC;

Console.WriteLine("Qual o seu gênero? M para Mulher H para Homem");
genero = char.Parse(Console.ReadLine());

if (genero != 'm' && genero != 'h' && genero != 'M' && genero != 'H')
{
    Console.WriteLine("Digite apenas os caracteres informados, tente novamente!!!!!");
}
else
{
    Console.WriteLine("Qual a sua altura em metros?");
    altura = double.Parse(Console.ReadLine());

    Console.WriteLine("Qual o seu peso?");
    peso = double.Parse(Console.ReadLine());

    IMC = peso / (altura * altura);

    switch (genero)
    {
        case 'M':
        case 'm':
            if (IMC < 20.7)
                Console.WriteLine($"Abaixo do peso! IMC = {IMC}");
            else if (IMC >= 20.7 && IMC < 26.5)
                Console.WriteLine($"Peso ideal! IMC = {IMC}");
            else if (IMC >= 26.6 && IMC < 27.8)
                Console.WriteLine($"Pouco acima do peso! IMC = {IMC}");
            else if (IMC > 27.9 && IMC < 31.1)
                Console.WriteLine($"Acima do peso! IMC = {IMC}");
            else
                Console.WriteLine($"Obesidade! IMC = {IMC}");
            break;
        case 'H':
        case 'h':
            if (IMC < 19.1)
                Console.WriteLine($"Abaixo do peso! IMC = {IMC}");
            else if (IMC >= 19.1 && IMC < 25.8)
                Console.WriteLine($"Peso ideal! IMC = {IMC}");
            else if (IMC >= 25.9 && IMC < 27.3)
                Console.WriteLine($"Pouco acima do peso! IMC = {IMC}");
            else if (IMC >= 27.4 && IMC < 32.3)
                Console.WriteLine($"Acima do peso! IMC = {IMC}");
            else
                Console.WriteLine($"Obesidade! IMC = {IMC}");
            break;
    }
}