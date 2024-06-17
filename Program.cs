
using ConsoleApp1;
using System;


class Program
{
    static void Main()
    {

        Library library1 = new Library("Emek");
        ConsoleMenu menu = new ConsoleMenu();
        Member member1 = new Member("Yusuf","Cokal","YC4747");
        Staff staff1 = new Staff("Ahmet", "Demir", "Danışma");
        Book book1 = new Book("Aşk-ı Memnu", "Halit Ziya Uşaklıgil", "457896541");

        Member member2 = new Member("Süleyman", "Cakır", "SC5623");
        Staff staff2 = new Staff("Utku", "Dündar", "Müdür");
        Book book2 = new Book("Kuyucaklı Yusuf", "Sabahattin Ali", "145693215");

        Member member3 = new Member("Tarık", "Aytac", "TA2364");
        Staff staff3 = new Staff("Hakan", "Tekinoğlu", "Müdür Yardımcısı");
        Book book3 = new Book("Uçurtma Avcısı", "Khaled Hosseini", "579631472");

        Member member4 = new Member("Remzi", "Şahin", "RS7123");
        Staff staff4 = new Staff("Ezgi", "Erdoğan", "Kütüphane Personeli");
        Book book4 = new Book("Sırça Köşk", "Sabahattin Ali", "579631472");


        library1.AddBook(book1);
        library1.AddStaff(staff1);
        library1.AddMember(member1);


        library1.AddBook(book2);
        library1.AddStaff(staff2);
        library1.AddMember(member2);

        library1.AddBook(book3);
        library1.AddStaff(staff3);
        library1.AddMember(member3);

        library1.AddBook(book4);
        library1.AddStaff(staff4);
        library1.AddMember(member4);

        library1.ShowLibraryInfos();


        menu.consoleMenu();

    }
}


