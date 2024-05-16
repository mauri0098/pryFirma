namespace pryFirma
{
    partial class frmFirma
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
            pbFirma = new PictureBox();
            btnGuardar = new Button();
            rdBlue = new RadioButton();
            rdRed = new RadioButton();
            rdOrange = new RadioButton();
            gbColors = new GroupBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFirma).BeginInit();
            gbColors.SuspendLayout();
            SuspendLayout();
            // 
            // pbFirma
            // 
            pbFirma.Location = new Point(1, 3);
            pbFirma.Name = "pbFirma";
            pbFirma.Size = new Size(576, 359);
            pbFirma.TabIndex = 0;
            pbFirma.TabStop = false;
            pbFirma.MouseMove += pbFirma_MouseMove;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(580, 161);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(81, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // rdBlue
            // 
            rdBlue.AutoSize = true;
            rdBlue.Checked = true;
            rdBlue.Location = new Point(6, 20);
            rdBlue.Name = "rdBlue";
            rdBlue.Size = new Size(48, 19);
            rdBlue.TabIndex = 2;
            rdBlue.TabStop = true;
            rdBlue.Text = "Blue";
            rdBlue.UseVisualStyleBackColor = true;
            // 
            // rdRed
            // 
            rdRed.AutoSize = true;
            rdRed.Location = new Point(6, 45);
            rdRed.Name = "rdRed";
            rdRed.Size = new Size(45, 19);
            rdRed.TabIndex = 3;
            rdRed.Text = "Red";
            rdRed.UseVisualStyleBackColor = true;
            // 
            // rdOrange
            // 
            rdOrange.AutoSize = true;
            rdOrange.Location = new Point(6, 70);
            rdOrange.Name = "rdOrange";
            rdOrange.Size = new Size(64, 19);
            rdOrange.TabIndex = 4;
            rdOrange.TabStop = true;
            rdOrange.Text = "Orange";
            rdOrange.UseVisualStyleBackColor = true;
            // 
            // gbColors
            // 
            gbColors.Controls.Add(rdOrange);
            gbColors.Controls.Add(rdBlue);
            gbColors.Controls.Add(rdRed);
            gbColors.Location = new Point(580, 3);
            gbColors.Name = "gbColors";
            gbColors.Size = new Size(84, 110);
            gbColors.TabIndex = 5;
            gbColors.TabStop = false;
            gbColors.Text = "Colors";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(580, 119);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 36);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 364);
            Controls.Add(btnLimpiar);
            Controls.Add(gbColors);
            Controls.Add(btnGuardar);
            Controls.Add(pbFirma);
            Name = "frmFirma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Firma";
            ((System.ComponentModel.ISupportInitialize)pbFirma).EndInit();
            gbColors.ResumeLayout(false);
            gbColors.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbFirma;
        private Button btnGuardar;
        private RadioButton rdBlue;
        private RadioButton rdRed;
        private RadioButton rdOrange;
        private GroupBox gbColors;
        private Button btnLimpiar;
    }
}
