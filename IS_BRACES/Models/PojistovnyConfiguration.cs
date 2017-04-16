// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace IS_BRACES.Models
{

    // Pojistovny
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class PojistovnyConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pojistovny>
    {
        public PojistovnyConfiguration()
            : this("dbo")
        {
        }

        public PojistovnyConfiguration(string schema)
        {
            ToTable("Pojistovny", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nazev).HasColumnName(@"Nazev").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Kod).HasColumnName(@"Kod").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
