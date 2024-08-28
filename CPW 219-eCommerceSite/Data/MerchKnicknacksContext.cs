using CPW_219_eCommerceSite.Models;
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
    }
}
