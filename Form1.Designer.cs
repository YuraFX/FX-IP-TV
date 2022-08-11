namespace FX_IP_TV
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbEmpty = new System.Windows.Forms.PictureBox();
            this.cB1 = new System.Windows.Forms.CheckBox();
            this.mS1 = new System.Windows.Forms.MenuStrip();
            this.списокСсылокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).BeginInit();
            this.mS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(0, 24);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(519, 306);
            this.WMP.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(341, 337);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 27);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Запустить канал";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUrl.Location = new System.Drawing.Point(12, 369);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(495, 22);
            this.tbUrl.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(170, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Закрыть канал";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbEmpty
            // 
            this.pbEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEmpty.Location = new System.Drawing.Point(0, 285);
            this.pbEmpty.Name = "pbEmpty";
            this.pbEmpty.Size = new System.Drawing.Size(519, 45);
            this.pbEmpty.TabIndex = 4;
            this.pbEmpty.TabStop = false;
            // 
            // cB1
            // 
            this.cB1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cB1.AutoSize = true;
            this.cB1.BackColor = System.Drawing.Color.Black;
            this.cB1.BackgroundImage = global::FX_IP_TV.Properties.Resources._3;
            this.cB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cB1.ForeColor = System.Drawing.Color.White;
            this.cB1.Location = new System.Drawing.Point(12, 342);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(142, 20);
            this.cB1.TabIndex = 2;
            this.cB1.Text = "Показать ToolBar";
            this.cB1.UseVisualStyleBackColor = false;
            this.cB1.CheckedChanged += new System.EventHandler(this.cB1_CheckedChanged);
            // 
            // mS1
            // 
            this.mS1.BackColor = System.Drawing.SystemColors.Control;
            this.mS1.BackgroundImage = global::FX_IP_TV.Properties.Resources.background3;
            this.mS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСсылокToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.mS1.Location = new System.Drawing.Point(0, 0);
            this.mS1.Name = "mS1";
            this.mS1.Size = new System.Drawing.Size(519, 28);
            this.mS1.TabIndex = 0;
            this.mS1.Text = "menuStrip1";
            // 
            // списокСсылокToolStripMenuItem
            // 
            this.списокСсылокToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.списокСсылокToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.списокСсылокToolStripMenuItem.Name = "списокСсылокToolStripMenuItem";
            this.списокСсылокToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.списокСсылокToolStripMenuItem.Text = "Список ссылок";
            this.списокСсылокToolStripMenuItem.Click += new System.EventHandler(this.списокСсылокToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.BackgroundImage = global::FX_IP_TV.Properties.Resources.background3;
            this.background.Location = new System.Drawing.Point(0, 285);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(519, 113);
            this.background.TabIndex = 5;
            this.background.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(519, 398);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbEmpty);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.mS1);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.background);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mS1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FX IP-TV 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).EndInit();
            this.mS1.ResumeLayout(false);
            this.mS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mS1;
        private System.Windows.Forms.ToolStripMenuItem списокСсылокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cB1;
        private System.Windows.Forms.TextBox tbUrl;
        public AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.PictureBox pbEmpty;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button btnClose;
    }
}

