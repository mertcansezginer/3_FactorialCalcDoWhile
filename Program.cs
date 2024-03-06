
Console.WriteLine("Faktoriyelini hesaplamak istediginiz sayiyi giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());  //kullanicidan sayi alindi
long faktoriyel = 1;   //baslangic degerlerini belirlendi
int i = 1;

do
{
    faktoriyel *= i;    //faktoriyel hesaplama islemi
    i++;
}
while (i <= sayi);

Console.WriteLine(sayi + " sayisinin faktoriyeli " + faktoriyel);
