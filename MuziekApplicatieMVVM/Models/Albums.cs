using System.Collections.Generic;

namespace MuziekApplicatieMVVM.Models
{
    public class Albums : Notify
    {

        private List<Songs> songs;

        public Albums()
        {
            songs = new List<Songs>();


        }


    }
}
