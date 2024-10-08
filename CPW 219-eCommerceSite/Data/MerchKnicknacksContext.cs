﻿using CPW_219_eCommerceSite.Models;
using Microsoft.EntityFrameworkCore;

namespace CPW_219_eCommerceSite.Data
{
    public class MerchKnicknacksContext : DbContext

    {
        public MerchKnicknacksContext(DbContextOptions<MerchKnicknacksContext> options) : base(options) 
        { 

        }

        public DbSet<Merch> Merchendise { get; set; }

        public DbSet<Member> Members { get; set; }
        public DbSet<CPW_219_eCommerceSite.Models.RegisterViewModel> RegisterViewModel { get; set; } = default!;
        public DbSet<CPW_219_eCommerceSite.Models.LoginViewModel> LoginViewModel { get; set; } = default!;

    }
}
