namespace Proyecto_Final
{
    partial class ConsultasEdificios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasEdificios));
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroEdificios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TablaEdificios = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtConsultaEdificios = new System.Windows.Forms.TextBox();
            this.lblConsultasEdificios = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEdificios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(420, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "BUSCAR POR:";
            // 
            // txtFiltroEdificios
            // 
            this.txtFiltroEdificios.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroEdificios.FormattingEnabled = true;
            this.txtFiltroEdificios.Items.AddRange(new object[] {
            "Nombre",
            "Manzana",
            "Cantidad de aptos"});
            this.txtFiltroEdificios.Location = new System.Drawing.Point(547, 146);
            this.txtFiltroEdificios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroEdificios.Name = "txtFiltroEdificios";
            this.txtFiltroEdificios.Size = new System.Drawing.Size(192, 36);
            this.txtFiltroEdificios.TabIndex = 15;
            this.txtFiltroEdificios.TextChanged += new System.EventHandler(this.txtFiltroEdificios_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(361, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 138);
            this.label1.TabIndex = 14;
            this.label1.Text = "BUSCAR O FILTRAR \r\nEDIFICIOS";
            // 
            // TablaEdificios
            // 
            this.TablaEdificios.AllowUserToAddRows = false;
            this.TablaEdificios.AllowUserToDeleteRows = false;
            this.TablaEdificios.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.TablaEdificios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEdificios.Location = new System.Drawing.Point(56, 278);
            this.TablaEdificios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TablaEdificios.Name = "TablaEdificios";
            this.TablaEdificios.ReadOnly = true;
            this.TablaEdificios.RowHeadersWidth = 51;
            this.TablaEdificios.RowTemplate.Height = 24;
            this.TablaEdificios.Size = new System.Drawing.Size(740, 178);
            this.TablaEdificios.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txtConsultaEdificios
            // 
            this.txtConsultaEdificios.Enabled = false;
            this.txtConsultaEdificios.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaEdificios.Location = new System.Drawing.Point(547, 226);
            this.txtConsultaEdificios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaEdificios.Name = "txtConsultaEdificios";
            this.txtConsultaEdificios.Size = new System.Drawing.Size(192, 35);
            this.txtConsultaEdificios.TabIndex = 18;
            this.txtConsultaEdificios.TextChanged += new System.EventHandler(this.txtConsultaEdificios_TextChanged);
            // 
            // lblConsultasEdificios
            // 
            this.lblConsultasEdificios.AutoSize = true;
            this.lblConsultasEdificios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultasEdificios.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConsultasEdificios.Location = new System.Drawing.Point(545, 202);
            this.lblConsultasEdificios.Name = "lblConsultasEdificios";
            this.lblConsultasEdificios.Size = new System.Drawing.Size(0, 17);
            this.lblConsultasEdificios.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 462);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 470);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "(Para generar reportes los datos deben ser exactos)";
            // 
            // ConsultasEdificios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(855, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblConsultasEdificios);
            this.Controls.Add(this.txtConsultaEdificios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltroEdificios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaEdificios);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultasEdificios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Edificios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultasEdificios_FormClosed);
            this.Load += new System.EventHandler(this.ConsultasEdificios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaEdificios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TablaEdificios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConsultasEdificios;
        public System.Windows.Forms.ComboBox txtFiltroEdificios;
        public System.Windows.Forms.TextBox txtConsultaEdificios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}