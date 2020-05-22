using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Upload;

namespace MvcApp.Controllers
{
    public class SpotifyController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload()
        {
            List<string> uploadFileNames = new List<string>();

            var files = Request.Form.Files;

            var genero = Request.Form["Genero"];
            var album = Request.Form["Album"];
            var artista = Request.Form["Artista"];


            var f = files[0];


            var rep = new MvcApp.Repositorio.Repositorio();
            rep.IncluirMusica(new MvcApp.Models.Musica() { Genero = genero, Artista = artista, Album = album, UrlStr = f.FileName });

            var path = $"wwwroot/musicas/Artista/{artista}/{album}";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var fs = new FileStream($"wwwroot/musicas/Artista/{artista}/{album}/" + f.FileName, FileMode.CreateNew);

            f.CopyTo(fs);

            fs.Close();

            return Ok();
        }


    }
}