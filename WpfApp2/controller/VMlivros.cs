using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.model;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity;

namespace WpfApp2.controller
{
    class VMlivros
    {
       
        public void inserlivro(string nome, string edicao, int ano)
        {
     
            using (basedadosEntities db = new basedadosEntities())
            {

            
                livros nova = new livros(); 
                nova.Nome = nome;
                nova.ediçao = edicao;
                nova.ano = ano;
                List<livros> livro = db.livros.ToList();

                db.livros.Add(nova);
                db.SaveChanges();
            
      
            }


        }
        public List<livros> getlivro()
        {

            using (basedadosEntities db = new basedadosEntities())
            {

                List<livros> livro = db.livros.ToList();
                return livro;
            }

        }
        public void dellivro(livros livros)
        {

            using (basedadosEntities db = new basedadosEntities())
            {


                db.livros.Remove(livros);
                db.SaveChanges();


            }


        }
    }
}
