using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApp.Models {

    public class Musica {

        public int Id { get; set; }
        public string Genero { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Letra { get; set; }
        public string UrlStr { get; set; }

        [NotMapped]
        public string Regravacao { get; set; }

        //public int Ano { get; set; }

        // private int _ano;

        // public void setAno (int ano) {

        //     this._ano = ano;
        // }

        // public int getAno () {
        //     return this._ano;
        // }

    }
}