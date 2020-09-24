using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLTestDatabase
{
    class Context : DbContext
    {
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<TipoPersona> TipoPersona { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Viaje> Viaje { get; set; }
        public DbSet<ViajeChofer> ViajeChofer { get; set; }
        public DbSet<ViajeChofer> ViajeChoferPedido { get; set; }
        public DbSet<PedidoCte> PedidoCte { get; set; }


       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=LAPTOP-3NTPDV2V; initial catalog=CompanyTestDB;persist security info=True; Integrated Security=SSPI;");
        }
    }
}
