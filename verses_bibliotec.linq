<Query Kind="Program" />

void Main()
{
	Console.WriteLine("Enter the new favorite verse: \n");
	var verse = Console.ReadLine();
	
	Console.WriteLine("\n");
	Console.WriteLine("\n");
	Console.WriteLine("List of Verse (s) \n");
	
	List <string> books = new List<string> { 
		"As well as the hand cannot say to the head I do not need you; Same we cannot say to Jesus I do not need you.",
		"God is love - 1 John 4:8.",
		"Alegraos delante del que cabalga en lo más alto aún que los cielos; Jehova es su nombre. - Salmos 68:4.",
		"Donde también se relata cuando los soldados le vistieron con un manto de púrpura y le colocaron la corona de espinas - Marcos 15:17 / Juan 19:2; Santas Escrituras.",
		"Que no sea tu furia mi corrección, sino que pueda adorarte hasta tiempo indefinido. - Salmos",
		"Que tu poder y tu nombre me defiendan - Salmos 54:1",
		"Guardaos pues de la idolatría - Deuteronomio 4:15"
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
