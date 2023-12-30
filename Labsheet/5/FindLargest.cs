using System;
class FindLargest{
    void int Largest( ref int[] arr){
        int max = arr[0];
        for(int i=1;i<arr.Length;i++){
            if(arr[i]>max){
                max = arr[i];
            }
        }
        return max;
    }
    static void Main(){
        int[] arr = {10,22,13,144,50};
        Console.WriteLine("Largest : {0}",Largest(ref arr));
    }
}