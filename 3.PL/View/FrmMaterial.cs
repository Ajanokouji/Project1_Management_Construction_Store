using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmMaterial : Form
    {
        IMaterialService _material;
        Guid _id;
        public FrmMaterial()
        {
            InitializeComponent();
            _material = new MaterialsService();
            txt_Code.Enabled = false;
            LoadData();
        }
        void LoadData()
        {
            int stt = 1;
            dgrid_Material.ColumnCount = 4;
            dgrid_Material.Columns[0].Name = "STT";
            dgrid_Material.Columns[1].Name = "Code";
            dgrid_Material.Columns[2].Name = "Name";
            dgrid_Material.Columns[3].Name = "Status";
            dgrid_Material.Rows.Clear();
            foreach (var x in _material.GetMaterials())
            {
                dgrid_Material.Rows.Add(stt++, x.Code, x.Name, x.Status == 1 ? "Active" : "Inavtive");
            }
        }
        bool CheckInput()
        {
            //if (txt_Code.Text.Length == 0)
            //{
            //    MessageBox.Show("Please complete all information");
            //    return false;
            //}
            if (txt_Name.Text.Length == 0)
            {
                MessageBox.Show("Please complete all information");
                return false;
            }
            return true;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {

            }
            else
            {
                int mats = _material.GetMaterials().Count + 1;
                DialogResult dialogResult = MessageBox.Show("Do you want more material?", "Massage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MaterialView material = new MaterialView()
                    {
                        Name = txt_Name.Text,
                        Status = 1,
                        IdMaterial = Guid.NewGuid(),
                        Code = "SP" + mats,
                    };
                    MessageBox.Show(_material.AddMaterials(material));
                    LoadData();
                    txt_Code.Text = null;
                    txt_Name.Text = null;
                }
                else MessageBox.Show("Unsuccessfully");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to remove material?", "Massage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_material.RemoveMaterials(_id));
                LoadData();
                txt_Code.Text = null;
                txt_Name.Text = null;
            }
            else MessageBox.Show("Unsuccessfully");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {

            }
            else
            {
                int mats = _material.GetMaterials().Count + 1;
                DialogResult dialogResult = MessageBox.Show("Do you want more material?", "Massage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MaterialView material = new MaterialView()
                    {
                        Name = txt_Name.Text,
                        Status = rbtn_HD.Checked == true ? 1 : 0,
                        IdMaterial = _id,
                        //Code = txt_Code.Text ,
                    };
                    MessageBox.Show(_material.UpdateMaterials(material));
                    LoadData();
                    txt_Code.Text = null;
                    txt_Name.Text = null;
                }
                else MessageBox.Show("Unsuccessfully");
            }
        }

        private void btn_GoPage_Click(object sender, EventArgs e)
        {
            FrmMaterialDetail frmMaterialDetails = new FrmMaterialDetail();
            this.Hide();
            frmMaterialDetails.ShowDialog();
        }

        private void dgrid_Material_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _material.GetMaterials().Count) return;
            _id = _material.GetMaterials().FirstOrDefault(c => c.Code == dgrid_Material.Rows[rowindex].Cells[1].Value.ToString()).IdMaterial;
            var temp = _material.GetMaterials().FirstOrDefault(c => c.IdMaterial == _id);
            txt_Code.Text = temp.Code;
            txt_Name.Text = temp.Name;
            if (temp.Status == 1)
            {
                rbtn_HD.Checked = true;
            }
            if (temp.Status == 0)
            {
                rbtn_KHD.Checked = true;
            }
        }
    }
}
