namespace TranscomInventoryManagement
{
    partial class ManageOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customersGV = new System.Windows.Forms.DataGridView();
            this.custID = new System.Windows.Forms.TextBox();
            this.ordID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.productsGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.custName = new System.Windows.Forms.TextBox();
            this.ordersGV = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 25);
            this.panel2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 100);
            this.panel1.TabIndex = 27;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.Color.Transparent;
            this.close.Location = new System.Drawing.Point(790, 13);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 25);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(272, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transcom Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(351, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(84, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Customer List";
            // 
            // customersGV
            // 
            this.customersGV.AllowUserToAddRows = false;
            this.customersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersGV.BackgroundColor = System.Drawing.Color.Snow;
            this.customersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.customersGV.Location = new System.Drawing.Point(12, 134);
            this.customersGV.Name = "customersGV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customersGV.RowTemplate.Height = 25;
            this.customersGV.Size = new System.Drawing.Size(309, 138);
            this.customersGV.TabIndex = 29;
            this.customersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGV_CellContentClick);
            // 
            // custID
            // 
            this.custID.Location = new System.Drawing.Point(12, 344);
            this.custID.Name = "custID";
            this.custID.PlaceholderText = "CustomerID";
            this.custID.Size = new System.Drawing.Size(164, 23);
            this.custID.TabIndex = 32;
            // 
            // ordID
            // 
            this.ordID.Location = new System.Drawing.Point(12, 306);
            this.ordID.Name = "ordID";
            this.ordID.PlaceholderText = "OrderID";
            this.ordID.Size = new System.Drawing.Size(164, 23);
            this.ordID.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 441);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 23);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(12, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 28);
            this.label4.TabIndex = 34;
            this.label4.Text = "Orders Date";
            // 
            // SearchCombo
            // 
            this.SearchCombo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(516, 108);
            this.SearchCombo.Margin = new System.Windows.Forms.Padding(0);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(156, 23);
            this.SearchCombo.TabIndex = 37;
            this.SearchCombo.Text = "Select Category";
            this.SearchCombo.SelectionChangeCommitted += new System.EventHandler(this.SearchCombo_SelectionChangeCommitted);
            // 
            // productsGV
            // 
            this.productsGV.AllowUserToAddRows = false;
            this.productsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGV.BackgroundColor = System.Drawing.Color.Snow;
            this.productsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.productsGV.Location = new System.Drawing.Point(339, 134);
            this.productsGV.Name = "productsGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productsGV.RowTemplate.Height = 25;
            this.productsGV.Size = new System.Drawing.Size(477, 138);
            this.productsGV.TabIndex = 36;
            this.productsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGV_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(378, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 38;
            this.label5.Text = "Quantity";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(494, 283);
            this.qty.Name = "qty";
            this.qty.PlaceholderText = "Enter Quantity";
            this.qty.Size = new System.Drawing.Size(164, 23);
            this.qty.TabIndex = 39;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(664, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 30);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add To Order";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(12, 384);
            this.custName.Name = "custName";
            this.custName.PlaceholderText = "CustomerName";
            this.custName.Size = new System.Drawing.Size(164, 23);
            this.custName.TabIndex = 42;
            // 
            // ordersGV
            // 
            this.ordersGV.AllowUserToAddRows = false;
            this.ordersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGV.BackgroundColor = System.Drawing.Color.Snow;
            this.ordersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.ordersGV.Location = new System.Drawing.Point(297, 326);
            this.ordersGV.Name = "ordersGV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ordersGV.RowTemplate.Height = 25;
            this.ordersGV.Size = new System.Drawing.Size(519, 138);
            this.ordersGV.TabIndex = 43;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Red;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(675, 103);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 30);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 511);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ordersGV);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.productsGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.custID);
            this.Controls.Add(this.ordID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customersGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageOrders";
            this.Text = "ManageOrders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label close;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView customersGV;
        private TextBox custID;
        private TextBox ordID;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox SearchCombo;
        private DataGridView productsGV;
        private Label label5;
        private TextBox qty;
        private Button btnAdd;
        private TextBox custName;
        private DataGridView ordersGV;
        private Button btnRefresh;
    }
}