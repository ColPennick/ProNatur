namespace ProNatur_Biomarkt_GmbH
{
    partial class LoadingScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.loadingProgressbar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoadingProgress = new System.Windows.Forms.Label();
            this.loadingbarTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loadingProgressbar
            // 
            resources.ApplyResources(this.loadingProgressbar, "loadingProgressbar");
            this.loadingProgressbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadingProgressbar.ForeColor = System.Drawing.Color.Lime;
            this.loadingProgressbar.Maximum = 25;
            this.loadingProgressbar.Name = "loadingProgressbar";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Name = "label1";
            // 
            // lblLoadingProgress
            // 
            resources.ApplyResources(this.lblLoadingProgress, "lblLoadingProgress");
            this.lblLoadingProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingProgress.ForeColor = System.Drawing.Color.Lime;
            this.lblLoadingProgress.Name = "lblLoadingProgress";
            // 
            // loadingbarTimer
            // 
            this.loadingbarTimer.Tick += new System.EventHandler(this.loadingbarTimer_Tick);
            // 
            // LoadingScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProNatur_Biomarkt_GmbH.Properties.Resources.GroceryImg;
            this.ControlBox = false;
            this.Controls.Add(this.lblLoadingProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadingProgressbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingScreen";
            this.Opacity = 0.85D;
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingProgressbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoadingProgress;
        private System.Windows.Forms.Timer loadingbarTimer;
    }
}

