using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Encryptor
{
    public partial class MainForm : Form
    {
        Cryptor cryptor;
        public BasicFunction function;
        FunctionSelector functionSelector;

        public MainForm()
        {
            InitializeComponent();
            cryptor = new Cryptor(Language.Turkish);
            functionSelector = new FunctionSelector(this, factorInput, fixTermInput, funcLabel, applyButton, clearButton);
            languageBox.SelectedItem = languageBox.Items[0];
            languageBox.SelectedIndexChanged += (sender, e) => ChangeLanguage();
        }

        void ChangeLanguage()
        {
            if(languageBox.SelectedItem.ToString() == "Türkçe")
            {
                cryptor.language = Language.Turkish;
            }
            else
            {
                cryptor.language = Language.English;
            }
        }
        private void enCryptButton_Click(object sender, EventArgs e)
        {
            if (function == null)
            {
                return;
            }
            string text = inputBox.Text;
            string enText = cryptor.EnCrypt(text, function);
            outputLabel.Text = enText;
        }

        private void deCryptButton_Click(object sender, EventArgs e)
        {
            if (function == null)
            {
                return;
            }
            string text = inputBox.Text;
            string enText = cryptor.DeCrypt(text, function);
            outputLabel.Text = enText;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            inputBox.Text = "";
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if(outputLabel.Text == "")
            {
                return;
            }
            Clipboard.SetText(outputLabel.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputBox.Text = Clipboard.GetText();
        }
    }

    class FunctionSelector
    {
        NumericUpDown factor;
        NumericUpDown fixTerm;
        Label function;
        Button applyButton;
        Button clearButton;
        Cryptor cryptor;
        MainForm main;

        public FunctionSelector(MainForm main,NumericUpDown factor, NumericUpDown fixTerm, Label function, Button applyButton, Button clearButton)
        {
            this.factor = factor;
            this.fixTerm = fixTerm;
            this.function = function;
            this.applyButton = applyButton;
            this.clearButton = clearButton;
            this.main = main;
            this.applyButton.Click += (sender, e) => ApplyClick();
            this.clearButton.Click += (sender, e) => ClearClick();
        }

        void ApplyClick()
        {
            if(factor.Value == 0 || fixTerm.Value == 0)
            {
                return;
            }
            main.function = new BasicFunction((int)factor.Value, (int)fixTerm.Value);
            function.Text = "f(x) = " + factor.Value.ToString() + "x" + " + " + fixTerm.Value.ToString();
        }

        void ClearClick()
        {
            function.Text = "f(x) = ax + b";
            factor.Value = 0;
            fixTerm.Value = 0;
        }
    }
}
