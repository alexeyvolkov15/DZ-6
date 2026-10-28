using System;

class Build
{

    private static int lastNumber = 10000;
    private int number;
    private int high;
    private int floor;
    private int entrance;
    private int room;

    public Build()
    {
        lastNumber++;
        number = lastNumber;
    }

    public void Set()
        {
            Console.WriteLine("Введите высоту здания:");
            high = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество этажей:");
            floor = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество квартир:");
            room = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество подъездов:");
            entrance = int.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Номер здания: " + number);
            Console.WriteLine("Высота здания: " + high);
            Console.WriteLine("Количество этажей: " + floor);
            Console.WriteLine("Количество квартир: " + room);
            Console.WriteLine("Количество подъездов: " + entrance);
            Console.WriteLine("Высота этажа: " + FloorHigh());
            Console.WriteLine("Квартир в подъезде: " + RoomInEntrance());
            Console.WriteLine("Квартир на этаже: " + RoomOnFloor());
        }

    public int FloorHigh()
    {
        return high / floor;
    }

    public int RoomInEntrance()
    {
        return (int)Math.Round((double)room / entrance, 0);
    }

    public int RoomOnFloor()
    {
        return (int)Math.Round((double)room / (floor * entrance), 0);
    }

    class Program
    {
        static void Main()
        {
            Build building = new Build();
        
            building.Set();
            building.Print();
        }
    }
}