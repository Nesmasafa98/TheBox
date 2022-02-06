using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Box_v0._1
{
    public class Board
    {
        string size;
        string Color1;
        string Color2;
        int[][] State;

        //return
        public Board(string s)
        {
            size = s;
        }
    }
}
