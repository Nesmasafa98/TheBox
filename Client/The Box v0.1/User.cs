using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Box_v0._1
{
    public class User
    { 
        string username;
        int Score;
        bool IsRoomOwner;
        bool IsPlayer;
        Room room;
        //new comment
        public string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public User(string name)
        {
            UserName = name;
        }
    }
}
