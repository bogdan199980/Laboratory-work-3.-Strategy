using System;

namespace StrategyPattern
{
    // Абстрактний клас, який визначає метод сортування
    abstract class SortStrategy
    {
        public abstract void Sort(int[] data);
    }

    // Клас сортування за зростанням
    class AscendingSortStrategy : SortStrategy
    {
        public override void Sort(int[] data)
        {
            Array.Sort(data);
        }
    }

    // Клас сортування за спаданням
    class DescendingSortStrategy : SortStrategy
    {
        public override void Sort(int[] data)
        {
            Array.Sort(data);
            Array.Reverse(data);
        }
    }

    // Клас контексту, який використовує об'єкт-стратегію для сортування даних
    class Context
    {
        private SortStrategy sortStrategy;

        public void SetSortStrategy(SortStrategy strategy)
        {
            this.sortStrategy = strategy;
        }

        public void SortData(int[] data)
        {
            Console.WriteLine("Sorting data:");
            sortStrategy.Sort(data);

            foreach (int item in data)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Client
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 5, 2, 4, 3 };

            Context context = new Context();

            // Використання об'єкта-стратегії для сортування за зростанням
            context.SetSortStrategy(new AscendingSortStrategy());
            context.SortData(data);

            // Використання об'єкта-стратегії для сортування за спаданням
            context.SetSortStrategy(new DescendingSortStrategy());
            context.SortData(data);
        }
    }
}
