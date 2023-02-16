
Ogrenci ogrenci = new Ogrenci();
ogrenci.Isim = "Ayşe";
ogrenci.Soyadi = "Yılmaz";
ogrenci.OgrenciNo = 293;
ogrenci.Sinif = 3;

ogrenci.SinifAtlat();
ogrenci.OgrenciBilgileriniGetir();

Ogrenci ogrenci2 = new Ogrenci();
ogrenci2.Isim = "Yeşim";
ogrenci2.Soyadi = "Çetintaş";
ogrenci2.OgrenciNo = 17035;
ogrenci2.Sinif = 1;

ogrenci2.SinifDusur();
ogrenci2.OgrenciBilgileriniGetir();



class Ogrenci
{
    private string isim;
    private string soyadi;
    private int ogrenciNo;
    private int sinif;
    

    public string Isim {
        get {return isim;} 
        set { isim = value;} 
    }

    public string Soyadi { get => soyadi; set => soyadi = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif { 
        get => sinif; 
        set {
            if(value<1){
                Console.WriteLine("Sınıf en az 1 olmalıdır");
                sinif=1;
            }else
                sinif=value;
        }
    }

    public Ogrenci(string isim, string soyadi, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyadi = soyadi;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public Ogrenci(){
        
    }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("Öğrenci Adı:{0}",this.Isim);
        Console.WriteLine("Öğrenci Soyadı:{0}",this.Soyadi);
        Console.WriteLine("Öğrenci No:{0}",this.OgrenciNo);
        Console.WriteLine("Öğrenci Sınıfı:{0}", this.Sinif);
    }

    public void SinifAtlat(){
        this.Sinif = this.Sinif + 1;
    }

    public void SinifDusur(){
        this.Sinif = this.Sinif - 1;
    }
}
