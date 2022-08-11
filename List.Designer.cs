namespace FX_IP_TV
{
    partial class List
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
            this.lblData = new System.Windows.Forms.Label();
            this.tbList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.Black;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Image = global::FX_IP_TV.Properties.Resources._4;
            this.lblData.Location = new System.Drawing.Point(70, 13);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(389, 25);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Список ссылок на момент 10.08.2022";
            // 
            // tbList
            // 
            this.tbList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbList.Location = new System.Drawing.Point(12, 49);
            this.tbList.Multiline = true;
            this.tbList.Name = "tbList";
            this.tbList.ReadOnly = true;
            this.tbList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbList.Size = new System.Drawing.Size(504, 433);
            this.tbList.TabIndex = 0;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::FX_IP_TV.Properties.Resources.background3;
            this.ClientSize = new System.Drawing.Size(528, 494);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.tbList);
            this.MaximizeBox = false;
            this.Name = "List";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список каналов FX IP-TV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox tbList;

    }
}