using System;
using System.Collections;
using System.Collections.Generic;
namespace ToDo
{
    public static class listele{
        public static void hepsini_listele(board degisken){
            System.Console.WriteLine("TODO Line");
            System.Console.WriteLine("*********************");
            if(degisken.todo.Count==0){
                System.Console.WriteLine("~BOŞ~");
            }
            else{
                foreach(var s in degisken.todo){
                    System.Console.WriteLine("Başlık        : "+s.baslik);
                    System.Console.WriteLine("İçerik        : "+s.icerik);
                    System.Console.WriteLine("Atanan Kişi   : "+s.atanan_kisi);
                    System.Console.WriteLine("Büyüklük      : "+s.buyukluk);
                    System.Console.WriteLine("-");       
                }
            }
            System.Console.WriteLine("\n\n\n");
            System.Console.WriteLine("IN PROGRESS Line");
            System.Console.WriteLine("*********************");
            if(degisken.inprogress.Count==0){
                System.Console.WriteLine("~BOŞ~");
            }
            else{
                foreach(var s in degisken.inprogress){
                    System.Console.WriteLine("Başlık        : "+s.baslik);
                    System.Console.WriteLine("İçerik        : "+s.icerik);
                    System.Console.WriteLine("Atanan Kişi   : "+s.atanan_kisi);
                    System.Console.WriteLine("Büyüklük      : "+s.buyukluk);
                    System.Console.WriteLine("-");       
                }

            }

            System.Console.WriteLine("\n\n\n");
            System.Console.WriteLine("DONE Line");
            System.Console.WriteLine("*********************");
            if(degisken.done.Count==0){
                System.Console.WriteLine("~BOŞ~");
            }
            else{
                foreach(var s in degisken.done){
                    System.Console.WriteLine("Başlık        : "+s.baslik);
                    System.Console.WriteLine("İçerik        : "+s.icerik);
                    System.Console.WriteLine("Atanan Kişi   : "+s.atanan_kisi);
                    System.Console.WriteLine("Büyüklük      : "+s.buyukluk);
                    System.Console.WriteLine("-");       
                }

            }

        }
    }
    
}