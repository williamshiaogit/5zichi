﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5c
{
    class WhitePiece : Piece
    {   
        //必須有自己的建構子，把新的x y傳給base的x y
        public WhitePiece(int x, int y) : base(x, y)
        {
            this.Image = Properties.Resources.white;
        }
    }
}
