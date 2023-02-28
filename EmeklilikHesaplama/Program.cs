internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lütfen cinsiyetinizi giriniz : (Erkek : e, Kadın : k)");
        string cinsiyet = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Lütfen sigorta gününüzü giriniz : ");
        int sigortaGunu = Convert.ToInt32(Console.ReadLine());

        EmeklilikZamani(sigortaGunu,cinsiyet);

    }

    public static void EmeklilikZamani(int sigortaGunu,string cinsiyet)
    {
        int emeklilikYasi;
        int kalanGun = 0;
        int kalanYil = 0;
        int kalanAy = 0;


        if (cinsiyet.ToLower() == "e")
        {
            emeklilikYasi = 25 * 360; // Erkekler 25 yıl çalıştıktan sonra emekli olacak
        }
        else if (cinsiyet.ToLower() == "k")
        {
            emeklilikYasi = 20 * 360; // Kadınların 20 yıl çalıştıktan sonra emekli olacak
        }
        else
        {
            Console.WriteLine("Cinsiyet parametresi hatalı girildi.");
            return;
        }

        if (sigortaGunu < emeklilikYasi)
        {
            kalanGun = emeklilikYasi - sigortaGunu; // kişinin emeklilik yaşına kadar kaç gün çalışması gerektiğini hesaplar. 
            kalanYil = kalanGun / 360; // emekli olmasına kaç yıl kaldığını bulabilmek için kalan gün sayısını 360 a böleriz
            kalanAy = (kalanGun % 360) / 30; // kişinin emekli olmasına kaç ay kaldığını bulabilmek için kalan günü 360 a böleriz kalanı da 30 a böleriz
            kalanGun = (kalanGun % 360) % 30; //kişinin emekli olana kadar kaç gün daha çalışması gerekir

            Console.WriteLine("Emekliliğinize {0} yıl {1} ay {2} gün kaldı.", kalanYil, kalanAy, kalanGun);
        }
        else
        {
            Console.WriteLine("Emekli oldunuz.");
        }
    }
}