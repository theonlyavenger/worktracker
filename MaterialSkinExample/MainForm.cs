using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        public MySqlConnection connection;
        string server;
        string database;
        string username;
        string password;

        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);

			
	        
        }

        private void blue_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        private void green_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }

        private void grey_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void darkmode_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            try
            {
                initilizeDatabase();
                clearStatus();
                status.Text = "Connected";
                status.Text = "Fetching existing data (if any) ..";
                displayData();
            }
            catch (Exception)
            {

                MessageBox.Show("Could not connect to the Database");
                this.Close();
            }
            
        }

        private void initilizeDatabase()
        {
            server = "localhost";
            database = "internship";
            username = "root";
            password = "";

            string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(constr);
        }

        private void displayData()
        {
            connection.Open();
            string query = "SELECT * FROM mydetails";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var item = new ListViewItem();
                item.Text = reader["date"].ToString();        // 1st column text
                item.SubItems.Add(reader["start"].ToString());  // 2nd column text
                item.SubItems.Add(reader["work"].ToString());  // 3nd column text
                item.SubItems.Add(reader["end"].ToString());  // 4nd column text
                materialListView1.Items.Add(item);
            }
            connection.Close();
        }
    
        private void clearStatus()
        {
            statusdialogue.Visible = true;
            timer2.Enabled = true;
            timer2.Interval = 5000;
            timer2.Start();
        }

        private void addworkhistory_Click(object sender, EventArgs e)
        {
            /* TODO */
        }

        private void starymyday_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToLongTimeString();
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");

            string sql = "INSERT into mydetails(date,start) Values('" + currentDate + "','" + currentTime + "')";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            try
            {

                cmd.ExecuteNonQuery();
               
                status.Text = "Entry for " + currentDate + " Initiated";
                clearStatus();
                status.Text = "Start Time Noted as " + currentTime;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + " ");
            }
            connection.Close();

        }

        private void endmyday_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToLongTimeString();
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");

            string sql = "UPDATE mydetails SET end= '" + currentTime + "'where date='" + currentDate + "'"; ;

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            try
            {
                cmd.ExecuteNonQuery();
                status.Text = "End Time Noted as " + currentTime;
                clearStatus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + " ");
            }
            connection.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = Convert.ToString(DateTime.Now.ToLongTimeString());
            currenttime.Text = time;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            status.Text = "";
            statusdialogue.Visible = false;
            timer2.Stop();
            timer2.Enabled = false;
        }
    }
}
