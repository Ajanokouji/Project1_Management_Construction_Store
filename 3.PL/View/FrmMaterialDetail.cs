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
    public partial class FrmMaterialDetail : Form
    {
        IMaterialDetailsService _MDetailsService;
        IMaterialService _MaterialService;
        IProducerService _ProducerService;
        Guid _Id;
        public FrmMaterialDetail()
        {
            InitializeComponent();
            _MDetailsService = new MDetailsService();
            this.CenterToScreen();
            LoadData();
            LoadProducer();
            LoadSP();
        }
        void LoadData()
        {
            int stt = 1;
            dgrid_Material.ColumnCount = 8;
            dgrid_Material.Columns[0].Name = "STT";
            dgrid_Material.Columns[1].Name = "Name";
            dgrid_Material.Columns[2].Name = "Price";
            dgrid_Material.Columns[3].Name = "ImportPrice";
            dgrid_Material.Columns[4].Name = "Amount";
            dgrid_Material.Columns[5].Name = "Unit";
            dgrid_Material.Columns[6].Name = "Producer";
            dgrid_Material.Columns[7].Name = "Status";
            dgrid_Material.Rows.Clear();
            foreach (var x in _MDetailsService.GetMaterialDetails())
            {
                dgrid_Material.Rows.Add(stt++, x.Name, x.Price, x.ImportPrice, x.Amount, x.Unit, x.NameProducer, x.Status == 1 ? "Active" : "Inactice");
            }
        }
        void LoadSearch(List<MaterialDetailsView> lst)
        {
            int stt = 1;
            dgrid_Material.ColumnCount = 8;
            dgrid_Material.Columns[0].Name = "STT";
            dgrid_Material.Columns[1].Name = "Name";
            dgrid_Material.Columns[2].Name = "Price";
            dgrid_Material.Columns[3].Name = "ImportPrice";
            dgrid_Material.Columns[4].Name = "Amount";
            dgrid_Material.Columns[5].Name = "Unit";
            dgrid_Material.Columns[6].Name = "Producer";
            dgrid_Material.Columns[7].Name = "Status";
            dgrid_Material.Rows.Clear();
            foreach (var x in lst)
            {
                dgrid_Material.Rows.Add(stt++, x.Name, x.Price, x.ImportPrice, x.Amount, x.Unit, x.NameProducer, x.Status == 1 ? "Active" : "Inactice");
            }
        }
        void LoadProducer()
        {
            foreach (var x in _MDetailsService.GetProducers())
            {
                cmb_Producer.Items.Add(x.Name);
            }
            //cmb_Producer.SelectedIndex = 0;
        }
        void LoadSP()
        {
            foreach (var x in _MDetailsService.GetMaterials())
            {
                cmb_NameSP.Items.Add(x.Name);
            }
            //cmb_NameSP.SelectedIndex = 0;
        }
        bool CheckInput()
        {
            if (txt_Unit.Text.Length == 0)
            {
                MessageBox.Show("Please complete all information");
                return false;
            }
            else if (!txt_Price.Text.All(char.IsNumber))
            {
                MessageBox.Show("Price must be alphanumeric character");
                return false;
            }
            else if (!txt_ImportPrice.Text.All(char.IsNumber))
            {
                MessageBox.Show("ImportPrice must be alphanumeric character");
                return false;
            }
            else if (!txt_Amount.Text.All(char.IsNumber))
            {
                MessageBox.Show("Amount must be alphanumeric character");
                return false;
            }
            else if (Convert.ToDecimal(txt_Price.Text) <= 0)
            {
                MessageBox.Show("Price must be alphanumeric character");
                return false;
            }
            else if (Convert.ToDecimal(txt_ImportPrice.Text) <= 0)
            {
                MessageBox.Show("ImportPrice must be alphanumeric character");
                return false;
            }
            else if (Convert.ToInt32(txt_Amount.Text) <= 0)
            {
                MessageBox.Show("Amount must be alphanumeric character");
                return false;
            }
            else if (Convert.ToInt32(txt_Price.Text) <= Convert.ToDecimal(txt_ImportPrice.Text))
            {
                MessageBox.Show("Price must be alphanumeric character");
                return false;
            }
            //else if (linkavatar == "")
            //{
            //    MessageBox.Show("Price must be alphanumeric character");
            //    return false;
            //}

            return true;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {

            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                //string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                //File.Copy(linkavatar, Path.Combine(projectDirectory, "Image", Path.GetFileName(linkavatar)), true);
                //linkavatar = Path.Combine(projectDirectory, "Image", Path.GetFileName(linkavatar));
                MaterialDetailsView m = new MaterialDetailsView()
                {
                    Amount = Convert.ToInt32(txt_Amount.Text),
                    //Code = _MDetailsService.GetMaterials()[cmb_NameSP.SelectedIndex].Code,
                    //Name = txt_Name.Text,
                    //Status = rbtn_HD.Checked ? 1 : 0,
                    IdMaterial = _MDetailsService.GetMaterials()[cmb_NameSP.SelectedIndex].IdMaterial,
                    IdMDetail = Guid.NewGuid(),
                    IdProducer = _MDetailsService.GetProducers()[cmb_Producer.SelectedIndex].IdProducer,
                    ImportPrice = Convert.ToDecimal(txt_ImportPrice.Text),
                    //NameProducer = cmb_Producer.Text,
                    Price = Convert.ToDecimal(txt_Price.Text),
                    Unit = txt_Unit.Text,
                    //LinkImage = linkavatar,
                };
                DialogResult dialogResult = MessageBox.Show("Do you want more material?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_MDetailsService.AddMaterialDetails(m));
                    LoadData();
                    cmb_NameSP.SelectedIndex = 0;
                    txt_Amount.Text = null;
                    txt_ImportPrice.Text = null;
                    txt_Price.Text = null;
                    txt_Unit.Text = null;
                    //linkavatar = null;
                    cmb_Producer.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Unsuccesfully");
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {

            }
            else
            {
                MaterialDetailsView m = new MaterialDetailsView()
                {
                    Amount = Convert.ToInt32(txt_Amount.Text),
                    //Code = "SP" + mats,
                    //Name = cmb_NameSP.Text,
                    //Status = rbtn_HD.Checked ? 1 : 0,
                    IdMaterial = _MDetailsService.GetMaterials()[cmb_NameSP.SelectedIndex].IdMaterial,
                    IdMDetail = _Id,
                    IdProducer = _MDetailsService.GetProducers()[cmb_Producer.SelectedIndex].IdProducer,
                    ImportPrice = Convert.ToDecimal(txt_ImportPrice.Text),
                    //NameProducer = cmb_Producer.Text,
                    Price = Convert.ToDecimal(txt_Price.Text),
                    Unit = txt_Unit.Text,
                    //LinkImage = linkavatar,
                };
                DialogResult dialogResult = MessageBox.Show("Do you want more material?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_MDetailsService.UpdateMaterialDetails(m));
                    LoadData();
                    cmb_NameSP.SelectedIndex = 0;
                    txt_Amount.Text = null;
                    txt_ImportPrice.Text = null;
                    txt_Price.Text = null;
                    txt_Unit.Text = null;
                    cmb_Producer.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Unsuccesfully");
                }
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want more material?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_MDetailsService.RemoveMaterialDetails(_Id));
                LoadData();
                cmb_NameSP.SelectedIndex = 0;
                txt_Amount.Text = null;
                txt_ImportPrice.Text = null;
                txt_Price.Text = null;
                txt_Unit.Text = null;
                cmb_Producer.SelectedIndex = 0;
            }
        }

        private void dgrid_Material_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _MDetailsService.GetMaterialDetails().Count) return;
            _Id = _MDetailsService.GetMaterialDetails().FirstOrDefault(c => c.Name == dgrid_Material.Rows[rowindex].Cells[1].Value.ToString()).IdMDetail;
            var temp = _MDetailsService.GetMaterialDetails().FirstOrDefault(c => c.IdMDetail == _Id);
            cmb_NameSP.Text = temp.Name;
            txt_Amount.Text = temp.Amount.ToString();
            txt_ImportPrice.Text = temp.ImportPrice.ToString();
            txt_Price.Text = temp.Price.ToString();
            txt_Unit.Text = temp.Unit;
            cmb_Producer.Text = temp.NameProducer;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(_MDetailsService.GetMaterialDetailsByName(txt_Search.Text));
        }
    }
}
