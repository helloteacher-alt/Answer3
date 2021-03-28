using System;

namespace Exam1_ข้อ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int box1, box2, box3, noBucket, movebox;
            Console.Write("Input the number of boxes in 1st bucket:");
            box1 = int.Parse(Console.ReadLine());
            Console.Write("Input the number of boxes in 2nd bucket:");
            box2 = int.Parse(Console.ReadLine());
            Console.Write("Input the number of boxes in 3rd bucket:");
            box3 = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("");
                Console.WriteLine("---------- 1st player Round ----------");
                Console.WriteLine("bucket1 = {0}  |  bucket2 = {1}  |  bucket 3 = {2}", box1, box2, box3);
                Console.WriteLine("---------- Play ----------");
                Console.Write("1st player select the number of bucket:");
                noBucket = int.Parse(Console.ReadLine());
                switch (noBucket)
                {
                    case 1:
                        Console.Write("The number of boxes you will remove: ");
                        movebox = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((movebox == 1 || movebox == 2))
                        {
                            box1 = box1 - movebox;
                        }
                        break;
                    case 2:
                        Console.Write("The number of boxes you will remove:");
                        movebox = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((movebox == 1 || movebox == 2))
                        {
                            box2 = box2 - movebox;
                        }
                        break;
                    case 3:
                        Console.Write("The number of boxes you will remove:");
                        movebox = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((movebox == 1 || movebox == 2))
                        {
                            box3 = box3 - movebox;
                        }
                        break;
                }
                if (box1 == 0 && box2 == 0 && box3 == 0)
                {
                    Console.WriteLine("2nd player won!");
                }
                else
                {
                    Console.WriteLine("---------- 2 nd player Round ----------");
                    Console.WriteLine("bucket1 = {0}  |  bucket2 = {1}  |  bucket 3 = {2}", box1, box2, box3);
                    Console.WriteLine("---------- Play ----------");
                    Console.Write("2nd player select the number of bucket:");
                    noBucket = int.Parse(Console.ReadLine());
                    switch (noBucket)
                    {
                        case 1:
                            Console.Write("The number of boxes you will remove: ");
                            movebox = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((movebox == 1 || movebox == 2))
                            {
                                box1 = box1 - movebox;
                            }
                            break;
                        case 2:
                            Console.Write("The number of boxes you will remove:");
                            movebox = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((movebox == 1 || movebox == 2))
                            {
                                box2 = box2 - movebox;
                            }
                            break;
                        case 3:
                            Console.Write("The number of boxes you will remove:");
                            movebox = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((movebox == 1 || movebox == 2))
                            {
                                box3 = box3 - movebox;
                            }
                            break;
                    }
                    if (box1 == 0 && box2 == 0 && box3 == 0)
                    {
                        Console.WriteLine("1st player won!");
                    }
                }
            } while (box1 != 0 || box2 != 0 || box3 != 0);
            Console.ReadLine();
        }
    }
}
