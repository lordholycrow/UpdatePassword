using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.IO;

namespace okuyaz
{
    public partial class Form1 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.; Initial Catalog=.; User Id=.; password=.");
        SqlConnection baglan2 = new SqlConnection("Data Source=.; Initial Catalog=.; User Id=.; password=.");
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = EASEncrypt("123456");

        }
        ///////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {


            //da.Fill(ds, "Mellivo_PrimPuan");
            //dataGridView1.DataSource = ds.Tables["Mellivo_PrimPuan"];
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Top 10000 * From table_name", baglan);
            DataSet ds = new DataSet();
            baglan.Close();
            da.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                baglan2.Open();

                string ekle = "insert into PrimPuan(DbRow1,DbRow2,DbRow3,DbRow4,DbRow5,DbRow6) values (@DbRow1,@DbRow2,@DbRow3,@DbRow4,@DbRow5,@DbRow6)";

                SqlCommand komut = new SqlCommand(ekle, baglan2);

                komut.Parameters.AddWithValue("@DbRow1", dt.Rows[i][0]);
                komut.Parameters.AddWithValue("@DbRow2", dt.Rows[i][1]);
                komut.Parameters.AddWithValue("@DbRow3", dt.Rows[i][2]);
                komut.Parameters.AddWithValue("@DbRow4", dt.Rows[i][3]);
                komut.Parameters.AddWithValue("@DbRow5", dt.Rows[i][4]);
                komut.Parameters.AddWithValue("@DbRow6", dt.Rows[i][5]);
                komut.ExecuteNonQuery();

                baglan2.Close();
            }

            MessageBox.Show("Aktarma işlemi başarıyla tamamlandı.");
        }
        ///////////////////////////////////////////////////////////
        private void button2_Click(object sender, EventArgs e)
        {
            baglan2.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("Select Top 10 DbRow2,DbRow1 From table_name", baglan2);
            DataSet ds2 = new DataSet();
            baglan2.Close();
            da2.Fill(dt2);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                baglan2.Open();
                string güncelle = "UPDATE table_name set DbRow2=@DbRow2 where DbRow1 = " + dt2.Rows[i][1].ToString();
                SqlCommand komut = new SqlCommand(güncelle, baglan2);
                komut.Parameters.AddWithValue("@DbRow2", EASEncrypt(dt2.Rows[i][0].ToString()));

                komut.ExecuteNonQuery();
                baglan2.Close();
            }
            MessageBox.Show("Şifre güncelleme işlemi başarıyla tamamlandı.");
        }

        public string EASEncrypt(string clearText)
        {
            string EncryptionKey = "FRMTDS2016IASDASDS99";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x76, 0x49, 0x65, 0x64, 0x20, 0x61, 0x76, 0x64, 0x76, 0x65, 0x6e, 0x65, 0x4d });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
    }
}

