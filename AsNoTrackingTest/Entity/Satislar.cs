using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsNoTrackingTest.Entity
{
    public class Satislar
    {
        [Key]
        public int? SatisID { get; set; }
        public char? MusteriID { get; set; }
        public int? PersonelID { get; set; }
        public DateTime? SatisTarihi { get; set; }
        public DateTime? SevkTarihi { get; set; }
        public DateTime? OdemeTarihi { get; set; }
        public int? ShipVia { get; set; }
        public decimal? NakliyeUcreti { get; set; }

        public string? SevkAdi { get; set; }
        public string? SevkAdresi { get; set; }
        public string? SevkSehri { get; set; }
        public string? SevkBolgesi { get; set; }
        public string? SevkPostaKodu { get; set; }
        public string? SevkUlkesi { get; set; }


    }
}
