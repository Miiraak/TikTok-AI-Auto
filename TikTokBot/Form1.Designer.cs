namespace TikTokBot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonConnection = new Button();
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button1 = new Button();
            buttonShutdown = new Button();
            textBoxUsername = new TextBox();
            label1 = new Label();
            buttonPublish = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            SuspendLayout();
            // 
            // buttonConnection
            // 
            buttonConnection.Location = new Point(12, 12);
            buttonConnection.Name = "buttonConnection";
            buttonConnection.Size = new Size(75, 23);
            buttonConnection.TabIndex = 4;
            buttonConnection.Text = "Auth0";
            buttonConnection.UseVisualStyleBackColor = true;
            buttonConnection.Click += ButtonConnection_Click;
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Dock = DockStyle.Top;
            webView2.Location = new Point(0, 0);
            webView2.Name = "webView2";
            webView2.Size = new Size(800, 400);
            webView2.TabIndex = 0;
            webView2.ZoomFactor = 1D;
            // 
            // button1
            // 
            button1.Location = new Point(528, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Infos ?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // buttonShutdown
            // 
            buttonShutdown.Location = new Point(528, 41);
            buttonShutdown.Name = "buttonShutdown";
            buttonShutdown.Size = new Size(75, 23);
            buttonShutdown.TabIndex = 6;
            buttonShutdown.Text = "Shutdown";
            buttonShutdown.UseVisualStyleBackColor = true;
            buttonShutdown.Click += ButtonShutdown_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(181, 41);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.ReadOnly = true;
            textBoxUsername.Size = new Size(253, 23);
            textBoxUsername.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 16);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // buttonPublish
            // 
            buttonPublish.Location = new Point(12, 41);
            buttonPublish.Name = "buttonPublish";
            buttonPublish.Size = new Size(75, 23);
            buttonPublish.TabIndex = 10;
            buttonPublish.Text = "Publish";
            buttonPublish.UseVisualStyleBackColor = true;
            buttonPublish.Click += buttonPublish_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(615, 633);
            ControlBox = false;
            Controls.Add(buttonPublish);
            Controls.Add(label1);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonShutdown);
            Controls.Add(button1);
            Controls.Add(buttonConnection);
            Cursor = Cursors.Cross;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tiktok Bot";
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonConnection;
        private Button button1;
        private Button buttonShutdown;
        private TextBox textBoxUsername;
        private Label label1;
        private Button buttonPublish;
        private OpenFileDialog openFileDialog1;
    }
}
