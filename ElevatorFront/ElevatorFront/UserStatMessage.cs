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
    public partial class UserStatMessage : UserControl
    {
        public UserStatMessage(String userMessage)
        {
            InitializeComponent();
            messageLabel.Text = userMessage;
        }

        private void UserStatMessage_Load(object sender, EventArgs e)
        {

        }

        private void messageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
