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
    public partial class FrmStaff : Form
    {
        IStaffService _staffService;
        IPositionService _positionService;
        Guid _id;
        public FrmStaff()
        {
            InitializeComponent();
            _staffService = new StaffService();
            _positionService = new PositionService();
            LoadData();
            txt_Code.Enabled = false;
            LoadPosition();
            LoadStore();
            LoadGender();
        }
        void LoadData()
        {
            int stt = 1;
            dgrid_Staff.ColumnCount = 11;
            dgrid_Staff.Columns[0].Name = "STT";
            dgrid_Staff.Columns[1].Name = "Code";
            dgrid_Staff.Columns[2].Name = "Name";
            dgrid_Staff.Columns[3].Name = "PhoneNumber";
            dgrid_Staff.Columns[4].Name = "Address";
            dgrid_Staff.Columns[5].Name = "BirthOfdate";
            dgrid_Staff.Columns[6].Name = "Wage";
            dgrid_Staff.Columns[7].Name = "Gender";
            dgrid_Staff.Columns[8].Name = "Status";
            dgrid_Staff.Columns[9].Name = "Position";
            dgrid_Staff.Columns[10].Name = "Store";
            dgrid_Staff.Rows.Clear();
            foreach (var x in _staffService.GetStaffs())
            {
                dgrid_Staff.Rows.Add(stt++, x.Code, x.Name, x.PhoneNumber, x.Address, x.BirthOfDate, x.Wage, x.Gender, x.Status == 1 ? "Active" : "Inactive", x.NamePosition, x.NameStore);
            }
        }
        void LoadSearch(List<StaffView> lst)
        {
            int stt = 1;
            dgrid_Staff.ColumnCount = 11;
            dgrid_Staff.Columns[0].Name = "STT";
            dgrid_Staff.Columns[1].Name = "Code";
            dgrid_Staff.Columns[2].Name = "Name";
            dgrid_Staff.Columns[3].Name = "PhoneNumber";
            dgrid_Staff.Columns[4].Name = "Address";
            dgrid_Staff.Columns[5].Name = "BirthOfdate";
            dgrid_Staff.Columns[6].Name = "Wage";
            dgrid_Staff.Columns[7].Name = "Gender";
            dgrid_Staff.Columns[8].Name = "Status";
            dgrid_Staff.Columns[9].Name = "Position";
            dgrid_Staff.Columns[10].Name = "Store";
            dgrid_Staff.Rows.Clear();
            foreach (var x in lst)
            {
                dgrid_Staff.Rows.Add(stt++, x.Code, x.Name, x.PhoneNumber, x.Address, x.BirthOfDate, x.Wage, x.Gender, x.Status == 1 ? "Active" : "Inactive", x.NamePosition, x.NameStore);
            }
        }
        bool CheckInput()
        {
            if (txt_Name.Text.Length == 0)
            {
                MessageBox.Show("Please complete all information");
                return false;
            }
            if (txt_Address.Text.Length == 0)
            {
                MessageBox.Show("Please complete all information");
                return false;
            }
            if (txt_Wage.Text.Length == 0)
            {
                MessageBox.Show("Please complete all information");
                return false;
            }
            if (!txt_Wage.Text.All(char.IsNumber))
            {
                MessageBox.Show("Phone number must be alphanumeric character");
                return false;
            }
            if (txt_SDT.Text.Length < 10)
            {
                MessageBox.Show("Please complete all information");
                return false;
            }
            if (!txt_SDT.Text.All(char.IsNumber))
            {
                MessageBox.Show("Phone number must be alphanumeric character");
                return false;
            }
            return true;
        }
        void LoadPosition()
        {
            foreach (var x in _positionService.GetPositions())
            {
                cmb_Position.Items.Add(x.Name);
            }
            cmb_Position.SelectedIndex = 0;
        }
        void LoadGender()
        {
            foreach (var x in _staffService.Gender())
            {
                cmb_Gender.Items.Add(x);
            }
            cmb_Gender.SelectedIndex = 0;
        }
        void LoadStore()
        {
            foreach (var x in _staffService.GetStores())
            {
                cmb_Store.Items.Add(x.Name);
            }
            cmb_Store.SelectedIndex = 0;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {

            }
            else
            {
                int mats = _staffService.GetStaffs().Count + 1;
                StaffView staff = new StaffView()
                {
                    IdStaff = Guid.NewGuid(),
                    Code = "NV" + mats,
                    Name = txt_Name.Text,
                    PhoneNumber = txt_SDT.Text,
                    Address = txt_Address.Text,
                    BirthOfDate = dt_BOD.Value,
                    Wage = Convert.ToDecimal(txt_Wage.Text),
                    Gender = cmb_Gender.Text,
                    Status = rbtn_HD.Checked ? 1 : 0,
                    IdPosition = _positionService.GetPositions()[cmb_Position.SelectedIndex].IdPosition,
                    IdStore = _staffService.GetStores()[cmb_Store.SelectedIndex].IdStore,
                };
                DialogResult dialog = MessageBox.Show("Do you want more staff?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    _staffService.AddStaffs(staff);
                    MessageBox.Show("Successfully");
                    LoadData();
                    txt_Address.Text = null;
                    txt_Code.Text = null;
                    txt_Name.Text = null;
                    txt_SDT.Text = null;
                    txt_Wage.Text = null;
                    dt_BOD.Value = DateTime.Now;
                    cmb_Gender.SelectedIndex = 0;
                    cmb_Position.SelectedIndex = 0;
                    cmb_Store.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Unsuccessfully");
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
                int mats = _staffService.GetStaffs().Count + 1;
                StaffView staff = new StaffView()
                {
                    IdStaff = _id,
                    Code = "NV" + mats,
                    Name = txt_Name.Text,
                    PhoneNumber = txt_SDT.Text,
                    Address = txt_Address.Text,
                    BirthOfDate = dt_BOD.Value,
                    Wage = Convert.ToDecimal(txt_Wage.Text),
                    Gender = cmb_Gender.Text,
                    Status = rbtn_HD.Checked ? 1 : 0,
                    IdPosition = _positionService.GetPositions()[cmb_Position.SelectedIndex].IdPosition,
                    IdStore = _staffService.GetStores()[cmb_Store.SelectedIndex].IdStore,
                };
                DialogResult dialog = MessageBox.Show("Do you want more staff?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    _staffService.UpdateStaffs(staff);
                    MessageBox.Show("Successfully");
                    LoadData();
                    txt_Address.Text = null;
                    txt_Code.Text = null;
                    txt_Name.Text = null;
                    txt_SDT.Text = null;
                    txt_Wage.Text = null;
                    dt_BOD.Value = DateTime.Now;
                    cmb_Gender.SelectedIndex = 0;
                    cmb_Position.SelectedIndex = 0;
                    cmb_Store.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Unsuccessfully");
                }

            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Do you want remove?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(_staffService.RemoveStaffs(_id));
                LoadData();
            }
            return;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(_staffService.GetStaffsByName(txt_Search.Text));
        }

        private void dgrid_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _staffService.GetStaffs().Count) return;
            _id = _staffService.GetStaffs().FirstOrDefault(c => c.Name == dgrid_Staff.Rows[rowindex].Cells[2].Value.ToString()).IdStaff;
            var temp = _staffService.GetStaffs().FirstOrDefault(c => c.IdStaff == _id);
            txt_Code.Text = temp.Code;
            txt_Address.Text = temp.Address;
            txt_SDT.Text = temp.PhoneNumber;
            txt_Wage.Text = temp.Wage.ToString();
            txt_Name.Text = temp.Name;
            cmb_Position.Text = temp.NamePosition;
            cmb_Store.Text = temp.NameStore;
            cmb_Gender.Text = temp.Gender;
            if (temp.Status == 1)
            {
                rbtn_HD.Checked = true;
            }
            else
            {
                rbtn_KHD.Checked = true;
            }
        }
    }
}
