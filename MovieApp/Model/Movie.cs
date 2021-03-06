﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Model
{
  public   class Movie : NotifyChanged
    {
        
        // Description about the movie
        public string _imageUrl { get; set; }
        private string _title;
        private string _director;
        private string _length;
        private string _genre;
        private string _censorship;
        private string _description;
        private int _price;
        private Uri _trailer;
        

        // Constructer.
        public Movie(string imageUrl,string title, string director, string lenght, string genre, string actors, string censorship, string description, int price)
        {
            _imageUrl = imageUrl;
            _title = title;
            _director = director;
            _length = lenght;
            _censorship = censorship;
            _description = description;
            _genre = genre;
            _price = price;
        }

        // Constructer if the movie has trailer.

        public Movie(string imageUrl, string title, string director, string lenght, string genre, string actors, string censorship, string description, int price, Uri trailer)
        {
            _imageUrl = imageUrl;
            _title = title;
            _director = director;
            _length = lenght;
            _censorship = censorship;
            _description = description;
            _genre = genre;
            _price = price;
            _trailer = trailer;
        }

        // Needed to add an empty contructer for the relay Command.
        public Movie() { }

        //--------------------------------------------
        // Get, Set and OnpropertyChanged
        //--------------------------------------------
      
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(Title); }
        }

        public string Director
        {
            get { return _director; }
            set { _director = value; OnPropertyChanged(Director); }
        }

        public string Length
        {
            get { return _length; }
            set { _length = value; OnPropertyChanged(Length); }
        }


        public string Censorship
        {
            get { return _censorship; }
            set { _censorship = value; OnPropertyChanged(Censorship); }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(Description);}
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; OnPropertyChanged(Genre); }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Uri Trailer
        {
            get { return _trailer; }
            set { _trailer = value; }
        }

    


        /* Tostring method that return all the information
             about the movie */
        public override string ToString()
        {
            return "Title: " + Title + "\n" +
                   "Director: " + Director + "\n" +
                   "Length: " + Length + "\n" +
                   "Genre: " + Genre + "\n" +
                   "Censorship:  " + Censorship + "\n" +
                   "Price" + Price + "\n" +
                   "Description:  " + Description;
        }
    }
}
