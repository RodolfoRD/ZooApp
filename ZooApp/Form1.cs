using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class Form1 : Form
    {
        private ZooAccess zooAccess;
        public Form1()
        {
            InitializeComponent();
            zooAccess = new ZooAccess();
        }
      

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtAnimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbRepro_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            AnimalS AddAnimal = new AnimalS();
            AddAnimal.Nombre = txtAnimal.Text;
            AddAnimal.ColoOjos = txtOjos.Text;
            AddAnimal.ColorPiel = txtPiel.Text;
            AddAnimal.Visto = txtVisto.Text;
            AddAnimal.Tipo = txtTipo.Text;
            AddAnimal.Repro = txtRep.Text;


            zooAccess.SaveAnimal(AddAnimal);

        }
          

        private void BtnSonido_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LTKSGFB\\DRODRIDB;Initial Catalog=zooApp;Integrated Security=True");


        }
        private void AnimalSel()
        {
            
           



        }
        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.animalTableAdapter.FillBy(this.zooAppDataSet1.animal);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.animalTableAdapter.FillBy1(this.zooAppDataSet1.animal);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "JPG |*.jpg|PNG|*.png";
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = o.FileName;
                pictureBox1.Image = new Bitmap (o.FileName);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtVisto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LTKSGFB\\DRODRIDB;Initial Catalog=zooApp;Integrated Security=True");
            try
            {
                string imgpath = txtPath.Text;
                FileStream fs;
                fs = new FileStream(@imgpath, FileMode.Open, FileAccess.Read);
                byte[] picbyte = new byte[fs.Length];
                fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                con.Open();
                string query = "Insert into  img (IMG_Path,IMG-PIC)values('" + txtPath + "',@pic)";
                SqlParameter Pica = new SqlParameter();
                Pica.SqlDbType = SqlDbType.Image;
                Pica.ParameterName = "pic";
                Pica.Value = picbyte;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(Pica);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Image Stored");
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
