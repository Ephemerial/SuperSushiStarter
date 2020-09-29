﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSushi.Data
{
    public class SuperSushiContext : DbContext
    {
        public DbSet<Gerecht> Gerechten { get; set; }
        public DbSet<Menu> Menus { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=SuperSushiStarter;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 1, Naam = "Smells Fishy" });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 2, Naam = "Bunny Bugs" });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 3, Naam = "Mighty Meaty" });

            modelBuilder.Entity<Gerecht>().HasData(new Gerecht { Id = 1, Omschrijving = "Maki Tuna", Soort = Soort.Vis });
            modelBuilder.Entity<Gerecht>().HasData(new Gerecht { Id = 2, Omschrijving = "Sashimi Salmon", Soort = Soort.Vis });

            modelBuilder.Entity<Gerecht>().HasData(new Gerecht { Id = 3, Omschrijving = "Caramelised Crickets ", Soort = Soort.Insect });
            modelBuilder.Entity<Gerecht>().HasData(new Gerecht { Id = 4, Omschrijving = "Cinnamon Worms", Soort = Soort.Insect });

            modelBuilder.Entity<Gerecht>().HasData(new Gerecht { Id = 5, Omschrijving = "Nigiri Tofu", Soort = Soort.Vega });
            modelBuilder.Entity<Gerecht>().HasData(new Gerecht { Id = 6, Omschrijving = "Gunkam Zeewier", Soort = Soort.Vega });

            modelBuilder.Entity<Gerecht>().HasData(new Gerecht { Id = 7, Omschrijving = "Tebasaki Kip", Soort = Soort.Vlees });
            modelBuilder.Entity<Gerecht>().HasData(new Gerecht { Id = 8, Omschrijving = "Teriyaki Biefstuk", Soort = Soort.Vlees });

        }
    }
}
