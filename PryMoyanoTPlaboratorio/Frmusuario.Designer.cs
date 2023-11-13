namespace PryMoyanoTPlaboratorio
{
    partial class Frmusuario
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
            this.lblcuit = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcuit = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Direccion = new System.Windows.Forms.TabControl();
            this.Dirección = new System.Windows.Forms.TabPage();
            this.Contacto = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Direccion.SuspendLayout();
            this.Dirección.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcuit
            // 
            this.lblcuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuit.Location = new System.Drawing.Point(6, 19);
            this.lblcuit.Name = "lblcuit";
            this.lblcuit.Size = new System.Drawing.Size(80, 23);
            this.lblcuit.TabIndex = 0;
            this.lblcuit.Text = "CUIT";
            this.lblcuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblapellido
            // 
            this.lblapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(6, 42);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(80, 23);
            this.lblapellido.TabIndex = 1;
            this.lblapellido.Text = "Apellido";
            this.lblapellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(6, 65);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(80, 23);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(289, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 72);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtcuit
            // 
            this.txtcuit.Location = new System.Drawing.Point(92, 19);
            this.txtcuit.Multiline = true;
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.Size = new System.Drawing.Size(132, 20);
            this.txtcuit.TabIndex = 4;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(92, 45);
            this.txtapellido.Multiline = true;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(132, 20);
            this.txtapellido.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(92, 71);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(132, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.lblcuit);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.lblapellido);
            this.groupBox1.Controls.Add(this.txtcuit);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 119);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Direccion
            // 
            this.Direccion.Controls.Add(this.Dirección);
            this.Direccion.Controls.Add(this.Contacto);
            this.Direccion.Location = new System.Drawing.Point(12, 138);
            this.Direccion.Name = "Direccion";
            this.Direccion.SelectedIndex = 0;
            this.Direccion.Size = new System.Drawing.Size(384, 139);
            this.Direccion.TabIndex = 8;
            this.Direccion.Tag = "Dirección";
            // 
            // Dirección
            // 
            this.Dirección.Controls.Add(this.textBox2);
            this.Dirección.Controls.Add(this.textBox1);
            this.Dirección.Controls.Add(this.label2);
            this.Dirección.Controls.Add(this.label1);
            this.Dirección.Location = new System.Drawing.Point(4, 22);
            this.Dirección.Name = "Dirección";
            this.Dirección.Padding = new System.Windows.Forms.Padding(3);
            this.Dirección.Size = new System.Drawing.Size(376, 113);
            this.Dirección.TabIndex = 0;
            this.Dirección.Text = "Dirección";
            this.Dirección.UseVisualStyleBackColor = true;
            // 
            // Contacto
            // 
            this.Contacto.Location = new System.Drawing.Point(4, 22);
            this.Contacto.Name = "Contacto";
            this.Contacto.Padding = new System.Windows.Forms.Padding(3);
            this.Contacto.Size = new System.Drawing.Size(376, 184);
            this.Contacto.TabIndex = 1;
            this.Contacto.Text = "Contacto";
            this.Contacto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dirección";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ciudad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 9;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(190, 358);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(76, 27);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(316, 358);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(76, 27);
            this.btnregistrar.TabIndex = 10;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // Frmusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 398);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmusuario";
            this.Load += new System.EventHandler(this.Frmusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Direccion.ResumeLayout(false);
            this.Dirección.ResumeLayout(false);
            this.Dirección.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblcuit;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcuit;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl Direccion;
        private System.Windows.Forms.TabPage Dirección;
        private System.Windows.Forms.TabPage Contacto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnregistrar;
    }
}