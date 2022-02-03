using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //*****************Ödev Soru 1******************* 
           //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında 
           //kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan 
           //çift olanlar console'a yazdırın. 
           
           Console.WriteLine("Kaç adet sayı gireceksiniz?"); 
           int n = Convert.ToInt32(Console.ReadLine()); 
           int[] dizi= new int[n]; 
           for(int i = 0;i<n;i++) 
           { 
               dizi[i]= Convert.ToInt32(Console.ReadLine()); 
               
               } 
           for(int i = 0;i<n;i++) 
           { 
               if(dizi[i] %2 == 0) Console.Write(dizi[i]+ " "); 
               } 
            

           //*****************Ödev1 Soru 2******************* 
           //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında //kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan 
           //m'e eşit yada tam bölünenleri console'a yazdırın. 
           
           Console.WriteLine("2 Adet pozitif tam sayi giriniz"); 
           int a = Convert.ToInt32(Console.ReadLine()); 
           int b = Convert.ToInt32(Console.ReadLine()); 
           
           Console.WriteLine("{0} Adet sayi giriniz:",a);

           int[] dizi2 = new int[b];
           for(int i =0;i<b;i++)

           {
               Console.WriteLine("{0}.sayiyi giriniz",i+1);

               dizi2[i] = Convert.ToInt32(Console.ReadLine());
           }

           for(int i=0;i<b;i++)
           {
               if(dizi2[i] == a || dizi2[i]%a ==0)
               {
                   Console.WriteLine(dizi2[i]+" ");
               }
           }


           //*****************Ödev1 Soru 3******************* 

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (d). Sonrasında 
            //kullanıcıdan d adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri 
            //sondan başa doğru console'a yazdırın.

            Console.WriteLine("Pozitif tam sayi giriniz"); 
           int d = Convert.ToInt32(Console.ReadLine()); 
           string[] kelimeler = new string[d];
           
           for(int i=0;i<d;i++)
           {
               kelimeler[i] = Console.ReadLine();
           }

           for(int i =d-1;i<0;i--)
           {
               Console.WriteLine(kelimeler[i]);
           }

           //*****************Ödev1 Soru 4******************* 
           // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime 
           //ve harf sayısını console'a yazdırın.

           Console.WriteLine("Bir cümle yazınız:");
           string cumle = Console.ReadLine();
           char[] karakterler = cumle.ToCharArray();
            int bosluk =1;
           for(int i=0;i<cumle.Length;i++)
           {
               if(karakterler[i] == ' ') bosluk++;
           }

           int harfSayisi = cumle.Length-bosluk;

           Console.WriteLine("{0} kelimeden ve {1} harften oluşur",bosluk,harfSayisi);



           



        }
    }
}
