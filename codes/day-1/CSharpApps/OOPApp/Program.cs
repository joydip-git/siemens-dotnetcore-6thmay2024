using SampleLibrary;

Console.WriteLine("Hello, World!");

Messenger messenger = new Messenger();
string message = messenger.GetMessage("Joydip");
Console.WriteLine(message);

Console.WriteLine("press enter to terminate...");
Console.ReadLine();

//Host
//WebHost
