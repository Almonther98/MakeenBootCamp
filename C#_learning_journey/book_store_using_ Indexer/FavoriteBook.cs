using System.Globalization;

namespace favoriteBook
{
    internal class FavoriteBook
        {
            private string[] names;
            private string[] authors;
        



            // constracter 
            public FavoriteBook(int size)
            {
                
                this.names = new string[size];
                this.authors = new string[size];
            }


            // set 
            public string this[int idx, string name]
            {
                set { this.names[idx] = name; this.authors[idx] = value; }

            }
            // get by name
            public string this[string name]
            {
                get
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (this.names[i] == name) return "Name: " + this.names[i] + "  Author: " + this.authors[i];
                    }

                    return "notfound !";
                }
            }

            // by index
            public string this[int index]
            {
                get
                {
                    return $"Name: {this.names[index]} --> Author: {this.authors[index]}";
                }
            }


            public void DisplayAllBooks()
            {
                Console.WriteLine("******************BOOKS******************");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"BookNumber [ {i + 1} ] Name: {names[i]}  ");
                }
                Console.WriteLine("******************BOOKS******************");

            }
            /*
             
             ##### this function delete the book name and the author from the tow lists by the book number 
                    input: book number 
             
             
             */
            public void barrowBook(int pos)
            {
                
                int indx = 0;

                string[] tempNames = new string[names.Length - 1];
                string[] tempAuthors = new string[authors.Length - 1];

                for (int i = 0; i < names.Length; i++)
                {

                    if (i == pos - 1)
                    {
                        continue;
                    }

                    tempNames[indx] = names[i];
                    tempAuthors[indx] = authors[i];

                    indx++;

                }

                names = tempNames;
                authors = tempAuthors;
            }
            /*
             
             ##### this function add the book name and the author to the tow lists by taking book name and the book author 
                    input: -book name 
                           -author name 
             
             
             */
        public void returnBook(string name, string aouthr)
            {

                if (names == null)
                {
                    names = new string[] { name };
                    authors = new string[] { aouthr };
                }
                else
                {
                    string[] tempNames = new string[names.Length + 1];
                    string[] tempAuthors = new string[authors.Length + 1];

                    for (int i = 0; i < names.Length; i++)
                    {
                        tempNames[i] = names[i];
                        tempAuthors[i] = authors[i];
                    }
                    tempNames[tempNames.Length - 1] = name;
                    tempAuthors[tempAuthors.Length - 1] = aouthr;
                    authors = tempAuthors;
                    names = tempNames;

                }
            }

            /*
              this function return the size of the nams list as the length of both lists length 
             */
            public int getSize()
            {
                return names.Length;
            }

            // grt book info
            public string getBookName(int index)
            {
                return names[index-1];
            }
            public string getBookAuthor(int index)
            {
                return authors[index-1];
            }


    }

    }
