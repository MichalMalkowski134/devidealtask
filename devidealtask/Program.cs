namespace devildealtask
{ 
    class library
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please pick a book category [1] IT, [2] History, [3] Classics, " +
                "[4] Law, [5] Medical, [6] Philosophy (type number 1-6): ");
                int type = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please write the day, month, year of the borrow");
                Console.WriteLine("Day: ");
                string borrow_day = Console.ReadLine();
                Console.WriteLine("Month: ");
                string borrow_month = Console.ReadLine();
                Console.WriteLine("Year: ");
                string borrow_year = Console.ReadLine();
                Console.WriteLine("Please write the day, month, year of the return");
                Console.WriteLine("Day: ");
                string return_day = Console.ReadLine();
                Console.WriteLine("Month: ");
                string return_month = Console.ReadLine();
                Console.WriteLine("Year: ");
                string return_year = Console.ReadLine();

                string borrow_date = borrow_day + "/" + borrow_month + "/" + borrow_year;
                string return_date = return_day + "/" + return_month + "/" + return_year;

                Borrow b = new Borrow(type, borrow_date, return_date);
                if (b.penalty_fee() != 0)
                    Console.WriteLine("For " + b.get_book_type() + " book, borrower penalty fee is " 
                        + b.penalty_fee());
                else
                    Console.WriteLine("For " + b.get_book_type() + " book, borrower has no fee to pay");

                Console.WriteLine("If you want to leave type 0, " +
                    "but if you want to borrow another book type anything else");
            }while (Console.ReadLine() != "0");
            
        }
    }
}

