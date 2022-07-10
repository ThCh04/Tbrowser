namespace Tbrowser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.backBtn = new System.Windows.Forms.ToolStripButton();
            this.forwBtn = new System.Windows.Forms.ToolStripButton();
            this.refBtn = new System.Windows.Forms.ToolStripButton();
            this.stopBtn = new System.Windows.Forms.ToolStripButton();
            this.homeBtn = new System.Windows.Forms.ToolStripButton();
            this.urlTx = new System.Windows.Forms.ToolStripTextBox();
            this.searchBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.donateBt = new System.Windows.Forms.ToolStripButton();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "Selección de nuevo elemento";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(1049, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1082, 25);
            this.miniToolStrip.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backBtn.Image = global::Tbrowser.Properties.Resources.md_arrow_round_back_1_512;
            this.backBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(23, 22);
            this.backBtn.Text = "Atrás (Ctrl+Izquierda)";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // forwBtn
            // 
            this.forwBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwBtn.Image = global::Tbrowser.Properties.Resources.md_arrow_round_forward_1_512;
            this.forwBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwBtn.Name = "forwBtn";
            this.forwBtn.Size = new System.Drawing.Size(23, 22);
            this.forwBtn.Text = "Siguiente (Ctrl+Derecha)";
            this.forwBtn.Click += new System.EventHandler(this.forwBtn_Click);
            // 
            // refBtn
            // 
            this.refBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refBtn.Image = global::Tbrowser.Properties.Resources.refresh_refresh_1_512;
            this.refBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(23, 22);
            this.refBtn.Text = "Refrescar (F5)";
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopBtn.Image = global::Tbrowser.Properties.Resources.x_18_512;
            this.stopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(23, 22);
            this.stopBtn.Text = "Detener (F4)";
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeBtn.Image = global::Tbrowser.Properties.Resources.home_home_7_512;
            this.homeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(23, 22);
            this.homeBtn.Text = "Inicio (Ctrl+I)";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // urlTx
            // 
            this.urlTx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.urlTx.Name = "urlTx";
            this.urlTx.Size = new System.Drawing.Size(900, 25);
            this.urlTx.Tag = "Buscar";
            this.urlTx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlTx_KeyDown);
            this.urlTx.Click += new System.EventHandler(this.urlTx_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchBtn.Image = global::Tbrowser.Properties.Resources.md_search_1_512;
            this.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(23, 22);
            this.searchBtn.Text = "Buscar";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backBtn,
            this.forwBtn,
            this.refBtn,
            this.stopBtn,
            this.homeBtn,
            this.urlTx,
            this.searchBtn,
            this.donateBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1211, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // donateBt
            // 
            this.donateBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.donateBt.Image = global::Tbrowser.Properties.Resources.paypal_23_512;
            this.donateBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.donateBt.Name = "donateBt";
            this.donateBt.Size = new System.Drawing.Size(23, 22);
            this.donateBt.Text = "Donar $";
            this.donateBt.Click += new System.EventHandler(this.donateBt_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 25);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1211, 545);
            this.chromiumWebBrowser1.TabIndex = 1;
            this.chromiumWebBrowser1.AddressChanged += new System.EventHandler<CefSharp.AddressChangedEventArgs>(this.chromiumWebBrowser1_AddressChanged);
            this.chromiumWebBrowser1.TitleChanged += new System.EventHandler<CefSharp.TitleChangedEventArgs>(this.chromiumWebBrowser1_TitleChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 570);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tbrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripButton backBtn;
        private System.Windows.Forms.ToolStripButton forwBtn;
        private System.Windows.Forms.ToolStripButton refBtn;
        private System.Windows.Forms.ToolStripButton stopBtn;
        private System.Windows.Forms.ToolStripButton homeBtn;
        private System.Windows.Forms.ToolStripTextBox urlTx;
        private System.Windows.Forms.ToolStripButton searchBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.ToolStripButton donateBt;
    }
}

