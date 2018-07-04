using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        public MySqlConnection connection;
        string server;
        int port;
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
			materialSkinManager.ColorScheme = new 
                ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        private void blue_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new 
                ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        private void green_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new 
                ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }

        private void grey_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new 
                ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void darkmode_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme ==
                MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            searchlabel1.Visible = false;
            searchlabel2.Visible = false;
            searchlabel3.Visible = false;
            startTime.Visible = false;
            endTime.Visible = false;
            materialListView2.Visible = false;

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
            catch (Exception ex)
            {

                MessageBox.Show("Could not connect to the Database\n "+ex.Message);
                this.Close();
            }
            
        }

    /*    private void initilizeDatabase()
        {
            server = "db4free.net";
            port = 3306;
            database = "worktracker";
            username = "manojjahgirdar";
            password = "password";

            string constr = "SERVER=" + server + ";" +"PORT ="+ port + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(constr);
        } */

        private void initilizeDatabase()
        {
            server = "localhost";
            database = "internship";
            username = "root";
            password = "";

            string constr = "SERVER=" + server +";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(constr);
        }


        private void displayData()
        {
            materialListView1.Items.Clear();
            connection.Open();
            string query = "SELECT * FROM mydetails ORDER BY sno DESC";
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
            timer2.Interval = 2000;
            timer2.Start();
        }

        private void addworkhistory_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("dd-MMM-yyyy");
            string work = txtWork.Text;
            string updateQuery = "UPDATE mydetails SET work = CONCAT(work, ', " + work + "') WHERE date= '" + currentDate + "'";
            string insertQuery = "UPDATE mydetails SET work = '" + work + "' WHERE date= '" + currentDate + "'"; 
            string checkQuery = "SELECT work from mydetails where date = '" + currentDate + "'";

            if (work == "")
            {
                status.Text = "Work field cannot be empty...";
                clearStatus();
            }
            else
            { 
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(checkQuery, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                string check = reader["work"].ToString();
                if (check == "")
                {
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd2 = new MySqlCommand(insertQuery, connection);
                    try
                    {
                        cmd2.ExecuteNonQuery();
                        status.Text = "Added First Work History..";
                        clearStatus();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                        displayData();
                    }
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd2 = new MySqlCommand(updateQuery, connection);
                    try
                    {
                        cmd2.ExecuteNonQuery();
                        status.Text = "Work History Updated..";
                        clearStatus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                        displayData();
                    }
                }
                }
            }
        }

        private void starymyday_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToLongTimeString();
            string currentDate = DateTime.Now.ToString("dd-MMM-yyyy");

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
                starymyday.Enabled = false;
                status.Text = "Today's Record already Added!";
                clearStatus();
            }
            finally
            {
                connection.Close();
                displayData();
                starymyday.Enabled = false;
            }
            

        }

        private void endmyday_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToLongTimeString();
            string currentDate = DateTime.Now.ToString("dd-MMM-yyyy");

            string insertQuery = "UPDATE mydetails SET end= '" + currentTime + "'where date='" + currentDate + "'"; ;
            string checkQuery = "SELECT end from mydetails where date = '" + currentDate + "'";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(checkQuery, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                string check = reader["end"].ToString();
                if (check == "")
                {
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd2 = new MySqlCommand(insertQuery, connection);
                    try
                    {
                        endmyday.Enabled = false;
                        cmd2.ExecuteNonQuery();
                        status.Text = "End time noted as: " + currentTime;
                        clearStatus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                        displayData();
                    }
                }
                else
                {
                    connection.Close();
                    endmyday.Enabled = false;
                    status.Text = "End Time already noted once!";
                    clearStatus();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = Convert.ToString(DateTime.Now.ToLongTimeString());
            currenttime.Text = time;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            status.Text = "";
            statusdialogue.Visible = false;
            timer2.Stop();
            timer2.Enabled = false;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            status.Text = "Refreshing Data..";
            this.Cursor = Cursors.AppStarting;
            displayData();
            clearStatus();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            materialListView2.Items.Clear();


            searchlabel1.Visible = true;
            searchlabel2.Visible = true;
            searchlabel3.Visible = true;
            startTime.Visible = true;
            endTime.Visible = true;
            materialListView2.Visible = true;

            string key = dateTimePicker1.Text;
            status.Text = "Searching work done on " + key + "..";
            clearStatus();

            string query = "SELECT * from mydetails where date = '" + key + "'";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var item = new ListViewItem();
                    startTime.Text = reader["start"].ToString();  // 2nd column text
                    item.SubItems.Add(reader["work"].ToString());  // 3nd column text
                    endTime.Text = reader["end"].ToString();
                    materialListView2.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void retroAdd_Click(object sender, EventArgs e)
        {
            string date = dtpDate.Text;
            string startTime = tbstart.Text;
            string endtime = tbend.Text;
            string work = tbwork.Text;

            string sql = "INSERT into mydetails(date,start,work,end) Values('" + date + "','" + startTime + "','" + work + "','" + endtime + "')";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            try
            {
                cmd.ExecuteNonQuery();
                status.Text = "Entry added...";
                clearStatus();
            }
            catch (Exception)
            {
                status.Text = "something went wrong";
                clearStatus();


            }
            finally
            {
                connection.Close();
                displayData();
            }
        }

       
    }
}
