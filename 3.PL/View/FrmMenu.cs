using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace _3.PL.Views
{
    public partial class FrmMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FrmMenu()
        {
            InitializeComponent();
            random = new Random();
            CloseChildForm.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            timer1.Start();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTop.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    CloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelmenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(31, 30, 68);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelBody.Controls.Add(childForm);
            this.panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lb_home.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            lb_home.Text = "HOME";
            panelTop.BackColor = Color.FromArgb(0, 0, 192);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            CloseChildForm.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("T");
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_revenue_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.FrmCustomer(), sender);
            lb_home.Text = btn_customer.Text;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to sign out?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("You have canceled your logout");
            }
        }

        private void CloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
    }
}
