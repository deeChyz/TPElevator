using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorFront
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 12; i++)
            { 
                floorMainPanel.Controls.Add(new FloorCell());
                floorButtonIndicatorsBox.Controls.Add(new FloorIndicator());
            }

            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек ждет лифта на 1 этаже"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек едет на 3 этаж"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек ждет лифта на 2 этаже"));
            peopleOnlineStats.Controls.Add(new UserStatMessage("Человек доставлен на целевой этаж 2 "));

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }

        private void floorMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void floorButtonIndicatorsBox_Paint(object sender, PaintEventArgs e)
        {

        } 

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void peopleCounterLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
