namespace GUI_Orders
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
            this.dtgvOrders = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipVia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.tbEmployeeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.dtRequired = new System.Windows.Forms.DateTimePicker();
            this.dtShipped = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbShipName = new System.Windows.Forms.TextBox();
            this.tbShipVia = new System.Windows.Forms.TextBox();
            this.tbFreight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbShipRegion = new System.Windows.Forms.TextBox();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.tbShipCity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbShipPostalCode = new System.Windows.Forms.TextBox();
            this.tbShipCountry = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrders)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvOrders
            // 
            this.dtgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CustomerID,
            this.EmployeeID,
            this.OrderDate,
            this.RequiredDate,
            this.ShippedDate,
            this.ShipVia,
            this.Freight,
            this.ShipName,
            this.ShipAddress,
            this.ShipCity,
            this.ShipRegion,
            this.ShipPostalCode,
            this.ShipCountry});
            this.dtgvOrders.Location = new System.Drawing.Point(-1, 156);
            this.dtgvOrders.Name = "dtgvOrders";
            this.dtgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvOrders.Size = new System.Drawing.Size(1022, 288);
            this.dtgvOrders.TabIndex = 0;
            this.dtgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOrders_CellClick);
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.Name = "OrderDate";
            // 
            // RequiredDate
            // 
            this.RequiredDate.DataPropertyName = "RequiredDate";
            this.RequiredDate.HeaderText = "RequiredDate";
            this.RequiredDate.Name = "RequiredDate";
            // 
            // ShippedDate
            // 
            this.ShippedDate.DataPropertyName = "ShippedDate";
            this.ShippedDate.HeaderText = "ShippedDate";
            this.ShippedDate.Name = "ShippedDate";
            // 
            // ShipVia
            // 
            this.ShipVia.DataPropertyName = "ShipVia";
            this.ShipVia.HeaderText = "ShipVia";
            this.ShipVia.Name = "ShipVia";
            // 
            // Freight
            // 
            this.Freight.DataPropertyName = "Freight";
            this.Freight.HeaderText = "Freight";
            this.Freight.Name = "Freight";
            // 
            // ShipName
            // 
            this.ShipName.DataPropertyName = "ShipName";
            this.ShipName.HeaderText = "ShipName";
            this.ShipName.Name = "ShipName";
            // 
            // ShipAddress
            // 
            this.ShipAddress.DataPropertyName = "ShipAddress";
            this.ShipAddress.HeaderText = "ShipAddress";
            this.ShipAddress.Name = "ShipAddress";
            // 
            // ShipCity
            // 
            this.ShipCity.DataPropertyName = "ShipCity";
            this.ShipCity.HeaderText = "ShipCity";
            this.ShipCity.Name = "ShipCity";
            // 
            // ShipRegion
            // 
            this.ShipRegion.DataPropertyName = "ShipRegion";
            this.ShipRegion.HeaderText = "ShipRegion";
            this.ShipRegion.Name = "ShipRegion";
            // 
            // ShipPostalCode
            // 
            this.ShipPostalCode.DataPropertyName = "ShipPostalCode";
            this.ShipPostalCode.HeaderText = "ShipPostalCode";
            this.ShipPostalCode.Name = "ShipPostalCode";
            // 
            // ShipCountry
            // 
            this.ShipCountry.DataPropertyName = "ShipCountry";
            this.ShipCountry.HeaderText = "ShipCountry";
            this.ShipCountry.Name = "ShipCountry";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTimKiem, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOrderID, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 441);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 62);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập OrderID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOrderID.Location = new System.Drawing.Point(615, 27);
            this.txtOrderID.Multiline = true;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(198, 32);
            this.txtOrderID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ ORDERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "OrderID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CustomerID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "EmployeeID";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(82, 34);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(100, 20);
            this.tbOrderID.TabIndex = 6;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(82, 75);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(100, 20);
            this.tbCustomerID.TabIndex = 6;
            // 
            // tbEmployeeID
            // 
            this.tbEmployeeID.Location = new System.Drawing.Point(82, 112);
            this.tbEmployeeID.Name = "tbEmployeeID";
            this.tbEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.tbEmployeeID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "OrderDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "RequiredDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "ShippedDate";
            // 
            // dtOrder
            // 
            this.dtOrder.Location = new System.Drawing.Point(280, 34);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(181, 20);
            this.dtOrder.TabIndex = 7;
            // 
            // dtRequired
            // 
            this.dtRequired.Location = new System.Drawing.Point(280, 72);
            this.dtRequired.Name = "dtRequired";
            this.dtRequired.Size = new System.Drawing.Size(181, 20);
            this.dtRequired.TabIndex = 7;
            // 
            // dtShipped
            // 
            this.dtShipped.Location = new System.Drawing.Point(280, 105);
            this.dtShipped.Name = "dtShipped";
            this.dtShipped.Size = new System.Drawing.Size(181, 20);
            this.dtShipped.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "ShipVia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Freight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "ShipName";
            // 
            // tbShipName
            // 
            this.tbShipName.Location = new System.Drawing.Point(531, 109);
            this.tbShipName.Name = "tbShipName";
            this.tbShipName.Size = new System.Drawing.Size(100, 20);
            this.tbShipName.TabIndex = 8;
            // 
            // tbShipVia
            // 
            this.tbShipVia.Location = new System.Drawing.Point(531, 34);
            this.tbShipVia.Name = "tbShipVia";
            this.tbShipVia.Size = new System.Drawing.Size(100, 20);
            this.tbShipVia.TabIndex = 8;
            // 
            // tbFreight
            // 
            this.tbFreight.Location = new System.Drawing.Point(531, 75);
            this.tbFreight.Name = "tbFreight";
            this.tbFreight.Size = new System.Drawing.Size(100, 20);
            this.tbFreight.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(637, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "ShipAddress";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(658, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "ShipCity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(641, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "ShipRegion";
            // 
            // tbShipRegion
            // 
            this.tbShipRegion.Location = new System.Drawing.Point(709, 105);
            this.tbShipRegion.Name = "tbShipRegion";
            this.tbShipRegion.Size = new System.Drawing.Size(100, 20);
            this.tbShipRegion.TabIndex = 8;
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Location = new System.Drawing.Point(709, 30);
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.Size = new System.Drawing.Size(100, 20);
            this.tbShipAddress.TabIndex = 8;
            // 
            // tbShipCity
            // 
            this.tbShipCity.Location = new System.Drawing.Point(709, 69);
            this.tbShipCity.Name = "tbShipCity";
            this.tbShipCity.Size = new System.Drawing.Size(100, 20);
            this.tbShipCity.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(812, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "ShipPostalCode";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(830, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "ShipCountry";
            // 
            // tbShipPostalCode
            // 
            this.tbShipPostalCode.Location = new System.Drawing.Point(900, 31);
            this.tbShipPostalCode.Name = "tbShipPostalCode";
            this.tbShipPostalCode.Size = new System.Drawing.Size(100, 20);
            this.tbShipPostalCode.TabIndex = 8;
            // 
            // tbShipCountry
            // 
            this.tbShipCountry.Location = new System.Drawing.Point(900, 69);
            this.tbShipCountry.Name = "tbShipCountry";
            this.tbShipCountry.Size = new System.Drawing.Size(100, 20);
            this.tbShipCountry.TabIndex = 8;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI_Orders.Properties.Resources.Button_Delete_icon;
            this.btnXoa.Location = new System.Drawing.Point(224, 27);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(181, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::GUI_Orders.Properties.Resources.Pencil_icon;
            this.btnSua.Location = new System.Drawing.Point(428, 27);
            this.btnSua.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(181, 32);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI_Orders.Properties.Resources.Actions_list_add_icon;
            this.btnThem.Location = new System.Drawing.Point(20, 27);
            this.btnThem.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(181, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI_Orders.Properties.Resources.zoom_seach_icon__1_;
            this.btnTimKiem.Location = new System.Drawing.Point(819, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(200, 32);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 516);
            this.Controls.Add(this.tbShipCountry);
            this.Controls.Add(this.tbShipCity);
            this.Controls.Add(this.tbFreight);
            this.Controls.Add(this.tbShipPostalCode);
            this.Controls.Add(this.tbShipAddress);
            this.Controls.Add(this.tbShipVia);
            this.Controls.Add(this.tbShipRegion);
            this.Controls.Add(this.tbShipName);
            this.Controls.Add(this.dtShipped);
            this.Controls.Add(this.dtRequired);
            this.Controls.Add(this.dtOrder);
            this.Controls.Add(this.tbEmployeeID);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dtgvOrders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrders)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.TextBox tbEmployeeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtOrder;
        private System.Windows.Forms.DateTimePicker dtRequired;
        private System.Windows.Forms.DateTimePicker dtShipped;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbShipName;
        private System.Windows.Forms.TextBox tbShipVia;
        private System.Windows.Forms.TextBox tbFreight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbShipRegion;
        private System.Windows.Forms.TextBox tbShipAddress;
        private System.Windows.Forms.TextBox tbShipCity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbShipPostalCode;
        private System.Windows.Forms.TextBox tbShipCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipVia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipCountry;
    }
}

