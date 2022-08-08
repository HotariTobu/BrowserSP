namespace BrowserSP
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.webCom = new System.Windows.Forms.WebBrowser();
            this.topPanel = new System.Windows.Forms.Panel();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.miniButton = new System.Windows.Forms.Button();
            this.maxiButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.reloButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.closButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // webCom
            // 
            this.webCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webCom.IsWebBrowserContextMenuEnabled = false;
            this.webCom.Location = new System.Drawing.Point(3, 43);
            this.webCom.MinimumSize = new System.Drawing.Size(20, 20);
            this.webCom.Name = "webCom";
            this.webCom.Size = new System.Drawing.Size(792, 402);
            this.webCom.TabIndex = 8;
            this.webCom.Url = new System.Uri("", System.UriKind.Relative);
            this.webCom.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webCom_Navigated);
            // 
            // topPanel
            // 
            this.topPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topPanel.Controls.Add(this.urlBox);
            this.topPanel.Controls.Add(this.miniButton);
            this.topPanel.Controls.Add(this.maxiButton);
            this.topPanel.Controls.Add(this.homeButton);
            this.topPanel.Controls.Add(this.reloButton);
            this.topPanel.Controls.Add(this.nextButton);
            this.topPanel.Controls.Add(this.prevButton);
            this.topPanel.Controls.Add(this.closButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(792, 40);
            this.topPanel.TabIndex = 1;
            this.topPanel.DoubleClick += new System.EventHandler(this.topPanel_DoubleClick);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // urlBox
            // 
            this.urlBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.urlBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.urlBox.Location = new System.Drawing.Point(104, 17);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(607, 23);
            this.urlBox.TabIndex = 4;
            this.urlBox.TextChanged += new System.EventHandler(this.urlBox_TextChanged);
            this.urlBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlBox_KeyPress);
            // 
            // miniButton
            // 
            this.miniButton.AutoSize = true;
            this.miniButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.miniButton.BackColor = System.Drawing.SystemColors.Window;
            this.miniButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.miniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniButton.Location = new System.Drawing.Point(711, 0);
            this.miniButton.Name = "miniButton";
            this.miniButton.Size = new System.Drawing.Size(23, 40);
            this.miniButton.TabIndex = 5;
            this.miniButton.Text = "-";
            this.miniButton.UseVisualStyleBackColor = false;
            this.miniButton.Click += new System.EventHandler(this.miniButton_Click);
            // 
            // maxiButton
            // 
            this.maxiButton.AutoSize = true;
            this.maxiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxiButton.BackColor = System.Drawing.SystemColors.Window;
            this.maxiButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxiButton.Location = new System.Drawing.Point(734, 0);
            this.maxiButton.Name = "maxiButton";
            this.maxiButton.Size = new System.Drawing.Size(29, 40);
            this.maxiButton.TabIndex = 6;
            this.maxiButton.Text = "□";
            this.maxiButton.UseVisualStyleBackColor = false;
            this.maxiButton.Click += new System.EventHandler(this.maxiButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.AutoSize = true;
            this.homeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeButton.BackColor = System.Drawing.SystemColors.Window;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(75, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(29, 40);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "凸";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // reloButton
            // 
            this.reloButton.AutoSize = true;
            this.reloButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reloButton.BackColor = System.Drawing.SystemColors.Window;
            this.reloButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.reloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloButton.Location = new System.Drawing.Point(46, 0);
            this.reloButton.Name = "reloButton";
            this.reloButton.Size = new System.Drawing.Size(29, 40);
            this.reloButton.TabIndex = 2;
            this.reloButton.Text = "○";
            this.reloButton.UseVisualStyleBackColor = false;
            this.reloButton.Click += new System.EventHandler(this.reloButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = true;
            this.nextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextButton.BackColor = System.Drawing.SystemColors.Window;
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(23, 0);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(23, 40);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.AutoSize = true;
            this.prevButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.prevButton.BackColor = System.Drawing.SystemColors.Window;
            this.prevButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.Location = new System.Drawing.Point(0, 0);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(23, 40);
            this.prevButton.TabIndex = 0;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // closButton
            // 
            this.closButton.AutoSize = true;
            this.closButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closButton.BackColor = System.Drawing.SystemColors.Window;
            this.closButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closButton.Location = new System.Drawing.Point(763, 0);
            this.closButton.Name = "closButton";
            this.closButton.Size = new System.Drawing.Size(29, 40);
            this.closButton.TabIndex = 7;
            this.closButton.Text = "×";
            this.closButton.UseVisualStyleBackColor = false;
            this.closButton.Click += new System.EventHandler(this.closButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.webCom);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(3);
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 9;
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "BrowserSP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webCom;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button miniButton;
        private System.Windows.Forms.Button closButton;
        private System.Windows.Forms.Button maxiButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button reloButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Panel mainPanel;
    }
}

