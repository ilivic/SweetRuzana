﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vizard.ADOApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RsteamEntities : DbContext
    {
        public RsteamEntities()
            : base("name=RsteamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Balances> Balances { get; set; }
        public virtual DbSet<Blocet> Blocet { get; set; }
        public virtual DbSet<Creaters> Creaters { get; set; }
        public virtual DbSet<Feivarit> Feivarit { get; set; }
        public virtual DbSet<GameComments> GameComments { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Librarys> Librarys { get; set; }
        public virtual DbSet<LibrarysGames> LibrarysGames { get; set; }
        public virtual DbSet<Prodactions> Prodactions { get; set; }
        public virtual DbSet<Reiteg> Reiteg { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}