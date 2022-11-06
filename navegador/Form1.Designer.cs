namespace navegador
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browser = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.atras = new System.Windows.Forms.ToolStripButton();
            this.alante = new System.Windows.Forms.ToolStripButton();
            this.cancelar = new System.Windows.Forms.ToolStripButton();
            this.actualizar = new System.Windows.Forms.ToolStripButton();
            this.navegador = new System.Windows.Forms.ToolStripTextBox();
            this.ir = new System.Windows.Forms.ToolStripButton();
            this.house = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(-9, -34);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(1171, 969);
            this.browser.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atras,
            this.alante,
            this.cancelar,
            this.actualizar,
            this.navegador,
            this.ir,
            this.house});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1174, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // atras
            // 
            this.atras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.atras.Image = ((System.Drawing.Image)(resources.GetObject("atras.Image")));
            this.atras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(23, 22);
            this.atras.Text = "toolStripButton1";
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // alante
            // 
            this.alante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alante.Image = ((System.Drawing.Image)(resources.GetObject("alante.Image")));
            this.alante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alante.Name = "alante";
            this.alante.Size = new System.Drawing.Size(23, 22);
            this.alante.Text = "toolStripButton2";
            this.alante.Click += new System.EventHandler(this.alante_Click);
            // 
            // cancelar
            // 
            this.cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelar.Image = ((System.Drawing.Image)(resources.GetObject("cancelar.Image")));
            this.cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(23, 22);
            this.cancelar.Text = "toolStripButton3";
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // actualizar
            // 
            this.actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actualizar.Image = ((System.Drawing.Image)(resources.GetObject("actualizar.Image")));
            this.actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(23, 22);
            this.actualizar.Text = "toolStripButton4";
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // navegador
            // 
            this.navegador.Margin = new System.Windows.Forms.Padding(1, 0, 2, 0);
            this.navegador.Name = "navegador";
            this.navegador.Size = new System.Drawing.Size(900, 25);
            this.navegador.Click += new System.EventHandler(this.navegador_Click);
            // 
            // ir
            // 
            this.ir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ir.Image = ((System.Drawing.Image)(resources.GetObject("ir.Image")));
            this.ir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ir.Name = "ir";
            this.ir.Size = new System.Drawing.Size(23, 22);
            this.ir.Text = "go";
            this.ir.Click += new System.EventHandler(this.ir_Click);
            // 
            // house
            // 
            this.house.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.house.Image = ((System.Drawing.Image)(resources.GetObject("house.Image")));
            this.house.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(23, 22);
            this.house.Text = "home";
            this.house.Click += new System.EventHandler(this.house_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 800);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.browser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Navegador";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton atras;
        private System.Windows.Forms.ToolStripButton alante;
        private System.Windows.Forms.ToolStripButton cancelar;
        private System.Windows.Forms.ToolStripButton actualizar;
        private System.Windows.Forms.ToolStripTextBox navegador;
        private System.Windows.Forms.ToolStripButton ir;
        private System.Windows.Forms.ToolStripButton house;
    }
}

