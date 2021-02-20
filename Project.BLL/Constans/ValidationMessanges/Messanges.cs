using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Constans.ValidationMessanges
{
    public static class Messanges
    {
        public static string ProductNameAndPriceInvalid = "Urun ismi ve fiyat bilgisi boş geçilemez. Fiyat 0 ve 0 dan kücük olamaz";
        public static string Updated = "Güncellendi.";
        public static string Added = "Eklendi.";
        public static string Deleted = "Silindi.";
        public static string Listed = "Listelendi.";
        public static string MaintenanceTime = "Site bakımdadır.";


        //Kategori ye ozel mesaj vermek ıstersek bu sekılde verebılırız.
        public static string CategoryName = "Kategori ismi boş geçilemez.";
        public static string CategoryAdded = "Kategori eklendi";
        public static string DeletedKategori = "Silindi.";
        public static string ListedKategori = "Listelendi.";

    }
}
