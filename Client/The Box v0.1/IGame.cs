using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static The_Box_v0._1.Game;

namespace The_Box_v0._1
{
    interface IGame
    {





        String WinningPlayer();



        void ReceiveStateOfOthterPlayer(Forms.BoardForm boardForm);

    }
}
