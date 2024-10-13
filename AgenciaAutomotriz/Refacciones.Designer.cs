namespace AgenciaAutomotriz
{
    partial class Refacciones
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
            this.dtgvRefacciones = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtbuscarRefacciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRefacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRefacciones
            // 
            this.dtgvRefacciones.AllowUserToAddRows = false;
            this.dtgvRefacciones.BackgroundColor = System.Drawing.Color.White;
            this.dtgvRefacciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvRefacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRefacciones.Location = new System.Drawing.Point(16, 98);
            this.dtgvRefacciones.Name = "dtgvRefacciones";
            this.dtgvRefacciones.RowHeadersWidth = 51;
            this.dtgvRefacciones.Size = new System.Drawing.Size(840, 401);
            this.dtgvRefacciones.TabIndex = 10;
            this.dtgvRefacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRefacciones_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(181)))));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(755, 52);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 39);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtbuscarRefacciones
            // 
            this.txtbuscarRefacciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscarRefacciones.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarRefacciones.ForeColor = System.Drawing.Color.Teal;
            this.txtbuscarRefacciones.Location = new System.Drawing.Point(113, 52);
            this.txtbuscarRefacciones.Multiline = true;
            this.txtbuscarRefacciones.Name = "txtbuscarRefacciones";
            this.txtbuscarRefacciones.Size = new System.Drawing.Size(613, 36);
            this.txtbuscarRefacciones.TabIndex = 8;
            this.txtbuscarRefacciones.TextChanged += new System.EventHandler(this.txtbuscarRefacciones_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(181)))));
            this.lbl1.Location = new System.Drawing.Point(363, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(182, 49);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Refacciones";
            // 
            // Refacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 536);
            this.Controls.Add(this.dtgvRefacciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtbuscarRefacciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Name = "Refacciones";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRefacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvRefacciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtbuscarRefacciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
    }
}