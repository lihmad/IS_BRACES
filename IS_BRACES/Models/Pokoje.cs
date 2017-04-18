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

    // Pokoje
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class Pokoje
    {
        public System.Guid Id { get; set; } // ID (Primary key)
        public System.Guid IdUbytovani { get; set; } // ID_Ubytovani (Primary key)
        public int Kapacita { get; set; } // Kapacita (Primary key)
        public string Popis { get; set; } // Popis

        // Foreign keys

        /// <summary>
        /// Parent Ubytovani pointed by [Pokoje].([IdUbytovani]) (FK_Pokoje_Ubytovani)
        /// </summary>
        public virtual Ubytovani Ubytovani { get; set; } // FK_Pokoje_Ubytovani

        public Pokoje()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
