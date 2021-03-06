// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CbsStudent.Migrations
{
    [DbContext(typeof(CbsStudentContext))]
    [Migration("20220524104316_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("CbsStudent.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AboutEvent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfileId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EventId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("CbsStudent.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MyProperty")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProfileId");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("CbsStudent.Models.Event", b =>
                {
                    b.HasOne("CbsStudent.Models.Profile", "Profile")
                        .WithMany("Events")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("CbsStudent.Models.Profile", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
