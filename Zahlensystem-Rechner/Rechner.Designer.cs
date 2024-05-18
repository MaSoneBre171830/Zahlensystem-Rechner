namespace Zahlensystem_Rechner
{
    partial class Rechner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tB_Num1 = new TextBox();
            cB_Operation = new ComboBox();
            tB_Num2 = new TextBox();
            btn_equals = new Button();
            tB_Result = new TextBox();
            cB_Type = new ComboBox();
            btn_Clear = new Button();
            label1 = new Label();
            btn_OpenMainForm = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // tB_Num1
            // 
            tB_Num1.Font = new Font("Segoe UI", 12F);
            tB_Num1.Location = new Point(128, 196);
            tB_Num1.Name = "tB_Num1";
            tB_Num1.Size = new Size(100, 29);
            tB_Num1.TabIndex = 0;
            // 
            // cB_Operation
            // 
            cB_Operation.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_Operation.Font = new Font("Segoe UI", 12F);
            cB_Operation.FormattingEnabled = true;
            cB_Operation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cB_Operation.Location = new Point(257, 196);
            cB_Operation.Name = "cB_Operation";
            cB_Operation.Size = new Size(51, 29);
            cB_Operation.TabIndex = 1;
            // 
            // tB_Num2
            // 
            tB_Num2.Font = new Font("Segoe UI", 12F);
            tB_Num2.Location = new Point(334, 196);
            tB_Num2.Name = "tB_Num2";
            tB_Num2.Size = new Size(100, 29);
            tB_Num2.TabIndex = 2;
            // 
            // btn_equals
            // 
            btn_equals.Location = new Point(268, 242);
            btn_equals.Name = "btn_equals";
            btn_equals.Size = new Size(31, 29);
            btn_equals.TabIndex = 3;
            btn_equals.Text = "=";
            btn_equals.UseVisualStyleBackColor = true;
            btn_equals.Click += btn_equals_Click;
            // 
            // tB_Result
            // 
            tB_Result.Font = new Font("Segoe UI", 12F);
            tB_Result.Location = new Point(231, 288);
            tB_Result.Name = "tB_Result";
            tB_Result.Size = new Size(100, 29);
            tB_Result.TabIndex = 4;
            // 
            // cB_Type
            // 
            cB_Type.AutoCompleteCustomSource.AddRange(new string[] { "Decimal", "Binary", "Oct", "Hex" });
            cB_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_Type.FormattingEnabled = true;
            cB_Type.Items.AddRange(new object[] { "Dec", "Bin", "Oct", "Hex" });
            cB_Type.Location = new Point(231, 115);
            cB_Type.Name = "cB_Type";
            cB_Type.Size = new Size(100, 23);
            cB_Type.TabIndex = 5;
            // 
            // btn_Clear
            // 
            btn_Clear.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Clear.Location = new Point(128, 288);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(75, 31);
            btn_Clear.TabIndex = 6;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 40.25F);
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 66);
            label1.TabIndex = 7;
            label1.Text = "Rechner";
            // 
            // btn_OpenMainForm
            // 
            btn_OpenMainForm.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_OpenMainForm.Location = new Point(24, 28);
            btn_OpenMainForm.Name = "btn_OpenMainForm";
            btn_OpenMainForm.Size = new Size(118, 33);
            btn_OpenMainForm.TabIndex = 8;
            btn_OpenMainForm.Text = "Go Back";
            btn_OpenMainForm.UseVisualStyleBackColor = true;
            btn_OpenMainForm.Click += btn_OpenMainForm_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(24, 87);
            button1.Name = "button1";
            button1.Size = new Size(118, 33);
            button1.TabIndex = 9;
            button1.Text = "Umrechner";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Rechner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(555, 400);
            Controls.Add(button1);
            Controls.Add(btn_OpenMainForm);
            Controls.Add(label1);
            Controls.Add(btn_Clear);
            Controls.Add(cB_Type);
            Controls.Add(tB_Result);
            Controls.Add(btn_equals);
            Controls.Add(tB_Num2);
            Controls.Add(cB_Operation);
            Controls.Add(tB_Num1);
            Name = "Rechner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rechner";
            FormClosed += Rechner_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tB_Num1;
        private ComboBox cB_Operation;
        private TextBox tB_Num2;
        private Button btn_equals;
        private TextBox tB_Result;
        private ComboBox cB_Type;
        private Button btn_Clear;
        private Label label1;
        private Button btn_OpenMainForm;
        private Button button1;
    }
}