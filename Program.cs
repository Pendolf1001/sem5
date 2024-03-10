//Дз семинар 5
//1 задача :

//Напишите программу, которая на входе принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

 Console.WriteLine("Введите число строк");
 int a=Convert.ToInt32(Console.ReadLine());
 
 Console.WriteLine("Введите число столбцов");
 int b=Convert.ToInt32(Console.ReadLine());
 
 Console.WriteLine("Введите минимальное число");
 int c=Convert.ToInt32(Console.ReadLine());
 
 Console.WriteLine("Введите максимальное число");
 int d=Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите номер строки");
 int e=Convert.ToInt32(Console.ReadLine());

 
 Console.WriteLine("Введите номер столбца");
 int f=Convert.ToInt32(Console.ReadLine());
 
 int [,] matrix=CreateRandomMatrix(a,b,c,d);


ShowRandomMatrix (matrix);

ShowChozenElement(matrix, e,f);

 static int [,] CreateRandomMatrix(int row, int colum, int min, int max){
     int [,] arr = new int [row,colum] ;
     Random rnd=new Random();
     for (int i=0;i<arr.GetLength(0);i++){
         for(int j=0;j<arr.GetLength(1);j++){
             arr[i,j]=rnd.Next(min,max+1);
         }
     }
     return arr;
 }
  
 static void ShowRandomMatrix(int [,] arr) {
        
      for (int i=0; i<arr.GetLength(0);i++){
        for (int j=0; j<arr.GetLength(1);j++){
      
            Console.Write($"{arr[i,j]} ");
     }
     Console.WriteLine();
 }
 }
 
 static void ShowChozenElement (int[,]arr, int row, int colum){
    if (row-1<arr.GetLength(0) && colum-1<arr.GetLength(1)){
int element=arr[row-1,colum-1];

Console.WriteLine(element);
    }
    else{
        Console.WriteLine("Нет такого элемента");
    }

 }