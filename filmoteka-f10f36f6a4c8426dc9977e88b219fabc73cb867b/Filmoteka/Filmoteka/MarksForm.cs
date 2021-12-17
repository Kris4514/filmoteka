using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmoteka
{
    public partial class MarksForm : Form
    {
        string mark;
        int x;
        string Z = GlobalClass.Variant1;
        public MarksForm()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LAPTOP-6038JFDU;Initial Catalog=FilmDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }

            Console.Read();
            namefilmLabel.Text = GlobalClass.Variant1;
            string stringCommand2 = "select [year] from [Films] WHERE [name]='" + GlobalClass.Variant1 + "'";
            SqlCommand da2 = new SqlCommand(stringCommand2, connection);
            // DataTable dt2 = new DataTable();
            // da2.Fill(dt2);
            connection.Open();
            year.Text = da2.ExecuteScalar().ToString();

            byte[] byteArray = new byte[0];
            string sqlCommand_foto = "select [poster] from [Films] WHERE [name]='" + GlobalClass.Variant1 + "'";
            MemoryStream ms = new MemoryStream(byteArray);
            Image img = Bitmap.FromStream(ms);
            this.pictureBox1.Image = img;
            connection.Close();
            //year.Text = "select [year] from [Films] WHERE [name]='" + GlobalClass.Variant1 + "'";

            //year.Text = GlobalClass.Variant2;
            //genre.Text = GlobalClass.Variant3;
            //director.Text = GlobalClass.Variant4;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            valuelabel.Text = trackBar1.Value.ToString();
            mark = trackBar1.Value.ToString();
            x = Convert.ToInt32(mark);
           /* if (x==2)
            {
                pictureBox2.Visible = false;
            }
            if (x == 3)
            {
                pictureBox3.Visible = false;

            }
            if (x == 4)
            {
                pictureBox4.Visible = false;
                

            }
            if (x == 5)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

            } */
        }

        private void MarksForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.dataSet1.Films);

        }
    }
}
