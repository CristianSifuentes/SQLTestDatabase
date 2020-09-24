﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLTestDatabase;

namespace SQLTestDatabase.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200924190349_1_3")]
    partial class _1_3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SQLTestDatabase.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RFC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("SQLTestDatabase.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadProductos")
                        .HasColumnType("int");

                    b.Property<int>("Descripcion")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("SQLTestDatabase.PedidoCte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaPedido")
                        .HasColumnType("datetime2");

                    b.Property<long>("PedidoId")
                        .HasColumnType("bigint");

                    b.Property<int?>("PedidoId1")
                        .HasColumnType("int");

                    b.Property<long>("PersonaId")
                        .HasColumnType("bigint");

                    b.Property<int?>("PersonaId1")
                        .HasColumnType("int");

                    b.Property<string>("Producto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId1");

                    b.HasIndex("PersonaId1");

                    b.ToTable("PedidoCte");
                });

            modelBuilder.Entity("SQLTestDatabase.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoMaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApellidoPaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<long?>("EmpresaId")
                        .HasColumnType("bigint");

                    b.Property<int?>("EmpresaId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RFC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId1");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("SQLTestDatabase.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoPersona");
                });

            modelBuilder.Entity("SQLTestDatabase.TipoVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoVehiculo");
                });

            modelBuilder.Entity("SQLTestDatabase.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TipoVehiculoId")
                        .HasColumnType("bigint");

                    b.Property<int?>("TipoVehiculoId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoVehiculoId1");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("SQLTestDatabase.Viaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Viaje");
                });

            modelBuilder.Entity("SQLTestDatabase.ViajeChofer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<long>("PersonaId")
                        .HasColumnType("bigint");

                    b.Property<int?>("PersonaId1")
                        .HasColumnType("int");

                    b.Property<long>("ViajeId")
                        .HasColumnType("bigint");

                    b.Property<int?>("ViajeId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId1");

                    b.HasIndex("ViajeId1");

                    b.ToTable("ViajeChofer");
                });

            modelBuilder.Entity("SQLTestDatabase.PedidoCte", b =>
                {
                    b.HasOne("SQLTestDatabase.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId1");

                    b.HasOne("SQLTestDatabase.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId1");
                });

            modelBuilder.Entity("SQLTestDatabase.Persona", b =>
                {
                    b.HasOne("SQLTestDatabase.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId1");
                });

            modelBuilder.Entity("SQLTestDatabase.Vehiculo", b =>
                {
                    b.HasOne("SQLTestDatabase.TipoVehiculo", "TipoVehiculo")
                        .WithMany()
                        .HasForeignKey("TipoVehiculoId1");
                });

            modelBuilder.Entity("SQLTestDatabase.ViajeChofer", b =>
                {
                    b.HasOne("SQLTestDatabase.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId1");

                    b.HasOne("SQLTestDatabase.Viaje", "Viaje")
                        .WithMany()
                        .HasForeignKey("ViajeId1");
                });
#pragma warning restore 612, 618
        }
    }
}
