using System;

namespace PlataformaEnergia
{
    public class Evento
    {
        public DateTime DataHora { get; set; }
        public string Descricao { get; set; }

        public Evento(string descricao)
        {
            DataHora = DateTime.Now;
            Descricao = descricao;
        }

        public virtual void ExibirResumo()
        {
            Console.WriteLine($"[{DataHora}] - {Descricao}");
        }
    }
}