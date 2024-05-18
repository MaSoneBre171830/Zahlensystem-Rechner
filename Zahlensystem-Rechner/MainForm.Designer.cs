namespace Zahlensystem_Rechner
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_openUmwandeln = new Button();
            btn_OpenRechnerForm = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_openUmwandeln
            // 
            btn_openUmwandeln.BackColor = Color.Gainsboro;
            btn_openUmwandeln.Font = new Font("Arial", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_openUmwandeln.Location = new Point(105, 290);
            btn_openUmwandeln.Name = "btn_openUmwandeln";
            btn_openUmwandeln.Size = new Size(332, 84);
            btn_openUmwandeln.TabIndex = 0;
            btn_openUmwandeln.Text = "Umrechner";
            btn_openUmwandeln.UseVisualStyleBackColor = false;
            btn_openUmwandeln.Click += btn_openUmwandeln_Click;
            // 
            // btn_OpenRechnerForm
            // 
            btn_OpenRechnerForm.Font = new Font("Arial", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_OpenRechnerForm.Location = new Point(513, 290);
            btn_OpenRechnerForm.Name = "btn_OpenRechnerForm";
            btn_OpenRechnerForm.Size = new Size(334, 84);
            btn_OpenRechnerForm.TabIndex = 1;
            btn_OpenRechnerForm.Text = "Rechner";
            btn_OpenRechnerForm.UseVisualStyleBackColor = true;
            btn_OpenRechnerForm.Click += btn_OpenRechnerForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 55F);
            label1.Location = new Point(115, 51);
            label1.Name = "label1";
            label1.Size = new Size(732, 91);
            label1.TabIndex = 2;
            label1.Text = "Zahlensystem Rechner";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(979, 530);
            Controls.Add(btn_OpenRechnerForm);
            Controls.Add(btn_openUmwandeln);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zahlensystem-Rechner";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_openUmwandeln;
        private Button btn_OpenRechnerForm;
        private Label label1;
    }
}
