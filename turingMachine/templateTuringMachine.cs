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
    public partial class templateTuringMachine : Form
    {
        Dictionary<string, List<String>> turingMachine;
        Form mainForm;
        public templateTuringMachine(Dictionary<string, List<String>> turingMachine, Form mainForm)
        {
            InitializeComponent();
            this.turingMachine = turingMachine;
            this.mainForm = mainForm;
        }

        private void templateTuringMachine_Load(object sender, EventArgs e)
        {
            Utilities.CenterForm(this);
            
        }

        private void templateTuringMachine_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }
    }
}
