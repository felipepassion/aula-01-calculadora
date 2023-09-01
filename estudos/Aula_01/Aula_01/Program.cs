// square root
Console.WriteLine("Por favor, digite um valor: ");
var valorLido = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
var valorLido2 = int.Parse(Console.ReadLine());

var menorValor = Math.Min(valorLido, valorLido2);
Console.WriteLine("O menor valor é: " + menorValor);