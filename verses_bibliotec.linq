<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Enter the new favorite verse: \n");
	var verse = Console.ReadLine();
	
	Console.WriteLine("\n");
	Console.WriteLine("\n");
	Console.WriteLine("List of Verse (s) \n");
	
	List<string> books = new List<string> { 
		"As well as the hand cannot say to the head I do not need you; Same we cannot say to Jesus I do not need you",
		"God is love"
	};
	
	books.Add(verse);
	int count = 0;

    foreach (string book in books)
    {
		count = count + 1;
		Console.Write("{0}) ", count);
		Console.Write("{0}) ", book);
		Console.WriteLine("\n");
	};
}

// Define other methods and classes here
