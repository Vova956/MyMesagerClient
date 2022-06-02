namespace Client
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
            this.components = new System.ComponentModel.Container();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.message_answer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.message_TextBox = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_getUsers = new System.Windows.Forms.Button();
            this.button_changeButton = new System.Windows.Forms.Button();
            this.register_nick_textBox = new System.Windows.Forms.TextBox();
            this.register_login_textBox = new System.Windows.Forms.TextBox();
            this.register_password_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.register_password = new System.Windows.Forms.Label();
            this.register_nick = new System.Windows.Forms.Label();
            this.register_login = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.answer = new System.Windows.Forms.RichTextBox();
            this.chat_answer = new System.Windows.Forms.RichTextBox();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chat_answer);
            this.tabPage2.Controls.Add(this.message_answer);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.message_TextBox);
            this.tabPage2.Controls.Add(this.send_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chat";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // message_answer
            // 
            this.message_answer.AutoSize = true;
            this.message_answer.Location = new System.Drawing.Point(16, 71);
            this.message_answer.Name = "message_answer";
            this.message_answer.Size = new System.Drawing.Size(16, 13);
            this.message_answer.TabIndex = 5;
            this.message_answer.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write Message : ";
            // 
            // message_TextBox
            // 
            this.message_TextBox.Location = new System.Drawing.Point(16, 44);
            this.message_TextBox.Name = "message_TextBox";
            this.message_TextBox.Size = new System.Drawing.Size(153, 20);
            this.message_TextBox.TabIndex = 2;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(25, 123);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(118, 39);
            this.send_button.TabIndex = 0;
            this.send_button.Text = "Send Message";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.answer);
            this.tabPage1.Controls.Add(this.button_getUsers);
            this.tabPage1.Controls.Add(this.button_changeButton);
            this.tabPage1.Controls.Add(this.register_nick_textBox);
            this.tabPage1.Controls.Add(this.register_login_textBox);
            this.tabPage1.Controls.Add(this.register_password_textBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.register_button);
            this.tabPage1.Controls.Add(this.register_password);
            this.tabPage1.Controls.Add(this.register_nick);
            this.tabPage1.Controls.Add(this.register_login);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Auth";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button_getUsers
            // 
            this.button_getUsers.Location = new System.Drawing.Point(157, 150);
            this.button_getUsers.Name = "button_getUsers";
            this.button_getUsers.Size = new System.Drawing.Size(110, 40);
            this.button_getUsers.TabIndex = 17;
            this.button_getUsers.Text = "GetUsers";
            this.button_getUsers.UseVisualStyleBackColor = true;
            this.button_getUsers.Click += new System.EventHandler(this.button_getUsers_Click);
            // 
            // button_changeButton
            // 
            this.button_changeButton.Location = new System.Drawing.Point(26, 225);
            this.button_changeButton.Name = "button_changeButton";
            this.button_changeButton.Size = new System.Drawing.Size(107, 40);
            this.button_changeButton.TabIndex = 15;
            this.button_changeButton.Text = "Change Auth";
            this.button_changeButton.UseVisualStyleBackColor = true;
            this.button_changeButton.Click += new System.EventHandler(this.button_changeButton_Click);
            // 
            // register_nick_textBox
            // 
            this.register_nick_textBox.Location = new System.Drawing.Point(134, 102);
            this.register_nick_textBox.Name = "register_nick_textBox";
            this.register_nick_textBox.Size = new System.Drawing.Size(100, 20);
            this.register_nick_textBox.TabIndex = 14;
            // 
            // register_login_textBox
            // 
            this.register_login_textBox.Location = new System.Drawing.Point(134, 67);
            this.register_login_textBox.Name = "register_login_textBox";
            this.register_login_textBox.Size = new System.Drawing.Size(100, 20);
            this.register_login_textBox.TabIndex = 13;
            // 
            // register_password_textBox
            // 
            this.register_password_textBox.Location = new System.Drawing.Point(134, 31);
            this.register_password_textBox.Name = "register_password_textBox";
            this.register_password_textBox.Size = new System.Drawing.Size(100, 20);
            this.register_password_textBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(26, 150);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(110, 40);
            this.register_button.TabIndex = 10;
            this.register_button.Tag = "RegisterButton";
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // register_password
            // 
            this.register_password.AutoSize = true;
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_password.Location = new System.Drawing.Point(21, 26);
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(114, 25);
            this.register_password.TabIndex = 2;
            this.register_password.Text = "Password : ";
            // 
            // register_nick
            // 
            this.register_nick.AutoSize = true;
            this.register_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_nick.Location = new System.Drawing.Point(24, 98);
            this.register_nick.Name = "register_nick";
            this.register_nick.Size = new System.Drawing.Size(115, 25);
            this.register_nick.TabIndex = 4;
            this.register_nick.Text = "Nickname : ";
            // 
            // register_login
            // 
            this.register_login.AutoSize = true;
            this.register_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_login.Location = new System.Drawing.Point(24, 62);
            this.register_login.Name = "register_login";
            this.register_login.Size = new System.Drawing.Size(76, 25);
            this.register_login.TabIndex = 3;
            this.register_login.Text = "Login : ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 322);
            this.tabControl1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(300, 16);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(277, 261);
            this.answer.TabIndex = 18;
            this.answer.Text = "";
            // 
            // chat_answer
            // 
            this.chat_answer.Location = new System.Drawing.Point(242, 10);
            this.chat_answer.Name = "chat_answer";
            this.chat_answer.Size = new System.Drawing.Size(333, 274);
            this.chat_answer.TabIndex = 6;
            this.chat_answer.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 322);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_getUsers;
        private System.Windows.Forms.Button button_changeButton;
        private System.Windows.Forms.TextBox register_nick_textBox;
        private System.Windows.Forms.TextBox register_login_textBox;
        private System.Windows.Forms.TextBox register_password_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label register_password;
        private System.Windows.Forms.Label register_nick;
        private System.Windows.Forms.Label register_login;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox message_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label message_answer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox answer;
        private System.Windows.Forms.RichTextBox chat_answer;
    }
}

