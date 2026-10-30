using System;
using System.Collections.Generic;

abstract class Animal
{

    private static int lastNumber = 1000;

    private int number;
    private string name;
    private int age;
    private string breed;
    private bool isHealthy;
    private bool isAdopted;



    public int Number
    {
        get { return number; }
    }

    public string Name
    {
        get { return name; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
        }
    }

    public string Breed
    {
        get { return breed; }
    }

    public bool IsHealthy
    {
        get { return isHealthy; }
        private set { isHealthy = value; }
    }

    public bool IsAdopted
    {
        get { return isAdopted; }
        private set { isAdopted = value; }
    }

    public void ChangeHealth(bool status)
    {
        IsHealthy = status;

        if (status)
            Console.WriteLine(Name + " теперь здоров");
        else
            Console.WriteLine(Name + " заболел");
    }
    

    public Animal(string name, int age, string breed)
    {
        lastNumber++;
        number = lastNumber;

        this.name = name;
        this.age = age;
        this.breed = breed;

        isHealthy = true;
        isAdopted = false;
    }


    public abstract void Sound();

    public virtual void Feed()
    {
        Console.WriteLine(name + " покормлен");
    }

    public virtual void CheckHealth()
    {
        if (IsHealthy)
            Console.WriteLine(name + " здоров");
        else
            Console.WriteLine(name + " болен");
    }

    public virtual void Adopt()
    {
        if (IsAdopted)
        {
            Console.WriteLine(name + " уже нашел семью");
        }
        else
        {
            IsAdopted = true;
            Console.WriteLine(name + " успешно оформлен в семью");
        }
    }

    public virtual void Show()
    {
        Console.WriteLine("КАРТОЧКА ПИТОМЦА");
        Console.WriteLine("Номер: " + Number);
        Console.WriteLine("Имя: " + Name);
        Console.WriteLine("Возраст: " + Age);
        Console.WriteLine("Порода: " + Breed);
        Console.WriteLine("Здоровье: " + (IsHealthy ? "Здоров" : "Болен"));
        Console.WriteLine("Статус: " + (IsAdopted ? "Нашел семью" : "Ищет семью"));
    }
}



class Cat : Animal
{

    public Cat() : base("Без имени", 0, "Неизвестная")
    {
    }

    public Cat(string name, int age, string breed) : base(name, age, breed)
    {
    }

    public override void Sound()
    {
        Console.WriteLine(Name + " говорит мяу");
    }

    public override void Feed()
    {
        Console.WriteLine("Кошка " + Name + " ест корм");
    }

    public override void CheckHealth()
    {
        base.CheckHealth();
    }

    public override void Adopt()
    {
        base.Adopt();
    }

    public override void Show()
    {
        base.Show();
    }
}




class Dog : Animal
{

    public Dog() : base("Без имени", 0, "Неизвестная")
    {
    }

    public Dog(string name, int age, string breed) : base(name, age, breed)
    {
    }

    public override void Sound()
    {
        Console.WriteLine(Name + " говорит гав");
    }

    public override void Feed()
    {
        Console.WriteLine("Собака " + Name + " ест корм");
    }

    public override void CheckHealth()
    {
        base.CheckHealth();
    }

    public override void Adopt()
    {
        base.Adopt();
    }

    public override void Show()
    {
        base.Show();
    }
}






class Parrot : Animal
{

    public Parrot() : base("Без имени", 0, "Неизвестная")
    {
    }

    public Parrot(string name, int age, string breed) : base(name, age, breed)
    {
    }

    public override void Sound()
    {
        Console.WriteLine(Name + " чирикает");
    }

    public override void Feed()
    {
        Console.WriteLine("Попугай " + Name + " ест корм");
    }

    public override void CheckHealth()
    {
        base.CheckHealth();
    }

    public override void Adopt()
    {
        base.Adopt();
    }

    public override void Show()
    {
        base.Show();
    }
}




class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>();

        animals.Add(new Cat("Барсик", 3, "Британская"));
        animals.Add(new Dog("Шарик", 5, "Овчарка"));
        animals.Add(new Parrot("Кеша", 2, "Какаду"));
        
        static Animal Find(List<Animal> animals, int number)
        {
            foreach (Animal animal in animals)
            {
                if (animal.Number == number)
                    return animal;
            }
            return null;
        }

        static void AddCat(List<Animal> animals)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите породу: ");
            string breed = Console.ReadLine();

            animals.Add(new Cat(name, age, breed));

            Console.WriteLine("Кошка добавлена!");
        }

        static void AddDog(List<Animal> animals)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите породу: ");
            string breed = Console.ReadLine();

            animals.Add(new Dog(name, age, breed));

            Console.WriteLine("Собака добавлена!");
        }

        static void AddParrot(List<Animal> animals)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите породу: ");
            string breed = Console.ReadLine();

            animals.Add(new Parrot(name, age, breed));

            Console.WriteLine("Попугай добавлен!");
        }

        while(true)
        {  

            Console.WriteLine("1. Показать всех питомцев");
            Console.WriteLine("2. Добавить кошку");
            Console.WriteLine("3. Добавить собаку");
            Console.WriteLine("4. Добавить попугая");
            Console.WriteLine("5. Удалить питомца");
            Console.WriteLine("6. Покормить питомца");
            Console.WriteLine("7. Проверить здоровье");
            Console.WriteLine("8. Изменить здоровье");
            Console.WriteLine("9. Оформить питомца в семью");
            Console.WriteLine("10. Послушать голоса животных");
            Console.WriteLine("11. Изменить возраст питомца");
            Console.WriteLine("0. Выход");
            Console.WriteLine("выберите команду:");
            int choice = int.Parse(Console.ReadLine());

            if (choice >= 5 && choice <= 9 || choice == 11)
            {
                Console.Write("Введите номер питомца: ");
                int number = int.Parse(Console.ReadLine());

                Animal animal = Find(animals, number);

                if (animal == null)
                {
                    Console.WriteLine("Питомец не найден!");
                    continue;
                }

                switch (choice)
                {
                    case 5:
                        animals.Remove(animal);
                        Console.WriteLine("Питомец удалён!");
                        break;

                    case 6:
                        animal.Feed();
                        break;

                    case 7:
                        animal.CheckHealth();
                        break;

                    case 8:
                        Console.WriteLine("1. Здоров");
                        Console.WriteLine("2. Болен");
                        int status = int.Parse(Console.ReadLine());

                        if (status == 1)
                            animal.ChangeHealth(true);
                        else if (status == 2)
                            animal.ChangeHealth(false);
                        else
                            Console.WriteLine("Неверный выбор!");
                        break;

                    case 9:
                        animal.Adopt();
                        break;

                    case 11:
                        Console.WriteLine("Введите новый возраст: ");
                        animal.Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Возраст обновлён");
                        break;
                }
            }

            else
            {
                switch (choice)
                {
                    case 1:
                        if (animals.Count == 0)
                        {
                            Console.WriteLine("В приюте пока нет животных.");
                        }
                        else
                        {
                            foreach (Animal animal in animals)
                            {
                                animal.Show();
                            }
                        }
                        break;

                    case 2:
                        AddCat(animals);
                        break;

                    case 3:
                        AddDog(animals);
                        break;

                    case 4:
                        AddParrot(animals);
                        break;

                    case 10:
                        foreach (Animal animal in animals)
                        {
                            animal.Sound();
                        }
                        break;

                    case 0:
                        Console.WriteLine("Программа завершена");
                        return;

                    default:
                        Console.WriteLine("Неправильное число");
                        break;
                }
            }
        }
    }
}