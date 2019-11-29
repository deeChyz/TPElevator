using Presentation.Interfaces.Views;
using System;
using System.Windows.Forms;

namespace ElevatorFront
{
    public partial class AddNewPassengerView : Form, IAddNewPassengerView
    {
        public AddNewPassengerView()
        {
            InitializeComponent();
        }

        public event Action<string, string> AddNewPassenger;

        public void ShowError(string message)
        {
            lblError.Text = message;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            AddNewPassenger?.Invoke(tbName.Text, tbFloor.Text);
        }
    }
}
