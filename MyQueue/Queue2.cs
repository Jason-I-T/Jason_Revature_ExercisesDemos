using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyQueue;

public class Queue2 {
    //Array we will use for our queue
    int[] queue = new int[0];

    public Queue2() {

    }

    // Add to end
    public void Enqueue(int entry){
        int size = Size();
        
        int[] tmp = new int[size + 1];
        tmp[size] = entry;

        for(int i = 0; i < size; i++) {
            tmp[i] = queue[i];
        }

        queue = tmp;
    }

    // Remove from beginning
    public int Dequeue() {
        int size = Size();
        int result = queue[0];
        int[] tmp = new int[size - 1];

        for(int i = 0; i < tmp.Length; i++) {
            tmp[i] = queue[i+1];
        }
        queue = tmp;

        return result;
    }

    // Check the front, return it.
    public int Peek() {
        return queue[0];
    }

    // Returns the current size of the queue
    public int Size() {
        return queue.Length;
    }

    // Print everything in the queue to console
    public void PrintQueue() {
        Console.WriteLine("Printing queue:");
        for(int i = 0; i < Size(); i++) {
            Console.Write($"{queue[i]} ");
        }
        Console.WriteLine();
    }
}
