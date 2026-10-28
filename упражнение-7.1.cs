using System;

enum Type
{
    Текущий,
    Сберегательный
}

class BankAccount
{
    private int number;
    private int balance;
    private Type type;

    public int Number
    {
        get { return number; }
        set { number = value; }
    }

    public int Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public Type AccountType
    {
        get { return type; }
        set { type = value; }
    }

    public void Print()
    {
        Console.WriteLine("Номер счёта: " + number);
        Console.WriteLine("Баланс: " + balance);
        Console.WriteLine("Тип счёта: " + type);
    }

}
class Program
{
    static void Main()
    {
       BankAccount account = new BankAccount();

        account.Number = 12345;
        account.Balance = 10000;
        account.AccountType = Type.Сберегательный;

        account.Print();
    }
}