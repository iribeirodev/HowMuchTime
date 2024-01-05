namespace HowMuchTime
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            lblHora = new Label();
            txtHora = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnSet = new Button();
            mskHora = new MaskedTextBox();
            lblHoraSet = new Label();
            lblTempoRestante = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            panelMostrador = new Panel();
            txtHoraRestante = new TextBox();
            panelMostrador.SuspendLayout();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.Location = new Point(13, 19);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(148, 15);
            lblHora.TabIndex = 0;
            lblHora.Text = "label1";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtHora
            // 
            txtHora.BackColor = Color.Navy;
            txtHora.Font = new Font("Digital-7 Mono", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            txtHora.ForeColor = Color.MediumTurquoise;
            txtHora.Location = new Point(13, 37);
            txtHora.Name = "txtHora";
            txtHora.ReadOnly = true;
            txtHora.Size = new Size(148, 43);
            txtHora.TabIndex = 1;
            txtHora.TabStop = false;
            txtHora.TextAlign = HorizontalAlignment.Center;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnSet
            // 
            btnSet.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSet.Location = new Point(364, 44);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(75, 27);
            btnSet.TabIndex = 3;
            btnSet.Text = "button1";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // mskHora
            // 
            mskHora.BackColor = Color.Navy;
            mskHora.Font = new Font("Digital-7 Mono", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            mskHora.ForeColor = Color.MediumTurquoise;
            mskHora.Location = new Point(203, 36);
            mskHora.Mask = "00:00";
            mskHora.Name = "mskHora";
            mskHora.PromptChar = ' ';
            mskHora.Size = new Size(137, 43);
            mskHora.TabIndex = 5;
            mskHora.TextAlign = HorizontalAlignment.Center;
            mskHora.ValidatingType = typeof(DateTime);
            // 
            // lblHoraSet
            // 
            lblHoraSet.Location = new Point(203, 19);
            lblHoraSet.Name = "lblHoraSet";
            lblHoraSet.Size = new Size(137, 14);
            lblHoraSet.TabIndex = 6;
            lblHoraSet.Text = "label1";
            lblHoraSet.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTempoRestante
            // 
            lblTempoRestante.Location = new Point(463, 18);
            lblTempoRestante.Name = "lblTempoRestante";
            lblTempoRestante.Size = new Size(148, 15);
            lblTempoRestante.TabIndex = 8;
            lblTempoRestante.Text = "label1";
            lblTempoRestante.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // panelMostrador
            // 
            panelMostrador.BackColor = Color.Transparent;
            panelMostrador.Controls.Add(txtHoraRestante);
            panelMostrador.Location = new Point(449, 37);
            panelMostrador.Name = "panelMostrador";
            panelMostrador.Size = new Size(166, 40);
            panelMostrador.TabIndex = 9;
            panelMostrador.Click += panelMostrador_Click;
            // 
            // txtHoraRestante
            // 
            txtHoraRestante.BackColor = Color.MediumTurquoise;
            txtHoraRestante.Enabled = false;
            txtHoraRestante.Font = new Font("Digital-7 Mono", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoraRestante.ForeColor = Color.Black;
            txtHoraRestante.Location = new Point(9, -1);
            txtHoraRestante.Name = "txtHoraRestante";
            txtHoraRestante.ReadOnly = true;
            txtHoraRestante.Size = new Size(148, 43);
            txtHoraRestante.TabIndex = 8;
            txtHoraRestante.TabStop = false;
            txtHoraRestante.TextAlign = HorizontalAlignment.Center;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(623, 113);
            Controls.Add(panelMostrador);
            Controls.Add(lblTempoRestante);
            Controls.Add(lblHoraSet);
            Controls.Add(mskHora);
            Controls.Add(btnSet);
            Controls.Add(txtHora);
            Controls.Add(lblHora);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormPrincipal_Load;
            panelMostrador.ResumeLayout(false);
            panelMostrador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private TextBox txtHora;
        private System.Windows.Forms.Timer timer1;
        private Button btnSet;
        private MaskedTextBox mskHora;
        private Label lblHoraSet;
        private Label lblTempoRestante;
        private System.Windows.Forms.Timer timer2;
        private Panel panelMostrador;
        private TextBox txtHoraRestante;
    }
}
