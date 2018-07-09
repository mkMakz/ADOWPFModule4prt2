using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADOWPFModule4prt2.Pages
{
    /// <summary>
    /// Interaction logic for ListGroup.xaml
    /// </summary>
    public partial class ListGroup : Page
    {
    private static SqlConnection con = new SqlConnection();
        public ListGroup()
        {
            InitializeComponent();

            con.ConnectionString = @"Server=DESKTOP-9QBKPFG\LOCALDB;Database=CRCMS_new;Trusted_Connection=True;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Group";

            DataSet ds = new DataSet();
            DataTable tbl = ds.Tables.Add("Group");

            SqlDataAdapter da =
                new SqlDataAdapter(cmd);

            con.Open();

            da.Fill(ds);

            con.Close();

           Group.ItemsSource


        }
    }
}
