namespace PryMoyanoTPlaboratorio
{
    partial class Frmlistado
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblapellido2 = new System.Windows.Forms.Label();
            this.txtapellido2 = new System.Windows.Forms.TextBox();
            this.btnlistar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblciudad = new System.Windows.Forms.Label();
            this.txtdireccion2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(306, 159);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtapellido2);
            this.tabPage1.Controls.Add(this.lblapellido2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(298, 133);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Apellido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtdireccion2);
            this.tabPage2.Controls.Add(this.lblciudad);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(298, 133);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dirección";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblapellido2
            // 
            this.lblapellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido2.Location = new System.Drawing.Point(6, 45);
            this.lblapellido2.Name = "lblapellido2";
            this.lblapellido2.Size = new System.Drawing.Size(80, 23);
            this.lblapellido2.TabIndex = 2;
            this.lblapellido2.Text = "Apellido";
            this.lblapellido2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtapellido2
            // 
            this.txtapellido2.Location = new System.Drawing.Point(92, 48);
            this.txtapellido2.Multiline = true;
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(132, 20);
            this.txtapellido2.TabIndex = 6;
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(238, 196);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(76, 27);
            this.btnlistar.TabIndex = 11;
            this.btnlistar.Text = "Listar";
            this.btnlistar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 156);
            this.dataGridView1.TabIndex = 12;
            // 
            // lblciudad
            // 
            this.lblciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciudad.Location = new System.Drawing.Point(6, 49);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(80, 23);
            this.lblciudad.TabIndex = 3;
            this.lblciudad.Text = "Ciudad";
            this.lblciudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdireccion2
            // 
            this.txtdireccion2.Location = new System.Drawing.Point(124, 52);
            this.txtdireccion2.Multiline = true;
            this.txtdireccion2.Name = "txtdireccion2";
            this.txtdireccion2.Size = new System.Drawing.Size(132, 20);
            this.txtdireccion2.TabIndex = 7;
            // 
            // Frmlistado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frmlistado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmlistado";
            this.UseWaitCursor = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblapellido2;
        private System.Windows.Forms.TextBox txtapellido2;
        private System.Windows.Forms.TextBox txtdireccion2;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}