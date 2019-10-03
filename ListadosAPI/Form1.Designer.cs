namespace ListadosAPI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.FormOp = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UsersDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.PictUser = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LblNameUser = new System.Windows.Forms.Label();
            this.FormOp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("The Light Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 98);
            this.button1.TabIndex = 1;
            this.button1.Text = "LISTAR USUARIOS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormOp
            // 
            this.FormOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.FormOp.Controls.Add(this.LblTitle);
            this.FormOp.Controls.Add(this.button2);
            this.FormOp.Location = new System.Drawing.Point(-1, -3);
            this.FormOp.Name = "FormOp";
            this.FormOp.Size = new System.Drawing.Size(803, 49);
            this.FormOp.TabIndex = 3;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("The Light Font", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblTitle.Location = new System.Drawing.Point(13, 23);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(82, 11);
            this.LblTitle.TabIndex = 6;
            this.LblTitle.Text = "LISTADOS CON API";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("The Light Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(749, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("The Light Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(35, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 98);
            this.button3.TabIndex = 4;
            this.button3.Text = "LISTAR POST";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AllowUserToAddRows = false;
            this.UsersDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UsersDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.UsersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.DoubleBuffered = true;
            this.UsersDataGrid.EnableHeadersVisualStyles = false;
            this.UsersDataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.UsersDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.UsersDataGrid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.UsersDataGrid.Location = new System.Drawing.Point(248, 62);
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.ReadOnly = true;
            this.UsersDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UsersDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.UsersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGrid.Size = new System.Drawing.Size(540, 439);
            this.UsersDataGrid.TabIndex = 5;
            this.UsersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGrid_CellContentClick);
            this.UsersDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGrid_CellContentDoubleClick);
            // 
            // PictUser
            // 
            this.PictUser.Location = new System.Drawing.Point(51, 27);
            this.PictUser.Name = "PictUser";
            this.PictUser.Size = new System.Drawing.Size(100, 84);
            this.PictUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictUser.TabIndex = 6;
            this.PictUser.TabStop = false;
            this.PictUser.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblNameUser);
            this.panel2.Controls.Add(this.PictUser);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.panel2.Location = new System.Drawing.Point(14, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 199);
            this.panel2.TabIndex = 7;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.FormOp;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LblNameUser
            // 
            this.LblNameUser.AutoSize = true;
            this.LblNameUser.Font = new System.Drawing.Font("The Light Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.LblNameUser.Location = new System.Drawing.Point(83, 169);
            this.LblNameUser.Name = "LblNameUser";
            this.LblNameUser.Size = new System.Drawing.Size(49, 16);
            this.LblNameUser.TabIndex = 7;
            this.LblNameUser.Text = "Nsdna";
            this.LblNameUser.Visible = false;
            this.LblNameUser.Click += new System.EventHandler(this.LblNameUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UsersDataGrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FormOp);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormOp.ResumeLayout(false);
            this.FormOp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel FormOp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid UsersDataGrid;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PictUser;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label LblNameUser;
    }
}

