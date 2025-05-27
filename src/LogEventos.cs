using System;
using System.Collections.Generic;

namespace PlataformaEnergia
{
    public class LogEventos
    {
        private List<Evento> eventos = new List<Evento>();

        public void AdicionarEvento(Evento evento)
        {
            eventos.Add(evento);
        }

        public void ExibirLogs()
        {
            Console.WriteLine("\n--- LOG DE EVENTOS ---");
            foreach (var e in eventos)
                e.ExibirResumo();
        }
    }
}