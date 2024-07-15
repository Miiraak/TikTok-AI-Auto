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
            textBoxFTPpassword = new TextBox();
            textBoxFTPusername = new TextBox();
            textBoxDomain = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            richTextBoxPrompt = new RichTextBox();
            label9 = new Label();
            label8 = new Label();
            textBoxAPI_URL = new TextBox();
            textBoxAuth_Token_AI = new TextBox();
            buttonGenerateImage = new Button();
            richTextBoxDescription = new RichTextBox();
            checkBoxAutoMusic = new CheckBox();
            label7 = new Label();
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
            label2.Location = new Point(23, 34);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 11;
            label2.Text = "Title :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 88);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 12;
            label3.Text = "Description :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 405);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 13;
            label4.Text = "Privacy Level :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 460);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 14;
            label5.Text = "Disable Duet ?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 480);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 15;
            label6.Text = "Disable comment ?";
            // 
            // comboBoxPrivacyLevel
            // 
            comboBoxPrivacyLevel.FormattingEnabled = true;
            comboBoxPrivacyLevel.Items.AddRange(new object[] { "PUBLIC_TO_EVERYONE", "MUTUAL_FOLLOW_FRIENDS", "FOLLOWER_OF_CREATOR", "SELF_ONLY" });
            comboBoxPrivacyLevel.Location = new Point(25, 423);
            comboBoxPrivacyLevel.Name = "comboBoxPrivacyLevel";
            comboBoxPrivacyLevel.Size = new Size(248, 23);
            comboBoxPrivacyLevel.TabIndex = 16;
            // 
            // checkBoxDuet
            // 
            checkBoxDuet.AutoSize = true;
            checkBoxDuet.Location = new Point(110, 461);
            checkBoxDuet.Name = "checkBoxDuet";
            checkBoxDuet.Size = new Size(15, 14);
            checkBoxDuet.TabIndex = 17;
            checkBoxDuet.UseVisualStyleBackColor = true;
            // 
            // checkBoxComment
            // 
            checkBoxComment.AutoSize = true;
            checkBoxComment.Location = new Point(137, 482);
            checkBoxComment.Name = "checkBoxComment";
            checkBoxComment.Size = new Size(15, 14);
            checkBoxComment.TabIndex = 18;
            checkBoxComment.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(23, 52);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(250, 23);
            textBoxTitle.TabIndex = 20;
            // 
            // panelPhoto
            // 
            panelPhoto.Controls.Add(textBoxFTPpassword);
            panelPhoto.Controls.Add(textBoxFTPusername);
            panelPhoto.Controls.Add(textBoxDomain);
            panelPhoto.Controls.Add(label13);
            panelPhoto.Controls.Add(label12);
            panelPhoto.Controls.Add(label11);
            panelPhoto.Controls.Add(label10);
            panelPhoto.Controls.Add(richTextBoxPrompt);
            panelPhoto.Controls.Add(label9);
            panelPhoto.Controls.Add(label8);
            panelPhoto.Controls.Add(textBoxAPI_URL);
            panelPhoto.Controls.Add(textBoxAuth_Token_AI);
            panelPhoto.Controls.Add(buttonGenerateImage);
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
            // textBoxFTPpassword
            // 
            textBoxFTPpassword.Location = new Point(347, 159);
            textBoxFTPpassword.Name = "textBoxFTPpassword";
            textBoxFTPpassword.PasswordChar = '*';
            textBoxFTPpassword.Size = new Size(220, 23);
            textBoxFTPpassword.TabIndex = 36;
            // 
            // textBoxFTPusername
            // 
            textBoxFTPusername.Location = new Point(347, 106);
            textBoxFTPusername.Name = "textBoxFTPusername";
            textBoxFTPusername.Size = new Size(220, 23);
            textBoxFTPusername.TabIndex = 35;
            // 
            // textBoxDomain
            // 
            textBoxDomain.Location = new Point(347, 52);
            textBoxDomain.Name = "textBoxDomain";
            textBoxDomain.Size = new Size(220, 23);
            textBoxDomain.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(347, 141);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 33;
            label13.Text = "Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(347, 88);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 32;
            label12.Text = "Username";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(347, 34);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 31;
            label11.Text = "Domain";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(347, 366);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 30;
            label10.Text = "Prompt :";
            // 
            // richTextBoxPrompt
            // 
            richTextBoxPrompt.Location = new Point(347, 387);
            richTextBoxPrompt.Name = "richTextBoxPrompt";
            richTextBoxPrompt.Size = new Size(220, 108);
            richTextBoxPrompt.TabIndex = 29;
            richTextBoxPrompt.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(347, 312);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 28;
            label9.Text = "AUTH_TOKEN :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(347, 258);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 27;
            label8.Text = "API_URL :";
            // 
            // textBoxAPI_URL
            // 
            textBoxAPI_URL.Location = new Point(347, 276);
            textBoxAPI_URL.Name = "textBoxAPI_URL";
            textBoxAPI_URL.Size = new Size(220, 23);
            textBoxAPI_URL.TabIndex = 26;
            // 
            // textBoxAuth_Token_AI
            // 
            textBoxAuth_Token_AI.Location = new Point(347, 330);
            textBoxAuth_Token_AI.Name = "textBoxAuth_Token_AI";
            textBoxAuth_Token_AI.PasswordChar = '*';
            textBoxAuth_Token_AI.Size = new Size(220, 23);
            textBoxAuth_Token_AI.TabIndex = 25;
            // 
            // buttonGenerateImage
            // 
            buttonGenerateImage.Location = new Point(492, 502);
            buttonGenerateImage.Name = "buttonGenerateImage";
            buttonGenerateImage.Size = new Size(75, 23);
            buttonGenerateImage.TabIndex = 24;
            buttonGenerateImage.Text = "Generate";
            buttonGenerateImage.UseVisualStyleBackColor = true;
            buttonGenerateImage.Click += buttonGenerateImage_Click;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(23, 106);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(250, 279);
            richTextBoxDescription.TabIndex = 23;
            richTextBoxDescription.Text = "";
            // 
            // checkBoxAutoMusic
            // 
            checkBoxAutoMusic.AutoSize = true;
            checkBoxAutoMusic.Location = new Point(103, 502);
            checkBoxAutoMusic.Name = "checkBoxAutoMusic";
            checkBoxAutoMusic.Size = new Size(15, 14);
            checkBoxAutoMusic.TabIndex = 22;
            checkBoxAutoMusic.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 500);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 21;
            label7.Text = "Music auto ?";
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
        private Label label9;
        private Label label8;
        private TextBox textBoxAPI_URL;
        private TextBox textBoxAuth_Token_AI;
        private Button buttonGenerateImage;
        private RichTextBox richTextBoxPrompt;
        private Label label10;
        private TextBox textBoxFTPpassword;
        private TextBox textBoxFTPusername;
        private TextBox textBoxDomain;
        private Label label13;
        private Label label12;
        private Label label11;
    }
}
