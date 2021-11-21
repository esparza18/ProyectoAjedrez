
namespace presentacionajedrez
{
    partial class FrmPartidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartidas));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnpartidas = new System.Windows.Forms.Button();
            this.dtgpartidas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.Location = new System.Drawing.Point(577, 95);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(261, 41);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar partida";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnpartidas
            // 
            this.btnpartidas.BackColor = System.Drawing.Color.DarkGray;
            this.btnpartidas.Location = new System.Drawing.Point(577, 15);
            this.btnpartidas.Margin = new System.Windows.Forms.Padding(6);
            this.btnpartidas.Name = "btnpartidas";
            this.btnpartidas.Size = new System.Drawing.Size(261, 41);
            this.btnpartidas.TabIndex = 6;
            this.btnpartidas.Text = "Agregar partida";
            this.btnpartidas.UseVisualStyleBackColor = false;
            this.btnpartidas.Click += new System.EventHandler(this.btnpartidas_Click);
            // 
            // dtgpartidas
            // 
            this.dtgpartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgpartidas.Location = new System.Drawing.Point(15, 15);
            this.dtgpartidas.Margin = new System.Windows.Forms.Padding(6);
            this.dtgpartidas.Name = "dtgpartidas";
            this.dtgpartidas.Size = new System.Drawing.Size(515, 206);
            this.dtgpartidas.TabIndex = 5;
            this.dtgpartidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgpartidas_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.Location = new System.Drawing.Point(577, 180);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(261, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmPartidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(877, 256);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnpartidas);
            this.Controls.Add(this.dtgpartidas);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FrmPartidas";
            this.Text = "FrmPartidas";
            this.Load += new System.EventHandler(this.FrmPartidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgpartidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnpartidas;
        public System.Windows.Forms.DataGridView dtgpartidas;
        private System.Windows.Forms.Button btnCancelar;
    }
}