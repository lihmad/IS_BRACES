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

    // Adresa
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class Adresa
    {
        public System.Guid Id { get; set; } // ID (Primary key)
        public string Ulice { get; set; } // Ulice (length: 255)
        public string Mesto { get; set; } // Mesto (length: 255)
        public string Psc { get; set; } // PSC (length: 6)
        public string Cp { get; set; } // CP (length: 10)

        // Reverse navigation

        /// <summary>
        /// Child Ubytovani where [Ubytovani].[ID_Adresa] point to this entity (FK_Ubytovani_Adresa)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Ubytovani> Ubytovani { get; set; } // Ubytovani.FK_Ubytovani_Adresa
        /// <summary>
        /// Child Zakaznici where [Zakaznici].[ID_Bydliste] point to this entity (FK_Zakaznici_Adresa)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Zakaznici> Zakaznici { get; set; } // Zakaznici.FK_Zakaznici_Adresa

        public Adresa()
        {
            Id = System.Guid.NewGuid();
            Ubytovani = new System.Collections.Generic.List<Ubytovani>();
            Zakaznici = new System.Collections.Generic.List<Zakaznici>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
