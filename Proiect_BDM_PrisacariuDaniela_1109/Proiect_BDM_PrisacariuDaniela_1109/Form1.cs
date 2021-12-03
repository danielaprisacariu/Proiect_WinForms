using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BDM_PrisacariuDaniela_1109
{
    public partial class Form1 : Form
    {
        OracleConnection conexiune;
        string imgSelectata = null;
        public Form1()
        {
            InitializeComponent();
            initializareListView();
        }

        public void deschidereConexiune()
        {
            string cons = "User ID=STUD_PRISACARIUD; Password=stud; Data Source=(DESCRIPTION=" +
           "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=37.120.249.41)(PORT=1521)))" +
           "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcls)));";
            conexiune = new OracleConnection(cons);
            //MessageBox.Show("Conexiune realizata cu succes!");
        }

        private void apelProcCautare(string denumire)
        {
            OracleCommand cmd = new OracleCommand("proc_citire_img", conexiune);

            try
            {
                conexiune.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("v_denumire", OracleDbType.Varchar2);
                cmd.Parameters.Add("flux", OracleDbType.Blob);
                cmd.Parameters[0].Direction = ParameterDirection.Input;
                cmd.Parameters[1].Direction = ParameterDirection.Output;
                cmd.Parameters[0].Value = denumire;

                cmd.ExecuteScalar();

                OracleBlob temp = (OracleBlob)cmd.Parameters[1].Value;
                pictureBox1.Image = Image.FromStream(temp);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                
            }
        }
        private void btnCautaImg_Click(object sender, EventArgs e)
        {
            deschidereConexiune();
            apelProcCautare(tbDenPictCutata.Text);
        }

        private void initializareListView()
        {
            listView1.Items.Clear();
            deschidereConexiune();
            string sqlSelect = "Select denumire, artist, anaparitie from picturi";
            OracleCommand cmd = new OracleCommand(sqlSelect, conexiune);
            try
            {
                conexiune.Open();
                OracleDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read())
                {
                    ListViewItem rand = new ListViewItem();
                    rand.Text = reader["denumire"].ToString();
                    rand.SubItems.Add(reader["artist"].ToString());
                    rand.SubItems.Add(reader["anaparitie"].ToString());
                    rand.Tag = reader["denumire"];

                    listView1.Items.Add(rand);
                    
                }
                
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                imgSelectata = item.Tag.ToString();
                apelProcCautare(imgSelectata);
            }
        }

        private void btnInserare_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            initializareListView();
        }

        private void btnVideoclipuri_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void imagineInOglindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deschidereConexiune();
            OracleCommand cmd = new OracleCommand("proc_procesare_img", conexiune);

            try
            {
                conexiune.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("v_denumire", OracleDbType.Varchar2).Value = imgSelectata;
                cmd.Parameters[0].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Imagine procesata!");
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mesaj = "Doriti sa stergeti inregistrarea " + imgSelectata + "?";
            const string nume = "Stergere";
            var result = MessageBox.Show(mesaj, nume, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                deschidereConexiune();
                OracleCommand cmd = new OracleCommand("proc_sterge_img", conexiune);
                try
                {
                    conexiune.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("v_denumire", OracleDbType.Varchar2).Value = imgSelectata;
                    cmd.Parameters[0].Direction = ParameterDirection.Input;

                    cmd.ExecuteNonQuery();

                    initializareListView();
                    
                }
                catch(OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                    
                }
            }
        }

        private void exportImagineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deschidereConexiune();
            try
            {
                conexiune.Open();

                OracleCommand cmd = new OracleCommand("proc_export_img", conexiune);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("v_denumire", OracleDbType.Varchar2).Value = imgSelectata;
                cmd.Parameters[0].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Imagine exportata cu succes!");
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void btnRegasireSemantica_Click(object sender, EventArgs e)
        {
            FormReagasireSemantica frm = new FormReagasireSemantica();
            frm.Show();
        }
    }
}
