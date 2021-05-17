using System;

namespace mkt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nome do anúncio");
            var nomeanuncio = (Console.ReadLine());

            Console.WriteLine("Empresa");
            var nomeempresa = (Console.ReadLine());

            Console.WriteLine("Data de início");
            var datain = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Data final");
            var datafim = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Valor por dia");
            var valor = Convert.ToInt64(Console.ReadLine());

            var diastotais = (datafim - datain).TotalDays;

            Int64 valortotalinvestido = (long)(diastotais * valor);


            Int64 visualizacoesTotais = 0;


            Int64 visualizacoes = valortotalinvestido * 30;


            // a cada 100 pessoas que visualizam o anúncio 12 clicam nele
            Int64 cliques = visualizacoes * 12 / 100;


            // a cada 20 pessoas que clicam no anúncio 3 compartilham nas redes sociais
            Int64 compartilhamentos = cliques * 3 / 20;


            // projeção aproximada da quantidade máxima de pessoas que visualizarão o mesmo anúncio (considerando o anúncio original + os compartilhamentos)
            visualizacoesTotais += visualizacoes;

            // cada compartilhamento nas redes sociais gera 40 novas visualizações
            visualizacoes = compartilhamentos * 40;


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Visualizações máximas: {visualizacoesTotais:N0}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Cliques máximos: {cliques:N0}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Compartilhamentos máximos: {compartilhamentos:N0}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Valor Total Investido: {valortotalinvestido:N0}");
        }

    }
}
