using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            for(int i=0;i<3;i++)
                notebook.AddNote(new Note(i.ToString(), i.ToString()));
            for(var iterator = notebook.GetIterator(); !iterator.IsDone;iterator.Next())
            {
                iterator.Current.Show();
            }

            Console.WriteLine("2.\n------");
            Box box = new Box();
            for (int i = 0; i < 3; i++)
                box.AddProduct(new Product(i.ToString(), i));
            IAbstractIterator<Product> boxIterator = box.GetIterator();
            while (!boxIterator.IsDone)
            {
                Console.WriteLine(boxIterator.Current.ToString());
                boxIterator.Next();
            }
        }
    }
}
