using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _5c
{
    //abstract 可以防止物件被意外的建立出來
    abstract class Piece : PictureBox
    {
        private static readonly int IMAGE_WIDTH = 50;

        public Piece(int x, int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x, y);
            this.Size = new Size(IMAGE_WIDTH, IMAGE_WIDTH);

        }
    }
}
