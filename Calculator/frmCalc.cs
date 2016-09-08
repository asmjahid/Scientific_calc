using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        
        int sign_Indicator  = 0;
        double variable1;
        double variable2;
        int addBit = 0;
        int subBit = 0;
        int multBit = 0;
        int divBit = 0;
        int modBit = 0;
        int powerBit = 0;
        Boolean fl = false;
        String s, x;
       public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(1);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(1);
                sign_Indicator = 0;
            }
           fl=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(2);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(2);
                sign_Indicator = 0;
            }
           fl=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(3);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(3);
                sign_Indicator = 0;
            }
           fl=true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(4);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(4);
                sign_Indicator = 0;
            }
           fl=true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(5);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(5);
                sign_Indicator = 0;
            }
           fl=true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(6);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(6);
                sign_Indicator = 0;
            }
           fl=true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(7);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(7);
                sign_Indicator = 0;
            }
           fl=true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(8);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(8);
                sign_Indicator = 0;
            }
           fl=true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(9);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(9);
                sign_Indicator = 0;
            }
           fl=true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(0);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(0);
                sign_Indicator = 0;
            }
           fl=true;
        }
        private void reset_SignBits()
        {
        addBit = 0;
        subBit = 0;
        multBit = 0;
        divBit = 0;
        modBit = 0;
        powerBit = 0;
        fl = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                addBit = 1;
                sign_Indicator = 1;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
         txtInput.Clear();
         sign_Indicator = 0;
         variable1 = 0;
         variable2 = 0;
         reset_SignBits();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                variable2 = Convert.ToDouble(txtInput.Text);
                calculate();
                reset_SignBits();
                subBit = 1;
                sign_Indicator = 1;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                multBit = 1;
                sign_Indicator = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                divBit = 1;
                sign_Indicator = 1;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
            }
            sign_Indicator = 1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int i = 0;
            char chr = '\0';
            int decimal_Indicator = 0;
            int l = txtInput.Text.Length-1;
            if (sign_Indicator != 1)
            {
                for (i = 0; i <= l; i++)
                {
                    chr = txtInput.Text[i];
                    if (chr == '.')
                    {
                        decimal_Indicator = 1;
                    }
                }

                if (decimal_Indicator != 1)
                {
                    txtInput.Text = txtInput.Text + Convert.ToString(".");
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double s,l;
            l = Convert.ToDouble(txtInput.Text);
            s = Math.Sqrt(l);
            txtInput.Text = Convert.ToString(s);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtInput.Text = (1 / Convert.ToDouble(txtInput.Text)).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                long fact = 1;
                for (int i = 1; i <= Convert.ToInt32(txtInput.Text); i++)
                {
                    fact = fact * i;
                }
                txtInput.Text = Convert.ToString(fact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Log(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
              try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Log10(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
 }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
              try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Exp(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
    
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Sin(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
              try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Cos(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
              try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Tan(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
              try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Round(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Floor(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Truncate(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCeil_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Ceiling(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvSin_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Asin(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Sinh(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Cosh(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Tanh(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
            }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvCos_Click(object sender, EventArgs e)
        {
               try
            {
             if (txtInput.Text.Length != 0)
             {
            double l;
            l = Math.Acos(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
             }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
            double l;
            l = Math.Atan(Convert.ToDouble(txtInput.Text));
            txtInput.Text = Convert.ToString(l);
 }
             sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculate()
        {
            if (txtInput.Text != ".")
            {
                variable2 = Convert.ToDouble(txtInput.Text);
                if (fl == false)
                {
                    variable1 = variable2;
                }
                else if (addBit == 1)
                {
                    variable1 = variable1 + variable2;
                }
                else if (subBit == 1)
                {
                    variable1 = variable1 - variable2;
                }
                else if (multBit == 1)
                {
                    variable1 = variable1 * variable2;
                }
                else if (divBit == 1)
                {
                    variable1 = variable1 / variable2;
                }
                else if (modBit == 1)
                {

                    variable2 = Convert.ToInt32(txtInput.Text);
                    variable1 = Convert.ToInt32(variable1 % variable2);
                }
               
                else
                {
                    variable1 = variable2;
                }
                txtInput.Text = Convert.ToString(variable1);

            }
          }

        private void button25_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                modBit = 1;
                sign_Indicator = 1;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            txtInput.Text = Math.PI.ToString();
            sign_Indicator = 1;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            
            s = txtInput.Text;
            int l = s.Length;
            for (int i = 0; i < l - 1; i++)
            {
                x += s[i];
            }
            txtInput.Text = x;
            x = "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
           
        }
       
    }
}
