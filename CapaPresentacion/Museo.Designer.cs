namespace CapaPresentacion
{
    partial class Museo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiposDeMuseoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTipoMuseoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeMuseoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiposDeMuseoToolStripMenuItem
            // 
            this.tiposDeMuseoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarTipoMuseoToolStripMenuItem});
            this.tiposDeMuseoToolStripMenuItem.Name = "tiposDeMuseoToolStripMenuItem";
            this.tiposDeMuseoToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.tiposDeMuseoToolStripMenuItem.Text = "Tipos de museo";
            // 
            // buscarTipoMuseoToolStripMenuItem
            // 
            this.buscarTipoMuseoToolStripMenuItem.Name = "buscarTipoMuseoToolStripMenuItem";
            this.buscarTipoMuseoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buscarTipoMuseoToolStripMenuItem.Text = "Buscar tipo museo";
            // 
            // Museo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Museo";
            this.Text = "Sistema Museo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiposDeMuseoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTipoMuseoToolStripMenuItem;
    }
}

