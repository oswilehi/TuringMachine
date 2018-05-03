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
        Dictionary<string, List<String>> palindromeMachine = new Dictionary<string, List<String>>();
        Dictionary<string, List<String>> copyOfPatternsMachine = new Dictionary<string, List<String>>();
        Dictionary<string, List<String>> sumMachine = new Dictionary<string, List<String>>();
        Dictionary<string, List<String>> subtractionMachine = new Dictionary<string, List<String>>();
        Dictionary<string, List<String>> multiplicationMachine = new Dictionary<string, List<String>>();
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
            templateTuringMachine palindromeForm = new templateTuringMachine(palindromeMachine, this);
            palindromeForm.Text = "Palíndromo";
            palindromeForm.Show();
            this.Visible = false;
        }

        private void goToCopyOfPatterns_Click(object sender, EventArgs e)
        {
            templateTuringMachine copyOfPatternsForm = new templateTuringMachine(copyOfPatternsMachine, this);
            copyOfPatternsForm.Text = "Copia de patrones";
            copyOfPatternsForm.Show();
            this.Visible = false;
        }

        private void goToSum_Click(object sender, EventArgs e)
        {
            templateTuringMachine sumForm = new templateTuringMachine(sumMachine, this);
            sumForm.Text = "Suma";
            sumForm.Show();
            this.Visible = false;
        }

        private void goToSubtraction_Click(object sender, EventArgs e)
        {
            templateTuringMachine subtractionForm = new templateTuringMachine(subtractionMachine, this);
            subtractionForm.Text = "Resta";
            subtractionForm.Show();
            this.Visible = false;
        }

        private void goToMultiplication_Click(object sender, EventArgs e)
        {
            templateTuringMachine multiplicationForm = new templateTuringMachine(multiplicationMachine, this);
            multiplicationForm.Text = "Multiplicación";
            multiplicationForm.Show();
            this.Visible = false;
        }
    }
}
