using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uygulamalarda Program.cs dosyasi baslangic kodlarinin bulunduğu yani uygulamanın ayağa kalkabilmesi için başlangıç kodlarının bulunduğu bir dosyadır.
            //.cs --> C#
            // Başlangıç kodlarından kastımız nedir? Uygulama ayağa kalktığında işletim sistemiyle iletişim kurabilecek metodun ve bu metot içerisinde başlangıca dair komutları barındıracak inşaa...
            /* Main fonksiyonu bir uygulamanın işletim sistemiyle ilişkisini sağlayan bir fonksiyondur.
             Main Fonksiyonu Kuralları
            - Herhangi bir uygulama olsada bu main foksiyonunda sade ve sadece 1 adet olmak zorundadır.
            - Main fonksiyonu, uygulamada Program.cs dosyası içerisinde Main isminde bulunur.
            - İşte bu fonksiyon işletim sistemiyle iletişim kurar.(Bu uygulama adına.) Yani, bu fonksiyon uygulama ilk ayağa kalktığında ilk tetiklenen fonksiyondur. Dolayısıyla ilk kodlarımızı bu fonksiyonda yazarız.
             */
            /*Top Level Statements --> Sıradan bir işlem içib bile oluşturulan console uygulamasında hiç yoktan basmakalıp(boilerplace) kodların gelmesi gerekmektedir. Günlük hayatta basit kodlar inşa edebilmek ve test süreçlerinde hızlı denemeler yapabilmek için bu tarz bir kod bloğuna maruz kalmamıza sizce gerek var mı?
             
            C# 9.0 ile gelen top level statements özelliği ile main fonksiyonunun zoraki imzasının tanımlanması kaldırılmıştır.
            Main fonksiyonun kullanılması developerın kararına bağlıdır.

            Normalde C# 9.0'dan önce bu kod derlenmeyecekti.Çünkü böyle bir syntax bulunmamaktaydı. Lakin C# 9.0 ile top level statements özelliği bizlere bu şekilde bir kod inşa etmemmizi sağlamaktadır.
            
            Kurallar;
            1.using blokları ile namespace arasında kodlar yazılabilir.
            2.bu işlem sade ve sadece program.cs dosyasında geçerlidir.Yani main fonksiyonunda yazılacak komutların direkt burada yazılmasına müsaade edilmek lakin farklı bir dosyada bu işlemi gerçekleştirememekteyiz.

            Uygulama derlenirken, Program.cs dosyasında varsa top level state. özelliği bu dosyaya özel algılayacak ve ilgili alana yazılan kodları main içerisinde yorumlayacaktır. Bunun dışında zaten bu özelliği başka bir dosyada kullanamayacağımızdan dolayı sadece Program.cs dosyasına has bir özelliktir.

            Top level statements, genellikle microservices yapılanmasında kodun gelişimi açısından hız kazandırıcı bir niteliğe sahiptir.

             */
        }
    }
}
