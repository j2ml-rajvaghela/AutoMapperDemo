using AutoMapperDemo.WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoMapperDemo.WebAPI.Configuration
{
    public class StudentModelConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("studentdemo_automapper");
            builder.HasKey(x => x.StudentId);

            builder
                .Property(x => x.StudentId)
                .HasColumnName("student_id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd()
                .IsRequired();


            builder
               .Property(x => x.Name)
               .HasColumnName("name")
               .HasColumnType("varchar(50)")
               .IsRequired();


            builder
               .Property(x => x.Age)
               .HasColumnName("age")
               .HasColumnType("integer")
               .IsRequired();
        }
    }
}
