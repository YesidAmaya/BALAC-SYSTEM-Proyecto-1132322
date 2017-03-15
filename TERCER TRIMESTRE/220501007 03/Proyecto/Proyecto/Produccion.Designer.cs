namespace Proyecto
{
    partial class Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produccion));
            this.Registrarmp = new System.Windows.Forms.Button();
            this.RProveedor = new System.Windows.Forms.Button();
            this.Exitproduccion = new System.Windows.Forms.Button();
            this.Listar = new System.Windows.Forms.Button();
            this.RegistrarP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrarmp
            // 
            this.Registrarmp.BackColor = System.Drawing.Color.SeaShell;
            this.Registrarmp.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarmp.Location = new System.Drawing.Point(32, 77);
            this.Registrarmp.Name = "Registrarmp";
            this.Registrarmp.Size = new System.Drawing.Size(103, 114);
            this.Registrarmp.TabIndex = 11;
            this.Registrarmp.Text = "Registrar Materia Prima";
            this.Registrarmp.UseVisualStyleBackColor = false;
            this.Registrarmp.Click += new System.EventHandler(this.Registrarmp_Click);
            // 
            // RProveedor
            // 
            this.RProveedor.BackColor = System.Drawing.Color.SeaShell;
            this.RProveedor.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RProveedor.Location = new System.Drawing.Point(359, 77);
            this.RProveedor.Name = "RProveedor";
            this.RProveedor.Size = new System.Drawing.Size(103, 114);
            this.RProveedor.TabIndex = 10;
            this.RProveedor.Text = "Registrar Proveedor";
            this.RProveedor.UseVisualStyleBackColor = false;
            // 
            // Exitproduccion
            // 
            this.Exitproduccion.BackColor = System.Drawing.Color.SeaShell;
            this.Exitproduccion.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitproduccion.Location = new System.Drawing.Point(374, 12);
            this.Exitproduccion.Name = "Exitproduccion";
            this.Exitproduccion.Size = new System.Drawing.Size(93, 23);
            this.Exitproduccion.TabIndex = 9;
            this.Exitproduccion.Text = "Cerrar Sesion";
            this.Exitproduccion.UseVisualStyleBackColor = false;
            this.Exitproduccion.Click += new System.EventHandler(this.Exitproduccion_Click);
            // 
            // Listar
            // 
            this.Listar.BackColor = System.Drawing.Color.SeaShell;
            this.Listar.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listar.Location = new System.Drawing.Point(250, 77);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(103, 114);
            this.Listar.TabIndex = 8;
            this.Listar.Text = "Listar Producto";
            this.Listar.UseVisualStyleBackColor = false;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // RegistrarP
            // 
            this.RegistrarP.BackColor = System.Drawing.Color.SeaShell;
            this.RegistrarP.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarP.Location = new System.Drawing.Point(141, 77);
            this.RegistrarP.Name = "RegistrarP";
            this.RegistrarP.Size = new System.Drawing.Size(103, 114);
            this.RegistrarP.TabIndex = 7;
            this.RegistrarP.Text = "Registrar Producto";
            this.RegistrarP.UseVisualStyleBackColor = false;
            this.RegistrarP.Click += new System.EventHandler(this.RegistrarP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Coffee-LAM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 56);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registrarmp);
            this.Controls.Add(this.RProveedor);
            this.Controls.Add(this.Exitproduccion);
            this.Controls.Add(this.Listar);
            this.Controls.Add(this.RegistrarP);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Produccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.Produccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registrarmp;
        private System.Windows.Forms.Button RProveedor;
        private System.Windows.Forms.Button Exitproduccion;
        private System.Windows.Forms.Button Listar;
        private System.Windows.Forms.Button RegistrarP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}