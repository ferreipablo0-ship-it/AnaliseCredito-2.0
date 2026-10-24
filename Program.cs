decimal valor, rendaComprovada, valorParcela, maiorParcelaPermitida;
int quantidadeParcelas;

Console.WriteLine("---Analise de Credito---");

Console.Write("Valor desejado..........: ");
valor = Convert.ToDecimal(Console.ReadLine());

Console.Write("Quantidade de parcelas..:");
quantidadeParcelas = Convert.ToInt32(Console.ReadLine());

Console.Write("Renda comprovada..........: ");
rendaComprovada = Convert.ToDecimal(Console.ReadLine());

valorParcela = valor / quantidadeParcelas;
maiorParcelaPermitida = rendaComprovada / 100 * 30;

Console.WriteLine();

Console.WriteLine($"Parcela: {valorParcela:C}");
Console.WriteLine($"Maior parcela permitida: {maiorParcelaPermitida:C}");

Console.WriteLine();

if (valorParcela > maiorParcelaPermitida)
{
    Console.WriteLine("Emprestimo não autorizado.");
}
else
{
    Console.WriteLine("Emprestimo autorizado.");
}