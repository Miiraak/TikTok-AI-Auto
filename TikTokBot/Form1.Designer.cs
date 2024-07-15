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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxPrivacyLevel = new ComboBox();
            checkBoxDuet = new CheckBox();
            checkBoxComment = new CheckBox();
            textBoxTitle = new TextBox();
            panelPhoto = new Panel();
            checkBoxAutoMusic = new CheckBox();
            label7 = new Label();
            richTextBoxDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            panelPhoto.SuspendLayout();
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
            textBoxUsername.Location = new Point(93, 27);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.ReadOnly = true;
            textBoxUsername.Size = new Size(169, 23);
            textBoxUsername.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 9);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 34);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 11;
            label2.Text = "Title :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 88);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 12;
            label3.Text = "Description :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 405);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 13;
            label4.Text = "Privacy Level :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 460);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 14;
            label5.Text = "Disable Duet ?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 480);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 15;
            label6.Text = "Disable comment ?";
            // 
            // comboBoxPrivacyLevel
            // 
            comboBoxPrivacyLevel.FormattingEnabled = true;
            comboBoxPrivacyLevel.Items.AddRange(new object[] { "PUBLIC_TO_EVERYONE", "MUTUAL_FOLLOW_FRIENDS", "FOLLOWER_OF_CREATOR", "SELF_ONLY" });
            comboBoxPrivacyLevel.Location = new Point(132, 423);
            comboBoxPrivacyLevel.Name = "comboBoxPrivacyLevel";
            comboBoxPrivacyLevel.Size = new Size(328, 23);
            comboBoxPrivacyLevel.TabIndex = 16;
            // 
            // checkBoxDuet
            // 
            checkBoxDuet.AutoSize = true;
            checkBoxDuet.Location = new Point(217, 461);
            checkBoxDuet.Name = "checkBoxDuet";
            checkBoxDuet.Size = new Size(15, 14);
            checkBoxDuet.TabIndex = 17;
            checkBoxDuet.UseVisualStyleBackColor = true;
            // 
            // checkBoxComment
            // 
            checkBoxComment.AutoSize = true;
            checkBoxComment.Location = new Point(244, 482);
            checkBoxComment.Name = "checkBoxComment";
            checkBoxComment.Size = new Size(15, 14);
            checkBoxComment.TabIndex = 18;
            checkBoxComment.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(130, 52);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(330, 23);
            textBoxTitle.TabIndex = 20;
            // 
            // panelPhoto
            // 
            panelPhoto.Controls.Add(richTextBoxDescription);
            panelPhoto.Controls.Add(checkBoxAutoMusic);
            panelPhoto.Controls.Add(label7);
            panelPhoto.Controls.Add(label4);
            panelPhoto.Controls.Add(textBoxTitle);
            panelPhoto.Controls.Add(label2);
            panelPhoto.Controls.Add(label3);
            panelPhoto.Controls.Add(checkBoxComment);
            panelPhoto.Controls.Add(label5);
            panelPhoto.Controls.Add(checkBoxDuet);
            panelPhoto.Controls.Add(label6);
            panelPhoto.Controls.Add(comboBoxPrivacyLevel);
            panelPhoto.Location = new Point(12, 70);
            panelPhoto.Name = "panelPhoto";
            panelPhoto.Size = new Size(591, 551);
            panelPhoto.TabIndex = 21;
            // 
            // checkBoxAutoMusic
            // 
            checkBoxAutoMusic.AutoSize = true;
            checkBoxAutoMusic.Location = new Point(210, 502);
            checkBoxAutoMusic.Name = "checkBoxAutoMusic";
            checkBoxAutoMusic.Size = new Size(15, 14);
            checkBoxAutoMusic.TabIndex = 22;
            checkBoxAutoMusic.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 500);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 21;
            label7.Text = "Music auto ?";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(130, 106);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(330, 279);
            richTextBoxDescription.TabIndex = 23;
            richTextBoxDescription.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(615, 633);
            ControlBox = false;
            Controls.Add(panelPhoto);
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
            panelPhoto.ResumeLayout(false);
            panelPhoto.PerformLayout();
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxPrivacyLevel;
        private CheckBox checkBoxDuet;
        private CheckBox checkBoxComment;
        private TextBox textBoxTitle;
        private Panel panelPhoto;
        private CheckBox checkBoxAutoMusic;
        private Label label7;
        private RichTextBox richTextBoxDescription;
    }
}
