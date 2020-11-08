using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sticker
{
    public partial class Form1 : Form
    {
        bool drag = false;
        int mx, my;

        public static TexturePack selectedTexturePack;
        public static string dataDirectory = Environment.GetFolderPath("")

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mx = e.X;
            my = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingForm().Show();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
                SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        }
    }
}
