using System.Collections.Generic;
using MvcApp.Models;
using System.Linq;

namespace MvcApp.Repositorio
{
    public class Repositorio
    {

        protected MySpotifyContext contexto;

        public Repositorio()
        {
            contexto = new MySpotifyContext();

        }

        public void IncluirMusica(Musica musica)
        {

            contexto.Add(musica);
            contexto.SaveChanges();

        }

        public bool ExcluirMusica(int musica_id)
        {

            return true;
        }

        public List<Musica> Listar()
        {

            var lista = contexto.Musicas.ToList();

            return lista;

        }

        public List<Musica> PesquisarPorGenero(string genero)
        {
            return null;
        }

        public List<Musica> PesquisarPorArtista(string artista)
        {

            return null;
        }

    }
}