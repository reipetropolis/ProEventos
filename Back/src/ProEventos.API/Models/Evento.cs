using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Models
{
    public class Evento
    {
        public Evento(){}

        public Evento(int EventoId, string Local, string DataEvento, string Tema, int QtdPessoas, string Lote, string ImagemUrl)
        {
            this.EventoId = EventoId;
            this.Local = Local;
            this.DataEvento = DataEvento;
            this.Tema = Tema;
            this.QtdPessoas = QtdPessoas;
            this.Lote = Lote;
            this.ImagemUrl = ImagemUrl;
        }

        public int EventoId { get; set; }
        public string? Local { get; set; }
        public string? DataEvento { get; set; }
        public string? Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string? Lote { get; set; }
        public string? ImagemUrl { get; set; }
    }
}