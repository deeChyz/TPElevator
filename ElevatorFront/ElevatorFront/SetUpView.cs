using Presentation.Interfaces.Views;
using System;
using System.Windows.Forms;

namespace ElevatorFront
{
    public partial class SetUpView : Form, ISetUpView
    {
        public string NumberOfFloors => tbNumberOfFloors.Text;

        public SetUpView()
        {
            InitializeComponent();
        }

        public event Action SetUp;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            SetUp?.Invoke();
        }

        public void ShowError(string message)
        {
            lblError.Text = message;
        }

        private void SetUpView_Load(object sender, EventArgs e)
        {

        }
    }
}
