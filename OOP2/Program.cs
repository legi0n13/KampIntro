using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "1234567890";
            musteri1.Id = 1;


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri(Şirket)
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //Müşteri classı hem gerçek müşterinin hem tüzel müşterinin referansını tutabiliyor.

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);


        }
    }
}
// Musteri musteri1 = new Musteri();
//musteri1.Adi = "Engin";
//musteri1.Soyadi = "Demiroğ";
//musteri1.Id = 1;
//musteri1.TcNo = "222222222";
//musteri1.MusteriNo = "12345";
//musteri1.SirketAdi = "?";
