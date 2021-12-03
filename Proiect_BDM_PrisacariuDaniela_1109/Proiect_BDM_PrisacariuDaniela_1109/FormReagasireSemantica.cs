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
    public partial class FormReagasireSemantica : Form
    {
        OracleConnection conexiune;
        public FormReagasireSemantica()
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

        private void generareSemnaturiImg()
        {
            deschidereConexiune();
            try
            {
                conexiune.Open();

                OracleCommand cmd = new OracleCommand("proc_gen_semn", conexiune);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Semnaturi generate!");
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
        private void btnRegasire_Click(object sender, EventArgs e)
        {
            generareSemnaturiImg();
            deschidereConexiune();           

            string numeFis = tbNumeImagine.Text;
            decimal cculoare = Convert.ToDecimal(tbCoefCuloare.Text);
            decimal ctextura = Convert.ToDecimal(tbCoefTextura.Text);
            decimal cforma = Convert.ToDecimal(tbCoefForma.Text);
            decimal clocatie = Convert.ToDecimal(tbCoefLocatie.Text);

            try
            {
                conexiune.Open();

                OracleCommand cmd = new OracleCommand("proc_regasire", conexiune);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("nfis", OracleDbType.Varchar2).Value = numeFis;
                cmd.Parameters.Add("cculoare", OracleDbType.Decimal).Value = cculoare;
                cmd.Parameters.Add("ctextura", OracleDbType.Decimal).Value = ctextura;
                cmd.Parameters.Add("cforma", OracleDbType.Decimal).Value = cforma;
                cmd.Parameters.Add("clocatie", OracleDbType.Decimal).Value = clocatie;
                cmd.Parameters.Add("idrez", OracleDbType.Int32);

                for(int i = 0; i < 5; i++)
                {
                    cmd.Parameters[i].Direction = ParameterDirection.Input;
                }
                cmd.Parameters[5].Direction = ParameterDirection.Output;

                cmd.ExecuteScalar();

                int id = Convert.ToInt32(cmd.Parameters[5].Value.ToString());

                string sqlSelect = "Select id, denumire from picturi";
                cmd.CommandText = sqlSelect;
                cmd.CommandType = CommandType.Text;

                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["id"].ToString()) == id)
                    {
                       
                        cmd = new OracleCommand("proc_citire_img", conexiune);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_denumire", OracleDbType.Varchar2).Value = reader["denumire"].ToString();
                        cmd.Parameters.Add("flux", OracleDbType.Blob);
                        cmd.Parameters[0].Direction = ParameterDirection.Input;
                        cmd.Parameters[1].Direction = ParameterDirection.Output;

                        cmd.ExecuteScalar();

                        OracleBlob temp = (OracleBlob)cmd.Parameters[1].Value;
                        pictureBox1.Image = Image.FromStream(temp);
                    }
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
    }
}
