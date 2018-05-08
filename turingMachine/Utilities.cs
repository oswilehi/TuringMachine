using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace turingMachine
{
    class Utilities
    {
        public static void CenterForm(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }

        public static void FillCombobox(ComboBox speed)
        {
            speed.Items.Add("Alta");
            speed.Items.Add("Media");
            speed.Items.Add("Baja");
        } 

        public static void CancelMaximizeAndMinimize(Form form)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
        }
    }
}
