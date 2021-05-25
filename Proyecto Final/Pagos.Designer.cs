namespace Proyecto_Final
{
    partial class Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFechaPagos = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesPagos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCedulaPagos = new System.Windows.Forms.ComboBox();
            this.txtTelefonoPagos = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmailPagos = new System.Windows.Forms.TextBox();
            this.txtNombrePagos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtFechaPagos
            // 
            this.txtFechaPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaPagos.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaPagos.Location = new System.Drawing.Point(101, 422);
            this.txtFechaPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaPagos.Name = "txtFechaPagos";
            this.txtFechaPagos.Size = new System.Drawing.Size(195, 34);
            this.txtFechaPagos.TabIndex = 1;
            this.txtFechaPagos.Value = new System.DateTime(2020, 11, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(132, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "FECHA ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(391, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "MES A PAGAR";
            // 
            // txtMesPagos
            // 
            this.txtMesPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesPagos.FormattingEnabled = true;
            this.txtMesPagos.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.txtMesPagos.Location = new System.Drawing.Point(385, 422);
            this.txtMesPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMesPagos.Name = "txtMesPagos";
            this.txtMesPagos.Size = new System.Drawing.Size(237, 33);
            this.txtMesPagos.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "REALIZAR PAGO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCedulaPagos
            // 
            this.txtCedulaPagos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtCedulaPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtCedulaPagos.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaPagos.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCedulaPagos.FormattingEnabled = true;
            this.txtCedulaPagos.Location = new System.Drawing.Point(667, 74);
            this.txtCedulaPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedulaPagos.Name = "txtCedulaPagos";
            this.txtCedulaPagos.Size = new System.Drawing.Size(215, 35);
            this.txtCedulaPagos.TabIndex = 49;
            this.txtCedulaPagos.TextChanged += new System.EventHandler(this.txtCedulaPagos_TextChanged);
            // 
            // txtTelefonoPagos
            // 
            this.txtTelefonoPagos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtTelefonoPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoPagos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoPagos.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTelefonoPagos.Location = new System.Drawing.Point(667, 326);
            this.txtTelefonoPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefonoPagos.Name = "txtTelefonoPagos";
            this.txtTelefonoPagos.ReadOnly = true;
            this.txtTelefonoPagos.Size = new System.Drawing.Size(215, 35);
            this.txtTelefonoPagos.TabIndex = 48;
            this.txtTelefonoPagos.Text = "TELEFONO";
            this.txtTelefonoPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(667, 286);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 2);
            this.panel3.TabIndex = 46;
            // 
            // txtEmailPagos
            // 
            this.txtEmailPagos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtEmailPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailPagos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPagos.ForeColor = System.Drawing.SystemColors.Control;
            this.txtEmailPagos.Location = new System.Drawing.Point(667, 242);
            this.txtEmailPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailPagos.Name = "txtEmailPagos";
            this.txtEmailPagos.ReadOnly = true;
            this.txtEmailPagos.Size = new System.Drawing.Size(215, 35);
            this.txtEmailPagos.TabIndex = 43;
            this.txtEmailPagos.Text = "EMAIL";
            this.txtEmailPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombrePagos
            // 
            this.txtNombrePagos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtNombrePagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombrePagos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePagos.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNombrePagos.Location = new System.Drawing.Point(667, 156);
            this.txtNombrePagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombrePagos.Name = "txtNombrePagos";
            this.txtNombrePagos.ReadOnly = true;
            this.txtNombrePagos.Size = new System.Drawing.Size(215, 35);
            this.txtNombrePagos.TabIndex = 42;
            this.txtNombrePagos.Text = "NOMBRE";
            this.txtNombrePagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(695, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 35);
            this.label3.TabIndex = 50;
            this.label3.Text = "CEDULA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(667, 369);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 2);
            this.panel4.TabIndex = 51;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.ForeColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(667, 199);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 2);
            this.panel5.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(667, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 2);
            this.panel1.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(912, 469);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCedulaPagos);
            this.Controls.Add(this.txtTelefonoPagos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtEmailPagos);
            this.Controls.Add(this.txtNombrePagos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMesPagos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaPagos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pagos_FormClosed);
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker txtFechaPagos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtMesPagos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtCedulaPagos;
        private System.Windows.Forms.TextBox txtTelefonoPagos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmailPagos;
        private System.Windows.Forms.TextBox txtNombrePagos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}