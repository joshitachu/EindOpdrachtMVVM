using System;
using System.Collections.Generic;

namespace MuziekApplicatieMVVM.Models
{
    public class Songs : Notify
    {

        public List<Songs> songList;

        public Songs(String voornaam, int songid, double duration, String songName, String achternaam, String genre)
        {

            this.Genre = genre;
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.SongName = songName;
            this.Duration = duration;
            this.SongID = songid;
            songList = new List<Songs>();



        }


        private String voornaam;

        public String Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; OnPropertyChanged("Voornaam"); }
        }

        private String achternaam;

        public String Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; OnPropertyChanged("Achternaam"); }
        }


        private String genre;

        public String Genre
        {
            get { return genre; }
            set { genre = value; OnPropertyChanged("Genre"); }
        }

        






        private int songID;

        public int SongID
        {
            get { return songID; }
            set { songID = value; OnPropertyChanged("SongId"); }
        }

        private String songName;

        public String SongName
        {
            get { return songName; }
            set { songName = value; OnPropertyChanged("SongName"); }
        }


        private double duration;

        public double Duration
        {
            get { return duration; }
            set { duration = value; OnPropertyChanged("Duration"); }
        }














        public Songs() { }
    }
}
