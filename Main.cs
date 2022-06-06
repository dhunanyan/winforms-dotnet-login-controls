using CustomControls.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void CustomTextBoxPassword1__TextChanged(object sender, EventArgs e)
        {
            panelPasswordCharCapital.BackgroundImage = Boolean.Parse(customTextBoxPassword1.IsCharCapitalPassed.ToString()) ? Resources.key : Resources.error;
            panelPasswordCharDigit.BackgroundImage = Boolean.Parse(customTextBoxPassword1.IsCharDigitPassed.ToString()) ? Resources.key : Resources.error;
            panelPasswordCharSpecial.BackgroundImage = Boolean.Parse(customTextBoxPassword1.IsCharSpecialPassed.ToString()) ? Resources.key : Resources.error;
            panelPasswordCharCount.BackgroundImage = Boolean.Parse(customTextBoxPassword1.IsCharCountPassed.ToString()) ? Resources.key : Resources.error;
        }

        private void CustomTextBoxLogin1__TextChanged(object sender, EventArgs e)
        {
            panelLoginCharSpecial.BackgroundImage = Boolean.Parse(customTextBoxLogin1.IsCharSpecialPassed.ToString()) ? Resources.ok : Resources.warning;
            panelLoginCharCount.BackgroundImage = Boolean.Parse(customTextBoxLogin1.IsCharCountPassed.ToString()) ? Resources.ok : Resources.warning;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(customTextBoxLogin1.CustomText.Length == 0 && customTextBoxPassword1.CustomText.Length == 0)
            {
                MessageBox.Show("Error. Please enter your Login and Password", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLogin1.Focus();
            }
            else if(customTextBoxLogin1.CustomText.Length == 0)
            {
                MessageBox.Show("Error. Please enter your Login", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLogin1.Focus();
            }
            else if(customTextBoxPassword1.CustomText.Length == 0)
            {
                MessageBox.Show("Error. Please enter your Password", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxPassword1.Focus();
            }
            else if (Boolean.Parse(customTextBoxPassword1.IsCharCapitalPassed.ToString()) &&
               Boolean.Parse(customTextBoxPassword1.IsCharDigitPassed.ToString()) &&
               Boolean.Parse(customTextBoxPassword1.IsCharSpecialPassed.ToString()) &&
               Boolean.Parse(customTextBoxPassword1.IsCharCountPassed.ToString()) &&
               Boolean.Parse(customTextBoxLogin1.IsCharSpecialPassed.ToString()) &&
               Boolean.Parse(customTextBoxLogin1.IsCharCountPassed.ToString()))
            {
                MessageBox.Show("Congratulations you have succesfully created a new account!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                customTextBoxLogin1.CustomText = null;
                customTextBoxPassword1.CustomText = null;
                customTextBoxLogin1.Focus();
            }
            else if((!Boolean.Parse(customTextBoxLogin1.IsCharSpecialPassed.ToString()) ||
                    !Boolean.Parse(customTextBoxLogin1.IsCharCountPassed.ToString())) &&
                    (Boolean.Parse(customTextBoxPassword1.IsCharCapitalPassed.ToString()) &&
                    Boolean.Parse(customTextBoxPassword1.IsCharDigitPassed.ToString()) &&
                    Boolean.Parse(customTextBoxPassword1.IsCharSpecialPassed.ToString()) &&
                    Boolean.Parse(customTextBoxPassword1.IsCharCountPassed.ToString())))
            {
                MessageBox.Show("Error. Please enter valid Login.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLogin1.CustomText = null;
                customTextBoxLogin1.Focus();
            }
            else if((!Boolean.Parse(customTextBoxPassword1.IsCharCapitalPassed.ToString()) ||
                    !Boolean.Parse(customTextBoxPassword1.IsCharDigitPassed.ToString()) ||
                    !Boolean.Parse(customTextBoxPassword1.IsCharSpecialPassed.ToString()) ||
                    !Boolean.Parse(customTextBoxPassword1.IsCharCountPassed.ToString())) &&
                    (Boolean.Parse(customTextBoxLogin1.IsCharSpecialPassed.ToString()) &&
                    Boolean.Parse(customTextBoxLogin1.IsCharCountPassed.ToString())))
            {
                MessageBox.Show("Error. Please enter valid Password.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxPassword1.CustomText = null;
                customTextBoxPassword1.Focus();

            }
            else
            {
                MessageBox.Show("Error. Please enter valid Login and Password.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLogin1.CustomText = null;
                customTextBoxPassword1.CustomText = null;
                customTextBoxLogin1.Focus();
            }
        }
    }
}
