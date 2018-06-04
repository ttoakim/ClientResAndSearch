using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubTest
{
    public partial class Form1 : Form
    {
        public Button btn;
        public Form1()
        {
            InitializeComponent();
            btn = new Button();
            btn.Location = new Point(50,50);
            btn.Text = "수정버튼";
            btn.Size = new Size(30,20);
            Controls.Add(btn);
        }
    }
}
