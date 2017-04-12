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
    enum Result{HIGH,LOW,CORRECT };
    class Guessing
    {
        private int limit;
        private int thinkedNum;

        public Guessing(int limit)
        {
            this.limit=limit;
        }
        public void Think()
        {
            Random rand = new Random();
            thinkedNum = rand.Next(1,limit);
        }
        public Result Check(int guessedNo)
        {
            if (guessedNo > thinkedNum)
            {
                MessageBox.Show("Value is Too High");
                return Result.HIGH;
            }
            if(guessedNo < thinkedNum)
            {
                MessageBox.Show("Value is Too Low");
                return Result.LOW;
            }
            return Result.CORRECT;
        }
    }
}
