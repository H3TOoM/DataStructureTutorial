
using System.Collections;
// Strongly typed array creation with explicit size and initializer
//int[] array = new int[1] { 42 };

// ArrayList 
ArrayList arrayList = new ArrayList();
arrayList.Add(1);  // int  // (Add method puts item at the end of the list)
arrayList.Add("two");  // string
arrayList.Add(3.0);  // double
arrayList.Add(true);  // bool
arrayList.Add(new object());  // object

// Add Range
arrayList.AddRange(new object[] { 4, "five", 6.0, });

// Insert an item at a specific index
arrayList.Insert(1, "inserted at index 1"); // 1 => index, "inserted at index 1" => item to insert


// Remove an item
//arrayList.Remove("two");

// Remove at index
//arrayList.RemoveAt(0);


// Remove range
arrayList.RemoveRange(0, 2); // 0 => start index, 2 => number of elements to remove


// Remove all items
//arrayList.Clear();


// Display ArrayList contents
Console.WriteLine("ArrayList contents:");
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}


// Boxing and Unboxing
int num = 123;          // Value type
object boxedNum = num; // Boxing
int unboxedNum = (int)boxedNum; // Unboxing
