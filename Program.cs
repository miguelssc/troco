Console.WriteLine("digite o valor do produto");
decimal valorproduto = Convert.ToDecimal(Console.ReadLine());


Console.WriteLine("digite o valor a ser pago");
decimal valorpago = Convert.ToDecimal(Console.ReadLine());
decimal troco = (valorpago - valorproduto);

if (valorpago < valorproduto)
{
Console.WriteLine("O valor que será pago é menor que o valor do produto.");
}
else
{
Console.WriteLine($"O valor do troco é {troco}.");
}