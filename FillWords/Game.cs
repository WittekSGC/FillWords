using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillWords
{
    public partial class Game : Form
    {
        private FWAlg fill;
        private MainMenuForm MainMenu;
        string[][] Matrix;
        string[] words;
        int Level; // 1 - 4
        int MSize;

        private Mode Pick { get; set; }
        SoundPlayer Player = new SoundPlayer(properites.Sound);
        bool Playing;

        //для бд
        OleDbDataAdapter adapter;
        OleDbConnection conn;
        DataTable table;
        string NickName;

        //время игры
        int Time;
        int HH, MM, SS;

        //флаг победы
        bool Win;

        //подсказки
        public int TimeOnNoPlay;

        public Game(Mode pick, MainMenuForm mainMenu, string Nick)
        {
            Pick = pick;
            MainMenu = mainMenu;
            NickName = Nick;
            InitializeComponent(); 
            Level = 1;
            tGameTime.Enabled = true;
            conn = new OleDbConnection(properites.DBConnectionString);
        }

        private void LoadLevel()
        {
            switch (Pick)
            {
                case Mode.fish:
                    LoadFishLevel();
                    break;
                case Mode.plants:
                    LoadPlantsLevel();
                    break;
                case Mode.animals:
                    LoadAnimalsLevel();
                    break;
                case Mode.eat:
                    LoadEatsLevel();
                    break;
                default:
                    break;
            }
            fill = new FWAlg(dataGridView1, Matrix, words, MSize, this);
            dataGridView1.Location = new Point((this.Width / 2) - (dataGridView1.Width / 2), dataGridView1.Location.Y);
            lbLevelNumber.Text = Level.ToString();
            Time = 0;
            TimeOnNoPlay = 0;
            if (Level == 1)
                btPrevLevel.Visible = false;
            tGameTime.Enabled = true;
            lbGameTime.Text = "0:00:00";

            table = new DataTable();
            conn.Open();
            adapter = new OleDbDataAdapter
            {
                SelectCommand = new OleDbCommand($"SELECT {Pick}level{Level} FROM UserRecords WHERE Nick='{NickName}'", conn)
            };
            adapter.Fill(table);
            lbTimeRecord.Text = "";
            if (table != null)
                lbTimeRecord.Text = table.Rows[0].Field<DateTime>(0).ToLongTimeString();
            conn.Close();
        }

        private void LoadFishLevel()
        {
            FileStream file = new FileStream(properites.Fishes + "level" + Level.ToString() + ".bin", FileMode.Open, FileAccess.Read); //не забыть убрать ../../
            StreamReader reader = new StreamReader(file);
            MSize = int.Parse(reader.ReadLine());
            words = reader.ReadLine().ToUpper().Split(' ');//слова в матрице
            Matrix = new string[MSize][];
            for (int i = 0; i < MSize; i++)
            {
                Matrix[i] = reader.ReadLine().ToUpper().Split('\t'); // строка матрицы
            }
            reader.Close();
            file.Close();

            lbCategory.Text = "Виды рыб";
        }

        private void LoadPlantsLevel()
        {
            FileStream file = new FileStream(properites.Plants + "level" + Level.ToString() + ".bin", FileMode.Open, FileAccess.Read); //не забыть убрать ../../
            StreamReader reader = new StreamReader(file);
            MSize = int.Parse(reader.ReadLine());
            words = reader.ReadLine().ToUpper().Split(' ');//слова в матрице
            Matrix = new string[MSize][];
            for (int i = 0; i < MSize; i++)
            {
                Matrix[i] = reader.ReadLine().ToUpper().Split('\t'); // строка матрицы
            }
            reader.Close();
            file.Close();

            lbCategory.Text = "Растения";
        }

        private void LoadAnimalsLevel()
        {
            FileStream file = new FileStream(properites.Animals + "level" + Level.ToString() + ".bin", FileMode.Open, FileAccess.Read); //не забыть убрать ../../
            StreamReader reader = new StreamReader(file);
            MSize = int.Parse(reader.ReadLine());
            words = reader.ReadLine().ToUpper().Split(' ');//слова в матрице
            Matrix = new string[MSize][];
            for (int i = 0; i < MSize; i++)
            {
                Matrix[i] = reader.ReadLine().ToUpper().Split('\t'); // строка матрицы
            }
            reader.Close();
            file.Close();

            lbCategory.Text = "Животные";
        }

        private void LoadEatsLevel()
        {
            FileStream file = new FileStream(properites.Eats + "level" + Level.ToString() + ".bin", FileMode.Open, FileAccess.Read); //не забыть убрать ../../
            StreamReader reader = new StreamReader(file);
            MSize = int.Parse(reader.ReadLine());
            words = reader.ReadLine().ToUpper().Split(' ');//слова в матрице
            Matrix = new string[MSize][];
            for (int i = 0; i < MSize; i++)
            {
                Matrix[i] = reader.ReadLine().ToUpper().Split('\t'); // строка матрицы
            }
            reader.Close();
            file.Close();

            lbCategory.Text = "Продукты";
        }

        private void TickSecond()
        {
            Time += tGameTime.Interval;
            HH = Time / 3600000;
            MM = (Time - (HH * 3600000)) / 60000;
            SS = (Time - (HH * 3600000) - (MM * 60000)) / 1000;

            lbGameTime.Text = $"{HH}:";
            if (MM < 10)
                lbGameTime.Text += $"0{MM}:";
            else
                lbGameTime.Text += $"{MM}:";
            if (SS < 10)
                lbGameTime.Text += $"0{SS}";
            else
                lbGameTime.Text += $"{SS}";
        }

        private void ShowTip()
        {
            lbTipWord.Text = fill.ShowTip();
        }

        private void NextLevel()
        {
            if (Level < 4)
                Level++;
            if (Level == 4)
            {
                btNextLevel.Visible = false;
                btPrevLevel.Visible = true;
            }
            if (Level > 1)
                btPrevLevel.Visible = true;
            LoadLevel();
            TickSecond();
            HideTip();
        }
        private void HideTip()
        {
            lbThisHas.Visible = false;
            lbTipWord.Visible = false;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            LoadLevel();
            Player.PlayLooping();
            Playing = true;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu.Show();
            if (Playing)
                Player.Stop();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            fill.OnCellMouseDown(sender, e);
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            fill.OnMouseUp();
            VictoryCheck();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            fill.OnCellMouseEnter(sender, e);
        }
        

        private void btNextLevel_Click(object sender, EventArgs e)
        {
            NextLevel();
        }

        private void btPrevLevel_Click(object sender, EventArgs e)
        {
            PreviousLevel();
        }

        private void tTips_Tick(object sender, EventArgs e)
        {
            TimeOnNoPlay += tTips.Interval;
            if (TimeOnNoPlay >= properites.ShowTipTime)
            {
                ShowTip();
                TimeOnNoPlay = 0;
                lbTipWord.Visible = true;
                lbThisHas.Visible = true;
            }
        }

        private void tGameTime_Tick(object sender, EventArgs e)
        {
            TickSecond();
        }

        private void btResumeGame_Click(object sender, EventArgs e)
        {
            pPausePanel.Visible = false;
            tGameTime.Enabled = true;
            tTips.Enabled = true;
            dataGridView1.Visible = true;
        }

        private void pbGamePause_Click(object sender, EventArgs e)
        {
            tGameTime.Enabled = false;
            tTips.Enabled = false;
            pPausePanel.Visible = true;
            dataGridView1.Visible = false;
        }

        private void pbSound_Click(object sender, EventArgs e)
        {
            if (Playing)
            {
                Playing = false;
                Player.Stop();
                pbSound.BackgroundImage = Images.SoundOff;
            }
            else
            {
                Playing = true;
                Player.PlayLooping();
                pbSound.BackgroundImage = Images.SoundOn;
            }
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            fill.OnMouseUp();
        }

        private void PreviousLevel()
        {
            if (Level > 1)
                Level--;
            if (Level == 1)
            {
                btNextLevel.Visible = true;
                btPrevLevel.Visible = false;
            }
            if (Level < 4)
                btNextLevel.Visible = true;
            LoadLevel();
            TickSecond();
            HideTip();
        }

        private void VictoryCheck()
        {
            Win = true;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (dataGridView1[i, j].Style.BackColor != properites.TrueWord)
                    {
                        Win = false;
                        break;
                    }
                }
                if (!Win)
                    break;
            }

            if (Win)
            {
                tGameTime.Enabled = false;
                string WinMessage = "Победа! Ваше время составило " + lbGameTime.Text;
                DateTime PlayerTime = DateTime.Parse("01.01.2000 " + lbGameTime.Text);
                DateTime RecordTime = new DateTime();
                if (lbTimeRecord.Text != "0:00:00")
                    RecordTime = DateTime.Parse("01.01.2000 " + lbTimeRecord.Text);

                if (lbTimeRecord.Text == "0:00:00" || PlayerTime < RecordTime)
                {
                    WinMessage += ". Новый Рекорд!";
                    lbTimeRecord.Text = lbGameTime.Text;

                    conn.Open();

                    _ = new OleDbCommand($"UPDATE UserRecords SET {Pick}level{Level}='{lbTimeRecord.Text}' WHERE  Nick='{NickName}'", conn).ExecuteNonQuery();

                    conn.Close();
                }

                MessageBox.Show(WinMessage);
                if (Level < 4)
                    NextLevel();
                else Close();
            }
        }
    }
}
