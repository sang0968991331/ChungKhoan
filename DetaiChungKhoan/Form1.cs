using CHUNGKHOAN;
using DetaiChungKhoan.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetaiChungKhoan
{
    public partial class btn_tapd : Form
    {
        Boolean checkmahoa = true;
        public btn_tapd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbMinSup.Text = trackBar1.Value + "";
        }
        private void LoadData(int minsup)
        {
            Program.KetNoi(); // kết nối tới DB
            SqlDataReader sqlDataReader;
            string strCommand = "DECLARE	@return_value int EXEC	@return_value = [dbo].[SP_GIAOTAC] @minsup = '"+ minsup +"', @isinc = 1 SELECT	'Return Value' = @return_value";
            sqlDataReader = Program.ExecSqlDataReader(strCommand);
            try
            {
                Program.listTapF.Clear();
                Program.listMahoa.Clear();
                TapF tapF = new TapF();
                tapF.Lable = "F1";
                
              //  if (sqlDataReader.HasRows) { return; }// het dong thi return
                while(sqlDataReader.Read()){

                    ListViewItem lv_Item = new ListViewItem();
                    lv_Item.Text = sqlDataReader.GetDateTime(0).ToString();
                    int colum = 1;
                    List<string> listtemp = new List<string>();
                    while(colum<sqlDataReader.FieldCount){
                        if (checkmahoa) { // chkec de ko lap lai 
                            Program.listMahoa.Add(new MaHoa(sqlDataReader.GetName(colum),colum));// add ma cp vs mahoa
                        }
                        if (sqlDataReader.GetInt32(colum) == 1)
                        {
                            listtemp.Add(colum.ToString()); // vi sao add colum ? vi colum tuong  voi ma ma hoa
                        }

                        
                        lv_Item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = sqlDataReader.GetInt32(colum).ToString() });
                        colum++;
                        
                    }
                    checkmahoa = false;
                    if(listtemp.Any()) { // kiem tra xem cai list co gia tri ko 
                        tapF.Add(sqlDataReader.GetDateTime(0).ToString(), listtemp);
                    }
                   // Console.WriteLine(sqlDataReader.GetDateTime(0)+"");
                    lv_tapD.Items.Add(lv_Item);   
                }
                foreach (var l in tapF)
                {
                    Console.WriteLine(l.Key + " " + l.Value.Count+" fdfdfd");
                }
                Program.listTapF.Add(tapF);
              
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    lv_tapD.Columns.Add(sqlDataReader.GetName(i));
                }
                lv_tapD.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lv_tapD.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
            }catch(Exception e){

            }

        }

        private void btntapd_Click(object sender, EventArgs e)
        {
            lv_tapD.Clear();
            lv_maHoa.Clear();
            lv_maHoa.Columns.Add("Ma co phieu");
            lv_maHoa.Columns.Add("Ma hoa");
            
            LoadData(trackBar1.Value);
            for (int i = 0; i < Program.listMahoa.Count; i++)
            {
                ListViewItem lv_Item = new ListViewItem();
                lv_Item.Text = Program.listMahoa[i].maCp.ToString();
                lv_Item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Program.listMahoa[i].maHoa.ToString() });
                lv_maHoa.Items.Add(lv_Item);

            }
            //lv_maHoa.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //lv_maHoa.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

    }
}
