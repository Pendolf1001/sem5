//Задача 4: Задайте двумерный массив зи целых чисел.
//Напишите программу, которая удалит строку и столбецб на пересечении которых расположен наименьший элемент массива.
//Под удалением понимается создание нового двумерного массиваб без строки и столбца.

using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

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


ShowRandomMatrix(WithoutMinMatrix(matrix));

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
 
static int [,] WithoutMinMatrix (int[,]array){

int [,]whithoutMinMatrix=new int [array.GetLength(0)-1,array.GetLength(1)-1];
   int minColumn=0;
    int minRow=0;
  int  minValue=array[0,0];

  for (int i=0; i<array.GetLength(0);i++) {
    for (int j=0; j<array.GetLength(1);j++){
        if (array[i,j]<minValue){
            minValue=array[i,j];
            minRow=i;
            minColumn=j;
        }
    }
  }


for (int k=0; k<whithoutMinMatrix.GetLength(0);k++){
    if (k<minRow){
        for (int l=0; l<whithoutMinMatrix.GetLength(1); l++){
            if (l<minColumn){
                whithoutMinMatrix[k,l]=array[k,l];
            }
            else{
                whithoutMinMatrix[k,l]=array[k,l+1];
            }
        }
    }
        else{
            for (int l=0; l<whithoutMinMatrix.GetLength(1); l++){
            if (l<minColumn){
                whithoutMinMatrix[k,l]=array[k+1,l];
            }
            else{
                 whithoutMinMatrix[k,l]=array[k+1,l+1];
            }
        }
    }
    }

return whithoutMinMatrix;
 }
 