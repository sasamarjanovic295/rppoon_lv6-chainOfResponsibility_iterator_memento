using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoItem toDoItem = new ToDoItem("title 1", "text", DateTime.Now);
            CareTaker careTaker = new CareTaker();
            careTaker.AddState(toDoItem.StoreState());
            Console.WriteLine(toDoItem);
            toDoItem.Rename("Title 2");
            careTaker.AddState(toDoItem.StoreState());
            Console.WriteLine(toDoItem);
            toDoItem.Rename("Title 3");
            careTaker.AddState(toDoItem.StoreState());
            Console.WriteLine(toDoItem);
            toDoItem.RestoreState(careTaker.GetFirstState());
            Console.WriteLine(toDoItem);

            BankAccount bankAccount = new BankAccount("Sasa", "karadzicevo", 700);
            BankCareTaker bankCareTaker = new BankCareTaker();
            bankCareTaker.AddState(bankAccount.StoreState());
            Console.WriteLine(bankAccount.ToString());
            bankAccount.UpdateBalance(10000);
            bankCareTaker.AddState(bankAccount.StoreState());
            Console.WriteLine(bankAccount.ToString());
            bankAccount.UpdateBalance(10000);
            bankCareTaker.AddState(bankAccount.StoreState());
            Console.WriteLine(bankAccount.ToString());
            bankAccount.UpdateBalance(10000);
            bankAccount.RestoreState(bankCareTaker.GetFirstState());
            Console.WriteLine(bankAccount.ToString());
        }
    }
}
