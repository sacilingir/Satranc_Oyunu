using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satranc_oyunu
{
    internal class Piyon : Chesspiece,IChesspiece
    {

      //Piyon sınıfı üst sınıftan özelliklerini alır.
        public Piyon(int PosX,int PosY, int Score, string type)
        {
            
            this.Score=Score;
            this.PosX = PosX;
            this.PosY= PosY;
            this.type = type;
        }

    }
}
