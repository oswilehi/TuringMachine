using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turingMachine
{
    public partial class turingMachineProcess : Form
    {
        public turingMachineProcess()
        {
            InitializeComponent();
            
        }

        private void turingMachine_Load(object sender, EventArgs e)
        {
            // Just center the form
            Utilities.CenterForm(this);
        }

        private void goToPalindrome_Click(object sender, EventArgs e)
        {
            templateTuringMachine palindromeForm = new templateTuringMachine(this, 1);
            palindromeForm.Text = "Palíndromo";
            palindromeForm.Show();
            this.Visible = false;
        }

        private void goToCopyOfPatterns_Click(object sender, EventArgs e)
        {
            templateTuringMachine copyOfPatternsForm = new templateTuringMachine(this, 2);
            copyOfPatternsForm.Text = "Copia de patrones";
            copyOfPatternsForm.Show();
            this.Visible = false;
        }

        private void goToSum_Click(object sender, EventArgs e)
        {
            templateTuringMachine sumForm = new templateTuringMachine(this, 3);
            sumForm.Text = "Suma";
            sumForm.Show();
            this.Visible = false;
        }

        private void goToSubtraction_Click(object sender, EventArgs e)
        {
            templateTuringMachine subtractionForm = new templateTuringMachine(this, 4);
            subtractionForm.Text = "Resta";
            subtractionForm.Show();
            this.Visible = false;
        }

        private void goToMultiplication_Click(object sender, EventArgs e)
        {
            templateTuringMachine multiplicationForm = new templateTuringMachine(this, 5);
            multiplicationForm.Text = "Multiplicación";
            multiplicationForm.Show();
            this.Visible = false;
        }
    }
}
