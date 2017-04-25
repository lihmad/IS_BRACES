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

    // VazT_Zajezd_TypZajezdu
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class VazTZajezdTypZajezduConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VazTZajezdTypZajezdu>
    {
        public VazTZajezdTypZajezduConfiguration()
            : this("dbo")
        {
        }

        public VazTZajezdTypZajezduConfiguration(string schema)
        {
            ToTable("VazT_Zajezd_TypZajezdu", schema);
            HasKey(x => new { x.Id, x.IdZajezdy, x.IdTypZajezdu });

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdZajezdy).HasColumnName(@"ID_Zajezdy").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTypZajezdu).HasColumnName(@"ID_Typ_zajezdu").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TypZajezdu).WithMany(b => b.VazTZajezdTypZajezdu).HasForeignKey(c => c.IdTypZajezdu).WillCascadeOnDelete(false); // FK_VazT_Zajezd_TypZajezdu_Typ_zajezdu
            HasRequired(a => a.Zajezdy).WithMany(b => b.VazTZajezdTypZajezdu).HasForeignKey(c => c.IdZajezdy).WillCascadeOnDelete(false); // FK_VazT_Zajezd_TypZajezdu_Zajezdy
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>