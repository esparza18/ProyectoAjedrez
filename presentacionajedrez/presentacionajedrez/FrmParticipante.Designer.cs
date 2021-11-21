namespace presentacionajedrez
{
    partial class FrmParticipante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParticipante));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnparticipante = new System.Windows.Forms.Button();
            this.dtgparticipantes = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgparticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.Location = new System.Drawing.Point(591, 108);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(261, 41);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar partida";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnparticipante
            // 
            this.btnparticipante.BackColor = System.Drawing.Color.DarkGray;
            this.btnparticipante.Location = new System.Drawing.Point(591, 28);
            this.btnparticipante.Margin = new System.Windows.Forms.Padding(6);
            this.btnparticipante.Name = "btnparticipante";
            this.btnparticipante.Size = new System.Drawing.Size(261, 41);
            this.btnparticipante.TabIndex = 10;
            this.btnparticipante.Text = "Agregar participante";
            this.btnparticipante.UseVisualStyleBackColor = false;
            this.btnparticipante.Click += new System.EventHandler(this.btnparticipante_Click);
            // 
            // dtgparticipantes
            // 
            this.dtgparticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgparticipantes.Location = new System.Drawing.Point(29, 28);
            this.dtgparticipantes.Margin = new System.Windows.Forms.Padding(6);
            this.dtgparticipantes.Name = "dtgparticipantes";
            this.dtgparticipantes.Size = new System.Drawing.Size(515, 206);
            this.dtgparticipantes.TabIndex = 9;
            this.dtgparticipantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgparticipantes_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.Location = new System.Drawing.Point(591, 193);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(261, 41);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(887, 264);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnparticipante);
            this.Controls.Add(this.dtgparticipantes);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FrmParticipante";
            this.Text = "FrmParticipante";
            this.Load += new System.EventHandler(this.FrmParticipante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgparticipantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnparticipante;
        public System.Windows.Forms.DataGridView dtgparticipantes;
        private System.Windows.Forms.Button btnCancelar;
    }
}