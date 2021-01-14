using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StudentDbContext
/// </summary>
public class StudentDbContext : DbContext
{
    public StudentDbContext() : base("name=StudentDbContext")
    {

    }

    public System.Data.Entity.DbSet<Student> Students { get; set; }
}