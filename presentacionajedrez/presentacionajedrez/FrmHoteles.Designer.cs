namespace presentacionajedrez
{
    partial class FrmHoteles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoteles));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnhoteles = new System.Windows.Forms.Button();
            this.dtghoteles = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtghoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.Location = new System.Drawing.Point(587, 107);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(261, 41);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar hotel";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnhoteles
            // 
            this.btnhoteles.BackColor = System.Drawing.Color.DarkGray;
            this.btnhoteles.Location = new System.Drawing.Point(587, 27);
            this.btnhoteles.Margin = new System.Windows.Forms.Padding(6);
            this.btnhoteles.Name = "btnhoteles";
            this.btnhoteles.Size = new System.Drawing.Size(261, 41);
            this.btnhoteles.TabIndex = 10;
            this.btnhoteles.Text = "Agregar hotel";
            this.btnhoteles.UseVisualStyleBackColor = false;
            this.btnhoteles.Click += new System.EventHandler(this.btnhoteles_Click);
            // 
            // dtghoteles
            // 
            this.dtghoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtghoteles.Location = new System.Drawing.Point(25, 27);
            this.dtghoteles.Margin = new System.Windows.Forms.Padding(6);
            this.dtghoteles.Name = "dtghoteles";
            this.dtghoteles.Size = new System.Drawing.Size(515, 206);
            this.dtghoteles.TabIndex = 9;
            this.dtghoteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtghoteles_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.Location = new System.Drawing.Point(587, 192);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(261, 41);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(871, 264);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnhoteles);
            this.Controls.Add(this.dtghoteles);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FrmHoteles";
            this.Text = "FrmHoteles";
            this.Load += new System.EventHandler(this.FrmHoteles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtghoteles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnhoteles;
        public System.Windows.Forms.DataGridView dtghoteles;
        private System.Windows.Forms.Button btnCancelar;
    }
}