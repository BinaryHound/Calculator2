using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAttempt {
    //ALL METHODS ARE PUBLIC FOR UNIT TESTING CURRENTLY!

    public partial class Form1 : Form {
       
        //Operators: The logical manipulations of data such as: +, -, *, /.
        public Stack<char> operatorsStack;

        //Holds the values for the output label.
        private StringBuilder sb;

        //Container to hold the number combinations when 1 and 2 are pressed to hold 12.
        Queue<float> numContainer;

        //Operands: The actual data, such as: 1, 2, 3, 4, 5, 6, 7, 8, 9, 0.
        public Stack<float> operandsStack;

        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public Form1() {
            InitializeComponent();
            operatorsStack = new Stack<char>();

            //has to be a float because otherwise we can't implement the decimal addition, subtraction, etc.
            operandsStack = new Stack<float>();
            sb = new StringBuilder();
            numContainer = new Queue<float>();
        }

        /// <summary>
        /// Checks to see if the values entered are in the correct order. Helps minimize wrongful operations to parsing.
        /// </summary>
        /// <returns></returns>
        public bool TokenChecker(Stack<float> Operand, Stack<char> Operator)
        {
            //TODO: Check to see if the next addition is valid.
            if( numContainer.Count > 0 || Operator.Count < Operand.Count )
            {
                return true;
            }
            return false;
        }

        private void numDequeuer()
        {
            float number = 0;
            //If there is only one value, then we simply just dequeue the queue.
            if (numContainer.Count == 1)
            {
                operandsStack.Push(numContainer.Dequeue());
            } else
            {
                while (numContainer.Count > 0)
                {
                    //Dequeue the current container of numbers and "contain" it in an float.
                    number += numContainer.Dequeue();
                    if (numContainer.Count > 0)
                    {
                        number *= 10;
                    }
                }
                //Move the operands stack push into here. Otherwise we are adding the number 0 to the stack...
                operandsStack.Push(number);
            }
        }

        public void EvaluateExpression(Stack<float> Operand, Stack<char> Operator)
        {
            //TODO: Evaluate the expression by 'popping' off of the Stacks and replacing with a push to the Operands Stack.
            float result = 0;
            while (( Operand.Count  > 0 ) && ( Operator.Count > 0 )) 
            {
                float num1 = Operand.Pop();
                float num2 = Operand.Pop();
                char evaluater = Operator.Pop();
                switch(evaluater)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num2 - num1;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num2 / num1;
                        break;
                    case '.':
                        Console.WriteLine("Currently not implemented...");
                        break;
                }
                operandsStack.Push(result);
                sb.Remove(0, sb.Length);
                sb.Append(result.ToString());
                Output.Text = sb.ToString();
            }
        }
        
        //TODO: Look into using only one delegate for a button press and possibly using a switch to find the right values.

        public void One_Click(object sender, EventArgs e)
        {
            //I want to call a method that checks that an operator is next to the number so we aren't adding 1 2 + unless of course.
            //the number is 12.
            numContainer.Enqueue(1);
            sb.Append("1");
            Output.Text = sb.ToString();
        }

        public void Two_Click(object sender, EventArgs e)
        {
            numContainer.Enqueue(2);
            sb.Append("2");
            Output.Text = sb.ToString();
        }


        public void Three_Click(object sender, EventArgs e)
        {
            numContainer.Enqueue(3);
            sb.Append("3");
            Output.Text = sb.ToString();
        }

        public void Four_Click(object sender, EventArgs e)
        {
            numContainer.Enqueue(4);
            sb.Append("4");
            Output.Text = sb.ToString();
        }

        public void Five_Click(object sender, EventArgs e)
        {
            numContainer.Enqueue(5);
            sb.Append("5");
            Output.Text = sb.ToString();
        }

        public void Six_Click(object sender, EventArgs e)
        {
            numContainer.Enqueue(6);
            sb.Append("6");
            Output.Text = sb.ToString();
        }

        public void Seven_Click(object sender, EventArgs e)
        {
            numContainer.Enqueue(7);
            sb.Append("7");
            Output.Text = sb.ToString();
        }

        public void Eight_Click(object sender, EventArgs e)
        {
            numContainer.Enqueue(8);
            sb.Append("8");
            Output.Text = sb.ToString();
        }

        public void Nine_Click(object sender, EventArgs e)
        {
            numContainer.Enqueue(9);
            sb.Append("9");
            Output.Text = sb.ToString();
        }

        public void Zero_Click(object sender, EventArgs e)
        {
            numContainer.Enqueue(0);
            sb.Append("0");
            Output.Text = sb.ToString();
        }

        public void Subtract_Click(object sender, EventArgs e)
        {
            //Make sure that if the - button is pressed that there is even anything to subtract in the first place.
            if(TokenChecker(operandsStack, operatorsStack))
            {
                if(numContainer.Count > 0)
                {
                    numDequeuer();
                }
                operatorsStack.Push('-');
                sb.Append(" - ");
                Output.Text = sb.ToString();
            }
        }

        public void Add_Click(object sender, EventArgs e)
        {
            if (TokenChecker(operandsStack, operatorsStack))
            {
                if (numContainer.Count > 0)
                {
                    numDequeuer();
                }
                operatorsStack.Push('+');
                sb.Append(" + ");
                Output.Text = sb.ToString();
            }
        }

        //NOT IMPLEMENTED YET!
        public void Decimal_Click(object sender, EventArgs e)
        {
            TokenChecker(operandsStack, operatorsStack);
            operatorsStack.Push('.');
        }

        public void Multiply_Click(object sender, EventArgs e)
        {
            if (TokenChecker(operandsStack, operatorsStack))
            {
                if (numContainer.Count > 0)
                {
                    numDequeuer();
                }
                operatorsStack.Push('*');
                sb.Append(" * ");
                Output.Text = sb.ToString();
            }
        }

        public void Division_Click(object sender, EventArgs e)
        {
            if (TokenChecker(operandsStack, operatorsStack))
            {
                if (numContainer.Count > 0)
                {
                    numDequeuer();
                }
                operatorsStack.Push('/');
                sb.Append(" / ");
                Output.Text = sb.ToString();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            operandsStack.Clear();
            operatorsStack.Clear();
            numContainer.Clear();
            Output.Text = "0";
            sb.Clear();
        }

        public void Equals_Click(object sender, EventArgs e)
        {
            numDequeuer();
            EvaluateExpression(operandsStack, operatorsStack);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonCalendar.Height;
            panelLeft.Top = buttonCalendar.Top;
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonCalculator.Height;
            panelLeft.Top = buttonCalculator.Top;
        }

        private void buttonToDo_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonToDo.Height;
            panelLeft.Top = buttonToDo.Top;
        }

        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonNotepad.Height;
            panelLeft.Top = buttonNotepad.Top;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
