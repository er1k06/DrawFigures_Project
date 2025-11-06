namespace figuresChoose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose figure :)");
            int bind = int.Parse(Console.ReadLine());
            if (bind == 1)
            {
                int height = 5;
                for (int i = 1; i <= height; i++)
                {
                    Console.WriteLine(new string('*', i));
                }
            }
            else if (bind == 2)
            {
                int size = 5;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {

                        if (row == 0 || row == size - 1 || col == 0 || col == size - 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (bind == 3)
            {
                int height = 5;
                int middle = (height + 1) / 2;

                // Upper part of the diamond
                for (int i = 1; i <= middle; i++)
                {
                    Console.Write(new string(' ', middle - i));
                    Console.WriteLine(new string('*', 2 * i - 1));
                }


                for (int i = middle - 1; i > 0; i--)
                {
                    Console.Write(new string(' ', middle - i));
                    Console.WriteLine(new string('*', 2 * i - 1));
                }
            }
            else if (bind == 4)
            {
                int height = 4;
                for (int i = 4; i >= 0; i--)
                {
                    Console.WriteLine(new string('*', i));
                }
            }
            else if (bind == 5)
            {
                int size = 6;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {

                        if (row == 0 || row == size - 1 || col == 0 || col == size - 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (bind == 6)
            {
                int height = 5;


                for (int i = 1; i <= height; i++)
                {
                    Console.Write(new string(' ', height - i));
                    Console.WriteLine(new string('*', 2 * i - 1));
                }
            }
            else if (bind == 7)
            {
                int height = 5;
                for (int i = height - 1; i > 0; i--)
                {
                    Console.Write(new string(' ', height - i));
                    Console.WriteLine(new string('*', 2 * i - 1));
                }
            }
            else if (bind == 8)
            {


                int width = 8;
                int height = 4;

                for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {

                        if (row == 0 || row == height - 1 || col == 0 || col == width - 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
    


