
namespace QuanLyHangHoa
{
    partial class UIthanhtoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIthanhtoan));
            this.panel_addGioHang = new System.Windows.Forms.Panel();
            this.button_addToCart = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView_listHH = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_thongTinHH = new System.Windows.Forms.Panel();
            this.dateTimePicker_ngayNhapKho = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_xuatXu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_HSD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.txt_donVi = new System.Windows.Forms.TextBox();
            this.txt_tenHang = new System.Windows.Forms.TextBox();
            this.txt_maHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView_bill = new System.Windows.Forms.DataGridView();
            this.panel_print = new System.Windows.Forms.Panel();
            this.label_total = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_print = new System.Windows.Forms.Button();
            this.panel_addGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listHH)).BeginInit();
            this.panel_thongTinHH.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bill)).BeginInit();
            this.panel_print.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_addGioHang
            // 
            this.panel_addGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_addGioHang.Controls.Add(this.button_addToCart);
            this.panel_addGioHang.Controls.Add(this.dataGridView_listHH);
            this.panel_addGioHang.Controls.Add(this.txt_search);
            this.panel_addGioHang.Controls.Add(this.label7);
            this.panel_addGioHang.Location = new System.Drawing.Point(472, 20);
            this.panel_addGioHang.Name = "panel_addGioHang";
            this.panel_addGioHang.Size = new System.Drawing.Size(460, 310);
            this.panel_addGioHang.TabIndex = 31;
            // 
            // button_addToCart
            // 
            this.button_addToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_addToCart.FlatAppearance.BorderSize = 0;
            this.button_addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addToCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_addToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addToCart.ImageIndex = 0;
            this.button_addToCart.ImageList = this.imageList1;
            this.button_addToCart.Location = new System.Drawing.Point(111, 94);
            this.button_addToCart.Name = "button_addToCart";
            this.button_addToCart.Size = new System.Drawing.Size(237, 54);
            this.button_addToCart.TabIndex = 26;
            this.button_addToCart.Text = "Thêm vào giỏ hàng";
            this.button_addToCart.UseVisualStyleBackColor = false;
            this.button_addToCart.Click += new System.EventHandler(this.button_addToCart_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Add Cart.ico");
            this.imageList1.Images.SetKeyName(1, "print.png");
            // 
            // dataGridView_listHH
            // 
            this.dataGridView_listHH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_listHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_listHH.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_listHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listHH.Location = new System.Drawing.Point(13, 154);
            this.dataGridView_listHH.Name = "dataGridView_listHH";
            this.dataGridView_listHH.RowHeadersWidth = 51;
            this.dataGridView_listHH.RowTemplate.Height = 24;
            this.dataGridView_listHH.Size = new System.Drawing.Size(435, 150);
            this.dataGridView_listHH.TabIndex = 27;
            this.dataGridView_listHH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_listHH_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Silver;
            this.txt_search.Location = new System.Drawing.Point(111, 51);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(237, 31);
            this.txt_search.TabIndex = 25;
            this.txt_search.Text = "Nhập tên hoặc mã hàng";
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tìm kiếm:";
            // 
            // panel_thongTinHH
            // 
            this.panel_thongTinHH.Controls.Add(this.dateTimePicker_ngayNhapKho);
            this.panel_thongTinHH.Controls.Add(this.label10);
            this.panel_thongTinHH.Controls.Add(this.txt_xuatXu);
            this.panel_thongTinHH.Controls.Add(this.label9);
            this.panel_thongTinHH.Controls.Add(this.label8);
            this.panel_thongTinHH.Controls.Add(this.dateTimePicker_HSD);
            this.panel_thongTinHH.Controls.Add(this.label6);
            this.panel_thongTinHH.Controls.Add(this.txt_gia);
            this.panel_thongTinHH.Controls.Add(this.txt_soLuong);
            this.panel_thongTinHH.Controls.Add(this.txt_donVi);
            this.panel_thongTinHH.Controls.Add(this.txt_tenHang);
            this.panel_thongTinHH.Controls.Add(this.txt_maHang);
            this.panel_thongTinHH.Controls.Add(this.label5);
            this.panel_thongTinHH.Controls.Add(this.label4);
            this.panel_thongTinHH.Controls.Add(this.label3);
            this.panel_thongTinHH.Controls.Add(this.label2);
            this.panel_thongTinHH.Controls.Add(this.label1);
            this.panel_thongTinHH.Location = new System.Drawing.Point(12, 20);
            this.panel_thongTinHH.Name = "panel_thongTinHH";
            this.panel_thongTinHH.Size = new System.Drawing.Size(454, 310);
            this.panel_thongTinHH.TabIndex = 30;
            // 
            // dateTimePicker_ngayNhapKho
            // 
            this.dateTimePicker_ngayNhapKho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_ngayNhapKho.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngayNhapKho.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngayNhapKho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_ngayNhapKho.Location = new System.Drawing.Point(176, 245);
            this.dateTimePicker_ngayNhapKho.Name = "dateTimePicker_ngayNhapKho";
            this.dateTimePicker_ngayNhapKho.Size = new System.Drawing.Size(142, 22);
            this.dateTimePicker_ngayNhapKho.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Ngày Nhập Kho:";
            // 
            // txt_xuatXu
            // 
            this.txt_xuatXu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_xuatXu.Location = new System.Drawing.Point(176, 99);
            this.txt_xuatXu.Name = "txt_xuatXu";
            this.txt_xuatXu.ReadOnly = true;
            this.txt_xuatXu.Size = new System.Drawing.Size(142, 22);
            this.txt_xuatXu.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Xuất Xứ:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "HSD:";
            // 
            // dateTimePicker_HSD
            // 
            this.dateTimePicker_HSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_HSD.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_HSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_HSD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_HSD.Location = new System.Drawing.Point(176, 282);
            this.dateTimePicker_HSD.Name = "dateTimePicker_HSD";
            this.dateTimePicker_HSD.Size = new System.Drawing.Size(142, 22);
            this.dateTimePicker_HSD.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(324, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "VNĐ";
            // 
            // txt_gia
            // 
            this.txt_gia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_gia.Location = new System.Drawing.Point(176, 206);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.ReadOnly = true;
            this.txt_gia.Size = new System.Drawing.Size(142, 22);
            this.txt_gia.TabIndex = 37;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_soLuong.Location = new System.Drawing.Point(176, 171);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(142, 22);
            this.txt_soLuong.TabIndex = 36;
            this.txt_soLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soLuong_KeyPress);
            // 
            // txt_donVi
            // 
            this.txt_donVi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_donVi.Location = new System.Drawing.Point(176, 136);
            this.txt_donVi.Name = "txt_donVi";
            this.txt_donVi.ReadOnly = true;
            this.txt_donVi.Size = new System.Drawing.Size(142, 22);
            this.txt_donVi.TabIndex = 35;
            // 
            // txt_tenHang
            // 
            this.txt_tenHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tenHang.Location = new System.Drawing.Point(176, 46);
            this.txt_tenHang.Multiline = true;
            this.txt_tenHang.Name = "txt_tenHang";
            this.txt_tenHang.ReadOnly = true;
            this.txt_tenHang.Size = new System.Drawing.Size(268, 47);
            this.txt_tenHang.TabIndex = 33;
            // 
            // txt_maHang
            // 
            this.txt_maHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_maHang.Location = new System.Drawing.Point(176, 7);
            this.txt_maHang.Name = "txt_maHang";
            this.txt_maHang.ReadOnly = true;
            this.txt_maHang.Size = new System.Drawing.Size(142, 22);
            this.txt_maHang.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Đơn Vị:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên Hàng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã Hàng:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dataGridView_bill);
            this.panel1.Location = new System.Drawing.Point(12, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 204);
            this.panel1.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(420, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "HÓA ĐƠN";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_bill
            // 
            this.dataGridView_bill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bill.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bill.Location = new System.Drawing.Point(3, 49);
            this.dataGridView_bill.Name = "dataGridView_bill";
            this.dataGridView_bill.RowHeadersWidth = 51;
            this.dataGridView_bill.RowTemplate.Height = 24;
            this.dataGridView_bill.Size = new System.Drawing.Size(917, 152);
            this.dataGridView_bill.TabIndex = 28;
            // 
            // panel_print
            // 
            this.panel_print.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_print.Controls.Add(this.label_total);
            this.panel_print.Controls.Add(this.label12);
            this.panel_print.Controls.Add(this.label11);
            this.panel_print.Controls.Add(this.button_print);
            this.panel_print.Location = new System.Drawing.Point(339, 546);
            this.panel_print.Name = "panel_print";
            this.panel_print.Size = new System.Drawing.Size(593, 52);
            this.panel_print.TabIndex = 29;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(163, 20);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(59, 21);
            this.label_total.TabIndex = 39;
            this.label_total.Text = "0.000";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(324, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "Thành tiền:";
            // 
            // button_print
            // 
            this.button_print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_print.FlatAppearance.BorderSize = 0;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_print.ImageIndex = 1;
            this.button_print.ImageList = this.imageList1;
            this.button_print.Location = new System.Drawing.Point(449, 6);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(144, 42);
            this.button_print.TabIndex = 29;
            this.button_print.Text = "       In hóa đơn";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // UIthanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 606);
            this.Controls.Add(this.panel_print);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_thongTinHH);
            this.Controls.Add(this.panel_addGioHang);
            this.Name = "UIthanhtoan";
            this.Text = "UIthanhtoan";
            this.Load += new System.EventHandler(this.UIthanhtoan_Load);
            this.panel_addGioHang.ResumeLayout(false);
            this.panel_addGioHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listHH)).EndInit();
            this.panel_thongTinHH.ResumeLayout(false);
            this.panel_thongTinHH.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bill)).EndInit();
            this.panel_print.ResumeLayout(false);
            this.panel_print.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_addGioHang;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_listHH;
        private System.Windows.Forms.Button button_addToCart;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel_thongTinHH;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayNhapKho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_xuatXu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_HSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.TextBox txt_donVi;
        private System.Windows.Forms.TextBox txt_tenHang;
        private System.Windows.Forms.TextBox txt_maHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_bill;
        private System.Windows.Forms.Panel panel_print;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}