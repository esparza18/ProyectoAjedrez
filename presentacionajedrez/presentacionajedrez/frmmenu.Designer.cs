namespace presentacionajedrez
{
    partial class frmmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblhoteles = new System.Windows.Forms.ToolStripLabel();
            this.btnhoteles = new System.Windows.Forms.ToolStripButton();
            this.lblparticipantes = new System.Windows.Forms.ToolStripLabel();
            this.btnparticipantes = new System.Windows.Forms.ToolStripButton();
            this.lblPartidas = new System.Windows.Forms.ToolStripLabel();
            this.btnpartidas = new System.Windows.Forms.ToolStripButton();
            this.lblSalir = new System.Windows.Forms.ToolStripLabel();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 20F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblhoteles,
            this.btnhoteles,
            this.lblparticipantes,
            this.btnparticipantes,
            this.lblPartidas,
            this.btnpartidas,
            this.lblSalir,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(157, 460);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // lblhoteles
            // 
            this.lblhoteles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblhoteles.LinkColor = System.Drawing.Color.White;
            this.lblhoteles.Name = "lblhoteles";
            this.lblhoteles.Size = new System.Drawing.Size(154, 33);
            this.lblhoteles.Text = "Hoteles";
            // 
            // btnhoteles
            // 
            this.btnhoteles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnhoteles.Image = ((System.Drawing.Image)(resources.GetObject("btnhoteles.Image")));
            this.btnhoteles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhoteles.Name = "btnhoteles";
            this.btnhoteles.Size = new System.Drawing.Size(154, 20);
            this.btnhoteles.Text = "hoteles";
            this.btnhoteles.Click += new System.EventHandler(this.btnhoteles_Click);
            // 
            // lblparticipantes
            // 
            this.lblparticipantes.Name = "lblparticipantes";
            this.lblparticipantes.Size = new System.Drawing.Size(154, 33);
            this.lblparticipantes.Text = "Participantes";
            // 
            // btnparticipantes
            // 
            this.btnparticipantes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnparticipantes.Image = ((System.Drawing.Image)(resources.GetObject("btnparticipantes.Image")));
            this.btnparticipantes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnparticipantes.Name = "btnparticipantes";
            this.btnparticipantes.Size = new System.Drawing.Size(154, 20);
            this.btnparticipantes.Text = "toolStripButton2";
            this.btnparticipantes.Click += new System.EventHandler(this.btnparticipantes_Click);
            // 
            // lblPartidas
            // 
            this.lblPartidas.Name = "lblPartidas";
            this.lblPartidas.Size = new System.Drawing.Size(154, 33);
            this.lblPartidas.Text = "Partidas";
            // 
            // btnpartidas
            // 
            this.btnpartidas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnpartidas.Image = ((System.Drawing.Image)(resources.GetObject("btnpartidas.Image")));
            this.btnpartidas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnpartidas.Name = "btnpartidas";
            this.btnpartidas.Size = new System.Drawing.Size(154, 20);
            this.btnpartidas.Text = "toolStripButton1";
            this.btnpartidas.Click += new System.EventHandler(this.btnpartidas_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(154, 33);
            this.lblSalir.Text = "Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 20);
            this.btnSalir.Text = "toolStripButton2";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(708, 460);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmmenu";
            this.Text = "frmmenu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel lblhoteles;
        public System.Windows.Forms.ToolStripButton btnhoteles;
        public System.Windows.Forms.ToolStripLabel lblparticipantes;
        public System.Windows.Forms.ToolStripButton btnparticipantes;
        public System.Windows.Forms.ToolStripLabel lblPartidas;
        public System.Windows.Forms.ToolStripButton btnpartidas;
        public System.Windows.Forms.ToolStripLabel lblSalir;
        public System.Windows.Forms.ToolStripButton btnSalir;
    }
}