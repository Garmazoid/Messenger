namespace Messenger
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows


        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogRegTab = new System.Windows.Forms.TabPage();
            this.ExitBut = new System.Windows.Forms.Button();
            this.Registrarion = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordRegistr = new System.Windows.Forms.TextBox();
            this.loginRegistr = new System.Windows.Forms.TextBox();
            this.passwordVhod = new System.Windows.Forms.TextBox();
            this.loginVhod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MesTab = new System.Windows.Forms.TabPage();
            this.FriendsTab = new System.Windows.Forms.TabPage();
            this.updateFriendListBut = new System.Windows.Forms.Button();
            this.updateUserListBut = new System.Windows.Forms.Button();
            this.sendRequestBut = new System.Windows.Forms.Button();
            this.deleteRequestBut = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.requestList = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.requestBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.friendList = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.updateFriendListBut1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.friendList1 = new System.Windows.Forms.ListBox();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.chatLabel = new System.Windows.Forms.Label();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.sendMessageBut = new System.Windows.Forms.Button();
            this.LogRegTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MesTab.SuspendLayout();
            this.FriendsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogRegTab
            // 
            this.LogRegTab.Controls.Add(this.ExitBut);
            this.LogRegTab.Controls.Add(this.Registrarion);
            this.LogRegTab.Controls.Add(this.Log);
            this.LogRegTab.Controls.Add(this.label4);
            this.LogRegTab.Controls.Add(this.label5);
            this.LogRegTab.Controls.Add(this.label6);
            this.LogRegTab.Controls.Add(this.passwordRegistr);
            this.LogRegTab.Controls.Add(this.loginRegistr);
            this.LogRegTab.Controls.Add(this.passwordVhod);
            this.LogRegTab.Controls.Add(this.loginVhod);
            this.LogRegTab.Controls.Add(this.label3);
            this.LogRegTab.Controls.Add(this.label2);
            this.LogRegTab.Controls.Add(this.label1);
            this.LogRegTab.Location = new System.Drawing.Point(4, 22);
            this.LogRegTab.Name = "LogRegTab";
            this.LogRegTab.Padding = new System.Windows.Forms.Padding(3);
            this.LogRegTab.Size = new System.Drawing.Size(445, 304);
            this.LogRegTab.TabIndex = 1;
            this.LogRegTab.Text = "вход";
            this.LogRegTab.UseVisualStyleBackColor = true;
            // 
            // ExitBut
            // 
            this.ExitBut.Location = new System.Drawing.Point(186, 275);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(75, 23);
            this.ExitBut.TabIndex = 12;
            this.ExitBut.Text = "выйти";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // Registrarion
            // 
            this.Registrarion.Location = new System.Drawing.Point(265, 215);
            this.Registrarion.Name = "Registrarion";
            this.Registrarion.Size = new System.Drawing.Size(126, 23);
            this.Registrarion.TabIndex = 11;
            this.Registrarion.Text = "зарегистрироваться";
            this.Registrarion.UseVisualStyleBackColor = true;
            this.Registrarion.Click += new System.EventHandler(this.Registrarion_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(78, 215);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(75, 23);
            this.Log.TabIndex = 10;
            this.Log.Text = "войти";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(273, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Регистрация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "логин";
            // 
            // passwordRegistr
            // 
            this.passwordRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passwordRegistr.Location = new System.Drawing.Point(253, 160);
            this.passwordRegistr.Name = "passwordRegistr";
            this.passwordRegistr.Size = new System.Drawing.Size(147, 20);
            this.passwordRegistr.TabIndex = 6;
            // 
            // loginRegistr
            // 
            this.loginRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loginRegistr.Location = new System.Drawing.Point(253, 116);
            this.loginRegistr.Name = "loginRegistr";
            this.loginRegistr.Size = new System.Drawing.Size(147, 20);
            this.loginRegistr.TabIndex = 5;
            // 
            // passwordVhod
            // 
            this.passwordVhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passwordVhod.Location = new System.Drawing.Point(44, 160);
            this.passwordVhod.Name = "passwordVhod";
            this.passwordVhod.Size = new System.Drawing.Size(147, 20);
            this.passwordVhod.TabIndex = 1;
            // 
            // loginVhod
            // 
            this.loginVhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loginVhod.Location = new System.Drawing.Point(44, 116);
            this.loginVhod.Name = "loginVhod";
            this.loginVhod.Size = new System.Drawing.Size(147, 20);
            this.loginVhod.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(90, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "логин";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.LogRegTab);
            this.tabControl1.Controls.Add(this.MesTab);
            this.tabControl1.Controls.Add(this.FriendsTab);
            this.tabControl1.ItemSize = new System.Drawing.Size(42, 18);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 330);
            this.tabControl1.TabIndex = 0;
            // 
            // MesTab
            // 
            this.MesTab.Controls.Add(this.sendMessageBut);
            this.MesTab.Controls.Add(this.MessageBox);
            this.MesTab.Controls.Add(this.chatLabel);
            this.MesTab.Controls.Add(this.chatBox);
            this.MesTab.Controls.Add(this.updateFriendListBut1);
            this.MesTab.Controls.Add(this.label11);
            this.MesTab.Controls.Add(this.friendList1);
            this.MesTab.Location = new System.Drawing.Point(4, 22);
            this.MesTab.Name = "MesTab";
            this.MesTab.Size = new System.Drawing.Size(445, 304);
            this.MesTab.TabIndex = 2;
            this.MesTab.Text = "чат";
            this.MesTab.UseVisualStyleBackColor = true;
            // 
            // FriendsTab
            // 
            this.FriendsTab.Controls.Add(this.updateFriendListBut);
            this.FriendsTab.Controls.Add(this.updateUserListBut);
            this.FriendsTab.Controls.Add(this.sendRequestBut);
            this.FriendsTab.Controls.Add(this.deleteRequestBut);
            this.FriendsTab.Controls.Add(this.label10);
            this.FriendsTab.Controls.Add(this.requestList);
            this.FriendsTab.Controls.Add(this.label9);
            this.FriendsTab.Controls.Add(this.userList);
            this.FriendsTab.Controls.Add(this.label8);
            this.FriendsTab.Controls.Add(this.requestBox);
            this.FriendsTab.Controls.Add(this.label7);
            this.FriendsTab.Controls.Add(this.friendList);
            this.FriendsTab.Location = new System.Drawing.Point(4, 22);
            this.FriendsTab.Name = "FriendsTab";
            this.FriendsTab.Size = new System.Drawing.Size(445, 304);
            this.FriendsTab.TabIndex = 3;
            this.FriendsTab.Text = "друзья";
            this.FriendsTab.UseVisualStyleBackColor = true;
            // 
            // updateFriendListBut
            // 
            this.updateFriendListBut.Location = new System.Drawing.Point(301, 271);
            this.updateFriendListBut.Name = "updateFriendListBut";
            this.updateFriendListBut.Size = new System.Drawing.Size(131, 23);
            this.updateFriendListBut.TabIndex = 15;
            this.updateFriendListBut.Text = "обновить";
            this.updateFriendListBut.UseVisualStyleBackColor = true;
            this.updateFriendListBut.Click += new System.EventHandler(this.updateFriendListBut_Click);
            // 
            // updateUserListBut
            // 
            this.updateUserListBut.Location = new System.Drawing.Point(12, 272);
            this.updateUserListBut.Name = "updateUserListBut";
            this.updateUserListBut.Size = new System.Drawing.Size(131, 23);
            this.updateUserListBut.TabIndex = 14;
            this.updateUserListBut.Text = "обновить";
            this.updateUserListBut.UseVisualStyleBackColor = true;
            this.updateUserListBut.Click += new System.EventHandler(this.updateUserListBut_Click);
            // 
            // sendRequestBut
            // 
            this.sendRequestBut.Location = new System.Drawing.Point(149, 242);
            this.sendRequestBut.Name = "sendRequestBut";
            this.sendRequestBut.Size = new System.Drawing.Size(147, 23);
            this.sendRequestBut.TabIndex = 13;
            this.sendRequestBut.Text = "отправить";
            this.sendRequestBut.UseVisualStyleBackColor = true;
            this.sendRequestBut.Click += new System.EventHandler(this.sendRequestBut_Click);
            // 
            // deleteRequestBut
            // 
            this.deleteRequestBut.Location = new System.Drawing.Point(149, 271);
            this.deleteRequestBut.Name = "deleteRequestBut";
            this.deleteRequestBut.Size = new System.Drawing.Size(147, 23);
            this.deleteRequestBut.TabIndex = 12;
            this.deleteRequestBut.Text = "отменить заявку";
            this.deleteRequestBut.UseVisualStyleBackColor = true;
            this.deleteRequestBut.Click += new System.EventHandler(this.deleteRequestBut_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(194, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "заявки";
            // 
            // requestList
            // 
            this.requestList.FormattingEnabled = true;
            this.requestList.Location = new System.Drawing.Point(149, 41);
            this.requestList.Name = "requestList";
            this.requestList.Size = new System.Drawing.Size(147, 147);
            this.requestList.TabIndex = 10;
            this.requestList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.requestList_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(17, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "пользователи";
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(12, 41);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(131, 225);
            this.userList.TabIndex = 8;
            this.userList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.userList_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "отправить/отменить заявку";
            // 
            // requestBox
            // 
            this.requestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.requestBox.Location = new System.Drawing.Point(149, 216);
            this.requestBox.Name = "requestBox";
            this.requestBox.Size = new System.Drawing.Size(147, 20);
            this.requestBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(340, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "друзья";
            // 
            // friendList
            // 
            this.friendList.FormattingEnabled = true;
            this.friendList.Location = new System.Drawing.Point(301, 39);
            this.friendList.Name = "friendList";
            this.friendList.Size = new System.Drawing.Size(131, 225);
            this.friendList.TabIndex = 0;
            this.friendList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.friendList_MouseDoubleClick);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusLabel.Location = new System.Drawing.Point(334, 11);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusLabel.Size = new System.Drawing.Size(129, 20);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "не авторизован";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updateFriendListBut1
            // 
            this.updateFriendListBut1.Location = new System.Drawing.Point(301, 271);
            this.updateFriendListBut1.Name = "updateFriendListBut1";
            this.updateFriendListBut1.Size = new System.Drawing.Size(131, 23);
            this.updateFriendListBut1.TabIndex = 18;
            this.updateFriendListBut1.Text = "обновить";
            this.updateFriendListBut1.UseVisualStyleBackColor = true;
            this.updateFriendListBut1.Click += new System.EventHandler(this.updateFriendListBut1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(340, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "друзья";
            // 
            // friendList1
            // 
            this.friendList1.FormattingEnabled = true;
            this.friendList1.Location = new System.Drawing.Point(301, 39);
            this.friendList1.Name = "friendList1";
            this.friendList1.Size = new System.Drawing.Size(131, 225);
            this.friendList1.TabIndex = 16;
            this.friendList1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.friendList1_MouseDoubleClick);
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(12, 39);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(283, 199);
            this.chatBox.TabIndex = 19;
            this.chatBox.Text = "";
            // 
            // chatLabel
            // 
            this.chatLabel.AutoSize = true;
            this.chatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chatLabel.Location = new System.Drawing.Point(8, 11);
            this.chatLabel.Name = "chatLabel";
            this.chatLabel.Size = new System.Drawing.Size(52, 20);
            this.chatLabel.TabIndex = 20;
            this.chatLabel.Text = "чат с:";
            // 
            // MessageBox
            // 
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MessageBox.Location = new System.Drawing.Point(12, 244);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(283, 20);
            this.MessageBox.TabIndex = 21;
            // 
            // sendMessageBut
            // 
            this.sendMessageBut.Location = new System.Drawing.Point(12, 270);
            this.sendMessageBut.Name = "sendMessageBut";
            this.sendMessageBut.Size = new System.Drawing.Size(131, 23);
            this.sendMessageBut.TabIndex = 22;
            this.sendMessageBut.Text = "отправить";
            this.sendMessageBut.UseVisualStyleBackColor = true;
            this.sendMessageBut.Click += new System.EventHandler(this.sendMessageBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 354);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LogRegTab.ResumeLayout(false);
            this.LogRegTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.MesTab.ResumeLayout(false);
            this.MesTab.PerformLayout();
            this.FriendsTab.ResumeLayout(false);
            this.FriendsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.TabPage LogRegTab;
        private System.Windows.Forms.Button Registrarion;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordRegistr;
        private System.Windows.Forms.TextBox loginRegistr;
        private System.Windows.Forms.TextBox passwordVhod;
        private System.Windows.Forms.TextBox loginVhod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MesTab;
        private System.Windows.Forms.TabPage FriendsTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox requestBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox friendList;
        private System.Windows.Forms.Button deleteRequestBut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox requestList;
        private System.Windows.Forms.Button sendRequestBut;
        private System.Windows.Forms.Button updateFriendListBut;
        private System.Windows.Forms.Button updateUserListBut;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button updateFriendListBut1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox friendList1;
        private System.Windows.Forms.Button sendMessageBut;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Label chatLabel;
        private System.Windows.Forms.RichTextBox chatBox;
    }
}

