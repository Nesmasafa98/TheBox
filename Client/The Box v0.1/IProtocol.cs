using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static The_Box_v0._1.Game;

namespace The_Box_v0._1
{
    interface IProtocol
    {
        Boolean ResponsecheckIfisInList(string UserName);
       

                  void StateConfigPlayer1();




        void StateConfigPlayer2();


                  state[,] ResponseReceiveState();

         Room ResponseJoin(User Myuser, string id, string p2Color);

         Room ResponseWatch(string id);

        void ResponseLog(User user);


        void ResponseShowplayer(List<User> players);


         void ResponseShowRooms(List<Room> rooms);
               

                Room ResponseCreate(User player1, string id, int index, string p1color);


    }
}