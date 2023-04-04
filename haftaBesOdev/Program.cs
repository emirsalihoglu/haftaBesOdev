using System.Collections;
using System.Drawing;
using System.Security.Cryptography;

namespace haftaBesOdev
{
    class Fatura
    {
        string MusteriTC;
        string AdSoyad;
        string Adres;
        string Il;
        string Ilce;
        ArrayList KullaniciSiparisleri = new ArrayList();
        ArrayList Faturalar = new ArrayList();
        string PostaKodu;

        public Fatura(string MusteriTc, string AdSoyad, string Adres, string Il, string Ilce)
        {
            this.MusteriTC = MusteriTc;
            this.AdSoyad = AdSoyad;
            this.Adres = Adres;
            this.Il = Il;
            this.Ilce = Ilce;
        }

        public Fatura(string MusteriTc, string AdSoyad, string Adres, string Il, string Ilce, string PostaKodu)
        {
            this.MusteriTC = MusteriTc;
            this.AdSoyad = AdSoyad;
            this.Adres = Adres;
            this.Il = Il;
            this.Ilce = Ilce;
            this.PostaKodu = PostaKodu;
        }

        void getMusteriTC()
        {
            Console.WriteLine(MusteriTC);
        }

        void setMusteriTC(string MusteriTC)
        {
            this.MusteriTC = MusteriTC;
        }

        void getAdSoyad()
        {
            Console.WriteLine(AdSoyad);
        }

        void setAdSoyad(string AdSoyad)
        {
            this.AdSoyad = AdSoyad;
        }

        void getAdres()
        {
            Console.WriteLine(Adres);
        }

        void setAdres(string Adres)
        {
            this.Adres = Adres;
        }

        void getIl()
        {
            Console.WriteLine(Il); ;
        }

        void setIl(string Il)
        {
            this.Il = Il;
        }

        void getIlce()
        {
            ;
        }

        void setIlce(string Ilce)
        {
            this.Ilce = Ilce;
        }

        void getPostaKodu()
        {
            Console.WriteLine(PostaKodu);
        }

        void setPostaKodu(string PostaKodu)
        {
            this.PostaKodu = PostaKodu;
        }




        void SiparisEkle(string urunKodu)
        {
            KullaniciSiparisleri.Add(urunKodu);
        }

        void faturaOlustur(string urunKodu)
        {
            bool bos = false;
            foreach (var i in KullaniciSiparisleri)
            {
                if (i == urunKodu)
                {
                    bos = true;
                }

            }
            if (bos)
            {
                Faturalar.Add(MusteriTC + "\n" + AdSoyad + "\n" + Adres + "\n" + Il + "\n" + Ilce + "\n" + PostaKodu + "\n" + urunKodu);
                Console.WriteLine(MusteriTC + "\n" + AdSoyad + "\n" + Adres + "\n" + Il + "\n" + Ilce + "\n" + PostaKodu + "\n" + urunKodu);
            }
            else
            {
                Console.WriteLine("Oluşturulamadı.");
            }
        }

        void getFatura()
        {
            foreach (var i in Faturalar)
            {
                Console.WriteLine(i);
            }
        }






        static void Main(string[] args)
        {
            Fatura f1 = new Fatura("10000000146", "Mustafa Kemal Atatürk", "Anıtkabir", "Ankara", "Çankaya", "06530");
            f1.SiparisEkle("125");
            f1.SiparisEkle("61");
            f1.faturaOlustur("120");
            f1.faturaOlustur("125");
            f1.getFatura();
        }


    }
}