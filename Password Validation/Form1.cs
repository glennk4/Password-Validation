using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string password;
        const int MINLENGTH = 8; 

        private void EnterButton_Click(object sender, EventArgs e)
        {
            password = PassInput.Text;
            bool[] conditions = { false, false, false, false };

            conditions[0] = Length();
            conditions[1] = Upper();
            conditions[2] = Lower();
            conditions[3] = Digit();

            EvaluatePassword(conditions); 
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


        //Check length of string 
        private bool Length()
        {
            bool lengthOk = false;

            if (password.Length >= MINLENGTH)
            {
                lengthOk = true; 
            }

            return lengthOk;   
        }


        //Check there's an Upper case char 
        private bool Upper()
        {
            bool hasUpper = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password, i))
                {
                    hasUpper = true; 
                }
            }

            return hasUpper; 
        }


        //Check there's a lower case char 
        private bool Lower()
        {
            bool hasLower = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password, i))
                {
                    hasLower = true; 
                }
            }

            return hasLower; 
        }


        private bool Digit()
        {
            bool hasDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password, i))
                {
                    hasDigit = true; 
                }
            }

            return hasDigit; 
        }


        //Evaluate Password
        private void EvaluatePassword(bool[] conditions)
        {
            if (conditions[0])
            {
                if (conditions[1])
                {
                    if (conditions[2])
                    {
                        if (conditions[3])
                        {
                            MessageBox.Show("Password Accepted!"); 
                        }
                        else
                        {
                            MessageBox.Show("FAIL. Password must contain at least 1 Numerical Digit"); 
                        }
                    }
                    else
                    {
                        MessageBox.Show("FAIL. Password must contain at least 1 Lower Case character"); 
                    }
                }
                else
                {
                    MessageBox.Show("FAIL. Password must contain at least 1 Upper Case character"); 
                }
            }
            else
            {
                MessageBox.Show("FAIL. Password must contain at least 8 characters"); 
            }
        }


        private void EyeButton_Click(object sender, EventArgs e)
        {
            if (PassInput.UseSystemPasswordChar == true)
            {
                PassInput.UseSystemPasswordChar = false;
            }
            else
            {
                PassInput.UseSystemPasswordChar = true; 
            }
        }


    }
}