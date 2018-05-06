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

        public static async Task UseDelay()
        {
            await Task.Delay(3000); // wait for 1 second
        }
    }
}
