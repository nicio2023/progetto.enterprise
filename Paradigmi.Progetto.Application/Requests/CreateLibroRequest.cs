﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Paradigmi.Progetto.Models.Context;
using Paradigmi.Progetto.Models.Entities;
using Paradigmi.Progetto.Models.Repositories;
using System.Linq;

namespace Paradigmi.Progetto.Application.Requests
{
    public class CreateLibroRequest
    {
        public string Nome { get; set; } = string.Empty;
        public string Autore { get; set; } = string.Empty;
        public string Editore { get; set; } = string.Empty;
        public DateTime DataPubblicazione { get; set; }
        public List<string>? Categorie { get; set; }


        public Libro ToEntity(List<CategoriaLibro> categorie)
        {
            MyDbContext _ctx = new MyDbContext();
            var request = new Libro();
            request.Nome = Nome;
            request.Editore = Editore;
            request.Autore = Autore;
            request.DataPubblicazione = DataPubblicazione;
            request.Categorie = categorie;
            return request;
        }
        /*private ICollection<Categoria> GetCategorie(List<string>? categorie)
        { 
            var Categorie = new List<Categoria>();
            var indexes = new List<int>();
            foreach (string cat in categorie)
            {
                indexes.Add(_categoriaRepository.GetCategoriaByNome(cat));
            }
            foreach(int i in indexes)
            {
                Categorie.Add(_categoriaRepository.GetCategoriaById(i));
            }
            return Categorie;
        }*/
        
    }
}
