namespace Fastfood
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BGG = new System.Windows.Forms.Button();
            this.btn_BGB = new System.Windows.Forms.Button();
            this.btn_BGT = new System.Windows.Forms.Button();
            this.btn_BGC = new System.Windows.Forms.Button();
            this.btn_CG = new System.Windows.Forms.Button();
            this.btn_GR = new System.Windows.Forms.Button();
            this.btn_GV = new System.Windows.Forms.Button();
            this.btn_TV = new System.Windows.Forms.Button();
            this.btn_KTC = new System.Windows.Forms.Button();
            this.btn_CF = new System.Windows.Forms.Button();
            this.btn_7up = new System.Windows.Forms.Button();
            this.btn_Pepsi = new System.Windows.Forms.Button();
            this.btn_cam = new System.Windows.Forms.Button();
            this.btn_Lipton = new System.Windows.Forms.Button();
            this.btn_Coca = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_xoahet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fastfood Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh mục món ăn";
            // 
            // btn_BGG
            // 
            this.btn_BGG.Location = new System.Drawing.Point(66, 98);
            this.btn_BGG.Name = "btn_BGG";
            this.btn_BGG.Size = new System.Drawing.Size(146, 23);
            this.btn_BGG.TabIndex = 6;
            this.btn_BGG.Text = "Burger phô mai gà";
            this.btn_BGG.UseVisualStyleBackColor = true;
            this.btn_BGG.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_BGB
            // 
            this.btn_BGB.Location = new System.Drawing.Point(66, 139);
            this.btn_BGB.Name = "btn_BGB";
            this.btn_BGB.Size = new System.Drawing.Size(146, 23);
            this.btn_BGB.TabIndex = 7;
            this.btn_BGB.Text = "Burger phô mai bò";
            this.btn_BGB.UseVisualStyleBackColor = true;
            this.btn_BGB.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_BGT
            // 
            this.btn_BGT.Location = new System.Drawing.Point(66, 182);
            this.btn_BGT.Name = "btn_BGT";
            this.btn_BGT.Size = new System.Drawing.Size(146, 23);
            this.btn_BGT.TabIndex = 8;
            this.btn_BGT.Text = "Burger phô mai tôm";
            this.btn_BGT.UseVisualStyleBackColor = true;
            this.btn_BGT.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_BGC
            // 
            this.btn_BGC.Location = new System.Drawing.Point(66, 220);
            this.btn_BGC.Name = "btn_BGC";
            this.btn_BGC.Size = new System.Drawing.Size(146, 23);
            this.btn_BGC.TabIndex = 9;
            this.btn_BGC.Text = "Burger phô mai cá";
            this.btn_BGC.UseVisualStyleBackColor = true;
            this.btn_BGC.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_CG
            // 
            this.btn_CG.Location = new System.Drawing.Point(245, 220);
            this.btn_CG.Name = "btn_CG";
            this.btn_CG.Size = new System.Drawing.Size(146, 23);
            this.btn_CG.TabIndex = 15;
            this.btn_CG.Text = "Cơm gà Tender";
            this.btn_CG.UseVisualStyleBackColor = true;
            this.btn_CG.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_GR
            // 
            this.btn_GR.Location = new System.Drawing.Point(245, 182);
            this.btn_GR.Name = "btn_GR";
            this.btn_GR.Size = new System.Drawing.Size(146, 23);
            this.btn_GR.TabIndex = 14;
            this.btn_GR.Text = "Gà rán phăn";
            this.btn_GR.UseVisualStyleBackColor = true;
            this.btn_GR.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_GV
            // 
            this.btn_GV.Location = new System.Drawing.Point(245, 139);
            this.btn_GV.Name = "btn_GV";
            this.btn_GV.Size = new System.Drawing.Size(146, 23);
            this.btn_GV.TabIndex = 13;
            this.btn_GV.Text = "Gà viên cola";
            this.btn_GV.UseVisualStyleBackColor = true;
            this.btn_GV.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_TV
            // 
            this.btn_TV.Location = new System.Drawing.Point(245, 98);
            this.btn_TV.Name = "btn_TV";
            this.btn_TV.Size = new System.Drawing.Size(146, 23);
            this.btn_TV.TabIndex = 12;
            this.btn_TV.Text = "Tôm viên cola";
            this.btn_TV.UseVisualStyleBackColor = true;
            this.btn_TV.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_KTC
            // 
            this.btn_KTC.Location = new System.Drawing.Point(426, 220);
            this.btn_KTC.Name = "btn_KTC";
            this.btn_KTC.Size = new System.Drawing.Size(146, 23);
            this.btn_KTC.TabIndex = 19;
            this.btn_KTC.Text = "Khoai tây chiên";
            this.btn_KTC.UseVisualStyleBackColor = true;
            this.btn_KTC.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_CF
            // 
            this.btn_CF.Location = new System.Drawing.Point(426, 182);
            this.btn_CF.Name = "btn_CF";
            this.btn_CF.Size = new System.Drawing.Size(67, 23);
            this.btn_CF.TabIndex = 18;
            this.btn_CF.Text = "Cafe";
            this.btn_CF.UseVisualStyleBackColor = true;
            this.btn_CF.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_7up
            // 
            this.btn_7up.Location = new System.Drawing.Point(426, 139);
            this.btn_7up.Name = "btn_7up";
            this.btn_7up.Size = new System.Drawing.Size(67, 23);
            this.btn_7up.TabIndex = 17;
            this.btn_7up.Text = "7 up";
            this.btn_7up.UseVisualStyleBackColor = true;
            this.btn_7up.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_Pepsi
            // 
            this.btn_Pepsi.Location = new System.Drawing.Point(426, 98);
            this.btn_Pepsi.Name = "btn_Pepsi";
            this.btn_Pepsi.Size = new System.Drawing.Size(67, 23);
            this.btn_Pepsi.TabIndex = 16;
            this.btn_Pepsi.Text = "Pepsi";
            this.btn_Pepsi.UseVisualStyleBackColor = true;
            this.btn_Pepsi.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_cam
            // 
            this.btn_cam.Location = new System.Drawing.Point(505, 182);
            this.btn_cam.Name = "btn_cam";
            this.btn_cam.Size = new System.Drawing.Size(67, 23);
            this.btn_cam.TabIndex = 22;
            this.btn_cam.Text = "Cam";
            this.btn_cam.UseVisualStyleBackColor = true;
            this.btn_cam.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_Lipton
            // 
            this.btn_Lipton.Location = new System.Drawing.Point(505, 139);
            this.btn_Lipton.Name = "btn_Lipton";
            this.btn_Lipton.Size = new System.Drawing.Size(67, 23);
            this.btn_Lipton.TabIndex = 21;
            this.btn_Lipton.Text = "Lipton";
            this.btn_Lipton.UseVisualStyleBackColor = true;
            this.btn_Lipton.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_Coca
            // 
            this.btn_Coca.Location = new System.Drawing.Point(505, 98);
            this.btn_Coca.Name = "btn_Coca";
            this.btn_Coca.Size = new System.Drawing.Size(67, 23);
            this.btn_Coca.TabIndex = 20;
            this.btn_Coca.Text = "Coca";
            this.btn_Coca.UseVisualStyleBackColor = true;
            this.btn_Coca.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(505, 264);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(67, 23);
            this.btn_Order.TabIndex = 23;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(66, 262);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(67, 23);
            this.btn_Xoa.TabIndex = 24;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên bàn";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(257, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 221);
            this.dataGridView1.TabIndex = 27;
            // 
            // btn_xoahet
            // 
            this.btn_xoahet.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_xoahet.Location = new System.Drawing.Point(139, 262);
            this.btn_xoahet.Name = "btn_xoahet";
            this.btn_xoahet.Size = new System.Drawing.Size(67, 23);
            this.btn_xoahet.TabIndex = 28;
            this.btn_xoahet.Text = "Xóa hết";
            this.btn_xoahet.UseVisualStyleBackColor = true;
            this.btn_xoahet.Click += new System.EventHandler(this.btn_xoahet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 549);
            this.Controls.Add(this.btn_xoahet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.btn_cam);
            this.Controls.Add(this.btn_Lipton);
            this.Controls.Add(this.btn_Coca);
            this.Controls.Add(this.btn_KTC);
            this.Controls.Add(this.btn_CF);
            this.Controls.Add(this.btn_7up);
            this.Controls.Add(this.btn_Pepsi);
            this.Controls.Add(this.btn_CG);
            this.Controls.Add(this.btn_GR);
            this.Controls.Add(this.btn_GV);
            this.Controls.Add(this.btn_TV);
            this.Controls.Add(this.btn_BGC);
            this.Controls.Add(this.btn_BGT);
            this.Controls.Add(this.btn_BGB);
            this.Controls.Add(this.btn_BGG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BGG;
        private System.Windows.Forms.Button btn_BGB;
        private System.Windows.Forms.Button btn_BGT;
        private System.Windows.Forms.Button btn_BGC;
        private System.Windows.Forms.Button btn_CG;
        private System.Windows.Forms.Button btn_GR;
        private System.Windows.Forms.Button btn_GV;
        private System.Windows.Forms.Button btn_TV;
        private System.Windows.Forms.Button btn_KTC;
        private System.Windows.Forms.Button btn_CF;
        private System.Windows.Forms.Button btn_7up;
        private System.Windows.Forms.Button btn_Pepsi;
        private System.Windows.Forms.Button btn_cam;
        private System.Windows.Forms.Button btn_Lipton;
        private System.Windows.Forms.Button btn_Coca;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_xoahet;
    }
}

