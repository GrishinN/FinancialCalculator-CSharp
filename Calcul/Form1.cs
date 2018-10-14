using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    public struct numberСharacteristic
    {
        public StringBuilder value;
        public int point_position;
        public int len;
        public decimal decimalValue;
    }

    public partial class Form1 : Form
    {
        bool vvodFirstNnumber = true;
        bool vvodSecondNnumber = true;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main(); // после перекинуть в другое место
            int operation;
            numberСharacteristic fNumber;
            numberСharacteristic sNumber;
        
            fNumber.value = new StringBuilder(firstNumber.Text);
            sNumber.value = new StringBuilder(secondNumber.Text);
            
            fNumber.len = fNumber.value.Length;
            sNumber.len = sNumber.value.Length;

            fNumber.decimalValue = -1;
            sNumber.decimalValue = -1;

            fNumber.point_position = -1;
            sNumber.point_position = -1;

            if(СheckNumber(ref fNumber) && СheckNumber(ref sNumber))
            {                
                operation = GetOperation();
                if(operation == -1)
                {
                    MessageBox.Show("Выберите одну из операций над числами");
                }
                else
                {
                    textBox1.Text = main.Сalculate(fNumber, sNumber, operation);
                }            
            }
            else
            {
                MessageBox.Show("Проверьте правильность вводимых данных");               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SecondNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private bool СheckNumber(ref numberСharacteristic number)
        {
            number.value.Replace('.', ',');
            number.value.Replace(" ","");
            if (!Decimal.TryParse(number.value.ToString(),out number.decimalValue))
            {
                return false;
            }            
            int k = 0;
            for (int i = number.value.Length - 1; i >= 0; i--)
            {
                if (k <= 2 && (number.value[i] == ',' || number.value[i] == '.'))
                {
                    number.point_position = k;                    
                    return true;
                }
                else if(k > 2 && (number.value[i] == ',' || number.value[i] == '.'))
                {
                    number.point_position = -1;
                    return false;
                }
                k++;
            }
            number.point_position = 0;            
            return true;
        }

        private int GetOperation()
        {
            if (radioButtonAddition.Checked)
            {
                return radioButtonAddition.TabIndex;
            }
            
            if (radioButtonSubtraction.Checked)
            {
                return radioButtonSubtraction.TabIndex;
            }

            if (radioButtonMultiply.Checked)
            {
                return radioButtonMultiply.TabIndex;
            }

            if (radioButtonDivide.Checked)
            {
                return radioButtonDivide.TabIndex;
            }

            return -1;
        }

        private void firstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 43 || e.KeyChar >= 47) && e.KeyChar != 32) //цифры, клавиша BackSpace ,запятая , точка , + и - в ASCII
            {
                e.Handled = true;
            }
        }

        private void secondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 43 || e.KeyChar >= 47) && e.KeyChar != 32) //цифры, клавиша BackSpace ,запятая , точка , + и - в ASCII
            {
                e.Handled = true;
            }
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Финансовый калькулятор_v1.\n Гришин Никита 3 курс 13 группа 2018год");
        }

        private void firstNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void firstNumber_Click(object sender, EventArgs e)
        {
            if (vvodFirstNnumber == true)
            {
                firstNumber.Text = "";
                vvodFirstNnumber = false;
            }
        }

        private void secondNumber_Click(object sender, EventArgs e)
        {
            if (vvodSecondNnumber == true)
            {
                secondNumber.Text = "";
                vvodSecondNnumber = false;
            }
        }
    }
}
