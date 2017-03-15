namespace Proyecto
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.Registrarmp = new System.Windows.Forms.Button();
            this.Listar = new System.Windows.Forms.Button();
            this.RegistrarP = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrarmp
            // 
            this.Registrarmp.BackColor = System.Drawing.Color.SeaShell;
            this.Registrarmp.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarmp.ForeColor = System.Drawing.Color.Black;
            this.Registrarmp.Location = new System.Drawing.Point(28, 73);
            this.Registrarmp.Name = "Registrarmp";
            this.Registrarmp.Size = new System.Drawing.Size(103, 104);
            this.Registrarmp.TabIndex = 13;
            this.Registrarmp.Text = "Registrar Venta";
            this.Registrarmp.UseVisualStyleBackColor = false;
            this.Registrarmp.Click += new System.EventHandler(this.Registrarmp_Click);
            // 
            // Listar
            // 
            this.Listar.BackColor = System.Drawing.Color.SeaShell;
            this.Listar.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listar.ForeColor = System.Drawing.Color.Black;
            this.Listar.Location = new System.Drawing.Point(246, 73);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(103, 104);
            this.Listar.TabIndex = 12;
            this.Listar.Text = "Consultar Producto";
            this.Listar.UseVisualStyleBackColor = false;
            // 
            // RegistrarP
            // 
            this.RegistrarP.BackColor = System.Drawing.Color.SeaShell;
            this.RegistrarP.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarP.ForeColor = System.Drawing.Color.Black;
            this.RegistrarP.Location = new System.Drawing.Point(137, 73);
            this.RegistrarP.Name = "RegistrarP";
            this.RegistrarP.Size = new System.Drawing.Size(103, 104);
            this.RegistrarP.TabIndex = 11;
            this.RegistrarP.Text = "Registrar Nuevo Cliente";
            this.RegistrarP.UseVisualStyleBackColor = false;
            this.RegistrarP.Click += new System.EventHandler(this.RegistrarP_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaShell;
            this.button4.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(278, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 26);
            this.button4.TabIndex = 10;
            this.button4.Text = "Cerrar Sesion";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 56);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Coffee-LAM";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registrarmp);
            this.Controls.Add(this.Listar);
            this.Controls.Add(this.RegistrarP);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registrarmp;
        private System.Windows.Forms.Button Listar;
        private System.Windows.Forms.Button RegistrarP;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}