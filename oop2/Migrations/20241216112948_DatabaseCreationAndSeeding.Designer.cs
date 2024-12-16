﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using oop2.Repository;

#nullable disable

namespace oop2.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20241216112948_DatabaseCreationAndSeeding")]
    partial class DatabaseCreationAndSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("oop2.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Jesus228",
                            PhoneNumber = "+375445566333"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mr.P",
                            PhoneNumber = "+375447300486"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ms. A",
                            PhoneNumber = "+375447300487"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mr. B",
                            PhoneNumber = "+375447300488"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mrs. C",
                            PhoneNumber = "+375447300489"
                        });
                });

            modelBuilder.Entity("oop2.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Equipment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Screen broken",
                            Name = "LG l345",
                            OrderId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Projector malfunction",
                            Name = "Epson 123",
                            OrderId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Whiteboard damage",
                            Name = "Standard Whiteboard",
                            OrderId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Laptop issue",
                            Name = "Dell XPS 15",
                            OrderId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Microphone not working",
                            Name = "Shure SM58",
                            OrderId = 1
                        });
                });

            modelBuilder.Entity("oop2.Models.EquipmentService", b =>
                {
                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.HasKey("EquipmentId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("EquipmentService");

                    b.HasData(
                        new
                        {
                            EquipmentId = 2,
                            ServiceId = 1,
                            count = 1
                        },
                        new
                        {
                            EquipmentId = 3,
                            ServiceId = 2,
                            count = 2
                        },
                        new
                        {
                            EquipmentId = 4,
                            ServiceId = 1,
                            count = 1
                        },
                        new
                        {
                            EquipmentId = 5,
                            ServiceId = 3,
                            count = 3
                        });
                });

            modelBuilder.Entity("oop2.Models.Master", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("contactInfo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("specialization")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Master");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dyadya",
                            contactInfo = "dyadya@gmail.com",
                            specialization = "screen fixer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vanya",
                            contactInfo = "vanya@gmail.com",
                            specialization = "laptop repair"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sasha",
                            contactInfo = "sasha@gmail.com",
                            specialization = "printer technician"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Misha",
                            contactInfo = "misha@gmail.com",
                            specialization = "network specialist"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Katya",
                            contactInfo = "katya@gmail.com",
                            specialization = "mobile device repair"
                        });
                });

            modelBuilder.Entity("oop2.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("MasterId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("MasterId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            MasterId = 1,
                            Status = "Выполнен"
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 2,
                            MasterId = 2,
                            Status = "Выполнен"
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 3,
                            MasterId = 3,
                            Status = "В процессе"
                        },
                        new
                        {
                            Id = 4,
                            ClientId = 4,
                            MasterId = 4,
                            Status = "Отменен"
                        },
                        new
                        {
                            Id = 5,
                            ClientId = 5,
                            MasterId = 5,
                            Status = "Выполнен"
                        });
                });

            modelBuilder.Entity("oop2.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Service");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Читска оборудования",
                            Price = 10
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ремонт экрана",
                            Price = 25
                        },
                        new
                        {
                            Id = 3,
                            Name = "Настройка сети",
                            Price = 15
                        },
                        new
                        {
                            Id = 4,
                            Name = "Установка программного обеспечения",
                            Price = 20
                        },
                        new
                        {
                            Id = 5,
                            Name = "Обслуживание принтера",
                            Price = 30
                        });
                });

            modelBuilder.Entity("oop2.Models.Equipment", b =>
                {
                    b.HasOne("oop2.Models.Order", "Order")
                        .WithMany("Equipment")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("oop2.Models.EquipmentService", b =>
                {
                    b.HasOne("oop2.Models.Equipment", "Equipment")
                        .WithMany("EquipmentService")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("oop2.Models.Service", "Service")
                        .WithMany("EquipmentService")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("oop2.Models.Order", b =>
                {
                    b.HasOne("oop2.Models.Client", "Client")
                        .WithMany("Order")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("oop2.Models.Master", "Master")
                        .WithMany("Order")
                        .HasForeignKey("MasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Master");
                });

            modelBuilder.Entity("oop2.Models.Client", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("oop2.Models.Equipment", b =>
                {
                    b.Navigation("EquipmentService");
                });

            modelBuilder.Entity("oop2.Models.Master", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("oop2.Models.Order", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("oop2.Models.Service", b =>
                {
                    b.Navigation("EquipmentService");
                });
#pragma warning restore 612, 618
        }
    }
}