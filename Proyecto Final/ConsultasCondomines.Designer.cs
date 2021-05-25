namespace Proyecto_Final
{
    partial class ConsultasCondomines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasCondomines));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TablaConsultasCond = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroCond = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsultaCond = new System.Windows.Forms.TextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaConsultasCond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TablaConsultasCond
            // 
            this.TablaConsultasCond.AllowUserToAddRows = false;
            this.TablaConsultasCond.AllowUserToDeleteRows = false;
            this.TablaConsultasCond.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.TablaConsultasCond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaConsultasCond.Location = new System.Drawing.Point(13, 270);
            this.TablaConsultasCond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TablaConsultasCond.Name = "TablaConsultasCond";
            this.TablaConsultasCond.ReadOnly = true;
            this.TablaConsultasCond.RowHeadersWidth = 51;
            this.TablaConsultasCond.RowTemplate.Height = 24;
            this.TablaConsultasCond.Size = new System.Drawing.Size(867, 182);
            this.TablaConsultasCond.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(353, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 138);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR O FILTRAR \r\nCONDOMINES";
            // 
            // txtFiltroCond
            // 
            this.txtFiltroCond.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtFiltroCond.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroCond.FormattingEnabled = true;
            this.txtFiltroCond.Items.AddRange(new object[] {
            "Cedula",
            "Correo Electronico",
            "Edificio"});
            this.txtFiltroCond.Location = new System.Drawing.Point(539, 140);
            this.txtFiltroCond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroCond.Name = "txtFiltroCond";
            this.txtFiltroCond.Size = new System.Drawing.Size(192, 37);
            this.txtFiltroCond.TabIndex = 3;
            this.txtFiltroCond.TextChanged += new System.EventHandler(this.txtFiltroCond_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(413, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "BUSCAR POR:";
            // 
            // txtConsultaCond
            // 
            this.txtConsultaCond.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtConsultaCond.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaCond.Location = new System.Drawing.Point(539, 222);
            this.txtConsultaCond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaCond.Name = "txtConsultaCond";
            this.txtConsultaCond.Size = new System.Drawing.Size(192, 34);
            this.txtConsultaCond.TabIndex = 5;
            this.txtConsultaCond.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConsulta.Location = new System.Drawing.Point(536, 192);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(66, 24);
            this.lblConsulta.TabIndex = 6;
            this.lblConsulta.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "(Para generar reportes los datos deben ser exactos)";
            // 
            // ConsultasCondomines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(892, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.txtConsultaCond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltroCond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaConsultasCond);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultasCondomines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultasCondomines";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultasCondomines_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaConsultasCond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView TablaConsultasCond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConsulta;
        public System.Windows.Forms.ComboBox txtFiltroCond;
        public System.Windows.Forms.TextBox txtConsultaCond;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}