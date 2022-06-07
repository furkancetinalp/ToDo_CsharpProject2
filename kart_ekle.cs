using System;
using System.Collections;
using System.Collections.Generic;
namespace ToDo
{
    public static class kart_ekle{
        public static void ekle(board degisken,Dictionary<string,int> uye){
            string _stringbuyukluk="";
            System.Console.Write("Başlık Giriniz                                   :");
            string _baslik = Console.ReadLine();

            System.Console.Write("İçerik Giriniz                                   :");
            string _icerik = Console.ReadLine();

            System.Console.Write("Büyüklük Seçiniz => XS(1),S(2),M(3),L(4),XL(5)   :");
            int _buyukluk = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Kişi Seçiniz                                     :");
            string _kisi = Console.ReadLine();

            if(_buyukluk==(int)buyuklukler.XS){
                _stringbuyukluk=buyuklukler.XS.ToString();
            }
            else if(_buyukluk==(int)buyuklukler.S){
                _stringbuyukluk=buyuklukler.S.ToString();
            }
            else if(_buyukluk==(int)buyuklukler.M){
                _stringbuyukluk=buyuklukler.M.ToString();
            }
            else if(_buyukluk==(int)buyuklukler.L){
                _stringbuyukluk=buyuklukler.L.ToString();
            }
            else if(_buyukluk==(int)buyuklukler.XL){
                _stringbuyukluk=buyuklukler.XL.ToString();
            }
            else{
                System.Console.WriteLine("Hatalı büyüklük değeri girildi!!");
            }


            if(!uye.ContainsKey(_kisi)){
                System.Console.WriteLine("Hatalı girişler yaptınız. {0} adında bir üye yoktur!!",_kisi);
            }
            else{
                card yeni = new card();
                yeni.baslik=_baslik;
                yeni.icerik=_icerik;
                yeni.buyukluk=_stringbuyukluk;
                yeni.atanan_kisi=uye[_kisi];
                System.Console.WriteLine("Hangi klona eklenecek? TODO(1) , IN PROGRESS(2) , DONE(3)");
                int cevap = Convert.ToInt32(Console.ReadLine());
                if(cevap==1){
                    degisken.todo.Add(yeni);
                }
                else if(cevap==2){
                    degisken.inprogress.Add(yeni);
                }
                else{
                    degisken.done.Add(yeni);
                }

                System.Console.WriteLine("Ekleme işlemi başarıyla tamamlandı.");

            }




            


        }
    }

}