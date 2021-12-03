using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_BDM_PrisacariuDaniela_1109
{
    public partial class Form3 : Form
    {
        OracleConnection conexiune;
        string videoSelectat = null;
        public Form3()
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

        private void initializareListView()
        {
            listView1.Items.Clear();
            deschidereConexiune();
            string sqlSelect = "select id, denumire_video from videoclipuri";

            OracleCommand cmd = new OracleCommand(sqlSelect, conexiune);

            try
            {
                conexiune.Open();

                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = reader["id"].ToString();
                    item.SubItems.Add(reader["denumire_video"].ToString());
                    item.Tag = reader["denumire_video"].ToString();

                    listView1.Items.Add(item);
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

            deschidereConexiune();
            try
            {
                conexiune.Open();

                
               
                foreach (ListViewItem itm in listView1.SelectedItems)
                {                
                    videoSelectat = itm.Tag.ToString();

                    wmp.URL = @"D:\csie\Master BDSA\An 1\BDM - Baze de Date Multimedia\Proiect\videos\" + videoSelectat + ".mp4";
                    wmp.Ctlcontrols.play();
                    
                }
               
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


        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
            initializareListView();
        }

        private void stergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string mesaj = "Doriti sa stergeti videoclipul " + videoSelectat + "?";
            const string nume = "Stergere";
            var result = MessageBox.Show(mesaj, nume, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                deschidereConexiune();
                OracleCommand cmd = new OracleCommand("proc_sterge_video", conexiune);
                try
                {
                    conexiune.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("v_denumire", OracleDbType.Varchar2).Value = videoSelectat;
                    cmd.Parameters[0].Direction = ParameterDirection.Input;

                    cmd.ExecuteNonQuery();

                    File.Delete(@"D:\csie\Master BDSA\An 1\BDM - Baze de Date Multimedia\Proiect\videos\" + videoSelectat + ".mp4");
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
    }
}
