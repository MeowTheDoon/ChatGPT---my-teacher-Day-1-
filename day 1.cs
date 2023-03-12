/*
Создайте класс "Книга", который содержит поля
"название", "автор", "год издания". Реализуйте в классе
конструкторы, свойства и метод,
который выводит всю информацию о книге.
*/

using BookInfo;
using System;

namespace BookInfo
{
    class Book
    {
        //поля класса
        public string BookTitle;
        public string Author;
        public string YearOfPublishing;

        //конструктор класс
        public Book(string name, string author, string yearOfPublishing)
        {
            this.BookTitle = name;
            this.Author = author;
            this.YearOfPublishing = yearOfPublishing;
        }

        //метод класса
        public void Output()
        {
            Console.WriteLine("Книга: " + BookTitle);
            Console.WriteLine("Автор: " + Author);
            Console.WriteLine("Год издания: " + YearOfPublishing);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //создание объекта класса
            Book DH = new Book("Сердце дракона", "Кирилл Клеванский", "2019");

            //вывод информации о книге
            DH.Output();
        }
    }
}