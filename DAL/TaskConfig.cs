using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL;

    public class TaskConfig : IEntityTypeConfiguration<BE.Task>
    {
        public void Configure(EntityTypeBuilder<BE.Task> builder)
        {
            builder.HasKey(e => e.TaskId);
            
            builder.ToTable("Task");
            
        }
    }

