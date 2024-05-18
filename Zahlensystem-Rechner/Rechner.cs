using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zahlensystemumrechner;

namespace Zahlensystem_Rechner
{
    public partial class Rechner : Form
    {
        Zahlensystem zahlensystem = new Zahlensystem();
        string result = "";
        string[] nums = new string[2];

        public Rechner()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.Rechner_Load);
        }

        private void Rechner_Load(object sender, EventArgs e)
        {
            // Set default selected item
            if (cB_Operation.Items.Count > 0 || cB_Type.Items.Count > 0)
            {
                cB_Operation.SelectedIndex = 0; // Select the first item by default
                cB_Type.SelectedIndex = 0;
            }
        }

        private void Rechner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            nums[0] = tB_Num1.Text;
            nums[1] = tB_Num2.Text;
            int baseNumber = GetBaseNumber();

            // checks which operation the user wants and executes the corresponding method  
            switch (cB_Operation.SelectedIndex)
            {
                case 0:
                    result = zahlensystem.Add(nums[0], nums[1], baseNumber);                            // 0 = +
                    break;                                                                              // 1 = -
                case 1:                                                                                 // 2 = *
                    result = zahlensystem.Sub(nums[0], nums[1], baseNumber);                            // 3 = /
                    break;
                case 2:
                    result = zahlensystem.Mult(nums[0], nums[1], baseNumber);
                    break;
                case 3:
                    result = zahlensystem.Div(nums[0], nums[1], baseNumber);
                    break;
            }

            tB_Result.Text = result;
        }


        // Gets the base number to know with that number system to work with
        public int GetBaseNumber()
        {
            int baseNumber = 0;
            switch (cB_Type.SelectedIndex)
            {
                case 0:                                   // 0 = Dec
                    baseNumber = 10;                      // 1 = Bin
                    break;                                // 2 = Oct
                case 1:                                   // 3 = Hex
                    baseNumber = 2;
                    break;
                case 2:
                    baseNumber = 8;
                    break;
                case 3:
                    baseNumber = 16;
                    break;

            }

            return baseNumber;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            // clears the textBoxes
            tB_Num1.Clear();
            tB_Num2.Clear();
            tB_Result.Clear();
        }

        private void btn_OpenMainForm_Click(object sender, EventArgs e)
        {
            //makes the user go back to the main form
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Umwandeln umwandeln = new Umwandeln();
            umwandeln.Show();
        }
    }
}
