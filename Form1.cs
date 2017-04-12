using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class GuessGame : Form
    {
        public GuessGame()
        {
            InitializeComponent();
                Guess.Think();
        }
        Guessing Guess = new Guessing(10);
        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            option.Clear();
            Guess.Think();
        }
    }
}
