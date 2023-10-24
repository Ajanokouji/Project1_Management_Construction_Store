namespace _3.PL.View
{
    partial class FrmPosition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_KhongHD = new System.Windows.Forms.RadioButton();
            this.rbtn_HoatDong = new System.Windows.Forms.RadioButton();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Remove = new FontAwesome.Sharp.IconButton();
            this.btn_Update = new FontAwesome.Sharp.IconButton();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dgrid_Position = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Position)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.rbtn_KhongHD);
            this.panel3.Controls.Add(this.rbtn_HoatDong);
            this.panel3.Controls.Add(this.txt_Name);
            this.panel3.Controls.Add(this.txt_Code);
            this.panel3.Location = new System.Drawing.Point(1, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 302);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(130, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(130, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(130, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã chức vụ";
            // 
            // rbtn_KhongHD
            // 
            this.rbtn_KhongHD.AutoSize = true;
            this.rbtn_KhongHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtn_KhongHD.Location = new System.Drawing.Point(391, 192);
            this.rbtn_KhongHD.Name = "rbtn_KhongHD";
            this.rbtn_KhongHD.Size = new System.Drawing.Size(146, 24);
            this.rbtn_KhongHD.TabIndex = 1;
            this.rbtn_KhongHD.TabStop = true;
            this.rbtn_KhongHD.Text = "Không hoạt động";
            this.rbtn_KhongHD.UseVisualStyleBackColor = true;
            // 
            // rbtn_HoatDong
            // 
            this.rbtn_HoatDong.AutoSize = true;
            this.rbtn_HoatDong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtn_HoatDong.Location = new System.Drawing.Point(232, 192);
            this.rbtn_HoatDong.Name = "rbtn_HoatDong";
            this.rbtn_HoatDong.Size = new System.Drawing.Size(102, 24);
            this.rbtn_HoatDong.TabIndex = 1;
            this.rbtn_HoatDong.TabStop = true;
            this.rbtn_HoatDong.Text = "Hoạt động";
            this.rbtn_HoatDong.UseVisualStyleBackColor = true;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(232, 128);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(209, 27);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(232, 65);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(209, 27);
            this.txt_Code.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Remove);
            this.panel4.Controls.Add(this.btn_Update);
            this.panel4.Controls.Add(this.btn_Add);
            this.panel4.Location = new System.Drawing.Point(697, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 299);
            this.panel4.TabIndex = 3;
            // 
            // btn_Remove
            // 
            this.btn_Remove.FlatAppearance.BorderSize = 0;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Remove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_Remove.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Remove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Remove.IconSize = 32;
            this.btn_Remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Remove.Location = new System.Drawing.Point(87, 192);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(116, 45);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Xóa";
            this.btn_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Update.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btn_Update.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Update.IconSize = 32;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(87, 128);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(116, 45);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Add.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.IconSize = 32;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(87, 65);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 45);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(291, 335);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(400, 34);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // dgrid_Position
            // 
            this.dgrid_Position.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgrid_Position.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Position.GridColor = System.Drawing.Color.White;
            this.dgrid_Position.Location = new System.Drawing.Point(1, 395);
            this.dgrid_Position.Name = "dgrid_Position";
            this.dgrid_Position.RowHeadersWidth = 51;
            this.dgrid_Position.RowTemplate.Height = 29;
            this.dgrid_Position.Size = new System.Drawing.Size(970, 208);
            this.dgrid_Position.TabIndex = 6;
            this.dgrid_Position.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Position_CellClick);
            // 
            // FrmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(966, 596);
            this.Controls.Add(this.dgrid_Position);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "FrmPosition";
            this.Text = "FrmPosition";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Position)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_KhongHD;
        private System.Windows.Forms.RadioButton rbtn_HoatDong;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btn_Remove;
        private FontAwesome.Sharp.IconButton btn_Update;
        private FontAwesome.Sharp.IconButton btn_Add;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dgrid_Position;
    }
}