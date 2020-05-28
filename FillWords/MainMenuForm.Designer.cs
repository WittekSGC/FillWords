namespace FillWords
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.lbPickCategory = new System.Windows.Forms.Label();
            this.btMod1 = new System.Windows.Forms.Button();
            this.btMod2 = new System.Windows.Forms.Button();
            this.btMod3 = new System.Windows.Forms.Button();
            this.btMod4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUserNick = new System.Windows.Forms.Label();
            this.btSwitchUser = new System.Windows.Forms.Button();
            this.tbSwitchUser = new System.Windows.Forms.TextBox();
            this.btSaveUser = new System.Windows.Forms.Button();
            this.btCancelUser = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPickCategory
            // 
            this.lbPickCategory.AutoSize = true;
            this.lbPickCategory.BackColor = System.Drawing.Color.Transparent;
            this.lbPickCategory.Font = new System.Drawing.Font("soft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPickCategory.ForeColor = System.Drawing.Color.Indigo;
            this.lbPickCategory.Location = new System.Drawing.Point(12, 230);
            this.lbPickCategory.Name = "lbPickCategory";
            this.lbPickCategory.Size = new System.Drawing.Size(446, 50);
            this.lbPickCategory.TabIndex = 0;
            this.lbPickCategory.Text = "Выберите категорию:";
            // 
            // btMod1
            // 
            this.btMod1.BackColor = System.Drawing.Color.Transparent;
            this.btMod1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMod1.FlatAppearance.BorderSize = 3;
            this.btMod1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMod1.Font = new System.Drawing.Font("soft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMod1.ForeColor = System.Drawing.Color.Indigo;
            this.btMod1.Location = new System.Drawing.Point(12, 283);
            this.btMod1.Name = "btMod1";
            this.btMod1.Size = new System.Drawing.Size(388, 90);
            this.btMod1.TabIndex = 1;
            this.btMod1.TabStop = false;
            this.btMod1.Text = "Виды рыб";
            this.btMod1.UseVisualStyleBackColor = false;
            this.btMod1.Click += new System.EventHandler(this.btMod1_Click);
            // 
            // btMod2
            // 
            this.btMod2.BackColor = System.Drawing.Color.Transparent;
            this.btMod2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMod2.FlatAppearance.BorderSize = 3;
            this.btMod2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMod2.Font = new System.Drawing.Font("soft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMod2.ForeColor = System.Drawing.Color.Indigo;
            this.btMod2.Location = new System.Drawing.Point(12, 379);
            this.btMod2.Name = "btMod2";
            this.btMod2.Size = new System.Drawing.Size(388, 90);
            this.btMod2.TabIndex = 1;
            this.btMod2.TabStop = false;
            this.btMod2.Text = "Животные";
            this.btMod2.UseVisualStyleBackColor = false;
            this.btMod2.Click += new System.EventHandler(this.btMod2_Click);
            // 
            // btMod3
            // 
            this.btMod3.BackColor = System.Drawing.Color.Transparent;
            this.btMod3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMod3.FlatAppearance.BorderSize = 3;
            this.btMod3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMod3.Font = new System.Drawing.Font("soft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMod3.ForeColor = System.Drawing.Color.Indigo;
            this.btMod3.Location = new System.Drawing.Point(406, 283);
            this.btMod3.Name = "btMod3";
            this.btMod3.Size = new System.Drawing.Size(386, 90);
            this.btMod3.TabIndex = 1;
            this.btMod3.TabStop = false;
            this.btMod3.Text = "Продукты";
            this.btMod3.UseVisualStyleBackColor = false;
            this.btMod3.Click += new System.EventHandler(this.btMod3_Click);
            // 
            // btMod4
            // 
            this.btMod4.BackColor = System.Drawing.Color.Transparent;
            this.btMod4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMod4.FlatAppearance.BorderSize = 3;
            this.btMod4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMod4.Font = new System.Drawing.Font("soft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMod4.ForeColor = System.Drawing.Color.Indigo;
            this.btMod4.Location = new System.Drawing.Point(406, 379);
            this.btMod4.Name = "btMod4";
            this.btMod4.Size = new System.Drawing.Size(386, 90);
            this.btMod4.TabIndex = 1;
            this.btMod4.TabStop = false;
            this.btMod4.Text = "Растения";
            this.btMod4.UseVisualStyleBackColor = false;
            this.btMod4.Click += new System.EventHandler(this.btMod4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("soft", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(637, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Здравствуйте,";
            // 
            // lbUserNick
            // 
            this.lbUserNick.BackColor = System.Drawing.Color.Transparent;
            this.lbUserNick.Font = new System.Drawing.Font("soft", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbUserNick.Location = new System.Drawing.Point(208, 184);
            this.lbUserNick.Name = "lbUserNick";
            this.lbUserNick.Size = new System.Drawing.Size(584, 35);
            this.lbUserNick.TabIndex = 3;
            this.lbUserNick.Text = "Гость";
            this.lbUserNick.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btSwitchUser
            // 
            this.btSwitchUser.BackColor = System.Drawing.Color.Transparent;
            this.btSwitchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSwitchUser.FlatAppearance.BorderSize = 0;
            this.btSwitchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSwitchUser.Font = new System.Drawing.Font("soft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSwitchUser.ForeColor = System.Drawing.Color.Black;
            this.btSwitchUser.Location = new System.Drawing.Point(642, 222);
            this.btSwitchUser.Name = "btSwitchUser";
            this.btSwitchUser.Size = new System.Drawing.Size(150, 32);
            this.btSwitchUser.TabIndex = 4;
            this.btSwitchUser.Text = "Это не Вы?";
            this.btSwitchUser.UseVisualStyleBackColor = false;
            this.btSwitchUser.Click += new System.EventHandler(this.btSwitchUser_Click);
            // 
            // tbSwitchUser
            // 
            this.tbSwitchUser.Font = new System.Drawing.Font("soft", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSwitchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbSwitchUser.Location = new System.Drawing.Point(536, 187);
            this.tbSwitchUser.Name = "tbSwitchUser";
            this.tbSwitchUser.Size = new System.Drawing.Size(256, 44);
            this.tbSwitchUser.TabIndex = 5;
            this.tbSwitchUser.Text = "Введите Ваш ник:";
            this.tbSwitchUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSwitchUser.Visible = false;
            this.tbSwitchUser.Enter += new System.EventHandler(this.textBox1_Enter);
            this.tbSwitchUser.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btSaveUser
            // 
            this.btSaveUser.BackColor = System.Drawing.Color.Transparent;
            this.btSaveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSaveUser.FlatAppearance.BorderSize = 0;
            this.btSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveUser.Font = new System.Drawing.Font("soft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveUser.ForeColor = System.Drawing.Color.Black;
            this.btSaveUser.Location = new System.Drawing.Point(574, 234);
            this.btSaveUser.Name = "btSaveUser";
            this.btSaveUser.Size = new System.Drawing.Size(115, 37);
            this.btSaveUser.TabIndex = 6;
            this.btSaveUser.Text = "Сохранить";
            this.btSaveUser.UseVisualStyleBackColor = false;
            this.btSaveUser.Visible = false;
            this.btSaveUser.Click += new System.EventHandler(this.btSaveUser_Click);
            // 
            // btCancelUser
            // 
            this.btCancelUser.BackColor = System.Drawing.Color.Transparent;
            this.btCancelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelUser.FlatAppearance.BorderSize = 0;
            this.btCancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelUser.Font = new System.Drawing.Font("soft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelUser.ForeColor = System.Drawing.Color.Black;
            this.btCancelUser.Location = new System.Drawing.Point(682, 236);
            this.btCancelUser.Name = "btCancelUser";
            this.btCancelUser.Size = new System.Drawing.Size(110, 33);
            this.btCancelUser.TabIndex = 7;
            this.btCancelUser.Text = "Отменить";
            this.btCancelUser.UseVisualStyleBackColor = false;
            this.btCancelUser.Visible = false;
            this.btCancelUser.Click += new System.EventHandler(this.btCancelUser_Click);
            // 
            // btHelp
            // 
            this.btHelp.BackColor = System.Drawing.Color.Transparent;
            this.btHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHelp.FlatAppearance.BorderSize = 3;
            this.btHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelp.Font = new System.Drawing.Font("soft", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btHelp.Location = new System.Drawing.Point(21, 159);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(147, 47);
            this.btHelp.TabIndex = 1;
            this.btHelp.TabStop = false;
            this.btHelp.Text = "Справка";
            this.btHelp.UseVisualStyleBackColor = false;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FillWords.Properties.Resources.startImage;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.btCancelUser);
            this.Controls.Add(this.btSaveUser);
            this.Controls.Add(this.tbSwitchUser);
            this.Controls.Add(this.btSwitchUser);
            this.Controls.Add(this.lbUserNick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMod4);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.btMod3);
            this.Controls.Add(this.btMod2);
            this.Controls.Add(this.btMod1);
            this.Controls.Add(this.lbPickCategory);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 520);
            this.MinimumSize = new System.Drawing.Size(820, 520);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Филворды\"";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPickCategory;
        private System.Windows.Forms.Button btMod1;
        private System.Windows.Forms.Button btMod2;
        private System.Windows.Forms.Button btMod3;
        private System.Windows.Forms.Button btMod4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUserNick;
        private System.Windows.Forms.Button btSwitchUser;
        private System.Windows.Forms.TextBox tbSwitchUser;
        private System.Windows.Forms.Button btSaveUser;
        private System.Windows.Forms.Button btCancelUser;
        private System.Windows.Forms.Button btHelp;
    }
}

