using System;
using System.Collections;
using System.Collections.Generic;
namespace ToDo
{
    public static class kart_tasi{
        public static void tasi(board degisken){
            while (true){
                System.Console.WriteLine("Öncelikle taşımak istediğiniz kartın ismini girmeniz gerekiyor.");
                System.Console.Write(" Lütfen kart başlığını yazınız: ");
                string cevap = Console.ReadLine();
                int index=0;

                //TODO İÇİN
                for(int i=0;i<degisken.todo.Count;i++){
                        if(cevap==degisken.todo[i].baslik){
                            index=1;
                            System.Console.WriteLine("Bulunan Kart Bilgileri:");
                            System.Console.WriteLine("*********************************");
                            System.Console.WriteLine("Başlık        :"+degisken.todo[i].baslik);
                            System.Console.WriteLine("İçerik        :"+degisken.todo[i].icerik);
                            System.Console.WriteLine("Atanan Kişi   :"+degisken.todo[i].atanan_kisi);
                            System.Console.WriteLine("Büyüklük      :"+degisken.todo[i].buyukluk);
                            System.Console.WriteLine("Line           :TODO");


                            System.Console.WriteLine("\n");
                            System.Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                            System.Console.WriteLine("(1) TODO");
                            System.Console.WriteLine("(2) IN PROGRESS");
                            System.Console.WriteLine("(3) DONE");
                            int yeni_line = Convert.ToInt32(Console.ReadLine());
                            if(yeni_line!=2 && yeni_line!=3 ){
                                System.Console.WriteLine("Hatalı bir seçim yaptınız!");
                                break;
                            }
                            card eklenecek = new card();
                            eklenecek.baslik=degisken.todo[i].baslik;
                            eklenecek.icerik=degisken.todo[i].icerik;
                            eklenecek.atanan_kisi=degisken.todo[i].atanan_kisi;
                            eklenecek.buyukluk=degisken.todo[i].buyukluk;

                            degisken.todo.Remove(degisken.todo[i]);
                            if(yeni_line==2){
                                degisken.inprogress.Add(eklenecek);
                                System.Console.WriteLine("Kart değiştirme işlemi başarıyla tamamlandı.");
                                break;
                            }
                            else if(yeni_line==3){
                                degisken.done.Add(eklenecek);
                                System.Console.WriteLine("Kart değiştirme işlemi başarıyla tamamlandı.");
                                break;
                            }
                        }
                }
                if(index==1){
                    break;
                }

                //IN PROGRESS İÇİN
                for(int i=0;i<degisken.inprogress.Count;i++){
                        if(cevap==degisken.inprogress[i].baslik){
                            index=1;
                            System.Console.WriteLine("Bulunan Kart Bilgileri:");
                            System.Console.WriteLine("*********************************");
                            System.Console.WriteLine("Başlık        :"+degisken.inprogress[i].baslik);
                            System.Console.WriteLine("İçerik        :"+degisken.inprogress[i].icerik);
                            System.Console.WriteLine("Atanan Kişi   :"+degisken.inprogress[i].atanan_kisi);
                            System.Console.WriteLine("Büyüklük      :"+degisken.inprogress[i].buyukluk);
                            System.Console.WriteLine("Line           :IN PROGRESS");


                            System.Console.WriteLine("\n");
                            System.Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                            System.Console.WriteLine("(1) TODO");
                            System.Console.WriteLine("(2) IN PROGRESS");
                            System.Console.WriteLine("(3) DONE");
                            int yeni_line = Convert.ToInt32(Console.ReadLine());
                            if(yeni_line!=1 && yeni_line!=3 ){
                                System.Console.WriteLine("Hatalı bir seçim yaptınız!");
                                break;
                            }
                            card eklenecek = new card();
                            eklenecek.baslik=degisken.inprogress[i].baslik;
                            eklenecek.icerik=degisken.inprogress[i].icerik;
                            eklenecek.atanan_kisi=degisken.inprogress[i].atanan_kisi;
                            eklenecek.buyukluk=degisken.inprogress[i].buyukluk;

                            degisken.inprogress.Remove(degisken.inprogress[i]);
                            if(yeni_line==1){
                                degisken.todo.Add(eklenecek);
                                System.Console.WriteLine("Kart değiştirme işlemi başarıyla tamamlandı.");
                                break;
                            }
                            else if(yeni_line==3){
                                degisken.done.Add(eklenecek);
                                System.Console.WriteLine("Kart değiştirme işlemi başarıyla tamamlandı.");
                                break;
                            }
                        }
                }
                if(index==1){
                    break;
                }

                //DONE İÇİN
                for(int i=0;i<degisken.done.Count;i++){
                        if(cevap==degisken.done[i].baslik){
                            index=1;
                            System.Console.WriteLine("Bulunan Kart Bilgileri:");
                            System.Console.WriteLine("*********************************");
                            System.Console.WriteLine("Başlık        :"+degisken.done[i].baslik);
                            System.Console.WriteLine("İçerik        :"+degisken.done[i].icerik);
                            System.Console.WriteLine("Atanan Kişi   :"+degisken.done[i].atanan_kisi);
                            System.Console.WriteLine("Büyüklük      :"+degisken.done[i].buyukluk);
                            System.Console.WriteLine("Line           :DONE");


                            System.Console.WriteLine("\n");
                            System.Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                            System.Console.WriteLine("(1) TODO");
                            System.Console.WriteLine("(2) IN PROGRESS");
                            System.Console.WriteLine("(3) DONE");
                            int yeni_line = Convert.ToInt32(Console.ReadLine());
                            if(yeni_line!=1 && yeni_line!=2 ){
                                System.Console.WriteLine("Hatalı bir seçim yaptınız!");
                                break;
                            }
                            card eklenecek = new card();
                            eklenecek.baslik=degisken.done[i].baslik;
                            eklenecek.icerik=degisken.done[i].icerik;
                            eklenecek.atanan_kisi=degisken.done[i].atanan_kisi;
                            eklenecek.buyukluk=degisken.done[i].buyukluk;

                            degisken.done.Remove(degisken.done[i]);
                            if(yeni_line==1){
                                degisken.todo.Add(eklenecek);
                                System.Console.WriteLine("Kart değiştirme işlemi başarıyla tamamlandı.");
                                break;
                            }
                            else if(yeni_line==2){
                                degisken.inprogress.Add(eklenecek);
                                System.Console.WriteLine("Kart değiştirme işlemi başarıyla tamamlandı.");
                                break;
                            }
                        }
                }
                if(index==1){
                    break;
                }
                if(index==0){
                    System.Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    System.Console.WriteLine("Taşımayı sonlandırmak için : (1)");
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