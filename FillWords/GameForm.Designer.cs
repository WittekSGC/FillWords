
namespace FillWords
{
    partial class GameForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pbSoundSwitcher = new System.Windows.Forms.PictureBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbLevelDesc = new System.Windows.Forms.Label();
            this.lbLevelNumber = new System.Windows.Forms.Label();
            this.lbRecordDescr = new System.Windows.Forms.Label();
            this.lbTimeDescr = new System.Windows.Forms.Label();
            this.lbTimeRecord = new System.Windows.Forms.Label();
            this.lbGameTime = new System.Windows.Forms.Label();
            this.tGameTime = new System.Windows.Forms.Timer(this.components);
            this.btNextLevel = new System.Windows.Forms.Button();
            this.btPrevLevel = new System.Windows.Forms.Button();
            this.tTips = new System.Windows.Forms.Timer(this.components);
            this.lbThisHas = new System.Windows.Forms.Label();
            this.lbTipWord = new System.Windows.Forms.Label();
            this.pbGamePause = new System.Windows.Forms.PictureBox();
            this.pPausePanel = new System.Windows.Forms.Panel();
            this.btResumeGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoundSwitcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGamePause)).BeginInit();
            this.pPausePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(227, 118);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 239);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            // 
            // pbSoundSwitcher
            // 
            this.pbSoundSwitcher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbSoundSwitcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSoundSwitcher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSoundSwitcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSoundSwitcher.Image = global::FillWords.Images.SoundOn;
            this.pbSoundSwitcher.Location = new System.Drawing.Point(537, 9);
            this.pbSoundSwitcher.Name = "pbSoundSwitcher";
            this.pbSoundSwitcher.Size = new System.Drawing.Size(58, 63);
            this.pbSoundSwitcher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSoundSwitcher.TabIndex = 4;
            this.pbSoundSwitcher.TabStop = false;
            this.pbSoundSwitcher.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbCategory
            // 
            this.lbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCategory.Font = new System.Drawing.Font("soft", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.Color.DeepPink;
            this.lbCategory.Location = new System.Drawing.Point(12, 9);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(272, 34);
            this.lbCategory.TabIndex = 5;
            this.lbCategory.Text = "Category";
            // 
            // lbLevelDesc
            // 
            this.lbLevelDesc.AutoSize = true;
            this.lbLevelDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLevelDesc.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevelDesc.ForeColor = System.Drawing.Color.DeepPink;
            this.lbLevelDesc.Location = new System.Drawing.Point(12, 43);
            this.lbLevelDesc.Name = "lbLevelDesc";
            this.lbLevelDesc.Size = new System.Drawing.Size(117, 29);
            this.lbLevelDesc.TabIndex = 6;
            this.lbLevelDesc.Text = "Уровень:";
            // 
            // lbLevelNumber
            // 
            this.lbLevelNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLevelNumber.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevelNumber.ForeColor = System.Drawing.Color.DeepPink;
            this.lbLevelNumber.Location = new System.Drawing.Point(124, 43);
            this.lbLevelNumber.Name = "lbLevelNumber";
            this.lbLevelNumber.Size = new System.Drawing.Size(173, 29);
            this.lbLevelNumber.TabIndex = 7;
            this.lbLevelNumber.Text = "LevelNumber";
            // 
            // lbRecordDescr
            // 
            this.lbRecordDescr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbRecordDescr.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordDescr.ForeColor = System.Drawing.Color.Aqua;
            this.lbRecordDescr.Location = new System.Drawing.Point(274, 9);
            this.lbRecordDescr.Name = "lbRecordDescr";
            this.lbRecordDescr.Size = new System.Drawing.Size(126, 29);
            this.lbRecordDescr.TabIndex = 8;
            this.lbRecordDescr.Text = "Рекорд:";
            this.lbRecordDescr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbTimeDescr
            // 
            this.lbTimeDescr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTimeDescr.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeDescr.ForeColor = System.Drawing.Color.Aqua;
            this.lbTimeDescr.Location = new System.Drawing.Point(270, 38);
            this.lbTimeDescr.Name = "lbTimeDescr";
            this.lbTimeDescr.Size = new System.Drawing.Size(130, 34);
            this.lbTimeDescr.TabIndex = 9;
            this.lbTimeDescr.Text = "Время:";
            this.lbTimeDescr.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbTimeRecord
            // 
            this.lbTimeRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTimeRecord.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeRecord.ForeColor = System.Drawing.Color.Aqua;
            this.lbTimeRecord.Location = new System.Drawing.Point(397, 9);
            this.lbTimeRecord.Name = "lbTimeRecord";
            this.lbTimeRecord.Size = new System.Drawing.Size(153, 29);
            this.lbTimeRecord.TabIndex = 10;
            this.lbTimeRecord.Text = "timeRecord";
            // 
            // lbGameTime
            // 
            this.lbGameTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbGameTime.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameTime.ForeColor = System.Drawing.Color.Aqua;
            this.lbGameTime.Location = new System.Drawing.Point(397, 38);
            this.lbGameTime.Name = "lbGameTime";
            this.lbGameTime.Size = new System.Drawing.Size(153, 34);
            this.lbGameTime.TabIndex = 11;
            this.lbGameTime.Text = "TimeGame";
            this.lbGameTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tGameTime
            // 
            this.tGameTime.Interval = 1000;
            this.tGameTime.Tick += new System.EventHandler(this.tGameTime_Tick);
            // 
            // btNextLevel
            // 
            this.btNextLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btNextLevel.FlatAppearance.BorderSize = 2;
            this.btNextLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNextLevel.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNextLevel.ForeColor = System.Drawing.Color.Yellow;
            this.btNextLevel.Location = new System.Drawing.Point(332, 457);
            this.btNextLevel.Name = "btNextLevel";
            this.btNextLevel.Size = new System.Drawing.Size(318, 40);
            this.btNextLevel.TabIndex = 12;
            this.btNextLevel.Text = "Следующий уровень";
            this.btNextLevel.UseVisualStyleBackColor = false;
            this.btNextLevel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPrevLevel
            // 
            this.btPrevLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btPrevLevel.FlatAppearance.BorderSize = 2;
            this.btPrevLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrevLevel.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrevLevel.ForeColor = System.Drawing.Color.Yellow;
            this.btPrevLevel.Location = new System.Drawing.Point(12, 457);
            this.btPrevLevel.Name = "btPrevLevel";
            this.btPrevLevel.Size = new System.Drawing.Size(314, 40);
            this.btPrevLevel.TabIndex = 13;
            this.btPrevLevel.Text = "Предыдущий уровень";
            this.btPrevLevel.UseVisualStyleBackColor = false;
            this.btPrevLevel.Click += new System.EventHandler(this.button2_Click);
            // 
            // tTips
            // 
            this.tTips.Enabled = true;
            this.tTips.Interval = 1000;
            this.tTips.Tick += new System.EventHandler(this.tTips_Tick);
            // 
            // lbThisHas
            // 
            this.lbThisHas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbThisHas.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThisHas.ForeColor = System.Drawing.Color.Lime;
            this.lbThisHas.Location = new System.Drawing.Point(12, 72);
            this.lbThisHas.Name = "lbThisHas";
            this.lbThisHas.Size = new System.Drawing.Size(327, 43);
            this.lbThisHas.TabIndex = 14;
            this.lbThisHas.Text = "Здесь есть слово:";
            this.lbThisHas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbThisHas.Visible = false;
            // 
            // lbTipWord
            // 
            this.lbTipWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTipWord.Font = new System.Drawing.Font("soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipWord.ForeColor = System.Drawing.Color.Lime;
            this.lbTipWord.Location = new System.Drawing.Point(332, 72);
            this.lbTipWord.Name = "lbTipWord";
            this.lbTipWord.Size = new System.Drawing.Size(318, 43);
            this.lbTipWord.TabIndex = 15;
            this.lbTipWord.Text = "TipWord";
            this.lbTipWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTipWord.Visible = false;
            // 
            // pbGamePause
            // 
            this.pbGamePause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbGamePause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbGamePause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGamePause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGamePause.Image = global::FillWords.Images.PauseGame1;
            this.pbGamePause.Location = new System.Drawing.Point(592, 9);
            this.pbGamePause.Name = "pbGamePause";
            this.pbGamePause.Size = new System.Drawing.Size(58, 63);
            this.pbGamePause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGamePause.TabIndex = 16;
            this.pbGamePause.TabStop = false;
            this.pbGamePause.Click += new System.EventHandler(this.pbGamePause_Click);
            // 
            // pPausePanel
            // 
            this.pPausePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pPausePanel.Controls.Add(this.btResumeGame);
            this.pPausePanel.Controls.Add(this.pictureBox1);
            this.pPausePanel.Location = new System.Drawing.Point(12, 107);
            this.pPausePanel.Name = "pPausePanel";
            this.pPausePanel.Size = new System.Drawing.Size(638, 390);
            this.pPausePanel.TabIndex = 17;
            this.pPausePanel.Visible = false;
            // 
            // btResumeGame
            // 
            this.btResumeGame.BackColor = System.Drawing.Color.Transparent;
            this.btResumeGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btResumeGame.FlatAppearance.BorderSize = 0;
            this.btResumeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResumeGame.Image = global::FillWords.Images.Resume1;
            this.btResumeGame.Location = new System.Drawing.Point(129, 138);
            this.btResumeGame.Name = "btResumeGame";
            this.btResumeGame.Size = new System.Drawing.Size(408, 81);
            this.btResumeGame.TabIndex = 1;
            this.btResumeGame.UseVisualStyleBackColor = false;
            this.btResumeGame.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FillWords.Images.Pause1;
            this.pictureBox1.Location = new System.Drawing.Point(173, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::FillWords.Properties.Resources.gameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 509);
            this.Controls.Add(this.pPausePanel);
            this.Controls.Add(this.pbSoundSwitcher);
            this.Controls.Add(this.pbGamePause);
            this.Controls.Add(this.lbTipWord);
            this.Controls.Add(this.lbThisHas);
            this.Controls.Add(this.btPrevLevel);
            this.Controls.Add(this.btNextLevel);
            this.Controls.Add(this.lbGameTime);
            this.Controls.Add(this.lbTimeRecord);
            this.Controls.Add(this.lbTimeDescr);
            this.Controls.Add(this.lbRecordDescr);
            this.Controls.Add(this.lbLevelNumber);
            this.Controls.Add(this.lbLevelDesc);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Филворды\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoundSwitcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGamePause)).EndInit();
            this.pPausePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pbSoundSwitcher;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbLevelDesc;
        private System.Windows.Forms.Label lbLevelNumber;
        private System.Windows.Forms.Label lbRecordDescr;
        private System.Windows.Forms.Label lbTimeDescr;
        private System.Windows.Forms.Label lbTimeRecord;
        private System.Windows.Forms.Label lbGameTime;
        private System.Windows.Forms.Timer tGameTime;
        private System.Windows.Forms.Button btNextLevel;
        private System.Windows.Forms.Button btPrevLevel;
        private System.Windows.Forms.Timer tTips;
        private System.Windows.Forms.Label lbThisHas;
        private System.Windows.Forms.Label lbTipWord;
        private System.Windows.Forms.PictureBox pbGamePause;
        private System.Windows.Forms.Panel pPausePanel;
        private System.Windows.Forms.Button btResumeGame;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}