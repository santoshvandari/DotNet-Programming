// 7. Write a C# program to calculate product of each row of jagged array.
using System;
class ProductOfJaggedArray{
    static void Main(){
        int[][] arr = new int[3][];
        arr[0] = new int[]{1,2,3,4};
        arr[1] = new int[]{5,6,7};
        arr[2] = new int[]{8,9};
        foreach(int[] i in arr){
            int product = 1;
            foreach(int num in i)
                product *= num;
            Console.WriteLine("Product : {0}",product);
        }
    }
}