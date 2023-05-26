namespace favoriteBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create instenc 
            FavoriteBook booklist = new FavoriteBook(5);
            // initial  books 
            booklist[0, "python"] = "ahmed mohsen";
            booklist[1, "C#"] = "ahmed ";
            booklist[2, "java"] = "ahmed mhammed ";
            booklist[3, "flutter"] = "ahmed ali";
            booklist[4, "C"] = "ahmed jeo";

            // create barrowed books list
            FavoriteBook barrowedbooklist = new FavoriteBook(0);


            // this loop to take the user option to barrow book or return  book or quit the program 
            while (true)
            {

                Console.WriteLine("Enter ( 1 ) to barrow  books , ( 2 ) to return a book. **( 0 )** to End Program.");
                int mainOption = 0; 
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        if (number == 1 || number ==2 || number ==0)
                        {
                            mainOption = number;
                            break;
                        }

                    }
                    Console.WriteLine("invalid input !!");
                    Console.WriteLine();
                    Console.WriteLine("Enter ( 1 ) to barrow  books , ( 2 ) to return a book. **( 0 )** to End Program.");
                }
                if (mainOption == 0) { break; }

                // baroow opration
                if(mainOption == 1)
                {
                    Console.WriteLine("Books to barrow:");
                    booklist.DisplayAllBooks();
                    Console.WriteLine();
                    Console.WriteLine("Select a book  by enter the book number -- enter ( 0 ) to out the program. :");
                    int bookNumber;
                    // this loop to take the nuber of the book to barrow 
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            if (number >= 0 && number <=booklist.getSize())
                            {
                                bookNumber = number;
                                break;
                            }

                        }
                        Console.WriteLine("invalid Book Number !!");
                    }

                    if (bookNumber == 0) { break; }

                    Console.WriteLine();
                    Console.WriteLine($"Book Information");
                    Console.WriteLine(booklist[bookNumber-1]);
                    Console.WriteLine();

                    Console.WriteLine(" select ( 1 ) to barrow , ( 0 ) to end shoping");

                    int option;
                    // this loop to conferm the barrow 
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            if (number == 0 || number == 1)
                            {
                                option = number;
                                break;
                            }

                        }
                        Console.WriteLine("invalid Opration Number !!");


                    }
                    if (option == 0) { break; }

                    barrowedbooklist.returnBook(booklist.getBookName(bookNumber), booklist.getBookAuthor(bookNumber));
                    booklist.barrowBook(bookNumber);             
                }

                // return opration
                if(mainOption == 2) 
                {
                    Console.WriteLine("Books to return:");
                    barrowedbooklist.DisplayAllBooks();
                    Console.WriteLine();
                    Console.WriteLine("Select a book  by enter the book number -- enter ( 0 ) to out the program. :");
                    int bookNumber;
                    // this loop to take the nuber of the book to return 
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            
                            if (number >= 0 && number <=barrowedbooklist.getSize())
                            {
                                bookNumber = number;
                                break;
                            }

                        }
                        Console.WriteLine("invalid Book Number !!");
                    }

                    if (bookNumber == 0) { break; }

                    Console.WriteLine();
                    Console.WriteLine($"Book Information");
                    Console.WriteLine(barrowedbooklist[bookNumber-1]);
                    Console.WriteLine();

                    Console.WriteLine(" select ( 1 ) to return , ( 0 ) to end shoping");

                    int option;
                    // this loop to conferm the barrow 
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            if (number == 0 || number == 1)
                            {
                                option = number;
                                break;
                            }

                        }
                        Console.WriteLine("invalid Opration Number !!");


                    }
                    if (option == 0) { break; }

                    booklist.returnBook(barrowedbooklist.getBookName(bookNumber), barrowedbooklist.getBookAuthor(bookNumber));
                    barrowedbooklist.barrowBook(bookNumber);
                }




            }

        }

    }

    }
