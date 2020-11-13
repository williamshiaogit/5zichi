using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5c
{
    public partial class 五子棋 : Form
    {
        public 五子棋()
        {
            InitializeComponent();

            //this.Controls.Add(new BlackPiece(10,20));
            //this.Controls.Add(new WhitePiece(80, 20));

        }

        private void 五子棋_Load(object sender, EventArgs e)
        {

        }

        private void 五子棋_MouseDown(object sender, MouseEventArgs e)
        {
            this.Controls.Add(new BlackPiece(e.X-25, e.Y-25));
        }

        private void 五子棋_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
