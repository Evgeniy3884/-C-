// Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B)
//  и возводит число A в степень B.
// 3, 5 -> 243
// 2, 4 -> 16

// int numberA = new Random().Next(1,10);//2
// int numberB = new Random().Next(1,10);
// int result = numberA ;
// for (int i = 1; i < numberB; i++)
// {
//     result = result * numberA;
// }
// Console.WriteLine(numberA + ", " + numberB + " -> "  + result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.WriteLine("введите число");
// string numberA = Console.ReadLine();
// int sum = 0;
// for(int i=0;i < numberA.Length;i++)
// {
// sum = sum + Convert.ToInt32(numberA[i].ToString());
// }
// Console.WriteLine(numberA + " -> " + sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел
//  и выводит отсортированный по модулю массив.
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
// 6, 1, -33 -> [1, 6, -33]

// int[] array = new int[8];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10,10);
// }

// foreach (var item in array)
// {
//     Console.Write(item + ", ");
// }
// Console.Write(" -> [");
// BubbleSort(array);

// foreach (var item in array)
// {
//     Console.Write(item + ", ");
// }

// Console.WriteLine("]");

// 	void BubbleSort(int[] array){
// 			for (int i = 0; i < array.Length; i++){
// 				for (int j = 0; j < array.Length - 1; j++){
//                     if (abs(array[j]) > abs(array[j + 1])){
// 						int t = array[j + 1];
// 						array[j + 1] = array[j];
// 						array[j] = t;
// 					}
//                 }
//             }
// 		}
//     int abs(int n){
//         if(n < 0){
//             return n * -1;
//         }
//         else return n;
//     }


