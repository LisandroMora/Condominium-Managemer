namespace Proyecto_Final
{
    partial class ConsultasManzanas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasManzanas));
            this.txtManzanaConsultas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TablaManzanas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaManzanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtManzanaConsultas
            // 
            this.txtManzanaConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManzanaConsultas.Location = new System.Drawing.Point(549, 183);
            this.txtManzanaConsultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManzanaConsultas.Name = "txtManzanaConsultas";
            this.txtManzanaConsultas.Size = new System.Drawing.Size(192, 30);
            this.txtManzanaConsultas.TabIndex = 11;
            this.txtManzanaConsultas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(377, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 138);
            this.label1.TabIndex = 8;
            this.label1.Text = "BUSCAR O FILTRAR \r\nMANZANAS";
            // 
            // TablaManzanas
            // 
            this.TablaManzanas.AllowUserToAddRows = false;
            this.TablaManzanas.AllowUserToDeleteRows = false;
            this.TablaManzanas.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.TablaManzanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaManzanas.Location = new System.Drawing.Point(477, 234);
            this.TablaManzanas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TablaManzanas.Name = "TablaManzanas";
            this.TablaManzanas.ReadOnly = true;
            this.TablaManzanas.RowHeadersWidth = 51;
            this.TablaManzanas.RowTemplate.Height = 24;
            this.TablaManzanas.Size = new System.Drawing.Size(345, 188);
            this.TablaManzanas.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(400, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "INGRESE EL NOMBRE DE LA MANZANA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 465);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "(Para generar reportes los datos deben ser exactos)";
            // 
            // ConsultasManzanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(875, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtManzanaConsultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaManzanas);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultasManzanas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas Manzanas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultasManzanas_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.TablaManzanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtManzanaConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TablaManzanas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}