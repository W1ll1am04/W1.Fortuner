using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortune_Cookie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var random = new Random();

            var list = new List<string> { "The fortune you seek is in another cookie.", "A conclusion is simply the place where you got tired of thinking.", "A foolish man listens to his heart. A wise man listens to cookies.", "An alien of some sort will be appearing to you shortly.", "He Who throws dirt is losing ground.", "Some men dream of fortunes, others dream of cookies.", "We don't know the future, but here's a cookie.", "The world may be your oyster, but it doesn't mean you'll get its pearl.", "Only listen to the fortune cookie; disregard all other fortune telling units.", "No snowflake feels responsible in an avalanche.", "Ask your mom instead of a cookie.", "He who laughs at himself never runs out of things to laugh at." };
            int index = random.Next(list.Count);

            fortune.Text = (list[index]);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
