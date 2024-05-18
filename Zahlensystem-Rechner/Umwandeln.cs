using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Zahlensystemumrechner;

namespace Zahlensystem_Rechner
{
    public partial class Umwandeln : Form
    {
        Zahlensystem zahlensystem = new Zahlensystem();
        private int convertType = 0; // saves the type of covertion the user picks
        private string result = ""; // saves the result 

        public Umwandeln()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.Umwandeln_Load);
        }

        private void Umwandeln_Load(object sender, EventArgs e)
        {

            // Set default selected item
            if (cB_Type.Items.Count > 0)
            {
                cB_Type.SelectedIndex = 0; // Select the first item by default
            }
        }


        private void Umwandeln_FormClosed(object sender, FormClosedEventArgs e)
        {
            // closes the application if the form is closed
            Application.Exit();
        }

        private void btn_OpenMainForm_Click(object sender, EventArgs e)
        {
            //makes the user go back to the main form
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btn_OpenRechnerForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rechner rechner = new Rechner();
            rechner.ShowDialog();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            string number = tB_Value.Text; // saves the number the user inputed in the textBox
            convertType = cB_Type.SelectedIndex; // saves the type of convertion the user selected

            // checks which operation the user wants and executes the corresponding method            
            switch (convertType)
            {
                case 0:     //throws an error message                                                                          
                    MessageBox.Show("Please select a convertion type!!!!");                             // 1 = Dec ---> Binary
                    break;                                                                              // 2 = Dec--->Oct
                case 1:                                                                                 // 3 = Dec--->Hex
                    result = zahlensystem.ConvertToBinary(number, 10);                                  // 4 = Binary--->Dec
                    break;                                                                              // 5 = Binary--->Oct
                case 2:                                                                                 // 6 = Binary--->Hex
                    result = zahlensystem.ConvertToOctal(number, 10);                                   // 7 = Oct--->Dec
                    break;                                                                              // 8 = Oct--->Binary
                case 3:                                                                                 // 9 = Oct--->Hex
                    result = zahlensystem.ConvertToHexadecimal(number, 10);                             // 10 = Hex--->Dec
                    break;                                                                              // 11 = Hex--->Binary
                case 4:                                                                                 // 12 = Hex--->Oct
                    result = zahlensystem.ConvertToDecimal(number, 2);
                    break;
                case 5:
                    result = zahlensystem.ConvertToOctal(number, 2);
                    break;
                case 6:
                    result = zahlensystem.ConvertToHexadecimal(number, 2);
                    break;
                case 7:
                    result = zahlensystem.ConvertToDecimal(number, 8);
                    break;
                case 8:
                    result = zahlensystem.ConvertToBinary(number, 8);
                    break;
                case 9:
                    result = zahlensystem.ConvertToHexadecimal(number, 8);
                    break;
                case 10:
                    result = zahlensystem.ConvertToDecimal(number, 16);
                    break;
                case 11:
                    result = zahlensystem.ConvertToBinary(number, 16);
                    break;
                case 12:
                    result = zahlensystem.ConvertToOctal(number, 16);
                    break;
            }
            // Outputs the result in the textBox
            tB_Result.Text = result;
        }

        
    }
}


