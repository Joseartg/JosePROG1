
namespace Jose01.VISTA
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLICKAQUIPARAMASINFORMAICONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemploUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.mATEMATICASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.arreglosToolStripMenuItem,
            this.mATEMATICASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLICKAQUIPARAMASINFORMAICONToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // cLICKAQUIPARAMASINFORMAICONToolStripMenuItem
            // 
            this.cLICKAQUIPARAMASINFORMAICONToolStripMenuItem.Name = "cLICKAQUIPARAMASINFORMAICONToolStripMenuItem";
            this.cLICKAQUIPARAMASINFORMAICONToolStripMenuItem.Size = new System.Drawing.Size(368, 22);
            this.cLICKAQUIPARAMASINFORMAICONToolStripMenuItem.Text = "SOMOS UNA EMPRESA DE DESARROLLO DE SOFTWARE";
            this.cLICKAQUIPARAMASINFORMAICONToolStripMenuItem.Click += new System.EventHandler(this.cLICKAQUIPARAMASINFORMAICONToolStripMenuItem_Click);
            // 
            // arreglosToolStripMenuItem
            // 
            this.arreglosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemploUsuarioToolStripMenuItem});
            this.arreglosToolStripMenuItem.Name = "arreglosToolStripMenuItem";
            this.arreglosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.arreglosToolStripMenuItem.Text = "Arreglos";
            this.arreglosToolStripMenuItem.Click += new System.EventHandler(this.arreglosToolStripMenuItem_Click);
            // 
            // ejemploUsuarioToolStripMenuItem
            // 
            this.ejemploUsuarioToolStripMenuItem.Name = "ejemploUsuarioToolStripMenuItem";
            this.ejemploUsuarioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ejemploUsuarioToolStripMenuItem.Text = "Ejemplo usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // mATEMATICASToolStripMenuItem
            // 
            this.mATEMATICASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumasToolStripMenuItem,
            this.restaToolStripMenuItem});
            this.mATEMATICASToolStripMenuItem.Name = "mATEMATICASToolStripMenuItem";
            this.mATEMATICASToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.mATEMATICASToolStripMenuItem.Text = "MATEMATICAS";
            // 
            // sumasToolStripMenuItem
            // 
            this.sumasToolStripMenuItem.Name = "sumasToolStripMenuItem";
            this.sumasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumasToolStripMenuItem.Text = "Suma";
            this.sumasToolStripMenuItem.Click += new System.EventHandler(this.sumasToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaToolStripMenuItem.Text = "Resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLICKAQUIPARAMASINFORMAICONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemploUsuarioToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mATEMATICASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
    }
}