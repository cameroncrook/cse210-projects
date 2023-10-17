using System;

class Program
{
    static void Main(string[] args)
    {
        // Set scriptures
        List<Reference> scriptures = new List<Reference>();

        Reference scripture1 = new Reference();
        scripture1.SetReference("Alma 32:21");
        scripture1.SetScripture("And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
        scriptures.Add(scripture1);

        Reference script2 = new Reference();
        script2.SetReference("Alma 58:37");
        script2.SetScripture("But, behold, it mattereth not—we trust God will deliver us, notwithstanding the weakness of our armies, yea, and deliver us out of the hands of our enemies.");
        scriptures.Add(script2);

        Reference script3 = new Reference();
        script3.SetReference("Ether 12:27");
        script3.SetScripture("And if men come unto me I will show unto them their aweakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that dhumble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        scriptures.Add(script3);

        // Program Starts Here
        // ====================================================
        
        // Gets random scripture from pool
        Random random = new Random();
        int randomIndex = random.Next(0, scriptures.Count);
        Reference reference = scriptures[randomIndex];

        reference.Init();

        bool isActive = true;

        do
        {
            reference.ScriptureClass.DisplayScripture(reference.GetReference());

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string response = Console.ReadLine();

            if (response.ToLower() == "quit")
            {
                isActive = false;

                Console.WriteLine("Exiting...");
            }
            else if (response == "")
            {
                // hide a word
                bool finishCheck = reference.ScriptureClass.HideRandomWord();

                if (finishCheck) {
                    isActive = false;
                }
            }

        } while (isActive);
    }
}