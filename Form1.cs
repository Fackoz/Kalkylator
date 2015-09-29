using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (isOperationPerformed))
                textBox_result.Clear();

            SpeechSynthesizer speech = new SpeechSynthesizer();
            Button button = (Button)sender;
            speech.SpeakAsync(button.Text);
            isOperationPerformed = false;
            if (button.Text == ",")
            {
                if (!textBox_result.Text.Contains(","))
                    textBox_result.Text = textBox_result.Text = button.Text;
            }else
            textBox_result.Text = textBox_result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.SpeakAsync(button.Text);
            if (resultValue != 0)
            {
                buttonEquals.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultValue = 0;
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_result.Text = (resultValue + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultValue - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultValue * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultValue / Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;               
            }
            resultValue = Double.Parse(textBox_result.Text);
            labelCurrentOperation.Text = "";
            SpeechSynthesizer speech = new SpeechSynthesizer();
            Button button = (Button)sender;
            speech.SpeakAsync(button.Text);
            speech.SpeakAsync(resultValue.ToString());
        }

        private void avslutaProgrammetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

    }
}
