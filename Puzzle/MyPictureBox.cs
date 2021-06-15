using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    class MyPictureBox : System.Windows.Forms.PictureBox
    {
        int index;
        int imageIndex;

        public int Index { get => index; set => index = value; }
        public int ImageIndex { get => imageIndex; set => imageIndex = value; }
        public bool IsMatch() 
        {
            return index == imageIndex;
        }
    }
}
