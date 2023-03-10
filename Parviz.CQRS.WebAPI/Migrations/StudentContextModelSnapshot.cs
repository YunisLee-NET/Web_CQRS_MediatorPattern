// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parviz.CQRS.WebAPI.Data;

namespace Parviz.CQRS.WebAPI.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Parviz.CQRS.WebAPI.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 21,
                            Name = "Parviz",
                            Surname = "Yunisli"
                        },
                        new
                        {
                            Id = 2,
                            Age = 21,
                            Name = "Murad",
                            Surname = "Aliyev"
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            Name = "Xuraman",
                            Surname = "Tagizade"
                        },
                        new
                        {
                            Id = 4,
                            Age = 22,
                            Name = "Osman",
                            Surname = "Bashirov"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
