 class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");
        string choice;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("dd/MM/yyyy");

                Entry newEntry = new Entry(date, prompt, response);
                myJournal.AddEntry(newEntry); 
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll(); 
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to load: ");
                string loadFilename = Console.ReadLine();
                myJournal.LoadFromFile(loadFilename); 
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to save: ");
                string saveFilename = Console.ReadLine();
                myJournal.SaveToFile(saveFilename); 
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid Choice. Please try again.");
            }
        }
        while (choice != "5");
    }
}                        