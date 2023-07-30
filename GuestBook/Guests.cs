namespace GuestBook;

public static class Guests
{
    public static (List<string> guestsList, int total) AskUsersName()
    {
        List<string> guestsNameList = new List<string>();
        string answer = "";
        int total = 0;
        do
        {
            Console.Write("what is your name : ");
            string name = Console.ReadLine();
            guestsNameList.Add(name);

            total += AskForPartyCount();


            Console.Write("Is there another guest ? (y/n) : ");
            answer = Console.ReadLine();

        } while (answer == "y");

        return (guestsNameList, total);
    }

    public static int AskForPartyCount()
    {

        bool flag = false;
        do
        {
            Console.Write("How many are in your party: ");
            string countText = Console.ReadLine();
            bool isValid = int.TryParse(countText, out int count);
            if (isValid is false)
            {
                Console.WriteLine("Please insert a numeric value");

                flag = true;

            }

            return count;


        } while (flag);
    }



    public static void PrintGuestsName(List<string> guestsList)
    {
        Console.WriteLine("Guests Name list : ");
        foreach (string name in guestsList)
        {
            Console.WriteLine(name);
        }
    }
}
