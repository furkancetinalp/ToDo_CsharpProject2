using System;
using System.Collections;
using System.Collections.Generic;
namespace ToDo
{
    public static class kart_guncelle
    {
        public static void guncelle(board degisken){
            System.Console.WriteLine("Öncelikle taşımak istediğiniz kartın ismini girmeniz gerekiyor.");
            System.Console.Write(" Lütfen kart başlığını yazınız: ");
            string cevap = Console.ReadLine();
            int index=0;
            for(int i=0;i<degisken.todo.Count;i++){
                        if(cevap==degisken.todo[i].baslik){
                            index=1;
                            card kart = new card();
                            System.Console.Write("Yeni ismi yazınız: ");
                            string isim = Console.ReadLine();
                            kart.baslik=isim;
                            kart.icerik=degisken.todo[i].icerik;
                            kart.atanan_kisi=degisken.todo[i].atanan_kisi;
                            kart.buyukluk=degisken.todo[i].buyukluk;

                            degisken.todo.Remove(degisken.todo[i]);

                            degisken.todo.Add(kart);
                            System.Console.WriteLine("İsim değiştirme işlemi başarıyla tamamlandı.");
                            break;

                        }
            }
            if(index!=1){
                for(int i=0;i<degisken.inprogress.Count;i++){

                    if(cevap==degisken.inprogress[i].baslik){
                        index=1;
                        card kart = new card();
                        System.Console.Write("Yeni ismi yazınız: ");
                        string isim = Console.ReadLine();
                        kart.baslik=isim;
                        kart.icerik=degisken.inprogress[i].icerik;
                        kart.atanan_kisi=degisken.inprogress[i].atanan_kisi;
                        kart.buyukluk=degisken.inprogress[i].buyukluk;

                        degisken.inprogress.Remove(degisken.inprogress[i]);

                        degisken.inprogress.Add(kart);
                        System.Console.WriteLine("İsim değiştirme işlemi başarıyla tamamlandı.");
                        break;

                    }
                }
            }
            if(index!=1){
                for(int i=0;i<degisken.done.Count;i++){
                    if(cevap==degisken.done[i].baslik){
                        index=1;
                        card kart = new card();
                        System.Console.Write("Yeni ismi yazınız: ");
                        string isim = Console.ReadLine();
                        kart.baslik=isim;
                        kart.icerik=degisken.done[i].icerik;
                        kart.atanan_kisi=degisken.done[i].atanan_kisi;
                        kart.buyukluk=degisken.done[i].buyukluk;

                        degisken.done.Remove(degisken.done[i]);

                        degisken.done.Add(kart);
                        System.Console.WriteLine("İsim değiştirme işlemi başarıyla tamamlandı.");
                        break;

                    }
                }
            }
            if(index==0){
                System.Console.WriteLine("{0} adında bir kart bulunmamaktadır!!!!!",cevap);
            }

        }
    }

}