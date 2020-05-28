using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace FillWords
{
    public partial class MainMenuForm : Form
    {
        private Game GameForm;
        string UserNick = "Гость";

        //для бд
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbConnection conn;
        DataTable table = new DataTable();

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btMod1_Click(object sender, EventArgs e)
        {
            ShowGameForm(Mode.fish);
        }

        private void btMod2_Click(object sender, EventArgs e)
        {
            ShowGameForm(Mode.animals);
        }

        private void btMod4_Click(object sender, EventArgs e)
        {
            ShowGameForm(Mode.plants);
        }

        private void btMod3_Click(object sender, EventArgs e)
        {
            ShowGameForm(Mode.eat);
        }

        private void ShowGameForm(Mode pick)
        {
            GameForm = new Game(pick, this, UserNick);
            GameForm.Show();
            Hide();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            string md = Environment.GetFolderPath(Environment.SpecialFolder.Personal);//путь к Документам
            if (Directory.Exists(md + "\\FillWords") == false)
            {
                Directory.CreateDirectory(md + "\\FillWords");
            }
            if (File.Exists(md + "\\FillWords\\UserRecords.mdb") == false)
            {
                File.WriteAllBytes(md + "\\FillWords\\UserRecords.mdb", Resources.UserRecords);
            }

            conn = new OleDbConnection(properites.DBConnectionString);

            FileStream config = new FileStream(properites.ConfigFile, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(config);
            UserNick = reader.ReadLine().Substring(13);
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Подключение к базе данных прервано: проверьте доступ программы к диску, на который она установлена");
            }
            adapter.SelectCommand = new OleDbCommand($"SELECT Nick FROM UserRecords WHERE Nick='{UserNick}'", conn);
            adapter.Fill(table);
            if (table.Rows.Count == 1)
                lbUserNick.Text = UserNick;
            conn.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tbSwitchUser.Text == "Введите Ваш ник:")
                tbSwitchUser.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tbSwitchUser.Text == "")
                tbSwitchUser.Text = "Введите Ваш ник:";
        }

        private void btSwitchUser_Click(object sender, EventArgs e)
        {
            btCancelUser.Visible = true;
            btSaveUser.Visible = true;
            btSwitchUser.Visible = false;

            lbUserNick.Visible = false;
            tbSwitchUser.Visible = true;
        }

        private void btCancelUser_Click(object sender, EventArgs e)
        {
            CloseAddingUser();
        }

        private void CloseAddingUser()
        {
            btCancelUser.Visible = false;
            btSaveUser.Visible = false;
            btSwitchUser.Visible = true;

            lbUserNick.Visible = true;
            tbSwitchUser.Visible = false;
        }

        private void btSaveUser_Click(object sender, EventArgs e)
        {
            conn.Open();
            table.Clear();

            adapter.SelectCommand = new OleDbCommand($"SELECT Nick FROM UserRecords WHERE Nick='{tbSwitchUser.Text}'", conn);
            adapter.Fill(table);

            if ((table.Rows.Count == 0) || (table == null))
            {
                _ = new OleDbCommand($"INSERT INTO UserRecords (Nick) VALUES ('{tbSwitchUser.Text}')", conn).ExecuteNonQuery();
                UserNick = tbSwitchUser.Text;
                lbUserNick.Text = UserNick;
                RewriteConfig();
            }

            if (table.Rows.Count == 1)
            {
                UserNick = tbSwitchUser.Text;
                lbUserNick.Text = UserNick;
                RewriteConfig();
            }

            conn.Close();

            CloseAddingUser();
        }

        private void RewriteConfig()
        {
            FileStream config = new FileStream(properites.ConfigFile, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(config);
            writer.Write("lastusername=" + UserNick);
            writer.Close();
            config.Close();
        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("help.chm");
        }
    }
}
