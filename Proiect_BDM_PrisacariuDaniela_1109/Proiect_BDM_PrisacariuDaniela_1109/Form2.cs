using Oracle.DataAccess.Client;
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
    public partial class Form2 : Form
    {
        OracleConnection conexiune;
        public Form2()
        {
            InitializeComponent();
        }

        public void deschidereConexiune()
        {
            string cons = "User ID=STUD_PRISACARIUD; Password=stud; Data Source=(DESCRIPTION=" +
           "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=37.120.249.41)(PORT=1521)))" +
           "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcls)));";
            conexiune = new OracleConnection(cons);
            //MessageBox.Show("Conexiune realizata cu succes!");
        }

        private void btnInserareImg_Click(object sender, EventArgs e)
        {
            deschidereConexiune();
            string denumire = tbDenumire.Text;
            string urlImg = tbURLImg.Text;
            string denImg = tbDenImagine.Text;
            string artist = tbArtist.Text;
            int an_aparitie = int.Parse(tbAnAparitie.Text);
            string sqlSelectMax = "select count(id) from picturi";
            OracleCommand cmd= new OracleCommand(sqlSelectMax, conexiune);

            try
            {
                conexiune.Open();
                int id = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                //MessageBox.Show(id.ToString());

                string sqlInsert = "declare obj ORDImage; ctx raw(64) := null; " +
                    "begin " +
                    "insert into picturi values(" + id + ", '" + denumire + "', ORDImage.init(), '" + artist + "', " + an_aparitie + ", ORDImageSignature.init()); " +
                    "select img into obj from picturi where id = " + id + " for update; " +
                    "obj.importFrom(ctx, 'http', '" + urlImg + "', '" + denImg + "');" +
                    "update picturi set img = obj where id = " + id + ";" +
                    "commit;" +
                    "end;";

                cmd = new OracleCommand(sqlInsert, conexiune);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Pictura adaugata cu succes!");
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                this.Close();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormInserareDePeServer frm = new FormInserareDePeServer();
            frm.ShowDialog();
        }
    }
}
