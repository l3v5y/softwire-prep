// Copyright (c) 2013 Olly Levett
using System;

namespace SoftwirePrep.Exercises
{
    /// <summary>
    /// Book class
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Book title
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Book author
        /// </summary>
        public string Author { get; private set; }

        /// <summary>
        /// Book publisher
        /// </summary>
        public string Publisher { get; private set; }

        /// <summary>
        /// ISBN of the book
        /// </summary>
        public string ISBN { get; private set; }

        /// <summary>
        /// Constructor that defaults publisher to O'Reilly
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Author"></param>
        /// <param name="ISBN"></param>
        public Book(string Title, string Author, string ISBN)
            : this(Title, Author, "O'Reilly", ISBN)
        {
        }

        /// <summary>
        /// Initialises a book object
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Author"></param>
        /// <param name="Publisher"></param>
        /// <param name="ISBN"></param>
        public Book(string Title, string Author, string Publisher, string ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
            this.ISBN = ISBN;
        }

        /// <summary>
        /// Display the book title on the console
        /// </summary>
        /// <returns></returns>
        public void DisplayBook()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// Provides a formatted representation of the book
        /// </summary>
        /// <returns>Title  Author(s) Publisher ISBN</returns>
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", this.Title, this.Author, this.Publisher, this.ISBN);
        }
    }
}