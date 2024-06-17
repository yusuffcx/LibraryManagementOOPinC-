using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConsoleMenu
    {
        public void consoleMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("*Uygulamadan cıkmak icin 1'e.\n*Kütüphane olusturmak icin 2'ye basiniz");
                string choose;
                choose = Console.ReadLine();

                if (choose == "2")
                {
                    Console.WriteLine("Kütüphane ismi giriniz:");
                    string kütüphane;

                    kütüphane = Console.ReadLine();
                    Library library2 = new Library(kütüphane);
                    Console.WriteLine();
                    Console.WriteLine(kütüphane+ " isimli " + "Kütüphane olusturuldu.\n");
                    Console.WriteLine("Uygulamadan cıkmak icin 1'e.\n-Kütüphaneye kitap girmek icin 2'ye basiniz");
                    string choose2;
                    choose2 = Console.ReadLine();
                    if (choose2 == "2")
                    {
                        Console.WriteLine("Kitap ismi giriniz:");
                        string book;
                        book = Console.ReadLine();

                        Console.WriteLine("Kitap yazarını giriniz:");
                        string author;
                        author = Console.ReadLine();

                        Console.WriteLine("Kitap ISBN numarasini girin:");
                        string isbn;
                        isbn = Console.ReadLine();
                        Book book5 = new Book(book, author, isbn);
                        library2.AddBook(book5);
                        Console.WriteLine("Kütüphaneye " + book + " isimli kitap eklendi.");

                        Console.WriteLine("Uygulamadan cıkmak icin 1'e.\n-Kütüphaneye üye bilgisi girmek icin 2'ye basiniz");
                        string choose5;
                        choose5 = Console.ReadLine();
                        if (choose5 == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Girmek istediginiz üyenin ismini giriniz:");
                            string MemberName;
                            MemberName = Console.ReadLine();

                            Console.WriteLine();
                            Console.WriteLine("Girmek istediginiz üyenin soyismini giriniz:");
                            string MemberSurname;
                            MemberSurname = Console.ReadLine();

                            Console.WriteLine();
                            Console.WriteLine("Girmek istediginiz üyenin ID'sini giriniz:");
                            string MemberID;
                            MemberID = Console.ReadLine();
                            Member member5 = new Member(MemberName, MemberSurname, MemberID);
                        }

                        Console.WriteLine("Uygulamadan cıkmak icin 1'e.\n-Kütüphaneye calisan bilgisi girmek icin 2'ye basiniz");
                        string choose3;
                        choose3 = Console.ReadLine();
                        if (choose3 == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Girmek istediginiz calisanin ismini giriniz:");
                            string staffName;
                            staffName = Console.ReadLine();

                            Console.WriteLine();
                            Console.WriteLine("Girmek istediginiz calisanin soyismini giriniz:");
                            string staffSurName;
                            staffSurName = Console.ReadLine();

                            Console.WriteLine();
                            Console.WriteLine("Girmek istediginiz calisanin pozisyonunu giriniz:");
                            string staffPosition;
                            staffPosition = Console.ReadLine();
                            Staff staff5 = new Staff(staffName, staffSurName, staffPosition);
                            library2.AddStaff(staff5);
                            Console.WriteLine("Calisan eklendi.");

                            Console.WriteLine("Bilgi ekleme uygulamasından cıkıldı. Kütüphane ve kitap bilgilerini görmek icin 1'e basiniz.");
                            string choose4;
                            choose4 = Console.ReadLine();
                            if (choose4 == "1")
                            {
                                library2.ShowLibraryInfos();
                            }

                            else if(choose4 != "1") { break; }

                        }
                        else if (choose3 == "1") { break; }
                        else { Console.WriteLine("Yanlis deger girdiniz. Uygulamadan cikiliyor."); }

                    }
                    else if (choose2 == "1")
                    {
                        break;
                    }

                }
                else if (choose == "1")
                {
                    break;
                }
                else { Console.WriteLine("Yanlis deger girdiniz. Uygulamadan cikiliyor."); }

            }


        }
    }
}


