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

    // Typ_zajezdu
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class TypZajezduConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TypZajezdu>
    {
        public TypZajezduConfiguration()
            : this("dbo")
        {
        }

        public TypZajezduConfiguration(string schema)
        {
            ToTable("Typ_zajezdu", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Popis).HasColumnName(@"Popis").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
