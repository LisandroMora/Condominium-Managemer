namespace Proyecto_Final
{
    partial class Reclamaciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reclamaciones));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFechaReclamacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReclamacion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedulaReclamacion = new System.Windows.Forms.ComboBox();
            this.txtTelefonoReclamaciones = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmailReclamaciones = new System.Windows.Forms.TextBox();
            this.txtNombreReclamaciones = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtFechaReclamacion
            // 
            this.txtFechaReclamacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaReclamacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaReclamacion.Location = new System.Drawing.Point(361, 401);
            this.txtFechaReclamacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaReclamacion.Name = "txtFechaReclamacion";
            this.txtFechaReclamacion.Size = new System.Drawing.Size(215, 38);
            this.txtFechaReclamacion.TabIndex = 2;
            this.txtFechaReclamacion.Value = new System.DateTime(2020, 11, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(221, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "FECHA ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReclamacion);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(593, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(240, 331);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECLAMACION";
            // 
            // txtReclamacion
            // 
            this.txtReclamacion.Location = new System.Drawing.Point(7, 34);
            this.txtReclamacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReclamacion.Multiline = true;
            this.txtReclamacion.Name = "txtReclamacion";
            this.txtReclamacion.Size = new System.Drawing.Size(227, 291);
            this.txtReclamacion.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 39);
            this.button1.TabIndex = 39;
            this.button1.Text = "Enviar reclamacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(361, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 2);
            this.panel1.TabIndex = 56;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.ForeColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(361, 183);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 2);
            this.panel5.TabIndex = 61;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(361, 353);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 2);
            this.panel4.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(389, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 35);
            this.label3.TabIndex = 59;
            this.label3.Text = "CEDULA";
            // 
            // txtCedulaReclamacion
            // 
            this.txtCedulaReclamacion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtCedulaReclamacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtCedulaReclamacion.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaReclamacion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCedulaReclamacion.FormattingEnabled = true;
            this.txtCedulaReclamacion.Location = new System.Drawing.Point(360, 58);
            this.txtCedulaReclamacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedulaReclamacion.Name = "txtCedulaReclamacion";
            this.txtCedulaReclamacion.Size = new System.Drawing.Size(215, 35);
            this.txtCedulaReclamacion.TabIndex = 58;
            this.txtCedulaReclamacion.TextChanged += new System.EventHandler(this.txtCedulaReclamacion_TextChanged);
            // 
            // txtTelefonoReclamaciones
            // 
            this.txtTelefonoReclamaciones.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTelefonoReclamaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoReclamaciones.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoReclamaciones.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTelefonoReclamaciones.Location = new System.Drawing.Point(360, 310);
            this.txtTelefonoReclamaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefonoReclamaciones.Name = "txtTelefonoReclamaciones";
            this.txtTelefonoReclamaciones.ReadOnly = true;
            this.txtTelefonoReclamaciones.Size = new System.Drawing.Size(215, 35);
            this.txtTelefonoReclamaciones.TabIndex = 57;
            this.txtTelefonoReclamaciones.Text = "TELEFONO";
            this.txtTelefonoReclamaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(360, 270);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 2);
            this.panel3.TabIndex = 55;
            // 
            // txtEmailReclamaciones
            // 
            this.txtEmailReclamaciones.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtEmailReclamaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailReclamaciones.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailReclamaciones.ForeColor = System.Drawing.SystemColors.Control;
            this.txtEmailReclamaciones.Location = new System.Drawing.Point(360, 226);
            this.txtEmailReclamaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailReclamaciones.Name = "txtEmailReclamaciones";
            this.txtEmailReclamaciones.ReadOnly = true;
            this.txtEmailReclamaciones.Size = new System.Drawing.Size(215, 35);
            this.txtEmailReclamaciones.TabIndex = 54;
            this.txtEmailReclamaciones.Text = "EMAIL";
            this.txtEmailReclamaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreReclamaciones
            // 
            this.txtNombreReclamaciones.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtNombreReclamaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreReclamaciones.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreReclamaciones.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNombreReclamaciones.Location = new System.Drawing.Point(360, 140);
            this.txtNombreReclamaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreReclamaciones.Name = "txtNombreReclamaciones";
            this.txtNombreReclamaciones.ReadOnly = true;
            this.txtNombreReclamaciones.Size = new System.Drawing.Size(215, 35);
            this.txtNombreReclamaciones.TabIndex = 53;
            this.txtNombreReclamaciones.Text = "NOMBRE";
            this.txtNombreReclamaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Reclamaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCedulaReclamacion);
            this.Controls.Add(this.txtTelefonoReclamaciones);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtEmailReclamaciones);
            this.Controls.Add(this.txtNombreReclamaciones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaReclamacion);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reclamaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reclamaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reclamaciones_FormClosed);
            this.Load += new System.EventHandler(this.Reclamaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker txtFechaReclamacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReclamacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtCedulaReclamacion;
        private System.Windows.Forms.TextBox txtTelefonoReclamaciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmailReclamaciones;
        private System.Windows.Forms.TextBox txtNombreReclamaciones;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}