/*
 * Given five positive integers, find the minimum and maximum values that can be 
 * calculated by summing exactly four of the five integers. Then print the respective 
 * minimum and maximum values as a single line of two space-separated long integers.
 */
namespace MiniMaxSum;
class Program
{
    static void Main(string[] args)
    {
        // int[] arr1 = {1, 2, 3, 4, 5};
        // MiniMaxSum(arr1);
        List<int> arr = new List<int>();
        arr.Add(1);
        arr.Add(2);
        arr.Add(3);
        arr.Add(4);
        arr.Add(5);
        miniMaxSum(arr);
    }

    // Came up with this after looking at first attempt...
    // ... and realizing that I needed to do this on hackerrank first
    public static void miniMaxSum(List<int> arr)
    {
        /* Set up our max/min values to compare with. 
           arrSum is used for getting min/max sum */
        long mini = long.MaxValue;
        long max = -1;
    
        long arrSum = 0;
        foreach(int x in arr) {
            long l = (long) x;
            arrSum += l;
        }
        
        /* Store the result of our calcuation in tmp every iteration.
           If the calcuation is less than min, update min. 
           If the calculation is more than max, udpate max.*/
        for(int i = 0; i < arr.Count(); i++) {
            long tmp = arrSum - (long)arr[i];
            if(tmp < mini) mini = tmp;
            if(tmp > max) max = tmp;
        }
       
        // Print result
        Console.WriteLine($"{mini} {max}");
    }

    // static void MiniMaxSum(int[] a) {
    //     // Constraints...
    //     if(a.Length != 5) return;
    //     foreach(int i in a) if(i < 0) return;

    //     int mini = MinSum(a);
    //     int max = MaxSum(a);

    //     Console.WriteLine($"{mini} {max}");
    // }

    // static int MinSum(int[] a) {
    //     int minSum = int.MaxValue;
    //     int sum = a.Sum();
    //     //Console.WriteLine(minSum);
    //     for(int i = 0; i < a.Length; i++) {
    //         int tmp = sum - a[i];
    //         //Console.WriteLine(tmp);
    //         if(tmp < minSum)
    //             minSum = tmp;
    //     }
    //     return minSum;
    // }

    // static int MaxSum(int[] a) {
    //     int maxSum = -1;
    //     int sum = a.Sum();
    //     for(int i = 0; i < a.Length; i++) {
    //         int tmp = sum - a[i];
    //         //Console.WriteLine(tmp);
    //         if(tmp > maxSum)
    //             maxSum = tmp;
    //     }
    //     return maxSum;
    // }
}
