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

    // VazT_Zakaznik_Zajezd
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class VazTZakaznikZajezdConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VazTZakaznikZajezd>
    {
        public VazTZakaznikZajezdConfiguration()
            : this("dbo")
        {
        }

        public VazTZakaznikZajezdConfiguration(string schema)
        {
            ToTable("VazT_Zakaznik_Zajezd", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdZakaznik).HasColumnName(@"ID_Zakaznik").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.IdZajezd).HasColumnName(@"ID_Zajezd").HasColumnType("uniqueidentifier").IsRequired();

            // Foreign keys
            HasRequired(a => a.Zajezdy).WithMany(b => b.VazTZakaznikZajezd).HasForeignKey(c => c.IdZajezd).WillCascadeOnDelete(false); // FK_VazT_Zakaznik_Zajezd_Zajezdy
            HasRequired(a => a.Zakaznici).WithMany(b => b.VazTZakaznikZajezd).HasForeignKey(c => c.IdZakaznik).WillCascadeOnDelete(false); // FK_VazT_Zakaznik_Zajezd_Zakaznici
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
