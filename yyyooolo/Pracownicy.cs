//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace yyyooolo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pracownicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pracownicy()
        {
            this.fak_sprze = new HashSet<fak_sprze>();
            this.fak_zak = new HashSet<fak_zak>();
        }
    
        public int id_prac { get; set; }
        public string Imie_prac { get; set; }
        public string Nazwisko_prac { get; set; }
        public string ulica_prac { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Miejscowosc { get; set; }
        public string Wojewodztwo { get; set; }
        public string Stanowisko { get; set; }
        public double Placa_brutto { get; set; }
        public System.DateTime data_dodania { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fak_sprze> fak_sprze { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fak_zak> fak_zak { get; set; }
    }
}