using System;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private int _pileOuFace;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _pileOuFace = new Random().Next(2);
            if (_pileOuFace == 1)
            {
                nbPiles.Text = Convert.ToString(Convert.ToInt32(nbPiles.Text) + 1);
            }
            else
            {
                nbFaces.Text = Convert.ToString(Convert.ToInt32(nbFaces.Text) + 1);
            }
        }
    }
}
