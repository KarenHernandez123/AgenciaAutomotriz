namespace AgenciaAutomotriz
{
    partial class Herramientas
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
            this.dtgvHerramientas = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHerramientas
            // 
            this.dtgvHerramientas.AllowUserToAddRows = false;
            this.dtgvHerramientas.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHerramientas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHerramientas.Location = new System.Drawing.Point(81, 146);
            this.dtgvHerramientas.Name = "dtgvHerramientas";
            this.dtgvHerramientas.RowHeadersWidth = 51;
            this.dtgvHerramientas.Size = new System.Drawing.Size(691, 401);
            this.dtgvHerramientas.TabIndex = 9;
            this.dtgvHerramientas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHerramientas_CellContentClick);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(181)))));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(716, 84);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(56, 49);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "+";
            this.btnagregar.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Teal;
            this.txtNombre.Location = new System.Drawing.Point(229, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(473, 36);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(239)))), ((int)(((byte)(221)))));
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(98, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(239)))), ((int)(((byte)(221)))));
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(362, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuarios";
            // 
            // Herramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 605);
            this.Controls.Add(this.dtgvHerramientas);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Herramientas";
            this.Text = "Herramientas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHerramientas;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}