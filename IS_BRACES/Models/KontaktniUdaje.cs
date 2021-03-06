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

    // Kontaktni_udaje
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class KontaktniUdaje
    {
        public System.Guid Id { get; set; } // ID (Primary key)
        public string Email { get; set; } // Email (length: 255)
        public string Telefon { get; set; } // Telefon (length: 20)

        // Reverse navigation

        /// <summary>
        /// Child Zakaznici where [Zakaznici].[ID_Kontaktni_udaje] point to this entity (FK_Zakaznici_Kontaktni_udaje)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Zakaznici> Zakaznici { get; set; } // Zakaznici.FK_Zakaznici_Kontaktni_udaje

        public KontaktniUdaje()
        {
            Id = System.Guid.NewGuid();
            Zakaznici = new System.Collections.Generic.List<Zakaznici>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
