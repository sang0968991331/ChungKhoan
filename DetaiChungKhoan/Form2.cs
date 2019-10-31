using CHUNGKHOAN;
using DetaiChungKhoan.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetaiChungKhoan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void LoadForm2()
        {
            TapF F = Program.listTapF[0];
            //TapL FA = new TapL();

            for (int i = 0; i < Program.listTapF.Count; i++)
            {
               // int count = 0;
                foreach (List<string> ls in F.Values)
                {

                    for (int j = 0; j < ls.Count; j++)
                    {
                        Console.WriteLine(ls[j]+"ss");
                    }

                }
                
            }
        }
        private void Load_F1(TapF tapF)
        {
            foreach (var l in tapF)
            {
                ListViewItem lv_Item = new ListViewItem();
                lv_Item.Text = l.Key.ToString();
                string temp = "";
                foreach (string s in l.Value)
                {
                    temp = temp + " " + s;
                }
                lv_Item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = temp });
                lv_tapF.Items.Add(lv_Item);
            }
        }
        private void Load_L1(TapF tapF, TapL tapL)
        {
            for (int i = 0; i < Program.listMahoa.Count; i++)
            {
                int count = 0;
                foreach (List<string> ls in tapF.Values)
                {

                    for (int j = 0; j < ls.Count; j++)
                    {
                        string t = Program.listMahoa[i].maHoa.ToString();
                        if (t.Equals(ls[j]))
                        {

                            count++;
                            // Console.WriteLine(count + "ca");
                        }
                    }

                }
                Console.WriteLine(Program.listMahoa[i].maHoa + " có : " + count);
                ListViewItem lv_Item = new ListViewItem();
                lv_Item.Text = Program.listMahoa[i].maHoa.ToString();
                lv_Item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = count.ToString() });
                lv_tapL.Items.Add(lv_Item);
                // Console.WriteLine(F.Keys.Count + "ssssw");
                List<string> lisTemp = new List<string>();
                lisTemp.Add(Program.listMahoa[i].maHoa.ToString());

                tapL.Add(lisTemp, count);

                Program.listTapL.Add(tapL);
            }
        }
        private List<string> Tim_Tap_C(List<string> listL, int k)
        {

            List<string> lTemp = new List<string>();
            if (k == 1)
            {
                for (int i = 0; i < listL.Count; i++)
                {
                    for (int j = i + 1; j < listL.Count; j++)
                    {
                        lTemp.Add(listL[i] + " " + listL[j]);
                    }
                }
            }
            else
            {

                for (int i = 0; i < listL.Count; i++)
                {
                    for (int j = i + 1; j < listL.Count; j++)
                    {
                        if (listL[i].Remove(listL[i].Length - 1).Trim().CompareTo(listL[j].Remove(listL[i].Length - 1).Trim()) == 0)
                        {
                            string kq = listL[i].Remove(listL[i].Length - 1).Trim() + " " + listL[i].Remove(0, listL[i].Length - 1).Trim() + " " + listL[j].Remove(0, listL[j].Length - 1).Trim();
                            lTemp.Add(kq);
                        }
                    }
                }

            }

            return lTemp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm2();
            lv_tapF.Columns.Add("Ngay");
            lv_tapF.Columns.Add("Ung vien");
            TapF tapF = Program.listTapF[0];
            Load_F1(tapF);

            
            TapL tapL = new TapL();
            lv_tapL.Columns.Add("Ung vien");
            lv_tapL.Columns.Add("Support");
            Load_L1(tapF, tapL);

            }

        private void btn_next_Click(object sender, EventArgs e)
        {
            List<string> ss = new List<string>();
            List<string> lsTapC = Tim_Tap_C(ss, 1);

            for (int i = 0; i < lsTapC.Count; i++)
            {
                Console.WriteLine(lsTapC[i] + " listt  ");
            }
        }
        }

    }

