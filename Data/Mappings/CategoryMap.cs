using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Tabela
            builder.ToTable("Category");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd() // Toda vez que for adicionado o item, o valor será gerado
                .UseIdentityColumn(); // PRIMARY KEY IDENTITY(1, 1)

            // Propriedades
            builder.Property(x => x.Name)
                .IsRequired() // NOT NULL
                .HasColumnName("Name") // Nome da coluna
                .HasColumnType("NVARCHAR") // Tipo do campo
                .HasMaxLength(80); // Tamanho do campo

            builder.Property(x => x.Slug)
                .IsRequired()
                .HasColumnName("Slug")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);
            
            // Índices
            builder.HasIndex(x => x.Slug, "IX_Category_Slug")
                .IsUnique(); // Transforma o índice único, não pode criar duas categorias com o mesmo índice no banco
        }
    }
}