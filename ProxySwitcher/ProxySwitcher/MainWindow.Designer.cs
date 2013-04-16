namespace ProxySwitcher
{
    partial class MainWindow
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
            this.labelProxyAddress = new System.Windows.Forms.Label();
            this.comboServers = new System.Windows.Forms.ComboBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.statusAuthor = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelNotice = new System.Windows.Forms.Label();
            this.statusAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProxyAddress
            // 
            this.labelProxyAddress.AutoSize = true;
            this.labelProxyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProxyAddress.Location = new System.Drawing.Point(8, 18);
            this.labelProxyAddress.Name = "labelProxyAddress";
            this.labelProxyAddress.Size = new System.Drawing.Size(114, 20);
            this.labelProxyAddress.TabIndex = 0;
            this.labelProxyAddress.Text = "Proxy Address:";
            // 
            // comboServers
            // 
            this.comboServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboServers.FormattingEnabled = true;
            this.comboServers.Location = new System.Drawing.Point(128, 15);
            this.comboServers.Name = "comboServers";
            this.comboServers.Size = new System.Drawing.Size(243, 26);
            this.comboServers.TabIndex = 2;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(11, 75);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(242, 33);
            this.btnSwitch.TabIndex = 4;
            this.btnSwitch.Text = "SWITCH NOW!";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(259, 75);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(112, 33);
            this.btnDisable.TabIndex = 5;
            this.btnDisable.Text = "No Proxy";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // statusAuthor
            // 
            this.statusAuthor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusAuthor.Location = new System.Drawing.Point(0, 120);
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(385, 22);
            this.statusAuthor.TabIndex = 6;
            this.statusAuthor.Text = "JM";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel1.Text = "2013, JM";
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotice.Location = new System.Drawing.Point(12, 56);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(195, 17);
            this.labelNotice.TabIndex = 7;
            this.labelNotice.Text = "Are You in Administrator Mode?";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 142);
            this.Controls.Add(this.labelNotice);
            this.Controls.Add(this.statusAuthor);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.comboServers);
            this.Controls.Add(this.labelProxyAddress);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Proxy Switcher";
            this.statusAuthor.ResumeLayout(false);
            this.statusAuthor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProxyAddress;
        private System.Windows.Forms.ComboBox comboServers;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.StatusStrip statusAuthor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelNotice;
    }
}

