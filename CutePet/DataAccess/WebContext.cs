﻿using DataAccess.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class WebContext : DbContext
    {
        // 1. Enable-Migrations
        // 2. Add-Migration
        // 3. Update-Database
        public WebContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }
        public DbSet<Users> users { set; get; }
        public DbSet<Tags> tags { set; get; }

        // chuỗi kết nối với tên db
    }
}