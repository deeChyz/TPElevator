using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorFront
{
    public partial class FloorCell : UserControl
    {
        public event Action OpenAddNewPassengerView;
        public FloorCell()
        {
            InitializeComponent();
        }

        private void FloorCell_Load(object sender, EventArgs e)
        {

        }

        private void elevetorCellCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            OpenAddNewPassengerView?.Invoke();
        }

        private void flowLayoutPanelForPassengers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ElevatorBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MovedOutPassengers_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
