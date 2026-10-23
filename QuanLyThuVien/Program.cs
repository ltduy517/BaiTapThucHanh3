using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("----Test----");
        Book b1=new Book ("Lap Trinh C#","Le Trung Duy",9999);
        Book b2=new Book("Doraemon","Trung Duy",99999);
        Book b3=new Book("Xuyen Khong Thanh Tien De","abcxyz",1000);
        
        b1.DisplayInfo();
        b2.DisplayInfo();
        b3.DisplayInfo();
        Console.WriteLine($"Tong so sach da tao= {Book.TotalBooks}");
    }

}