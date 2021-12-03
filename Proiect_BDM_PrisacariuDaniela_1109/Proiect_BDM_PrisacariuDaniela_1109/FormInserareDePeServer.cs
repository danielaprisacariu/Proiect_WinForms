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
    public partial class FormInserareDePeServer : Form
    {
        OracleConnection conexiune;
        public FormInserareDePeServer()
        {
            InitializeComponent();
        }

        public void deschidereConexiune()
        {
            string cons = "User ID=STUD_PRISACARIUD; Password=stud; Data Source=(DESCRIPTION=" +
           "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=37.120.249.41)(PORT=1521)))" +
           "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcls)));";
            conexiune = new OracleConnection(cons);
            
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            deschidereConexiune();

            string nfis = tbNumeFisServer.Text;
            string denumire = tbDenumire.Text;
            string artist = tbArtist.Text;
            int an_aparitie = Convert.ToInt32(tbAnAparitie.Text);

            string sqlSelectMax = "select count(id) from picturi";
            OracleCommand cmd = new OracleCommand(sqlSelectMax, conexiune); 
            try
            {
                conexiune.Open();

                int id = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                

                cmd = new OracleCommand("proc_inserare_server", conexiune);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("v_denumire", OracleDbType.Varchar2).Value = denumire;
                cmd.Parameters.Add("v_nfis", OracleDbType.Varchar2).Value = nfis;
                cmd.Parameters.Add("v_artist", OracleDbType.Varchar2).Value = artist;
                cmd.Parameters.Add("v_anaparitie", OracleDbType.Varchar2).Value = an_aparitie;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Imagine inserata in bd!");
 
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                Close();
            }
        }
    }
}
