using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Core.Domain.Projects;

namespace Nop.Data.Mapping.Projects
{
    public class ProjectMap : NopEntityTypeConfiguration<Project>
    {
        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable(nameof(Project));
            builder.HasKey(project => project.Id);

            builder.Property(project => project.Name).HasMaxLength(250);
            builder.Property(project => project.ShortDescription).HasMaxLength(1500);
            builder.Property(project => project.FullDescription).HasMaxLength(3000);

            base.Configure(builder);
        }
    }
}
