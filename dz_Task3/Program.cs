//Задача 3:  задайте прямоугольный двумерный массивю.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов

Console.WriteLine("Введите число строк");
 int a=Convert.ToInt32(Console.ReadLine());
 
 Console.WriteLine("Введите число столбцов");
 int b=Convert.ToInt32(Console.ReadLine());
 
 Console.WriteLine("Введите минимальное число");
 int c=Convert.ToInt32(Console.ReadLine());
 
 Console.WriteLine("Введите максимальное число");
 int d=Convert.ToInt32(Console.ReadLine());

 
 int [,] matrix=CreateRandomMatrix(a,b,c,d);


ShowRandomMatrix (matrix);

Console.WriteLine("_________________________");

DoMinRowValueInMatrix(matrix);

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
 
 static void DoMinRowValueInMatrix(int [,] arr){

int minSum=100000;

int minIndex=0;

int SumRow=0;

for (int i=0; i<arr.GetLength(0); i++){
    for(int j=0; j<arr.GetLength(1); j++){
        SumRow+=arr[i,j];
    }
    if (minSum>SumRow){
        minSum=SumRow;
        minIndex=i;
    }
    SumRow=0;

}

Console.WriteLine($"Cтрока с индексом {minIndex}");

 }