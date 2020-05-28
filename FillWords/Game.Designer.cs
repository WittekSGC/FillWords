namespace FillWords
{
    partial class Game
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbCategory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLevelNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTimeRecord = new System.Windows.Forms.Label();
            this.lbGameTime = new System.Windows.Forms.Label();
            this.btPrevLevel = new System.Windows.Forms.Button();
            this.btNextLevel = new System.Windows.Forms.Button();
            this.tGameTime = new System.Windows.Forms.Timer(this.components);
            this.tTips = new System.Windows.Forms.Timer(this.components);
            this.lbThisHas = new System.Windows.Forms.Label();
            this.lbTipWord = new System.Windows.Forms.Label();
            this.pPausePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btResumeGame = new System.Windows.Forms.Button();
            this.pbSound = new System.Windows.Forms.PictureBox();
            this.pbGamePause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pPausePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGamePause)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(216, 109);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(359, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            // 
            // lbCategory
            // 
            this.lbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCategory.Font = new System.Drawing.Font("soft", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.Color.Lime;
            this.lbCategory.Location = new System.Drawing.Point(12, 9);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(328, 34);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "lbCategory";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Уровень";
            // 
            // lbLevelNumber
            // 
            this.lbLevelNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLevelNumber.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevelNumber.ForeColor = System.Drawing.Color.Lime;
            this.lbLevelNumber.Location = new System.Drawing.Point(117, 43);
            this.lbLevelNumber.Name = "lbLevelNumber";
            this.lbLevelNumber.Size = new System.Drawing.Size(223, 29);
            this.lbLevelNumber.TabIndex = 3;
            this.lbLevelNumber.Text = "lbLevelNumber";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(336, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Рекорд:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(338, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Время:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbTimeRecord
            // 
            this.lbTimeRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTimeRecord.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeRecord.ForeColor = System.Drawing.Color.Lime;
            this.lbTimeRecord.Location = new System.Drawing.Point(452, 9);
            this.lbTimeRecord.Name = "lbTimeRecord";
            this.lbTimeRecord.Size = new System.Drawing.Size(199, 34);
            this.lbTimeRecord.TabIndex = 6;
            this.lbTimeRecord.Text = "lbTimeRecord";
            // 
            // lbGameTime
            // 
            this.lbGameTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbGameTime.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameTime.ForeColor = System.Drawing.Color.Lime;
            this.lbGameTime.Location = new System.Drawing.Point(452, 43);
            this.lbGameTime.Name = "lbGameTime";
            this.lbGameTime.Size = new System.Drawing.Size(199, 29);
            this.lbGameTime.TabIndex = 7;
            this.lbGameTime.Text = "lbGameTime";
            // 
            // btPrevLevel
            // 
            this.btPrevLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btPrevLevel.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btPrevLevel.FlatAppearance.BorderSize = 4;
            this.btPrevLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrevLevel.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrevLevel.ForeColor = System.Drawing.Color.Yellow;
            this.btPrevLevel.Location = new System.Drawing.Point(12, 398);
            this.btPrevLevel.Name = "btPrevLevel";
            this.btPrevLevel.Size = new System.Drawing.Size(383, 40);
            this.btPrevLevel.TabIndex = 8;
            this.btPrevLevel.Text = "Предыдущий уровень";
            this.btPrevLevel.UseVisualStyleBackColor = false;
            this.btPrevLevel.Click += new System.EventHandler(this.btPrevLevel_Click);
            // 
            // btNextLevel
            // 
            this.btNextLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btNextLevel.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btNextLevel.FlatAppearance.BorderSize = 4;
            this.btNextLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNextLevel.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNextLevel.ForeColor = System.Drawing.Color.Yellow;
            this.btNextLevel.Location = new System.Drawing.Point(405, 398);
            this.btNextLevel.Name = "btNextLevel";
            this.btNextLevel.Size = new System.Drawing.Size(383, 40);
            this.btNextLevel.TabIndex = 8;
            this.btNextLevel.Text = "Следующий уровень";
            this.btNextLevel.UseVisualStyleBackColor = false;
            this.btNextLevel.Click += new System.EventHandler(this.btNextLevel_Click);
            // 
            // tGameTime
            // 
            this.tGameTime.Tick += new System.EventHandler(this.tGameTime_Tick);
            // 
            // tTips
            // 
            this.tTips.Enabled = true;
            this.tTips.Tick += new System.EventHandler(this.tTips_Tick);
            // 
            // lbThisHas
            // 
            this.lbThisHas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbThisHas.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThisHas.ForeColor = System.Drawing.Color.Lime;
            this.lbThisHas.Location = new System.Drawing.Point(12, 72);
            this.lbThisHas.Name = "lbThisHas";
            this.lbThisHas.Size = new System.Drawing.Size(383, 34);
            this.lbThisHas.TabIndex = 9;
            this.lbThisHas.Text = "Здесь есть слово:";
            this.lbThisHas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbThisHas.Visible = false;
            // 
            // lbTipWord
            // 
            this.lbTipWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTipWord.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipWord.ForeColor = System.Drawing.Color.Lime;
            this.lbTipWord.Location = new System.Drawing.Point(390, 72);
            this.lbTipWord.Name = "lbTipWord";
            this.lbTipWord.Size = new System.Drawing.Size(398, 34);
            this.lbTipWord.TabIndex = 10;
            this.lbTipWord.Text = "label3";
            this.lbTipWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTipWord.Visible = false;
            // 
            // pPausePanel
            // 
            this.pPausePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pPausePanel.Controls.Add(this.label1);
            this.pPausePanel.Controls.Add(this.btResumeGame);
            this.pPausePanel.Location = new System.Drawing.Point(12, 102);
            this.pPausePanel.Name = "pPausePanel";
            this.pPausePanel.Size = new System.Drawing.Size(776, 336);
            this.pPausePanel.TabIndex = 11;
            this.pPausePanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("soft", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(187, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 101);
            this.label1.TabIndex = 1;
            this.label1.Text = "ПАУЗА";
            // 
            // btResumeGame
            // 
            this.btResumeGame.BackColor = System.Drawing.Color.Transparent;
            this.btResumeGame.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btResumeGame.FlatAppearance.BorderSize = 2;
            this.btResumeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResumeGame.Font = new System.Drawing.Font("soft", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResumeGame.ForeColor = System.Drawing.Color.Yellow;
            this.btResumeGame.Location = new System.Drawing.Point(204, 203);
            this.btResumeGame.Name = "btResumeGame";
            this.btResumeGame.Size = new System.Drawing.Size(351, 56);
            this.btResumeGame.TabIndex = 0;
            this.btResumeGame.Text = "ПРОДОЛЖИТЬ";
            this.btResumeGame.UseVisualStyleBackColor = false;
            this.btResumeGame.Click += new System.EventHandler(this.btResumeGame_Click);
            // 
            // pbSound
            // 
            this.pbSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbSound.BackgroundImage = global::FillWords.Images.SoundOn;
            this.pbSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSound.Location = new System.Drawing.Point(650, 9);
            this.pbSound.Name = "pbSound";
            this.pbSound.Size = new System.Drawing.Size(70, 63);
            this.pbSound.TabIndex = 12;
            this.pbSound.TabStop = false;
            this.pbSound.Click += new System.EventHandler(this.pbSound_Click);
            // 
            // pbGamePause
            // 
            this.pbGamePause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbGamePause.BackgroundImage = global::FillWords.Images.PauseGame1;
            this.pbGamePause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGamePause.Location = new System.Drawing.Point(717, 9);
            this.pbGamePause.Name = "pbGamePause";
            this.pbGamePause.Size = new System.Drawing.Size(71, 63);
            this.pbGamePause.TabIndex = 12;
            this.pbGamePause.TabStop = false;
            this.pbGamePause.Click += new System.EventHandler(this.pbGamePause_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::FillWords.Images.gameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbGamePause);
            this.Controls.Add(this.pbSound);
            this.Controls.Add(this.pPausePanel);
            this.Controls.Add(this.lbTipWord);
            this.Controls.Add(this.lbThisHas);
            this.Controls.Add(this.btNextLevel);
            this.Controls.Add(this.btPrevLevel);
            this.Controls.Add(this.lbGameTime);
            this.Controls.Add(this.lbTimeRecord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbLevelNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Филворды";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pPausePanel.ResumeLayout(false);
            this.pPausePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGamePause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLevelNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTimeRecord;
        private System.Windows.Forms.Label lbGameTime;
        private System.Windows.Forms.Button btPrevLevel;
        private System.Windows.Forms.Button btNextLevel;
        private System.Windows.Forms.Timer tGameTime;
        private System.Windows.Forms.Timer tTips;
        private System.Windows.Forms.Label lbThisHas;
        private System.Windows.Forms.Label lbTipWord;
        private System.Windows.Forms.Panel pPausePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btResumeGame;
        private System.Windows.Forms.PictureBox pbSound;
        private System.Windows.Forms.PictureBox pbGamePause;
    }
}