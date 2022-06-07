using System;
using System.Collections;
using System.Collections.Generic;
namespace ToDo
{
    public static class kart_sil{
        public static void sil(board degisken){
            while (true){
                System.Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                System.Console.Write(" Lütfen kart başlığını yazınız: ");
                string cevap = Console.ReadLine();
                int index=0;
                for(int i=0;i<degisken.todo.Count;i++){
                    if(cevap==degisken.todo[i].baslik){
                        index=1;
                        degisken.todo.Remove(degisken.todo[i]);
                        System.Console.WriteLine("Silme işlemi başarıyla tamamlandı");
                    }
                }
                for(int i=0;i<degisken.inprogress.Count;i++){
                    if(cevap==degisken.inprogress[i].baslik){
                        index=1;
                        degisken.inprogress.Remove(degisken.inprogress[i]);
                        System.Console.WriteLine("Silme işlemi başarıyla tamamlandı");

                    }
                }
                for(int i=0;i<degisken.done.Count;i++){
                    if(cevap==degisken.done[i].baslik){
                        index=1;
                        degisken.done.Remove(degisken.done[i]);
                        System.Console.WriteLine("Silme işlemi başarıyla tamamlandı");

                    }
                }
                if(index==1){
                    break;
                }
                if(index==0){
                    System.Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    System.Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                    System.Console.WriteLine("Yeniden denemek için : (2)");
                    int secenek=Convert.ToInt32(Console.ReadLine());
                    if(secenek==1){
                        break;
                    }
                }
            }       
        }
    }

}