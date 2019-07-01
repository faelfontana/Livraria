using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Livraria.Models;
using System.Data.Entity;

public class Contexto : DbContext
{
    public Contexto() :
        base("Contexto")
    { }

    public DbSet<Livros> Livros { get; set; }


}