using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;

namespace UI
{
    public partial class Drug_Delete_UI : Form
    {
        public Drug_Delete_UI()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDname.Text == ""&& lvwShow .SelectedItems .Count == 0 )
            {
                PromptingForm p = new PromptingForm("请选择需要删除的数据 !");
                p.ShowDialog();
                return;
            }

            Drug_insert Ddelete = new Drug_insert();
            Ddelete.Dname = txtDname.Text;
            DialogResult dr = MessageBox.Show("确定要删除吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string mes = new Drug_insert_BLL().Delete(Ddelete);
                txtDname.Text = "";
                comboBox1_SelectedIndexChanged(null, null);
                PromptingForm p = new PromptingForm(mes);
                p.ShowDialog();
            }
        }
      

        private void lvwShow_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvwShow.SelectedItems[0];
            txtDname.Text = item.SubItems[0].Text;
        }

        private void Drug_Delete_UI_Load(object sender, EventArgs e)
        {
            try
            {
                lvwShow.Items.Clear();
                List<Drug_insert> di = new Drug_insert_BLL().SelectAll(txtDname.Text);
                int m = (int)Math.Ceiling(di.Count / 20.0);
                for (int i = 1; i <= m; i++)
                {
                    comboBox1.Items.Add(i + "");
                }
                if (comboBox1.Text == "")
                {
                    comboBox1.Text = "1";
                    return;
                }
            }
            catch { }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDname.Text == "")
            {
                PromptingForm p = new PromptingForm("请输入药品名字！");
                p.ShowDialog();
                return;
            }
            lvwShow.Items.Clear();
            List<Drug_insert> di = new Drug_insert_BLL().SelectAll(txtDname.Text);
            if (di.Count == 0)
            {

                PromptingForm p = new PromptingForm("没有你要查找的数据！");
                p.ShowDialog();
                return;
            }
            comboBox1.Text = 1+"";
            lvwShow.Items.Clear();
            for (int i = 0; i < di.Count; i++)
            {
                ListViewItem item = new ListViewItem(di[i].Dname + "");
                item.SubItems.Add(di[i].Dtype + "");
                item.SubItems.Add(di[i].DcostName + "");
                item.SubItems.Add(di[i].Dspec + "");
                item.SubItems.Add(di[i].DjiXing + "");
                item.SubItems.Add(di[i].DinsertPrice + "");
                item.SubItems.Add(di[i].DsellPrice + "");
                item.SubItems.Add(di[i].Dstock + "");
                item.SubItems.Add(di[i].DstockMax + "");
                item.SubItems.Add(di[i].DstockMin + "");
                item.SubItems.Add(di[i].DeffectTime + "");
                item.SubItems.Add(di[i].DproductTime + "");
                item.SubItems.Add(di[i].Efficay + "");
                lvwShow.Items.Add(item);
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDname.Text = "";
            comboBox1_SelectedIndexChanged(null,null);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwShow.Items.Clear();
            List<Drug_insert> di = new Drug_insert_BLL().SelectAll(txtDname.Text);
            for (int i = (int.Parse(comboBox1.Text)-1)*20; i < 20 * int.Parse(comboBox1.Text); i++)
            {
                if (i < di.Count)
                {
                    ListViewItem item = new ListViewItem(di[i].Dname + "");
                    item.SubItems.Add(di[i].Dtype + "");
                    item.SubItems.Add(di[i].DcostName + "");
                    item.SubItems.Add(di[i].Dspec + "");
                    item.SubItems.Add(di[i].DjiXing + "");
                    item.SubItems.Add(di[i].DinsertPrice + "");
                    item.SubItems.Add(di[i].DsellPrice + "");
                    item.SubItems.Add(di[i].Dstock + "");
                    item.SubItems.Add(di[i].DstockMax + "");
                    item.SubItems.Add(di[i].DstockMin + "");
                    item.SubItems.Add(di[i].DeffectTime + "");
                    item.SubItems.Add(di[i].DproductTime + "");
                    item.SubItems.Add(di[i].Efficay + "");
                    lvwShow.Items.Add(item);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Text = 1 + "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1 .Items.Count + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "1")
            {
                comboBox1.Text = int.Parse(comboBox1.Text) - 1 + "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != comboBox1 .Items .Count +"")
            {
                comboBox1.Text = int.Parse(comboBox1.Text) + 1 + "";
            }
        }
    }
}
