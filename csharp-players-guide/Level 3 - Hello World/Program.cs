/*** BEYOND HELLO WORLD ***/

/** Variables **/
string name;
name = "Marti";
Console.WriteLine("Hello, " + name + "!");


/** Reading Text from The Console **/
string firstName;
Console.WriteLine("What is your first name?");
firstName = Console.ReadLine();
Console.WriteLine("Hi, " + firstName + "!");

/* Challenge */
Console.WriteLine("Bread is ready.");
Console.WriteLine("Who is the bread for?");
string recipient = Console.ReadLine();
Console.WriteLine(recipient + " got bread.");