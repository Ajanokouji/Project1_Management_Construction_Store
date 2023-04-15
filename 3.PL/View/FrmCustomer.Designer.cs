namespace _3.PL.Views
{
    partial class FrmCustomer
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
            panel1 = new System.Windows.Forms.Panel();
            btn_delete = new FontAwesome.Sharp.IconButton();
            dgrid_customer = new System.Windows.Forms.DataGridView();
            btn_clear = new FontAwesome.Sharp.IconButton();
            btn_update = new FontAwesome.Sharp.IconButton();
            btn_add = new FontAwesome.Sharp.IconButton();
            txt_search = new System.Windows.Forms.TextBox();
            rbtn_inactive = new System.Windows.Forms.RadioButton();
            rbtn_activate = new System.Windows.Forms.RadioButton();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_name = new System.Windows.Forms.TextBox();
            txt_code = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_customer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(dgrid_customer);
            panel1.Controls.Add(btn_clear);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(txt_search);
            panel1.Controls.Add(rbtn_inactive);
            panel1.Controls.Add(rbtn_activate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(txt_code);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1379, 308);
            panel1.TabIndex = 0;
            // 
            // btn_delete
            // 
            btn_delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btn_delete.IconColor = System.Drawing.Color.Black;
            btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_delete.IconSize = 32;
            btn_delete.Location = new System.Drawing.Point(976, 175);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new System.Drawing.Size(170, 60);
            btn_delete.TabIndex = 24;
            btn_delete.Text = "Delete";
            btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // dgrid_customer
            // 
            dgrid_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrid_customer.Location = new System.Drawing.Point(421, 29);
            dgrid_customer.Name = "dgrid_customer";
            dgrid_customer.RowHeadersWidth = 51;
            dgrid_customer.RowTemplate.Height = 29;
            dgrid_customer.Size = new System.Drawing.Size(533, 206);
            dgrid_customer.TabIndex = 23;
            dgrid_customer.CellClick += dgrid_customer_CellClick;
            // 
            // btn_clear
            // 
            btn_clear.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            btn_clear.IconColor = System.Drawing.Color.Black;
            btn_clear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_clear.IconSize = 32;
            btn_clear.Location = new System.Drawing.Point(1176, 175);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new System.Drawing.Size(187, 60);
            btn_clear.TabIndex = 22;
            btn_clear.Text = "Clear";
            btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_update
            // 
            btn_update.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btn_update.IconColor = System.Drawing.Color.Black;
            btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_update.IconSize = 32;
            btn_update.Location = new System.Drawing.Point(1176, 36);
            btn_update.Name = "btn_update";
            btn_update.Size = new System.Drawing.Size(187, 60);
            btn_update.TabIndex = 21;
            btn_update.Text = "Update";
            btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btn_add.IconColor = System.Drawing.Color.Black;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.IconSize = 32;
            btn_add.Location = new System.Drawing.Point(976, 36);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(170, 60);
            btn_add.TabIndex = 20;
            btn_add.Text = "Add";
            btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new System.Drawing.Point(421, 253);
            txt_search.Name = "txt_search";
            txt_search.Size = new System.Drawing.Size(533, 27);
            txt_search.TabIndex = 16;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // rbtn_inactive
            // 
            rbtn_inactive.AutoSize = true;
            rbtn_inactive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            rbtn_inactive.Location = new System.Drawing.Point(152, 183);
            rbtn_inactive.Name = "rbtn_inactive";
            rbtn_inactive.Size = new System.Drawing.Size(81, 24);
            rbtn_inactive.TabIndex = 14;
            rbtn_inactive.TabStop = true;
            rbtn_inactive.Text = "Inactive";
            rbtn_inactive.UseVisualStyleBackColor = true;
            // 
            // rbtn_activate
            // 
            rbtn_activate.AutoSize = true;
            rbtn_activate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            rbtn_activate.Location = new System.Drawing.Point(149, 135);
            rbtn_activate.Name = "rbtn_activate";
            rbtn_activate.Size = new System.Drawing.Size(84, 24);
            rbtn_activate.TabIndex = 13;
            rbtn_activate.TabStop = true;
            rbtn_activate.Text = "Activate";
            rbtn_activate.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label7.Location = new System.Drawing.Point(39, 135);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 20);
            label7.TabIndex = 11;
            label7.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(39, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Location = new System.Drawing.Point(149, 81);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(232, 27);
            txt_name.TabIndex = 2;
            // 
            // txt_code
            // 
            txt_code.Location = new System.Drawing.Point(149, 29);
            txt_code.Name = "txt_code";
            txt_code.Size = new System.Drawing.Size(232, 27);
            txt_code.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(39, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1379, 308);
            Controls.Add(panel1);
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_customer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.RadioButton rbtn_inactive;
        private System.Windows.Forms.RadioButton rbtn_activate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_clear;
        private FontAwesome.Sharp.IconButton btn_update;
        private System.Windows.Forms.DataGridView dgrid_customer;
        private FontAwesome.Sharp.IconButton btn_delete;
    }
}