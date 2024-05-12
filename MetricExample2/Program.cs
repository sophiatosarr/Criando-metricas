using System;
using System.Diagnostics.Metrics;

class HatCoMetrics
{
    private readonly Counter<int> _hatsSold;

    public HatCoMetrics(IMeterFactory meterFactory)
    {
        var meter = meterFactory.Create("HatCo.Store");
        _hatsSold = meter.CreateCounter<int>("hatco.store.hats_sold");
    }

    public void HatsSold(int quantity)
    {
        _hatsSold.Add(quantity);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Configuração do medidor
        var meter = new Meter("HatCo.Store");

        // Configuração do contador
        var hatsSoldCounter = meter.CreateCounter<int>("hatco.store.hats_sold");

        // Simulação de vendas de chapéus
        Console.WriteLine("Simulando vendas de chapéus. Pressione qualquer tecla para parar.");
        while (!Console.KeyAvailable)
        {
            // Pretendemos que a loja vende 4 chapéus a cada segundo
            System.Threading.Thread.Sleep(1000);
            hatsSoldCounter.Add(4);
        }
    }
}
