/*Задание 3
Создайте приложение «Список книг для прочтения». 
Приложение должно позволять добавлять книги в список, удалять книги из списка, проверять есть ли книга в 
списке, и т. д. Используйте механизм свойств, перегрузки 
операторов, индексаторов.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_T3
{
    public class MyLibrary
    {
        private List<Book> myLibrary;
        public int Count
        {
            get
            {
                return myLibrary.Count;
            }
        }

        public MyLibrary()
        {
            myLibrary = new List<Book>();
        }

        public void Add(Book newBook)
        {
            if (!myLibrary.Contains(newBook))
                myLibrary.Add(newBook);
        }

        public void Delete(int index)
        {
            myLibrary.RemoveAt(index);
        }

        public Book this[int index]
        {
            get 
            { 
                if (index >= 0 && index < myLibrary.Count()) 
                    return myLibrary[index];
                else 
                    return myLibrary[0];
            }
            set { myLibrary[index] = value; }            
        }
            
            
    }
}
