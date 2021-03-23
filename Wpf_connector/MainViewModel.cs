using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Wpf_connector
{
  public class MainViewModel
  {
    public MySqlConnection myconnector;
    public MySqlCommand mycom;
    public string constr = "Server=localhost;Database=medxregistry;Uid=root;charset=utf8;";
    public SD.DataSet ds;

    private void Button_Click(object sender, RoutedEventArgs e)
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
  }
}
