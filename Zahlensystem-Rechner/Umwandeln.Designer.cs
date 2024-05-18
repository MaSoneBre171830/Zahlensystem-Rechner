namespace Zahlensystem_Rechner
{
    partial class Umwandeln
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
            label1 = new Label();
            tB_Value = new TextBox();
            cB_Type = new ComboBox();
            btn_OpenMainForm = new Button();
            btn_Convert = new Button();
            tB_Result = new TextBox();
            btn_OpenRechnerForm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 40.25F);
            label1.Location = new Point(123, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 66);
            label1.TabIndex = 0;
            label1.Text = "Umrechner";
            // 
            // tB_Value
            // 
            tB_Value.Font = new Font("Segoe UI", 12F);
            tB_Value.Location = new Point(25, 149);
            tB_Value.Name = "tB_Value";
            tB_Value.Size = new Size(138, 29);
            tB_Value.TabIndex = 1;
            // 
            // cB_Type
            // 
            cB_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_Type.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cB_Type.FormattingEnabled = true;
            cB_Type.Items.AddRange(new object[] { "--Umwandeln--", "Dec ---> Binary", "Dec ---> Oct", "Dec ---> Hex", "Binary ---> Dec", "Binary ---> Oct", "Binary ---> Hex", "Oct ---> Dec", "Oct ---> Binary", "Oct ---> Hex", "Hex ---> Dec", "Hex ---> Binary", "Hex ---> Oct" });
            cB_Type.Location = new Point(190, 150);
            cB_Type.Name = "cB_Type";
            cB_Type.Size = new Size(129, 28);
            cB_Type.TabIndex = 3;
            // 
            // btn_OpenMainForm
            // 
            btn_OpenMainForm.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_OpenMainForm.Location = new Point(12, 30);
            btn_OpenMainForm.Name = "btn_OpenMainForm";
            btn_OpenMainForm.Size = new Size(105, 33);
            btn_OpenMainForm.TabIndex = 4;
            btn_OpenMainForm.Text = "Go Back";
            btn_OpenMainForm.UseVisualStyleBackColor = true;
            btn_OpenMainForm.Click += btn_OpenMainForm_Click;
            // 
            // btn_Convert
            // 
            btn_Convert.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Convert.Location = new Point(190, 239);
            btn_Convert.Name = "btn_Convert";
            btn_Convert.Size = new Size(129, 38);
            btn_Convert.TabIndex = 5;
            btn_Convert.Text = "Convert";
            btn_Convert.UseVisualStyleBackColor = true;
            btn_Convert.Click += btn_Convert_Click;
            // 
            // tB_Result
            // 
            tB_Result.Font = new Font("Segoe UI", 12F);
            tB_Result.Location = new Point(348, 149);
            tB_Result.Name = "tB_Result";
            tB_Result.ReadOnly = true;
            tB_Result.Size = new Size(138, 29);
            tB_Result.TabIndex = 6;
            // 
            // btn_OpenRechnerForm
            // 
            btn_OpenRechnerForm.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_OpenRechnerForm.Location = new Point(397, 30);
            btn_OpenRechnerForm.Name = "btn_OpenRechnerForm";
            btn_OpenRechnerForm.Size = new Size(105, 33);
            btn_OpenRechnerForm.TabIndex = 7;
            btn_OpenRechnerForm.Text = "Rechner";
            btn_OpenRechnerForm.UseVisualStyleBackColor = true;
            btn_OpenRechnerForm.Click += btn_OpenRechnerForm_Click;
            // 
            // Umwandeln
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(514, 339);
            Controls.Add(btn_OpenRechnerForm);
            Controls.Add(tB_Result);
            Controls.Add(btn_Convert);
            Controls.Add(btn_OpenMainForm);
            Controls.Add(cB_Type);
            Controls.Add(tB_Value);
            Controls.Add(label1);
            Name = "Umwandeln";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Umwandeln";
            FormClosed += Umwandeln_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tB_Value;
        private ComboBox cB_Type;
        private Button btn_OpenMainForm;
        private Button btn_Convert;
        private TextBox tB_Result;
        private Button btn_OpenRechnerForm;
    }
}