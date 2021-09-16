using Microsoft.EntityFrameworkCore;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //initialize constructor else gives error
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        //create database with AppUser(Models) details with table Users
        public DbSet<AppUser>Users{get; set;}

        internal ActionResult<AppUser> Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}