namespace ApiPostPut
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
            this.BttnPost = new System.Windows.Forms.Button();
            this.Bar = new System.Windows.Forms.Panel();
            this.BttnClose = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtJob = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblError = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TxtJobPut = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BttnPut = new System.Windows.Forms.Button();
            this.LblErrorPut = new System.Windows.Forms.Label();
            this.LblErrorDel = new System.Windows.Forms.Label();
            this.BttnDel = new System.Windows.Forms.Button();
            this.TxtIDDel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BttnPost
            // 
            this.BttnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.BttnPost.FlatAppearance.BorderSize = 0;
            this.BttnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnPost.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnPost.Location = new System.Drawing.Point(38, 224);
            this.BttnPost.Name = "BttnPost";
            this.BttnPost.Size = new System.Drawing.Size(195, 58);
            this.BttnPost.TabIndex = 0;
            this.BttnPost.Text = "POST";
            this.BttnPost.UseVisualStyleBackColor = false;
            this.BttnPost.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.Bar.Controls.Add(this.BttnClose);
            this.Bar.Controls.Add(this.LblTitle);
            this.Bar.Location = new System.Drawing.Point(0, -1);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(801, 43);
            this.Bar.TabIndex = 3;
            // 
            // BttnClose
            // 
            this.BttnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.BttnClose.FlatAppearance.BorderSize = 0;
            this.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnClose.Location = new System.Drawing.Point(738, 0);
            this.BttnClose.Name = "BttnClose";
            this.BttnClose.Size = new System.Drawing.Size(63, 42);
            this.BttnClose.TabIndex = 4;
            this.BttnClose.Text = "X";
            this.BttnClose.UseVisualStyleBackColor = false;
            this.BttnClose.Click += new System.EventHandler(this.BttnClose_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LblTitle.Location = new System.Drawing.Point(13, 12);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(77, 14);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "POST Y PUT";
            // 
            // TxtName
            // 
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtName.HintText = "Nombre";
            this.TxtName.isPassword = false;
            this.TxtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtName.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtName.LineThickness = 3;
            this.TxtName.Location = new System.Drawing.Point(38, 111);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(195, 41);
            this.TxtName.TabIndex = 4;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtName.OnValueChanged += new System.EventHandler(this.TxtName_OnValueChanged);
            // 
            // TxtJob
            // 
            this.TxtJob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtJob.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtJob.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtJob.HintText = "Trabajo";
            this.TxtJob.isPassword = false;
            this.TxtJob.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtJob.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtJob.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtJob.LineThickness = 3;
            this.TxtJob.Location = new System.Drawing.Point(35, 160);
            this.TxtJob.Margin = new System.Windows.Forms.Padding(4);
            this.TxtJob.Name = "TxtJob";
            this.TxtJob.Size = new System.Drawing.Size(198, 41);
            this.TxtJob.TabIndex = 5;
            this.TxtJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtJob.OnValueChanged += new System.EventHandler(this.TxtJob_OnValueChanged);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(49)))), ((int)(((byte)(41)))));
            this.LblError.Location = new System.Drawing.Point(35, 318);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(147, 14);
            this.LblError.TabIndex = 5;
            this.LblError.Text = "*CAMPOS SIN RELLENAR";
            this.LblError.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Bar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // TxtJobPut
            // 
            this.TxtJobPut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtJobPut.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJobPut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtJobPut.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtJobPut.HintText = "Trabajo";
            this.TxtJobPut.isPassword = false;
            this.TxtJobPut.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtJobPut.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtJobPut.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtJobPut.LineThickness = 3;
            this.TxtJobPut.Location = new System.Drawing.Point(298, 145);
            this.TxtJobPut.Margin = new System.Windows.Forms.Padding(4);
            this.TxtJobPut.Name = "TxtJobPut";
            this.TxtJobPut.Size = new System.Drawing.Size(198, 41);
            this.TxtJobPut.TabIndex = 6;
            this.TxtJobPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtJobPut.OnValueChanged += new System.EventHandler(this.TxtJobPut_OnValueChanged);
            // 
            // BttnPut
            // 
            this.BttnPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.BttnPut.FlatAppearance.BorderSize = 0;
            this.BttnPut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnPut.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnPut.Location = new System.Drawing.Point(298, 224);
            this.BttnPut.Name = "BttnPut";
            this.BttnPut.Size = new System.Drawing.Size(195, 58);
            this.BttnPut.TabIndex = 7;
            this.BttnPut.Text = "PUT";
            this.BttnPut.UseVisualStyleBackColor = false;
            this.BttnPut.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblErrorPut
            // 
            this.LblErrorPut.AutoSize = true;
            this.LblErrorPut.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorPut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(49)))), ((int)(((byte)(41)))));
            this.LblErrorPut.Location = new System.Drawing.Point(295, 318);
            this.LblErrorPut.Name = "LblErrorPut";
            this.LblErrorPut.Size = new System.Drawing.Size(147, 14);
            this.LblErrorPut.TabIndex = 8;
            this.LblErrorPut.Text = "*CAMPOS SIN RELLENAR";
            this.LblErrorPut.Visible = false;
            // 
            // LblErrorDel
            // 
            this.LblErrorDel.AutoSize = true;
            this.LblErrorDel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(49)))), ((int)(((byte)(41)))));
            this.LblErrorDel.Location = new System.Drawing.Point(567, 318);
            this.LblErrorDel.Name = "LblErrorDel";
            this.LblErrorDel.Size = new System.Drawing.Size(147, 14);
            this.LblErrorDel.TabIndex = 11;
            this.LblErrorDel.Text = "*CAMPOS SIN RELLENAR";
            this.LblErrorDel.Visible = false;
            // 
            // BttnDel
            // 
            this.BttnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.BttnDel.FlatAppearance.BorderSize = 0;
            this.BttnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnDel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnDel.Location = new System.Drawing.Point(570, 224);
            this.BttnDel.Name = "BttnDel";
            this.BttnDel.Size = new System.Drawing.Size(195, 58);
            this.BttnDel.TabIndex = 10;
            this.BttnDel.Text = "DELETE";
            this.BttnDel.UseVisualStyleBackColor = false;
            this.BttnDel.Click += new System.EventHandler(this.button3_Click);
            // 
            // TxtIDDel
            // 
            this.TxtIDDel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtIDDel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIDDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtIDDel.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtIDDel.HintText = "ID";
            this.TxtIDDel.isPassword = false;
            this.TxtIDDel.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtIDDel.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtIDDel.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(235)))), ((int)(((byte)(163)))));
            this.TxtIDDel.LineThickness = 3;
            this.TxtIDDel.Location = new System.Drawing.Point(570, 145);
            this.TxtIDDel.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIDDel.Name = "TxtIDDel";
            this.TxtIDDel.Size = new System.Drawing.Size(198, 41);
            this.TxtIDDel.TabIndex = 9;
            this.TxtIDDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtIDDel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIDDel_KeyPress);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(257, 84);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(16, 281);
            this.bunifuSeparator1.TabIndex = 12;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(527, 84);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(16, 281);
            this.bunifuSeparator2.TabIndex = 13;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.LblErrorDel);
            this.Controls.Add(this.BttnDel);
            this.Controls.Add(this.TxtIDDel);
            this.Controls.Add(this.LblErrorPut);
            this.Controls.Add(this.BttnPut);
            this.Controls.Add(this.TxtJobPut);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.TxtJob);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.BttnPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Bar.ResumeLayout(false);
            this.Bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttnPost;
        private System.Windows.Forms.Panel Bar;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BttnClose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtJob;
        private System.Windows.Forms.Label LblError;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtJobPut;
        private System.Windows.Forms.Button BttnPut;
        private System.Windows.Forms.Label LblErrorPut;
        private System.Windows.Forms.Label LblErrorDel;
        private System.Windows.Forms.Button BttnDel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtIDDel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}

