/* */

// Ekranda girilen sayıya kadar olan tek sayıları ekrana yazdırma
Console.WriteLine(" Lütfen Bir Sayı Giriniz... ");
int input =  int.Parse(Console.ReadLine());
Console.WriteLine(" Tek Sayılar: ");
for(int i = 1; i<= input; i++){
    if(i%2 == 1)
        Console.WriteLine(i);
}

// 1-1000 arasındaki çift sayıların toplamını ekrana yazdırma
Console.WriteLine(" 1 ile 1000 arasındaki tek ve çift sayıların toplamı ");
int tekToplam = 0;
int ciftToplam = 0;
for(int i = 1; i<=1000; i++){
    if(i%2==1)
        tekToplam += i;
    else
        ciftToplam += i;
}

Console.WriteLine($"Çift Sayıların Toplamı : {ciftToplam}");
Console.WriteLine($"Tek Sayıların Toplamı : {ciftToplam}");

// Break: Case'e göre Bir Döngü içerisinde loop' dan yani döngüden çıkmanız gerekiyorsa, break kullanırsınız.
// Continue: Sadece o şartı atlamak gerekiyorsa continue kullanılır.

Console.WriteLine("Break Örnek: 1-10 kadar sayıları yazcak 4 görünce döngü sonlandıracak. ");

for(int i = 1; i<=10; i++){
    if(i == 4)
        break;
    Console.WriteLine(i);
}


Console.WriteLine("Continue Örnek: 1-10 kadar sayıları yazcak 4 ü atlayıp döngü devam edecek. ");
for(int j=0; j<=10; j++){
   if(j==4)
        continue;
   Console.WriteLine(j);

}