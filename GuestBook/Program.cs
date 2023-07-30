
using GuestBook;

(List<string> guestsName, int total) = Guests.AskUsersName();
Guests.PrintGuestsName(guestsName);
Console.WriteLine($"Total number of guests is : {total}");
