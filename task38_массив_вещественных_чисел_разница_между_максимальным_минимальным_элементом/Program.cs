/*38/ Задайте массив вещественных чисел.Найдите разницу между
 максимальным и минимальным элементами массива.
[3,7,22,2,78]->76
*/






class Program//класс стандартный для создания приложений main
    {
        static void Main(string[] args)//применение метода main с void()
        {
            Random rnd = new Random();//генератор случайных чисел
            int[] array = new int[10];//size массива
            int max=0, min=100;//границы массива
            for (int i = 0; i < array.Length; i++ )  array[i] = rnd.Next(100);//граница рандобных значений чисел до 100
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
           
               for (int i = 0; i < array.Length; i++);
                Console.WriteLine("[" + string.Join(", ", array) + "]");//выводим массив
                 Console.WriteLine("max:  " + max);//значение максим.
                 Console.WriteLine("min  " +min);//значение миним.
                 Console.WriteLine("Разница максимального и минимального:  "+(max - min));
                //Console.ReadKey();
        }
    }
