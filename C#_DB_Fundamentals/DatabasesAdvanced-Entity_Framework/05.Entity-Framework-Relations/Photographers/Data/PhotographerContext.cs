namespace Photographers.Data
{
    using Migrations;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PhotographerContext : DbContext
    {
       
        public PhotographerContext()
            : base("name=PhotographerContext")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<PhotographerContext,Configuration>());
        }

       
         public virtual DbSet<Photographer> Photographers { get; set; }
         public virtual DbSet<Album> Albums { get; set; }
         public virtual DbSet<Picture> Pictures { get; set; }
         public virtual DbSet<Tag> Tags { get; set; }

        public virtual DbSet<PhotographerAlbum> PhotographerAlbums { get; set; }
    }

   
}