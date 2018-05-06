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
        Form mainForm;
        int typeOfMachine;
        public templateTuringMachine(Form mainForm, int typeOfMachine)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.typeOfMachine = typeOfMachine;
        }

        private void templateTuringMachine_Load(object sender, EventArgs e)
        {
            Utilities.CenterForm(this);
            
        }

        private void templateTuringMachine_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn_runMachine_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            tapeOfTuring.Columns.Clear();
            Process.ExecuteMachine(txt_instruction,tapeOfTuring, lbl_actualState, lbl_stepsCounter, typeOfMachine);
        }
    }
}
