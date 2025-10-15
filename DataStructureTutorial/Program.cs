
using System.Collections;
// Strongly typed array creation with explicit size and initializer
//int[] array = new int[1] { 42 };

// ArrayList 
ArrayList arrayList = new ArrayList();
arrayList.Add( 1 );  // int  // (Add method puts item at the end of the list)
arrayList.Add( "two" );  // string
arrayList.Add( 3.0 );  // double
arrayList.Add( true );  // bool
arrayList.Add( new object() );  // object

// Add Range
arrayList.AddRange( new object[] { 4, "five", 6.0, } );

// Insert an item at a specific index
arrayList.Insert( 1, "inserted at index 1" ); // 1 => index, "inserted at index 1" => item to insert


// Remove an item
//arrayList.Remove("two");

// Remove at index
//arrayList.RemoveAt(0);


// Remove range
arrayList.RemoveRange( 0, 2 ); // 0 => start index, 2 => number of elements to remove


// Remove all items
//arrayList.Clear();


// Display ArrayList contents
//Console.WriteLine("ArrayList contents:");
//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//}


// Boxing and Unboxing
int num = 123;          // Value type
object boxedNum = num; // Boxing
int unboxedNum = (int)boxedNum; // Unboxing


//Console.WriteLine($"Original number: {num}, Boxed number: {boxedNum}, Unboxed number: {unboxedNum}");

// Performance Implications 1.Array 2.ArrayList 3.Generic List


// Generic List && Dictionary
// 1. Generic List ==> List put items of the same type , no boxing/unboxing overhead
var intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };



// 2. Generic Dictionary ==> Key-Value pairs
 var dict = new Dictionary<string, int>
 {
     { "one", 1 },
     { "two", 2 },
     { "three", 3 }
 };

// Check if a key exists
//if ( dict.ContainsKey( "two" ))
//    Console.WriteLine( dict["two"] );
//else
//    Console.WriteLine( "Key not found" );


// TryGetValue
//if ( dict.TryGetValue( "three", out int value ))
//    Console.WriteLine( value );
//else
//    Console.WriteLine( "Key not found" );
