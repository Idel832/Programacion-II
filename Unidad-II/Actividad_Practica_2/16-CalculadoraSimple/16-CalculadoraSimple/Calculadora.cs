using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_CalculadoraSimple
{
    public partial class Form_Main : Form

    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool OperationPending = false;

        public Form_Main()
        {
            InitializeComponent();
        }
        private void Btn_Num_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            TxtBox_Result.Text = currentInput;
        }

        private void Btn_Operacion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                if (OperationPending)
                {
                    Operar();
                }

                Button button = (Button)sender;
                operation = button.Text;
                result = double.Parse(currentInput);
                currentInput = "";
                OperationPending = true;
            }
        }

        private void Operar()
        {
            if (OperationPending)
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;

                    case "-":
                        result -= secondNumber;
                        break;

                    case "*":
                        result *= secondNumber;
                        break;

                    case "/":
                        if (secondNumber != 0)
                        {
                            result /= secondNumber;
                        }
                        else
                        {
                            TxtBox_Result.Text = "Error";
                            return;
                        }
                        break;
                }
                TxtBox_Result.Text = result.ToString();
                currentInput = "";
                OperationPending = false;
            }
        }


        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            OperationPending = false;
            TxtBox_Result.Text = "";

        }
        private void Btn_Result_Click(object sender, EventArgs e)
        {
            try
            {
                Operar();
            }
            catch
            {
                TxtBox_Result.Text = "Error";
                currentInput = "";
                OperationPending = false;
            }

        }
    }
}
