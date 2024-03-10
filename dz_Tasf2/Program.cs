//Задача 2: ЗАдайтедвумерный массив. Напишите программуб которая меняет
//местами первую и последнюю строку массива.


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

ShowRandomMatrix(DoChengetMatrix(matrix));

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
 
 static int [,] DoChengetMatrix (int[,]arr ){
    int [,] ChangeArr=new int [arr.GetLength(0),arr.GetLength(1)];
    for (int i=0; i<arr.GetLength(0); i++){
        for (int j=0;j< arr.GetLength(1); j++){
            if (i==0){
                ChangeArr[i,j]=arr[arr.GetLength(0)-1,j];
            }
            else if (i==arr.GetLength(0)-1){
                ChangeArr[i,j]=arr[0,j];
            }
            else{
                ChangeArr[i,j]=arr[i,j];
            }
            
        }
    }
    return ChangeArr;

 }