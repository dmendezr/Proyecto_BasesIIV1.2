﻿namespace Presentacion
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilacionBasicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilacionAvanzadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.votanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.tsmAdministracion});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilacionBasicaToolStripMenuItem,
            this.perfilacionAvanzadaToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // perfilacionBasicaToolStripMenuItem
            // 
            this.perfilacionBasicaToolStripMenuItem.Name = "perfilacionBasicaToolStripMenuItem";
            this.perfilacionBasicaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.perfilacionBasicaToolStripMenuItem.Text = "Perfilacion Basica";
            this.perfilacionBasicaToolStripMenuItem.Click += new System.EventHandler(this.perfilacionBasicaToolStripMenuItem_Click);
            // 
            // perfilacionAvanzadaToolStripMenuItem
            // 
            this.perfilacionAvanzadaToolStripMenuItem.Name = "perfilacionAvanzadaToolStripMenuItem";
            this.perfilacionAvanzadaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.perfilacionAvanzadaToolStripMenuItem.Text = "Perfilacion Avanzada";
            // 
            // tsmAdministracion
            // 
            this.tsmAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.votanteToolStripMenuItem,
            this.cantonToolStripMenuItem,
            this.distritoToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.tsmAdministracion.Name = "tsmAdministracion";
            this.tsmAdministracion.Size = new System.Drawing.Size(100, 20);
            this.tsmAdministracion.Text = "Administracion";
            // 
            // votanteToolStripMenuItem
            // 
            this.votanteToolStripMenuItem.Name = "votanteToolStripMenuItem";
            this.votanteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.votanteToolStripMenuItem.Text = "Votante";
            this.votanteToolStripMenuItem.Click += new System.EventHandler(this.votanteToolStripMenuItem_Click);
            // 
            // cantonToolStripMenuItem
            // 
            this.cantonToolStripMenuItem.Name = "cantonToolStripMenuItem";
            this.cantonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cantonToolStripMenuItem.Text = "Canton";
            this.cantonToolStripMenuItem.Click += new System.EventHandler(this.cantonToolStripMenuItem_Click);
            // 
            // distritoToolStripMenuItem
            // 
            this.distritoToolStripMenuItem.Name = "distritoToolStripMenuItem";
            this.distritoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.distritoToolStripMenuItem.Text = "Distrito";
            this.distritoToolStripMenuItem.Click += new System.EventHandler(this.distritoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilacionBasicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilacionAvanzadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAdministracion;
        private System.Windows.Forms.ToolStripMenuItem votanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
    }
}



