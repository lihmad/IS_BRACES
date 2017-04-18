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

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public partial class DB_Model : System.Data.Entity.DbContext, IDB_Model
    {
        public System.Data.Entity.DbSet<Adresa> Adresa { get; set; } // Adresa
        public System.Data.Entity.DbSet<Destinace> Destinace { get; set; } // Destinace
        public System.Data.Entity.DbSet<Doprava> Doprava { get; set; } // Doprava
        public System.Data.Entity.DbSet<Kategorie> Kategorie { get; set; } // Kategorie
        public System.Data.Entity.DbSet<KontaktniUdaje> KontaktniUdaje { get; set; } // Kontaktni_udaje
        public System.Data.Entity.DbSet<Pojisteni> Pojisteni { get; set; } // Pojisteni
        public System.Data.Entity.DbSet<Pojistovny> Pojistovny { get; set; } // Pojistovny
        public System.Data.Entity.DbSet<Pokoje> Pokoje { get; set; } // Pokoje
        public System.Data.Entity.DbSet<Prilohy> Prilohy { get; set; } // Prilohy
        public System.Data.Entity.DbSet<Rezervace> Rezervace { get; set; } // Rezervace
        public System.Data.Entity.DbSet<Stravovani> Stravovani { get; set; } // Stravovani
        public System.Data.Entity.DbSet<sys_DatabaseFirewallRules> sys_DatabaseFirewallRules { get; set; } // database_firewall_rules
        public System.Data.Entity.DbSet<TypUbytovani> TypUbytovani { get; set; } // Typ_ubytovani
        public System.Data.Entity.DbSet<TypZajezdu> TypZajezdu { get; set; } // Typ_zajezdu
        public System.Data.Entity.DbSet<Ubytovani> Ubytovani { get; set; } // Ubytovani
        public System.Data.Entity.DbSet<VazTZajezdTypZajezdu> VazTZajezdTypZajezdu { get; set; } // VazT_Zajezd_TypZajezdu
        public System.Data.Entity.DbSet<VazTZakaznikZajezd> VazTZakaznikZajezd { get; set; } // VazT_Zakaznik_Zajezd
        public System.Data.Entity.DbSet<Zajezdy> Zajezdy { get; set; } // Zajezdy
        public System.Data.Entity.DbSet<Zakaznici> Zakaznici { get; set; } // Zakaznici

        static DB_Model()
        {
            System.Data.Entity.Database.SetInitializer<DB_Model>(null);
            //DB_ModelStaticPartial(); // Create the following method in your partial class: private static void DB_ModelStaticPartial() { }
        }

        public DB_Model()
            : base("Name=DB")
        {
            InitializePartial();
        }

        public DB_Model(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public DB_Model(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public DB_Model(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public DB_Model(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AdresaConfiguration());
            modelBuilder.Configurations.Add(new DestinaceConfiguration());
            modelBuilder.Configurations.Add(new DopravaConfiguration());
            modelBuilder.Configurations.Add(new KategorieConfiguration());
            modelBuilder.Configurations.Add(new KontaktniUdajeConfiguration());
            modelBuilder.Configurations.Add(new PojisteniConfiguration());
            modelBuilder.Configurations.Add(new PojistovnyConfiguration());
            modelBuilder.Configurations.Add(new PokojeConfiguration());
            modelBuilder.Configurations.Add(new PrilohyConfiguration());
            modelBuilder.Configurations.Add(new RezervaceConfiguration());
            modelBuilder.Configurations.Add(new StravovaniConfiguration());
            modelBuilder.Configurations.Add(new sys_DatabaseFirewallRulesConfiguration());
            modelBuilder.Configurations.Add(new TypUbytovaniConfiguration());
            modelBuilder.Configurations.Add(new TypZajezduConfiguration());
            modelBuilder.Configurations.Add(new UbytovaniConfiguration());
            modelBuilder.Configurations.Add(new VazTZajezdTypZajezduConfiguration());
            modelBuilder.Configurations.Add(new VazTZakaznikZajezdConfiguration());
            modelBuilder.Configurations.Add(new ZajezdyConfiguration());
            modelBuilder.Configurations.Add(new ZakazniciConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AdresaConfiguration(schema));
            modelBuilder.Configurations.Add(new DestinaceConfiguration(schema));
            modelBuilder.Configurations.Add(new DopravaConfiguration(schema));
            modelBuilder.Configurations.Add(new KategorieConfiguration(schema));
            modelBuilder.Configurations.Add(new KontaktniUdajeConfiguration(schema));
            modelBuilder.Configurations.Add(new PojisteniConfiguration(schema));
            modelBuilder.Configurations.Add(new PojistovnyConfiguration(schema));
            modelBuilder.Configurations.Add(new PokojeConfiguration(schema));
            modelBuilder.Configurations.Add(new PrilohyConfiguration(schema));
            modelBuilder.Configurations.Add(new RezervaceConfiguration(schema));
            modelBuilder.Configurations.Add(new StravovaniConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_DatabaseFirewallRulesConfiguration(schema));
            modelBuilder.Configurations.Add(new TypUbytovaniConfiguration(schema));
            modelBuilder.Configurations.Add(new TypZajezduConfiguration(schema));
            modelBuilder.Configurations.Add(new UbytovaniConfiguration(schema));
            modelBuilder.Configurations.Add(new VazTZajezdTypZajezduConfiguration(schema));
            modelBuilder.Configurations.Add(new VazTZakaznikZajezdConfiguration(schema));
            modelBuilder.Configurations.Add(new ZajezdyConfiguration(schema));
            modelBuilder.Configurations.Add(new ZakazniciConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);
    }
}
// </auto-generated>
