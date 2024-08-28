using Microsoft.EntityFrameworkCore;
using BlaqJzure.Domain.Prodects;
using BlaqJzure.Domain.Users;
using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BlaqJzure.Repository
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Prodect> Prodects { get; set; }
    }
}
