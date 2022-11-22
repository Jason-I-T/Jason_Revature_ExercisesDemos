using System;
using System.Collections.Generic;
/*
enqueue
dequeue
peek

use a list...
list.addfirst - enqueue
list.remove - dequeue
list[i] - peek

only want a single type of data
*/

namespace MyQueue
{
     
    public class MyQueue<T> {
        List<T> myList = new List<T>();
        public MyQueue() {}

        public void enqueue(T entry) {
            myList.Add(entry);
        }

        public T dequeue() {
            if(Size() >= 0) {
                T entry = myList[0];
                myList.RemoveAt(0);
                return entry;
            } else {
                return default(T);
            }
        }

        public T peek() {
            if(Size() >= 0) {
                T entry = myList[0];
                return entry;
            } else {
                return default(T);
            }
        }

        public int Size() {
            return this.myList.Count;
        }

        public void printQueue() {
            foreach(T entry in myList) {
                Console.WriteLine(entry);
            }
        }

        public bool Contains(T query){
            foreach(T entry in myList) {
                if(entry.Equals(query)) {
                    return true;
                }
            }
            return false;
        }

        public void Clear() {        
            myList.Clear();
        }
    }
}