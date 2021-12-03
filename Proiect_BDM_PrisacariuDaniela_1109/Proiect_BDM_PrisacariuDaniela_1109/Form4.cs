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
    public partial class Form4 : Form
    {
        OracleConnection conexiune;
        public Form4()
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

        private void btnAdaugaVideo_Click(object sender, EventArgs e)
        {
            deschidereConexiune();
            string denumire = tbDenumire.Text;
            string urlVideo = tbURLVideo.Text;
            string video = tbVideo.Text;

            string sqlSelectMax = "select max(id) from videoclipuri";
            OracleCommand cmd = new OracleCommand(sqlSelectMax, conexiune);
            try
            {
                conexiune.Open();

                int id = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                cmd.CommandText = "declare " +
                    "obj ORDVideo; " +
                    "ctx raw(64) := null; " +
                    "begin " +
                    "insert into videoclipuri values(" + id + ", '" + denumire + "', ORDVideo.init()); " +
                    "select videoclip into obj from videoclipuri where id = " + id + " for update; " +
                    "obj.importFrom(ctx, 'http', '" + urlVideo + "', '" + video + "'); " +
                    "update videoclipuri set videoclip = obj where id = " + id + "; " +
                    "end;";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "proc_salvare_video";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = Convert.ToInt32(id);
                cmd.Parameters.Add("flux", OracleDbType.Blob);
                cmd.Parameters[0].Direction = ParameterDirection.Input;
                cmd.Parameters[1].Direction = ParameterDirection.Output;
               

                cmd.ExecuteScalar();

                Byte[] blob = new Byte[((OracleBlob)cmd.Parameters[1].Value).Length];
                FileStream fs = null;
                ((OracleBlob)cmd.Parameters[1].Value).Read(blob, 0, blob.Length);
                fs = new FileStream(@"D:\csie\Master BDSA\An 1\BDM - Baze de Date Multimedia\Proiect\videos\" + denumire + ".mp4", FileMode.CreateNew, FileAccess.ReadWrite);
                fs.Write(blob, 0, blob.Length);
                fs.Close();

                MessageBox.Show("Videoclip inserat cu succes!");
                

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

       
    }
}
