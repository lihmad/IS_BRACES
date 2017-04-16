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

    // Pojisteni
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class Pojisteni
    {
        public System.Guid Id { get; set; } // ID (Primary key)
        public System.Guid IdPojistovna { get; set; } // ID_Pojistovna
        public decimal Cena { get; set; } // Cena
        public string Typ { get; set; } // Typ (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child Rezervace where [Rezervace].[ID_Pojisteni] point to this entity (FK_Rezervace_Pojisteni)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Rezervace> Rezervace { get; set; } // Rezervace.FK_Rezervace_Pojisteni

        // Foreign keys

        /// <summary>
        /// Parent Pojistovny pointed by [Pojisteni].([IdPojistovna]) (FK_Pojisteni_Pojistovny)
        /// </summary>
        public virtual Pojistovny Pojistovny { get; set; } // FK_Pojisteni_Pojistovny

        public Pojisteni()
        {
            Id = System.Guid.NewGuid();
            Rezervace = new System.Collections.Generic.List<Rezervace>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
