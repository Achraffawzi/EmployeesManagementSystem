﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionConge
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDGestionDesCongesEntities2 : DbContext
    {
        public BDGestionDesCongesEntities2()
            : base("name=BDGestionDesCongesEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Chef> Chef { get; set; }
        public virtual DbSet<Conge> Conge { get; set; }
        public virtual DbSet<Employe> Employe { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}