
using System.Collections;
// Strongly typed array creation with explicit size and initializer
//int[] array = new int[1] { 42 };

// ArrayList 
//ArrayList arrayList = new ArrayList();
//arrayList.Add( 1 );  // int  // (Add method puts item at the end of the list)
//arrayList.Add( "two" );  // string
//arrayList.Add( 3.0 );  // double
//arrayList.Add( true );  // bool
//arrayList.Add( new object() );  // object

// Add Range
//arrayList.AddRange( new object[] { 4, "five", 6.0, } );

// Insert an item at a specific index
//arrayList.Insert( 1, "inserted at index 1" ); // 1 => index, "inserted at index 1" => item to insert


// Remove an item
//arrayList.Remove("two");

// Remove at index
//arrayList.RemoveAt(0);


// Remove range
//arrayList.RemoveRange( 0, 2 ); // 0 => start index, 2 => number of elements to remove


// Remove all items
//arrayList.Clear();


// Display ArrayList contents
//Console.WriteLine("ArrayList contents:");
//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//}


// Boxing and Unboxing
//int num = 123;          // Value type
//object boxedNum = num; // Boxing
//int unboxedNum = (int)boxedNum; // Unboxing


//Console.WriteLine($"Original number: {num}, Boxed number: {boxedNum}, Unboxed number: {unboxedNum}");

// Performance Implications 1.Array 2.ArrayList 3.Generic List


// Generic List && Dictionary
// 1. Generic List ==> List put items of the same type , no boxing/unboxing overhead
//var intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };



// 2. Generic Dictionary ==> Key-Value pairs
//var dict = new Dictionary<string, int>
//{
//    { "one", 1 },
//    { "two", 2 },
//    { "three", 3 }
//};

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




// Stack && Queue

// 1. Stack ==> LIFO (Last In First Out)
// 2. Queue ==> FIFO (First In First Out)

// Stack Example
//Stack<int> stack = new Stack<int>();
// Push items onto the stack
//stack.Push( 1 );
//stack.Push( 2 );

//Console.WriteLine( $"Stack Pop: {stack.Pop()}" ); // Outputs 2
//Console.WriteLine( $"Stack Peek: {stack.Peek()}" ); // Outputs 1

// pop method removes and returns the top item
// peek method returns the top item without removing it

// Queue Example
//Queue<string> queue = new Queue<string>();
// Enqueue items into the queue
//queue.Enqueue( "first" );
//queue.Enqueue( "second" );
//Console.WriteLine( $"Queue Dequeue: {queue.Dequeue()}" ); // Outputs "first"
//Console.WriteLine( $"Queue Peek: {queue.Peek()}" ); // Outputs "second"

// dequeue method removes and returns the front item
// peek method returns the front item without removing it

class AppendTextCommand
{
    private string _textToAppend;
    public AppendTextCommand( string text )
    {
        _textToAppend = text;
    }
    public void Execute( ref string target )
    {
        target += _textToAppend;
    }
}

internal class Program
{

    static void ExcuteQueueExample()
    {
        Queue<string> queue = new Queue<string>();

        while (true)
        {
            Console.WriteLine( "Please Select a document to print (or type 'exit' to quit):" );
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
                break;

            queue.Enqueue( input );
            Console.WriteLine( $"Document '{input}' added to the print queue." );
            if (queue.Count > 0)
            {
                string documentToPrint = queue.Dequeue();
                Console.WriteLine( $"Printing document: {documentToPrint}" );
            }
            else
            {
                Console.WriteLine( "No documents in the print queue." );
            }

        }
    }

    static void ExcuteStackExample()
    {
        var commandStack = new Stack<AppendTextCommand>();
        while (true)
        {
            Console.Write( "Enter text to append (or 'undo' to undo last append, 'exit' to quit): " );
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;
            else if (input.ToLower() == "undo")
            {
                if (commandStack.Count > 0)
                {
                    commandStack.Pop();
                    Console.WriteLine( "Last append undone." );
                }
                else
                {
                    Console.WriteLine( "No commands to undo." );
                }
            }
            else
            {
                var command = new AppendTextCommand( input );
                commandStack.Push( command );
            }
            // Execute all commands in the stack to build the final string
            string result = string.Empty;
            foreach (var cmd in commandStack)
            {
                cmd.Execute( ref result );
            }
            Console.WriteLine( $"Current text: {result}" );
        }
    }
    private static void Main( string[] args )
    {


        //ExcuteStackExample();
        //ExcuteQueueExample();

    }
}