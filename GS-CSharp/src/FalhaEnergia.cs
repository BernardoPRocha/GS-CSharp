using System;

namespace PlataformaEnergia
{
    public class FalhaEnergia : Evento
    {
        public string Local { get; set; }

        public FalhaEnergia(string local, string descricao) : base(descricao)
        {
            Local = local;
        }

        public override void ExibirResumo()
        {
            Console.WriteLine($"[{DataHora}] - Falha em {Local}: {Descricao}");
        }
    }
}