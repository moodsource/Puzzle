using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog = null;
        Image image = null;
        PictureBox pictureBoxWhole = null;
        private void buttonImageBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog == null)
            {
                openFileDialog = new OpenFileDialog();  
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxImagePath.Text = openFileDialog.FileName;
                image = CreateBitmapImage(Image.FromFile(openFileDialog.FileName));
                if (pictureBoxWhole == null)
                {
                    pictureBoxWhole = new PictureBox();
                    pictureBoxWhole.Width = groupBoxPuzzle.Width;
                    pictureBoxWhole.Height = groupBoxPuzzle.Height;
                    groupBoxPuzzle.Controls.Add(pictureBoxWhole);
                }
                pictureBoxWhole.Image = image;
            }
        }
        private Bitmap CreateBitmapImage(Image image) 
        {
            Bitmap bitmap = new Bitmap(groupBoxPuzzle.Width, groupBoxPuzzle.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            graphics.DrawImage(image, new Rectangle(0, 0, groupBoxPuzzle.Width, groupBoxPuzzle.Height));
            graphics.Flush();

            return bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        MyPictureBox[] pictureBoxes = null;
        private const int LEVEL_1_NUM = 4;
        private const int  LEVEL_2_NUM = 9;
        private const int LEVEL_3_NUM = 16;
        private const int LEVEL_4_NUM = 25;
        Image[] images = null;
        int currentLevel = 0;
        private void buttonLevel1_Click(object sender, EventArgs e)
        {
            currentLevel = LEVEL_1_NUM;
            labelStatus.Text = "Level 1 is ongoing...";
            PlayLevel();
        }
        private void buttonLevel2_Click(object sender, EventArgs e)
        {
            currentLevel = LEVEL_2_NUM;
            labelStatus.Text = "Level 2 is ongoing...";
            PlayLevel();
        }
        private void buttonLevel3_Click(object sender, EventArgs e)
        {
            currentLevel = LEVEL_3_NUM;
            labelStatus.Text = "Level 3 is ongoing...";
            PlayLevel();
        }
        private void buttonLevel4_Click(object sender, EventArgs e)
        {
            currentLevel = LEVEL_4_NUM;
            labelStatus.Text = "Level 4 is ongoing...";
            PlayLevel();
        }
        private void PlayLevel()
        {
            if (pictureBoxWhole != null)
            {
                groupBoxPuzzle.Controls.Remove(pictureBoxWhole);
                pictureBoxWhole.Dispose();
                pictureBoxWhole = null;
            }
            if (pictureBoxes == null || pictureBoxes.Length != currentLevel)
            {
                pictureBoxes = new MyPictureBox[currentLevel];
                images = new Image[currentLevel];
            }
            int numRow = (int)Math.Sqrt(currentLevel);
            int numCol = numRow;
            int unitX = groupBoxPuzzle.Width / numRow;
            int unitY = groupBoxPuzzle.Height / numCol;
            int[] indices = new int[currentLevel];
            for (int i = 0; i < currentLevel; i++)
            {
                indices[i] = i;
                if (pictureBoxes[i] == null)
                {
                    pictureBoxes[i] = new MyPictureBox();
                    pictureBoxes[i].Click += new EventHandler(OnPuzzleClick);
                }
                pictureBoxes[i].Width = unitX;
                pictureBoxes[i].Height = unitY;
                pictureBoxes[i].Index = i;
                CreateBitmapImage(image, images, i, numRow, numCol, unitX, unitY);
                pictureBoxes[i].Location = new Point(unitX * (i % numCol), unitY * (i / numCol));
                if (!groupBoxPuzzle.Controls.Contains(pictureBoxes[i]))
                {
                    groupBoxPuzzle.Controls.Add(pictureBoxes[i]);
                }
            }
            Shuffle(ref indices);

            for (int i = 0; i < currentLevel; i++)
            {
                pictureBoxes[i].Image = images[indices[i]];
                pictureBoxes[i].ImageIndex = indices[i];
            }
        }
        MyPictureBox firstBox;
        MyPictureBox secondBox;
        public void OnPuzzleClick(object sender, EventArgs e) 
        {
            if (firstBox == null)
            {
                firstBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (secondBox == null)
            {
                secondBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.FixedSingle;
                secondBox.BorderStyle = BorderStyle.Fixed3D;
                SwitchImage(firstBox, secondBox);
                firstBox = null;
                secondBox = null;
            }
        }
        private bool IsSuccessful() 
        {
            for (int i = 0; i < currentLevel; i++)
            {
                if (pictureBoxes[i].ImageIndex != pictureBoxes[i].Index)
                {
                    return false;
                }
            }
            return true;
        }
        private void CreateBitmapImage(Image image, Image[] images, int index, int numRow, int numCol, int unitX, int unitY) 
        {
            images[index] = new Bitmap(unitX, unitY);

            Graphics graphics = Graphics.FromImage(images[index]);
            graphics.Clear(Color.White);
            graphics.DrawImage(image, new Rectangle(0, 0, unitX, unitY),
                new Rectangle(unitX * (index % numCol), unitY * (index / numCol), unitX, unitY),
                GraphicsUnit.Pixel);
            graphics.Flush();
        }
        private void SwitchImage(MyPictureBox box1, MyPictureBox box2) 
        {
            int tmp = box2.ImageIndex;
            box2.Image = images[box1.ImageIndex];
            box2.ImageIndex = box1.ImageIndex;
            box1.Image = images[tmp];
            box1.ImageIndex = tmp;
            if (IsSuccessful())
            {
                labelStatus.Text = "Well Done";
            }
        }
        private void Shuffle(ref int[] array) 
        {
            Random random = new Random();
            int n = array.Length;
            while (n>1)
            {
                int k = random.Next(n);
                n--;
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
