
// string[,]table=new string[2,5];
// // string.Empty
// // table[0,0] table[0,1] table[0,3] table[0,4] 
// // table[1,0] table[1,1] table[1,3] table[1,4] 

// table[1,2]="слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// void PrintArray(int[,]image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,]image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             image[i,j]= new Random().Next(1,10);
//         }
//     }
// }

// int[,]imageix = new int[3,4];
// PrintArray(imageix);
// FillArray(imageix);
// Console.WriteLine();
// PrintArray(imageix);


// //способ разукрасить картику если есть массив
// int[,] pic= new int[,] //-указан массив который у него был,а нам никто не дал
// void PrintImage(int[,]image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             // Console.Write($"{image[i, j]} ");
//             if(image[i,j]==0) Console.Write($" ");
//             else Console.Write($" + ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)
// {
//     if( pic[row,col]==0)
//     {
//         pic[row,col]=1;
//         FillImage(row-1,col)
//         FillImage(row-1,col)
//         FillImage(row+1,col)
//         FillImage(row,col+1)
//     }
// }

// PrintArray(pic);
// FillImage(13, 13);
// PrintArray(pic);

//РЕКУРСИЯ!!!

// double Factorial(int n)
// {
//     //ОПРЕДЕЛЕНИЕ ФАКТОРИАЛА 1! = 1 /0! =1 -ноль факториала тоже 1!!!
    
//     if(n==1) return 1;
//     else return n* Factorial(n-1);

// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}"); //1*2*3....40=
// }
// // Console.WriteLine(Factorial(3)); //1*2*3=6

//ФИБОНАЧИ
//f(1) =1
//f(2) =1
//f(n) = f(n-1)+f(n -2)

// double Fibonacci( int n)
// {
//     if(n==1 || n==2) return 1;
//     else return Fibonacci(n-1)+ Fibonacci(n-2);
// }

// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({Fibonacci(i)}");
// }
// {
    
// }