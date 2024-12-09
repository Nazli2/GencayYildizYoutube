using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yorum Satırları ve Region
            // --> bu bir açıklama satırı anlamına gelmektedir.

            #region Yorum Satırları/Açıklama Satırları

            //Açıklama Satırları/Yorum Satırları
            //Kodun niteliğini, anlaşılabilirliğini, kalitesini arttırabilmek için kullanılırlar.
            //Kritik noktalarda ve özet olarak kodları izah etmeliyiz.
            //Tek Satırlık
            /*
             Çok
            Satırlık
            Yorum
            Alanı
             */

            //Nerede kullanılırlar? : İstediğin her yerde yorum yazabilirsin lakin kod konseptini ve semantik akışı bozmaman kaydıyla.

            #endregion

            #region Region

            //Region
            //Kod dosyasını kategorik hale getirmemizi sağlayan bir ön işlemci komutudur. Developer'ın yazmış olduğu kodu daha net görmesini ve kategorize etmesini sağlar.

            #endregion

            #region ToDo

            //todo Burada 1'den 10'a kadar yazılmalıdır.
            //View - Task List'te görünür.

            #endregion

            #region Debugging

            //Debugging kodun akışı esnasında kodu okuyabilmemizi ve gözlemleyebilmemizi sağlamaktadır.
            //Kompleks algoritmalarda zaman alıcıdır.

            //Break Point --> işaretlenen kodun debug edilmesini sağlayan bir teknoloji.
            //Bir uygulama debug modda ayağa kaldırıldığında akış break point'in işaretlediği koda geldiğinde biz kodu debug edebileceğiz.
            //Break point ile debug edilen kodun devam edebilmesi için F10 tuşuna basmalıyız.

            #endregion

            #region Watch Penceresi

            //Bir kodun içerisinde yapılan operasyon esnasında eğer siz bu operasyonu debug ediyorsanız debug edilen operasyonun içerisinde değişken denilen noktalar var bu değişkenlerin ya da değişen değerlerinin daha hızlı, daha net daha düzgün şekilde görebilmek istiyorsanız watch dediğimiz pencereyi kullanabilmekteyiz.

            #endregion
        }
    }
}
