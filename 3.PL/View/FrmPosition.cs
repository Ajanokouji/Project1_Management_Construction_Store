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
    public partial class FrmPosition : Form
    {
        IPositionService _position;
        Guid _id;
        public FrmPosition()
        {
            InitializeComponent();
            _position = new PositionService();
            txt_Code.Enabled = false;
            LoadData();
        }
        void LoadData()
        {
            int stt = 1;
            dgrid_Position.ColumnCount = 4;
            dgrid_Position.Columns[0].Name = "STT";
            dgrid_Position.Columns[1].Name = "Mã chức vụ";
            dgrid_Position.Columns[2].Name = "Tên chức vụ";
            dgrid_Position.Columns[3].Name = "Trạng thái";
            dgrid_Position.Rows.Clear();
            foreach (var x in _position.GetPositions())
            {
                dgrid_Position.Rows.Add(stt++, x.Code, x.Name, x.Status);
            }
        }
        PositionView GetDataFromGui()
        {
            int codets = _position.GetPositions().Count() + 1;
            PositionView po = new PositionView()
            {
                IdPosition = Guid.NewGuid(),
                Code = "CV" + codets.ToString(),
                Name = txt_Name.Text,
                Status = rbtn_HoatDong.Checked ? 1 : 0,
            };
            return po;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Bạn có muốn thêm chức vụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(_position.AddPositions(GetDataFromGui()));
                LoadData();
            }
            return;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Bạn có muốn sửa chức vụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (txt_Code.Text == "" || txt_Name.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(_position.UpdatePositions(new PositionView()
                {
                    IdPosition = _id,
                    Code = txt_Code.Text,
                    Name = txt_Name.Text,
                    Status = rbtn_HoatDong.Checked ? 1 : 0,
                }));
                LoadData();
            }
            return;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Bạn có muốn xóa chức vụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(_position.RemovePositions(_id));
                LoadData();
            }
            return;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            _position.GetPositionsByName(txt_Search.Text);
        }

        private void dgrid_Position_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _position.GetPositions().Count) return;
            _id = _position.GetPositions().FirstOrDefault(c => c.Name == dgrid_Position.Rows[rowindex].Cells[2].Value.ToString()).IdPosition;
            var temp = _position.GetPositions().FirstOrDefault(c => c.IdPosition == _id);
            txt_Code.Text = temp.Code;
            txt_Name.Text = temp.Name;
            if (temp.Status == 1)
            {
                rbtn_HoatDong.Checked = true;
            }
            else rbtn_KhongHD.Checked = true;
        }
    }
}
