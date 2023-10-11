
namespace Product
{
    partial class productform
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.datepicker1 = new System.Windows.Forms.DateTimePicker();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.defect_shrimp = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Shrimp_Total = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.detect_bulgogi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Bulgogi_total = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.defect_cheese = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cheese_total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.defect_moster = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monsterX_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cboxCheese = new System.Windows.Forms.CheckBox();
            this.cboxMonsterX = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hamburgerDataSet = new Product.HamburgerDataSet();
            this.productTableAdapter = new Product.HamburgerDataSetTableAdapters.productTableAdapter();
            this.cboxBulgogiWhaper = new System.Windows.Forms.CheckBox();
            this.cboxShrimpWhaper = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 29);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 34);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.Controls.Add(this.datepicker1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.end_date, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(298, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 34);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // datepicker1
            // 
            this.datepicker1.Location = new System.Drawing.Point(3, 3);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(199, 21);
            this.datepicker1.TabIndex = 0;
            this.datepicker1.Value = new System.DateTime(2023, 10, 2, 10, 47, 0, 0);
            this.datepicker1.ValueChanged += new System.EventHandler(this.datepicker1_ValueChanged);
            // 
            // end_date
            // 
            this.end_date.Location = new System.Drawing.Point(228, 3);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(200, 21);
            this.end_date.TabIndex = 1;
            this.end_date.Value = new System.DateTime(2023, 10, 7, 10, 47, 0, 0);
            this.end_date.ValueChanged += new System.EventHandler(this.end_date_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 26);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(732, 370);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(128)))), ((int)(((byte)(129)))));
            this.panel7.Controls.Add(this.defect_shrimp);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.Shrimp_Total);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(545, 5);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(182, 108);
            this.panel7.TabIndex = 5;
            // 
            // defect_shrimp
            // 
            this.defect_shrimp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.defect_shrimp.AutoSize = true;
            this.defect_shrimp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defect_shrimp.ForeColor = System.Drawing.Color.White;
            this.defect_shrimp.Location = new System.Drawing.Point(142, 83);
            this.defect_shrimp.Name = "defect_shrimp";
            this.defect_shrimp.Size = new System.Drawing.Size(24, 17);
            this.defect_shrimp.TabIndex = 4;
            this.defect_shrimp.Text = "10";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bodoni Bd BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(73, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 15);
            this.label18.TabIndex = 3;
            this.label18.Text = "Defective:";
            // 
            // Shrimp_Total
            // 
            this.Shrimp_Total.AutoSize = true;
            this.Shrimp_Total.Font = new System.Drawing.Font("Bodoni Bd BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shrimp_Total.ForeColor = System.Drawing.Color.White;
            this.Shrimp_Total.Location = new System.Drawing.Point(69, 43);
            this.Shrimp_Total.Name = "Shrimp_Total";
            this.Shrimp_Total.Size = new System.Drawing.Size(58, 29);
            this.Shrimp_Total.TabIndex = 2;
            this.Shrimp_Total.Text = "100";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bodoni Bd BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(7, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 29);
            this.label20.TabIndex = 1;
            this.label20.Text = "Total";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(7, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "Shrimp Whaper";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(195)))));
            this.panel6.Controls.Add(this.detect_bulgogi);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.Bulgogi_total);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(365, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 108);
            this.panel6.TabIndex = 4;
            // 
            // detect_bulgogi
            // 
            this.detect_bulgogi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.detect_bulgogi.AutoSize = true;
            this.detect_bulgogi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detect_bulgogi.ForeColor = System.Drawing.Color.White;
            this.detect_bulgogi.Location = new System.Drawing.Point(140, 83);
            this.detect_bulgogi.Name = "detect_bulgogi";
            this.detect_bulgogi.Size = new System.Drawing.Size(24, 17);
            this.detect_bulgogi.TabIndex = 4;
            this.detect_bulgogi.Text = "10";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bodoni Bd BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(71, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Defective:";
            // 
            // Bulgogi_total
            // 
            this.Bulgogi_total.AutoSize = true;
            this.Bulgogi_total.Font = new System.Drawing.Font("Bodoni Bd BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bulgogi_total.ForeColor = System.Drawing.Color.White;
            this.Bulgogi_total.Location = new System.Drawing.Point(69, 43);
            this.Bulgogi_total.Name = "Bulgogi_total";
            this.Bulgogi_total.Size = new System.Drawing.Size(58, 29);
            this.Bulgogi_total.TabIndex = 2;
            this.Bulgogi_total.Text = "100";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bodoni Bd BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(7, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 29);
            this.label15.TabIndex = 1;
            this.label15.Text = "Total";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(7, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Bulgogi Whaper";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(129)))));
            this.panel5.Controls.Add(this.defect_cheese);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.Cheese_total);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(185, 5);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 108);
            this.panel5.TabIndex = 3;
            // 
            // defect_cheese
            // 
            this.defect_cheese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.defect_cheese.AutoSize = true;
            this.defect_cheese.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defect_cheese.ForeColor = System.Drawing.Color.White;
            this.defect_cheese.Location = new System.Drawing.Point(140, 83);
            this.defect_cheese.Name = "defect_cheese";
            this.defect_cheese.Size = new System.Drawing.Size(24, 17);
            this.defect_cheese.TabIndex = 4;
            this.defect_cheese.Text = "10";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bodoni Bd BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(71, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Defective:";
            // 
            // Cheese_total
            // 
            this.Cheese_total.AutoSize = true;
            this.Cheese_total.Font = new System.Drawing.Font("Bodoni Bd BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cheese_total.ForeColor = System.Drawing.Color.White;
            this.Cheese_total.Location = new System.Drawing.Point(69, 43);
            this.Cheese_total.Name = "Cheese_total";
            this.Cheese_total.Size = new System.Drawing.Size(58, 29);
            this.Cheese_total.TabIndex = 2;
            this.Cheese_total.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bodoni Bd BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cheese Whaper";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.defect_moster);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.monsterX_total);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 108);
            this.panel4.TabIndex = 2;
            // 
            // defect_moster
            // 
            this.defect_moster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.defect_moster.AutoSize = true;
            this.defect_moster.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defect_moster.ForeColor = System.Drawing.Color.White;
            this.defect_moster.Location = new System.Drawing.Point(140, 83);
            this.defect_moster.Name = "defect_moster";
            this.defect_moster.Size = new System.Drawing.Size(24, 17);
            this.defect_moster.TabIndex = 4;
            this.defect_moster.Text = "10";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni Bd BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(71, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Defective:";
            // 
            // monsterX_total
            // 
            this.monsterX_total.AutoSize = true;
            this.monsterX_total.Font = new System.Drawing.Font("Bodoni Bd BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterX_total.ForeColor = System.Drawing.Color.White;
            this.monsterX_total.Location = new System.Drawing.Point(69, 43);
            this.monsterX_total.Name = "monsterX_total";
            this.monsterX_total.Size = new System.Drawing.Size(58, 29);
            this.monsterX_total.TabIndex = 2;
            this.monsterX_total.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni Bd BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MonsterX";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.chart1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(548, 116);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.6748F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.3252F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(176, 246);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 76);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(170, 167);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cboxShrimpWhaper);
            this.panel8.Controls.Add(this.cboxBulgogiWhaper);
            this.panel8.Controls.Add(this.cboxCheese);
            this.panel8.Controls.Add(this.cboxMonsterX);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(170, 67);
            this.panel8.TabIndex = 2;
            // 
            // cboxCheese
            // 
            this.cboxCheese.AutoSize = true;
            this.cboxCheese.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxCheese.Location = new System.Drawing.Point(0, 16);
            this.cboxCheese.Name = "cboxCheese";
            this.cboxCheese.Size = new System.Drawing.Size(170, 16);
            this.cboxCheese.TabIndex = 1;
            this.cboxCheese.Text = "Cheese Whaper";
            this.cboxCheese.UseVisualStyleBackColor = true;
            this.cboxCheese.CheckedChanged += new System.EventHandler(this.cboxCheese_CheckedChanged);
            // 
            // cboxMonsterX
            // 
            this.cboxMonsterX.AutoSize = true;
            this.cboxMonsterX.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxMonsterX.Location = new System.Drawing.Point(0, 0);
            this.cboxMonsterX.Name = "cboxMonsterX";
            this.cboxMonsterX.Size = new System.Drawing.Size(170, 16);
            this.cboxMonsterX.TabIndex = 0;
            this.cboxMonsterX.Text = "MonsterX";
            this.cboxMonsterX.UseVisualStyleBackColor = true;
            this.cboxMonsterX.CheckedChanged += new System.EventHandler(this.cboxMonsterX_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(8, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(534, 246);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn13.HeaderText = "product_name";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "product_day";
            this.dataGridViewTextBoxColumn14.HeaderText = "product_day";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Defective";
            this.dataGridViewTextBoxColumn15.HeaderText = "Defective";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Defective_code";
            this.dataGridViewTextBoxColumn16.HeaderText = "Defective_code";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.hamburgerDataSet;
            // 
            // hamburgerDataSet
            // 
            this.hamburgerDataSet.DataSetName = "HamburgerDataSet";
            this.hamburgerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // cboxBulgogiWhaper
            // 
            this.cboxBulgogiWhaper.AutoSize = true;
            this.cboxBulgogiWhaper.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxBulgogiWhaper.Location = new System.Drawing.Point(0, 32);
            this.cboxBulgogiWhaper.Name = "cboxBulgogiWhaper";
            this.cboxBulgogiWhaper.Size = new System.Drawing.Size(170, 16);
            this.cboxBulgogiWhaper.TabIndex = 2;
            this.cboxBulgogiWhaper.Text = "BulgogiWhaper";
            this.cboxBulgogiWhaper.UseVisualStyleBackColor = true;
            this.cboxBulgogiWhaper.CheckedChanged += new System.EventHandler(this.cboxBulgogiWhaper_CheckedChanged);
            // 
            // cboxShrimpWhaper
            // 
            this.cboxShrimpWhaper.AutoSize = true;
            this.cboxShrimpWhaper.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxShrimpWhaper.Location = new System.Drawing.Point(0, 48);
            this.cboxShrimpWhaper.Name = "cboxShrimpWhaper";
            this.cboxShrimpWhaper.Size = new System.Drawing.Size(170, 16);
            this.cboxShrimpWhaper.TabIndex = 3;
            this.cboxShrimpWhaper.Text = "Shrimp Whaper";
            this.cboxShrimpWhaper.UseVisualStyleBackColor = true;
            this.cboxShrimpWhaper.CheckedChanged += new System.EventHandler(this.cboxShrimpWhaper_CheckedChanged);
            // 
            // productform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(732, 459);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "productform";
            this.Load += new System.EventHandler(this.productform_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker datepicker1;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label defect_moster;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label monsterX_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label defect_shrimp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Shrimp_Total;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label detect_bulgogi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Bulgogi_total;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label defect_cheese;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Cheese_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectivecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
  
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private HamburgerDataSet hamburgerDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private HamburgerDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox cboxCheese;
        private System.Windows.Forms.CheckBox cboxMonsterX;
        private System.Windows.Forms.CheckBox cboxShrimpWhaper;
        private System.Windows.Forms.CheckBox cboxBulgogiWhaper;
    }
}