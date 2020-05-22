using System.Collections.Generic;
using MvcApp.Models;

namespace MvcApp.Repositorio {
    public class Repositorio {

        protected MySpotifyContext contexto;

        public Repositorio () {
            this.contexto = new MySpotifyContext ();

        }

        public void IncluirMusica (Musica musica) {

            contexto.Add (musica);
            contexto.SaveChanges ();

        }

        public bool ExcluirMusica (int musica_id) {

            return true;
        }

        public List<Musica> Listar () {

            return null;
        }

        public List<Musica> Pesquisar (string musica) {

            return null;
        }

        public List<Musica> PesquisarPorGenero (string genero) {
            return null;
        }

        public List<Musica> PesquisarPorArtista (string artista) {

            return null;
        }

        public bool Atualizar (int Id, Musica musica) {

            return true;
        }

    }
}