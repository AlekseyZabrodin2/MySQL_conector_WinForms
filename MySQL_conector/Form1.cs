using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL_conector
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    public MySqlConnection myconnector;
    public MySqlCommand mycom;
    public string constr = "Server=localhost;Database=medxregistry;Uid=root;charset=utf8;";
    public SD.DataSet ds;

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        myconnector = new MySqlConnection(constr);
        myconnector.Open();
        MessageBox.Show("DB CONNECT");
        myconnector.Close();
      }
      catch
      {
        MessageBox.Show("Хрен тебе!!!");
      }
    }
    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        string script = scripter.Text;
        myconnector = new MySqlConnection(constr);
        myconnector.Open();
        MySqlDataAdapter ms_data = new MySqlDataAdapter(script, myconnector);
        SD.DataTable table = new SD.DataTable();
        ms_data.Fill(table);
        dgv.DataSource = table;
        myconnector.Close();
      }
      catch
      {
        MessageBox.Show("Connection Lost");
      }
    }
    private void button3_Click(object sender, EventArgs e)
    {
      try
      {
        myconnector = new MySqlConnection(constr);
        myconnector.Open();
        SD.DataTable table = new SD.DataTable();
        dgv.DataSource = table;
        myconnector.Close();
      }
      catch
      {
        MessageBox.Show("Error");
      }
    }
  }
}
