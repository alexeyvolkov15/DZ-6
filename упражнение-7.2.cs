using System;
using System.Globalization;

enum Type
{
    Текущий,
    Сберегательный
}

class BankAccount
{
    private static int count = 10000;
    private int number;
    private int balance;
    private Type type;

    public int Number
    {
        get { return number; }
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

    public int Generate()
    {
        count++;
        return count;
    }

    public BankAccount()
    {
        number = Generate();
    }

}
class Program
{
    static void Main()
    {
       BankAccount account = new BankAccount();

        account.Balance = 500000;
        account.AccountType = Type.Сберегательный;

        account.Print();
    }
}