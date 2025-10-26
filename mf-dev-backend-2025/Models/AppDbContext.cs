
﻿namespace mf_dev_backend_2025.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Veiculos> Veiculos { get; set; }
        public DbSet<Consumo> Consumo { get; set; }
    }
}
