using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace turingMachine
{
    class Process
    {
        /* 1->palindrome
         * 2->copyOfPatterns
         * 3->sum
         * 4->subtraction
         * 5->multiplication 
         */
        public static void fillDictionary(Dictionary<string, List<String>> turingMachine, int dictionary)
        {
            
        }

        public static void fillPalindrome()
        {
            // List for states
            List<string> q0 = new List<string>();
            q0.Add("q1,a,B,R");
            q0.Add("q4,b,B,R");
            q0.Add("q6,c,B,R");
            q0.Add("q8,B,B,R");
            List<string> q1 = new List<string>();
            q1.Add("q1,a,a,R");
            q1.Add("q1,b,b,R");
            q1.Add("q1,c,c,R");
            q1.Add("q2,B,B,L");
            List<string> q2 = new List<string>();
            q2.Add("q3,a,B,L");
            q2.Add("q8,B,B,R");
        }

        public static void ExecuteMachine(DataGrid tape, Dictionary<string, List<String>> turingMachine)
        {

        }
    }
}
