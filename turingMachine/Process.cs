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

        static int steps = 0;
        static string actualState = "q0";
        static int actualPositionInTape = 1;
        static int actualMove = 0;
        static int numberOfStates;
        static int horizontalMove = 55;
        static bool inputIsCorrect = true;
        static Dictionary<string, List<String>> turingMachine = new Dictionary<string, List<String>>();
        static Dictionary<string, string> definitionOfTuringMachine = new Dictionary<string, string>();

        /* 1->palindrome
         * 2->copyOfPatterns
         * 3->sum
         * 4->subtraction
         * 5->multiplication 
         */
        public static void fillDictionary(int dictionary)
        {
            switch (dictionary)
            {
                case 1:
                    fillPalindrome(turingMachine);
                    fillDefinitionOfTuringMachine(numberOfStates, "a,b,c", "a,b,c,B", "q8");
                    break;
                case 2:
                    fillCopyOfPatterns(turingMachine);
                    fillDefinitionOfTuringMachine(numberOfStates, "a,b,c", "a,b,c,X,Y,Z", "q6");
                    break;
                case 3:
                    fillSum(turingMachine);
                    fillDefinitionOfTuringMachine(numberOfStates, "|,+,=", "|,X,+,=", "q4");
                    break;
            }

        }

        public static void fillPalindrome(Dictionary<string, List<String>> turingMachine)
        {
            // Estado al que me muevo, simbolo que estoy leyendo, simbolo por el que sustituyo, y hacia donde me muevo
            // List for states
            List<string> q0 = new List<string>();
            q0.Add("q1,a,B,1");
            q0.Add("q4,b,B,1");
            q0.Add("q6,c,B,1");
            q0.Add("q8,B,B,1");
            List<string> q1 = new List<string>();
            q1.Add("q1,a,a,1");
            q1.Add("q1,b,b,1");
            q1.Add("q1,c,c,1");
            q1.Add("q2,B,B,-1");
            List<string> q2 = new List<string>();
            q2.Add("q3,a,B,-1");
            q2.Add("q8,B,B,1");
            List<string> q3 = new List<string>();
            q3.Add("q3,a,a,-1");
            q3.Add("q3,b,b,-1");
            q3.Add("q3,c,c,-1");
            q3.Add("q0,B,B,1");
            List<string> q4 = new List<string>();
            q4.Add("q4,a,a,1");
            q4.Add("q4,b,b,1");
            q4.Add("q4,c,c,1");
            q4.Add("q5,B,B,-1");
            List<string> q5 = new List<string>();
            q5.Add("q3,b,B,-1");
            q5.Add("q8,B,B,1");
            List<string> q6 = new List<string>();
            q6.Add("q6,a,a,1");
            q6.Add("q6,b,b,1");
            q6.Add("q6,c,c,1");
            q6.Add("q7,B,B,-1");
            List<string> q7 = new List<string>();
            q7.Add("q3,c,B,-1");
            q7.Add("q8,B,B,1");
            List<string> q8 = new List<string>();
            q8.Add("-");

            // Fill dictionary
            turingMachine.Add("q0", q0);
            turingMachine.Add("q1", q1);
            turingMachine.Add("q2", q2);
            turingMachine.Add("q3", q3);
            turingMachine.Add("q4", q4);
            turingMachine.Add("q5", q5);
            turingMachine.Add("q6", q6);
            turingMachine.Add("q7", q7);
            turingMachine.Add("q8", q8);

            numberOfStates = turingMachine.Count;

        }

        public static void fillCopyOfPatterns(Dictionary<string, List<String>> turingMachine)
        {
            // Estado al que me muevo, simbolo que estoy leyendo, simbolo por el que sustituyo, y hacia donde me muevo
            // List for states
            List<string> q0 = new List<string>();
            q0.Add("q0,Z,Z,1");
            q0.Add("q0,X,X,1");
            q0.Add("q0,Y,Y,1");
            q0.Add("q1,a,X,1");
            q0.Add("q3,b,Y,1");
            q0.Add("q4,c,Z,1");
            q0.Add("q5,B,B,-1");
            List<string> q1 = new List<string>();
            q1.Add("q1,Z,Z,1");
            q1.Add("q1,X,X,1");
            q1.Add("q1,Y,Y,1");
            q1.Add("q1,a,a,1");
            q1.Add("q1,b,b,1");
            q1.Add("q1,c,c,1");
            q1.Add("q2,B,X,-1");
            List<string> q2 = new List<string>();
            q2.Add("q2,Z,Z,-1");
            q2.Add("q2,X,X,-1");
            q2.Add("q2,Y,Y,-1");
            q2.Add("q2,a,a,-1");
            q2.Add("q2,b,b,-1");
            q2.Add("q2,c,c,-1");
            q2.Add("q0,B,B,1");
            List<string> q3 = new List<string>();
            q3.Add("q3,Z,Z,1");
            q3.Add("q3,X,X,1");
            q3.Add("q3,Y,Y,1");
            q3.Add("q3,a,a,1");
            q3.Add("q3,b,b,1");
            q3.Add("q3,c,c,1");
            q3.Add("q2,B,Y,-1");
            List<string> q4 = new List<string>();
            q4.Add("q4,Z,Z,1");
            q4.Add("q4,X,X,1");
            q4.Add("q4,Y,Y,1");
            q4.Add("q4,a,a,1");
            q4.Add("q4,b,b,1");
            q4.Add("q4,c,c,1");
            q4.Add("q2,B,Z,-1");
            List<string> q5 = new List<string>();
            q5.Add("q5,Z,c,-1");
            q5.Add("q5,X,a,-1");
            q5.Add("q5,Y,b,-1");
            q5.Add("q6,B,B,1");
            List<string> q6 = new List<string>();
            q6.Add("-");

            // Fill dictionary
            turingMachine.Add("q0", q0);
            turingMachine.Add("q1", q1);
            turingMachine.Add("q2", q2);
            turingMachine.Add("q3", q3);
            turingMachine.Add("q4", q4);
            turingMachine.Add("q5", q5);
            turingMachine.Add("q6", q6);
            numberOfStates = turingMachine.Count;
        }

        public static void fillSum(Dictionary<string, List<String>> turingMachine)
        {
            List<string> q0 = new List<string>();
            q0.Add("q4,=,=,1");
            q0.Add("q1,|,X,1");
            q0.Add("q0,+,+,1");
            List<string> q1 = new List<string>();
            q1.Add("q1,|,|,1");
            q1.Add("q1,+,+,1");
            q1.Add("q2,=,=,1");
            List<string> q2 = new List<string>();
            q2.Add("q2,|,|,1");
            q2.Add("q3,B,|,-1");
            List<string> q3 = new List<string>();
            q3.Add("q3,|,|,-1");
            q3.Add("q3,+,+,-1");
            q3.Add("q3,=,=,-1");
            q3.Add("q0,X,X,1");
            List<string> q4 = new List<string>();
            q4.Add("-");

            turingMachine.Add("q0", q0);
            turingMachine.Add("q1", q1);
            turingMachine.Add("q2", q2);
            turingMachine.Add("q3", q3);
            turingMachine.Add("q4", q4);

            numberOfStates = turingMachine.Count;

        }

        public static void fillSubtraction(Dictionary<string, List<String>> turingMachine)
        {

        }

        public static void fillMultiplication(Dictionary<string, List<String>> turingMachine)
        {

        }

        public static async void ExecuteMachine(TextBox instruction, DataGridView tape, Label State, Label counterOfSteps, int typeOfMachine)
        {
            //Limpiar valores
            steps = 0;
            actualState = "q0";
            actualPositionInTape = 1;
            actualMove = 0;
            State.Text = "q0";
            counterOfSteps.Text = "0";
            //Limpiar diccionarios
            if (turingMachine != null)
                turingMachine.Clear();
            if (definitionOfTuringMachine != null)
                definitionOfTuringMachine.Clear();
            fillDictionary(typeOfMachine);
            //Verificar entrada
            if (verifyInput(instruction.Text, typeOfMachine))
            {
                fillDataGrid(instruction, tape);
                while (actualState != definitionOfTuringMachine["AS"] && inputIsCorrect)
                {
                    await Task.Delay(1000);
                    Transition(tape, State, counterOfSteps);
                    await Task.Delay(1000)/*.Wait()*/;
                }
                if (inputIsCorrect)
                    MessageBox.Show("La cadena ingresada es válida");
                else
                    MessageBox.Show("La cadena ingresada no es válida");
                instruction.Text = "";
            }
            else
            {
                MessageBox.Show("La cadena ingresada tiene carácteres no permitidos");
                instruction.Text = "";
            }
            inputIsCorrect = true;              
        }

        public static void fillDataGrid(TextBox instruction, DataGridView tape)
        {

            if (instruction.Text != "")
            {
                string text = instruction.Text;
                char[] instructiontxt = text.ToCharArray();
                for (int i = 0; i < instruction.Text.Length + 2; i++)
                {
                    tape.Columns.Add(i.ToString(), i.ToString());
                    if (i <= instructiontxt.Length && i != 0)
                        tape[i, 0].Value = instructiontxt[i - 1].ToString();
                    else
                        tape[i, 0].Value = "B";
                    tape.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                tape.Rows[0].Height = 163;
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Font = new Font("Bold", 25F, GraphicsUnit.Pixel);
                tape.Rows[0].DefaultCellStyle = style;
            }
        }

        public static void Transition(DataGridView tape, Label State, Label counterOfSteps)
        {
            // Agrego una columna cuando el cabezal se acerque al final
            if (actualPositionInTape + 1 == tape.Columns.Count)
            {
                tape.Columns.Add((actualPositionInTape + 1).ToString(), (actualPositionInTape + 1).ToString());
                tape[actualPositionInTape + 1, 0].Value = "B";
            }

            //Pinto la celda donde va el cabezal
            if (tape.Rows[0].Cells[actualPositionInTape].Style.BackColor == Color.Aqua)
                tape.Rows[0].Cells[actualPositionInTape].Style.BackColor = Color.Red;
            else
                tape.Rows[0].Cells[actualPositionInTape].Style.BackColor = Color.Aqua;

            tape.HorizontalScrollingOffset = tape.HorizontalScrollingOffset + horizontalMove;

            //Primero leo el primer caracter de la cadena para ver si hay una transicion para ese simbolo
            List<string> transitions = turingMachine[actualState];
            for (int i = 0; i < transitions.Count; i++)
            {
                string[] transition = transitions.ElementAt<string>(i).Split(',');
                if (transition[1] == tape.Rows[0].Cells[actualPositionInTape].Value.ToString())
                {
                    actualState = transition[0];
                    actualMove = int.Parse(transition[3]);
                    tape.Rows[0].Cells[actualPositionInTape].Value = transition[2];
                    actualPositionInTape = actualPositionInTape + actualMove;
                    steps++;
                    State.Text = actualState;
                    counterOfSteps.Text = steps.ToString();
                    break; 
                }
                else
                {
                    if (i == transitions.Count - 1)
                        inputIsCorrect = false;
                }
            }

            //MessageBox.Show("La cadena no es válida para el automata");

        }


        public static void fillDefinitionOfTuringMachine(int numberOfStates, string inputsPermitted, string symbolsOfTape, string acceptationState)
        {
            // number of states
            definitionOfTuringMachine.Add("NS", numberOfStates.ToString());
            // inpust permitted separated by commas
            definitionOfTuringMachine.Add("IP", inputsPermitted);
            // symbols of tape separated by commas
            definitionOfTuringMachine.Add("ST", symbolsOfTape);
            // initial state
            definitionOfTuringMachine.Add("IS", "q0");
            // whitespace
            definitionOfTuringMachine.Add("WS", "B");
            // acceptation state
            definitionOfTuringMachine.Add("AS", acceptationState);
        }

        public static bool verifyInput(string instruction, int typeOfMachine)
        {
            string[] inputsPermitted = definitionOfTuringMachine["IP"].Split(',');
            char[] input = instruction.ToCharArray();

            if (input.Length == 0)
                return false;

            if (typeOfMachine == 3 | typeOfMachine == 4 | typeOfMachine == 5)
            {
                if (input[input.Length - 1] != '=')
                    return false;
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (inputsPermitted.Contains<string>(input[i].ToString()))
                            continue;
                        else
                            return false;
                    }
                }
            }

            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (inputsPermitted.Contains<string>(input[i].ToString()))
                        continue;
                    else
                        return false;
                }
            }          
            return true;
        }
    }
}
