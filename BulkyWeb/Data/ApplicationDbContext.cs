using System;
using BulkyWeb.Models;
using BulkyWeb.Models.Status;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<Category> Categories { get; set; }
        public DbSet<Status> ControlStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Category>().HasData(
				new Category { Id=1, Name="Action", DisplayOrder=1},
                new Category { Id = 2, Name = "Scifi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "Initiated" },
                new Status { Id = 2, Name = "Pending" }
                );
        }

    }
}

