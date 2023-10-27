﻿/*Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
ve dizinin elemanlarını sıralayan programı yazınız.
*/

using System;
using System.Collections;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            ArrayList sesliHarfler = new ArrayList();

            Console.Write("Metni giriniz: ");
            string cumle = Console.ReadLine(); //kullanıcıdan cümle alındı

            char[] cumleHarfleri = cumle.ToCharArray(); //alınan cümle harflerine ayrıştırılıp yeni bir char dizisine atıldı
            
            int elemanSayisi = cumleHarfleri.Count(); //yeni dizinin kac elemani oldugu bulundu
            int[] ascii = new int[elemanSayisi]; //ascii dizisi olusturduk
            
            for(int i=0; i<elemanSayisi; i++){
                ascii[i] = asciiCevir(cumleHarfleri[i]);
            }
            //cumlenin harflerini tek tek ascii karakterlerine (10 tabanında rakamlara) cevirdik
            //ASCII karakterlerinde 65-90 arası büyük harfler, 97-122 arası küçük harflerdir
            //65:A, 69:E, 73:I, 79:O, 85:U olmak üzere 5 adet büyük sesli harf
            //97:a, 101:e, 105:i, 111:o, 117:u olmak üzere 5 adet küçük sesli harf mevcuttur.
            //Bu aşamada ascii koduna dönüştürdüğümüz karakterlerden switch case yardımıyla sesli harfleri yakalayıp -
            //tekrar char'a donusturerek sesliHarfler ArrayList'imize atacağız
            for(int i=0; i<elemanSayisi; i++){
                switch (ascii[i])
                {   
                    case 65:
                    {
                        sesliHarfler.Add(metineCevir(ascii[i]));
                        break;
                    }
                    case 69:
                    {
                        sesliHarfler.Add(metineCevir(ascii[i]));
                        break;
                    }
                    case 73:
                    {
                        sesliHarfler.Add(metineCevir(ascii[i]));
                        break;
                    }
                    case 79:
                    {
                        sesliHarfler.Add(metineCevir(ascii[i]));
                        break;
                    }
                    case 85:
                    {
                        sesliHarfler.Add(metineCevir(ascii[i]));
                        break;
                    }
                    case 97:
                    {
                        sesliHarfler.Add(metineCevir(ascii[i]));
                        break;
                    }
                    case 101:
                    {
                        sesliHarfler.Add(metineCevir(ascii[i]));
                        break;
                    }
                    case 105:
                    {
                        sesliHarfler.Add(metineCevir(ascii[i]));
                        break;
                    }
                    case 111:
                    {
                        sesliHarfler.Add(metineCevir(ascii[i]));
                        break;
                    }
                    case 117:
                    {
                        sesliHarfler.Add(metineCevir(ascii[i]));
                        break;
                    }
                    
                    
                }
            }
            
            Console.WriteLine("Girdiginiz cumledeki sesli harfler:");
            sesliHarfler.Sort();
            foreach (var item in sesliHarfler)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nHarfler ASCII degerlerine göre küçükten büyüğe sıralanmıştır");
        }

        public static int asciiCevir(char c){
            int cevrilmis = c;
            return cevrilmis;
        }

        public static char metineCevir(int i){
            char cevrilmis = (char)i;
            return cevrilmis;
        }
    
    }
}