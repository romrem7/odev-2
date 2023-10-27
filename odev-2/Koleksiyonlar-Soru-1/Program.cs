// Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

        // Negatif ve numeric olmayan girişleri engelleyin.
        // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

        ﻿using System;
using System.Collections;

namespace degisken{

    class Program{
        static void Main(string[] args){
            ArrayList asal = new ArrayList(); 
            ArrayList asalOlmayan = new ArrayList();
            ArrayList sayilar = new ArrayList();
            int asalSayaci=0, asalOlmayanSayaci=0;
            int asalOrtalama=0, asalOlmayanOrtalama=0;
            int asalToplam=0, asalOlmayanToplam=0;
            
            Console.WriteLine("Sayilari giriniz");
            for(int i=0 ; i<20 ; i++){ 
                try{
                    int n = Convert.ToInt32(Console.ReadLine());
                    
                    if(n <= 0){
                        Console.WriteLine("Pozitif tam sayı giriniz.");
                    }

                    else{
                        sayilar.Add(n);
                    }
                }
                catch (FormatException )
                {
                    Console.WriteLine("Veri tipi uygun değil. Girilen deger bir sayi olmalidir.");    
                }
            }    
                
                
                
            foreach (var item in sayilar){
                if(asalKontrol(Convert.ToInt32(item))==true){
                    asal.Add(item);
                    asalSayaci++;
                    asalToplam=asalToplam + Convert.ToInt32(item);
                }
                else{
                    asalOlmayan.Add(item);
                    asalOlmayanSayaci++;
                    asalOlmayanToplam=asalOlmayanToplam + Convert.ToInt32(item);
                }
            }

            asalOrtalama = asalToplam/asalSayaci;
            asalOlmayanOrtalama = asalOlmayanToplam/asalOlmayanSayaci;
                
            asal.Sort();
            asal.Reverse();
            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            

            Console.Write("Asal Sayilarin büyükten kücüge dogru siralanmasi: "); 
            foreach (var item in asal)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Asal Sayilar dizisinin eleman sayisi:" + asalSayaci);
            Console.WriteLine("Asal Sayilar dizisinin ortalamasi:" + asalOrtalama);

            Console.Write("Asal Olmayan Sayilarin büyükten kücüge dogru siralanmasi: ");
            foreach (var item in asalOlmayan)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Asal Olmayan Sayilar dizisinin eleman sayisi:" + asalOlmayanSayaci);
            Console.WriteLine("Asal Sayilar dizisinin ortalamasi:" + asalOlmayanOrtalama);
            
        }
        public static bool asalKontrol(int sayi){
            int sayac = 0;
            bool asal;
            int i;
            
            for(i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }

            if (sayac == 2)
            {
                asal = true;
            }

            else
            {
                asal = false;
            }

            return asal;
        } 
    }
}