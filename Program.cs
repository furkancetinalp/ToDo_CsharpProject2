using System;
using System.Collections;
using System.Collections.Generic;
namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            //BOARD OLUŞTURMA
            board board1 = new board();

            //ÜYELER OLUŞTURMA VE ÜYE ATAMA
            Dictionary<string,int> uyeler = new Dictionary<string, int>();
            uyeler.Add("uye1",18);
            uyeler.Add("uye2",20);
            uyeler.Add("uye3",22);
            uyeler.Add("uye4",24);
            uyeler.Add("uye5",26);
            uyeler.Add("uye6",27);

            //3 ADET KART OLUŞTURMA
            card kart1= new card(); //OLUŞTURULAN KART BURADA!!!!!!!!!
            kart1.baslik = "Başlık1";
            kart1.icerik = "İçerik1";
            kart1.atanan_kisi=uyeler["uye1"];
            kart1.buyukluk="XS";

            card kart2= new card();
            kart2.baslik = "Başlık2";
            kart2.icerik = "İçerik2";
            kart2.atanan_kisi=uyeler["uye2"];
            kart2.buyukluk="M";


            card kart3= new card();
            kart3.baslik = "Başlık3";
            kart3.icerik = "İçerik3";
            kart3.atanan_kisi=uyeler["uye3"];
            kart3.buyukluk="S";


            //OLUŞTURULAN KARTLARIN TODO'YA ATANMASI
            board1.todo.Add(kart1);
            board1.todo.Add(kart2);
            board1.todo.Add(kart3);

            while (true){
                System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
                System.Console.WriteLine("******************************************");
                System.Console.WriteLine("(1) Board Listelemek");
                System.Console.WriteLine("(2) Board'a Kart Eklemek");
                System.Console.WriteLine("(3) Board'dan Kart Silmek");
                System.Console.WriteLine("(4) Kart Taşımak");
                System.Console.WriteLine("(5) Kart ismi güncellemek");
                System.Console.WriteLine("(0) Programdan çıkmak");
                string cevap= Console.ReadLine();
                if(cevap=="0"){
                    System.Console.WriteLine("Programdan çıkış yapıldı!");
                    break;
                }
                if(cevap=="1"){
                    listele.hepsini_listele(board1);
                }
                else if(cevap=="2"){
                    kart_ekle.ekle(board1,uyeler);
                }
                else if(cevap=="3"){
                    kart_sil.sil(board1);
                }
                else if(cevap=="4"){
                    kart_tasi.tasi(board1);

                }
                else if(cevap=="5"){
                    kart_guncelle.guncelle(board1);
                }
                else{
                    System.Console.WriteLine("Hatalı deneme! Lütfen geçerli komutlardan birini yazınız");
                }
            }

        }
    }
}
