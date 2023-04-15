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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _3.PL.Views
{
    public partial class FrmCustomer : Form
    {
        private ICustomerService _iCustomerService;
        Guid _id;
        public FrmCustomer()
        {
            InitializeComponent();
            _iCustomerService = new CustomerServices();
            txt_code.Enabled = false;
            LoadData();
        }

        void LoadData()
        {
            int stt = 1;
            dgrid_customer.ColumnCount = 4;
            dgrid_customer.Columns[0].Name = "STT";
            dgrid_customer.Columns[1].Name = "Code";
            dgrid_customer.Columns[2].Name = "Name";
            dgrid_customer.Columns[3].Name = "Status";
            dgrid_customer.Rows.Clear();
            var lstcustomer = _iCustomerService.GetCustomerViews();
            lstcustomer = lstcustomer.Where(x => x.Code.ToLower().Contains(txt_search.Text.ToLower()) || x.Name.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            foreach (var x in lstcustomer)
            {
                dgrid_customer.Rows.Add(stt++, x.Code, x.Name, x.Status == 1 ? "Activate" : "Inactive");
            }
        }
        //public CustomerView GetDataFromGui()
        //{
        //    int codets = _iCustomerService.GetCustomerViews().Count() + 1;
        //    CustomerView vctm = new CustomerView()
        //    {
        //        IdCustomer = Guid.NewGuid(),
        //        Code = "KH" + codets.ToString(),
        //        Name = txt_name.Text,
        //        PhoneNumber = txt_sdt.Text,
        //        Address = txt_address.Text,
        //        Gender = cmb_gender.Text,
        //        BirthOfDate = dateTimePicker1.Value,
        //        Status = rbtn_activate.Checked ? 1 : 0,
        //    };
        //    return vctm;
        //}

        bool CheckInput()
        {
            if (txt_name.Text.Length == 0)
            {
                MessageBox.Show("Please complete all information");
                return false;
            }
            return true;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {

            }
            else
            {
                int kh = _iCustomerService.GetCustomerViews().Count + 1;
                CustomerView ctmv = new CustomerView()
                {
                    IdCustomer = Guid.NewGuid(),
                    Code = "KH" + kh,
                    Name = txt_name.Text,
                };
                DialogResult dialog = MessageBox.Show("Do you want more customer?", "Message!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    _iCustomerService.AddCustomer(ctmv);
                    MessageBox.Show("Successfully");
                    LoadData();
                    txt_code.Text = null;
                    txt_name.Text = null;
                }
                else
                {
                    MessageBox.Show("Unsuccessfully");
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {

            }
            else
            {
                int kh = _iCustomerService.GetCustomerViews().Count;
                CustomerView ctmv = new CustomerView()
                {
                    IdCustomer = _id,
                    Code = "KH" + kh,
                    Name = txt_name.Text,
                };
                DialogResult dialog = MessageBox.Show("Do you want more customer?", "Message!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    _iCustomerService.UpdateCustomer(ctmv);
                    MessageBox.Show("Successfully");
                    LoadData();
                    txt_code.Text = null;
                    txt_name.Text = null;
                }
                else
                {
                    MessageBox.Show("Unsuccessfully");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_code.Text = null;
            txt_name.Text = null;
            rbtn_activate.Checked = true;
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            var hoi = MessageBox.Show("Do you want to remove to this board?", "Message!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (hoi == DialogResult.Yes)
            {
                MessageBox.Show(_iCustomerService.DeleteCustomer(_id));
                LoadData();
            }
            return;
        }

        private void dgrid_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _iCustomerService.GetCustomerViews().Count) return;
            _id = _iCustomerService.GetCustomerViews().FirstOrDefault(c => c.Name == dgrid_customer.Rows[rowindex].Cells[2].Value.ToString()).IdCustomer;
            var temp = _iCustomerService.GetCustomerViews().FirstOrDefault(c => c.IdCustomer == _id);
            txt_code.Text = temp.Code;
            txt_name.Text = temp.Name;
            if (temp.Status == 1)
            {
                rbtn_activate.Checked = true;
            }
            else
            {
                rbtn_inactive.Checked = true;
            }
        }
    }
}
