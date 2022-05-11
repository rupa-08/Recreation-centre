
namespace Coursework1
{
    partial class visitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visitorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.duration_txt = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grpMembers_dropdown = new System.Windows.Forms.ComboBox();
            this.price = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedOutRadioBtn = new System.Windows.Forms.RadioButton();
            this.checkedInRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weekendRadioBtn = new System.Windows.Forms.RadioButton();
            this.weekdayRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.agedRadioBtn = new System.Windows.Forms.RadioButton();
            this.adultRadioBtn = new System.Windows.Forms.RadioButton();
            this.childRadioBtn = new System.Windows.Forms.RadioButton();
            this.number_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshGridToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshGridToolStripMenuItem
            // 
            this.refreshGridToolStripMenuItem.Name = "refreshGridToolStripMenuItem";
            this.refreshGridToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.refreshGridToolStripMenuItem.Text = "Refresh Grid";
            this.refreshGridToolStripMenuItem.Click += new System.EventHandler(this.refreshGridToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyReportToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.dailyReportToolStripMenuItem.Text = "Daily Report";
            this.dailyReportToolStripMenuItem.Click += new System.EventHandler(this.dailyReportToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(321, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visitor Form";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(25, 531);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(752, 192);
            this.dataGridView.TabIndex = 86;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.duration_txt);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.grpMembers_dropdown);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.name_txt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.number_txt);
            this.groupBox1.Controls.Add(this.id_txt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 400);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.MintCream;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitBtn.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold);
            this.submitBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.submitBtn.Location = new System.Drawing.Point(521, 344);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(99, 41);
            this.submitBtn.TabIndex = 149;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click_1);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.MintCream;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.clearBtn.Location = new System.Drawing.Point(627, 344);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(99, 41);
            this.clearBtn.TabIndex = 148;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click_1);
            // 
            // duration_txt
            // 
            this.duration_txt.FormattingEnabled = true;
            this.duration_txt.Items.AddRange(new object[] {
            "30 Minutes",
            "1 Hour",
            "2 Hours",
            "3 Hours",
            "4 Hours",
            "5 Hours",
            "6 Hours",
            "7 Hours",
            "Unlimited"});
            this.duration_txt.Location = new System.Drawing.Point(541, 229);
            this.duration_txt.Name = "duration_txt";
            this.duration_txt.Size = new System.Drawing.Size(185, 21);
            this.duration_txt.TabIndex = 147;
            this.duration_txt.Text = "-- SELECT DURATION --";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(462, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 146;
            this.label13.Text = "Duration";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(541, 160);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker.TabIndex = 145;
            // 
            // grpMembers_dropdown
            // 
            this.grpMembers_dropdown.FormattingEnabled = true;
            this.grpMembers_dropdown.Items.AddRange(new object[] {
            "Individual",
            "Group of 3",
            "Group of 6",
            "Group of 10",
            "Group of 15",
            "Group of 20",
            "Group of 25",
            "Group of 30",
            "Group of 100",
            "Group of 200"});
            this.grpMembers_dropdown.Location = new System.Drawing.Point(541, 105);
            this.grpMembers_dropdown.Name = "grpMembers_dropdown";
            this.grpMembers_dropdown.Size = new System.Drawing.Size(185, 21);
            this.grpMembers_dropdown.TabIndex = 144;
            this.grpMembers_dropdown.Text = "-- GROUP MEMBERS --";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(541, 279);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(185, 33);
            this.price.TabIndex = 143;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(541, 34);
            this.name_txt.Multiline = true;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(185, 33);
            this.name_txt.TabIndex = 142;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(462, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 141;
            this.label12.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(462, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 140;
            this.label7.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(462, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 139;
            this.label5.Text = "Members";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(462, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 138;
            this.label3.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.checkedOutRadioBtn);
            this.groupBox3.Controls.Add(this.checkedInRadioBtn);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(113, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 46);
            this.groupBox3.TabIndex = 137;
            this.groupBox3.TabStop = false;
            // 
            // checkedOutRadioBtn
            // 
            this.checkedOutRadioBtn.AutoSize = true;
            this.checkedOutRadioBtn.Location = new System.Drawing.Point(136, 19);
            this.checkedOutRadioBtn.Name = "checkedOutRadioBtn";
            this.checkedOutRadioBtn.Size = new System.Drawing.Size(114, 20);
            this.checkedOutRadioBtn.TabIndex = 1;
            this.checkedOutRadioBtn.TabStop = true;
            this.checkedOutRadioBtn.Text = "Checked Out";
            this.checkedOutRadioBtn.UseVisualStyleBackColor = true;
            // 
            // checkedInRadioBtn
            // 
            this.checkedInRadioBtn.AutoSize = true;
            this.checkedInRadioBtn.Location = new System.Drawing.Point(18, 19);
            this.checkedInRadioBtn.Name = "checkedInRadioBtn";
            this.checkedInRadioBtn.Size = new System.Drawing.Size(103, 20);
            this.checkedInRadioBtn.TabIndex = 0;
            this.checkedInRadioBtn.TabStop = true;
            this.checkedInRadioBtn.Text = "Checked In";
            this.checkedInRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.weekendRadioBtn);
            this.groupBox2.Controls.Add(this.weekdayRadioBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(113, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 46);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            // 
            // weekendRadioBtn
            // 
            this.weekendRadioBtn.AutoSize = true;
            this.weekendRadioBtn.Location = new System.Drawing.Point(136, 16);
            this.weekendRadioBtn.Name = "weekendRadioBtn";
            this.weekendRadioBtn.Size = new System.Drawing.Size(168, 20);
            this.weekendRadioBtn.TabIndex = 1;
            this.weekendRadioBtn.TabStop = true;
            this.weekendRadioBtn.Text = "Weekend (Saturday)";
            this.weekendRadioBtn.UseVisualStyleBackColor = true;
            // 
            // weekdayRadioBtn
            // 
            this.weekdayRadioBtn.AutoSize = true;
            this.weekdayRadioBtn.Location = new System.Drawing.Point(18, 19);
            this.weekdayRadioBtn.Name = "weekdayRadioBtn";
            this.weekdayRadioBtn.Size = new System.Drawing.Size(100, 20);
            this.weekdayRadioBtn.TabIndex = 0;
            this.weekdayRadioBtn.TabStop = true;
            this.weekdayRadioBtn.Text = "Weekdays";
            this.weekdayRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.agedRadioBtn);
            this.groupBox4.Controls.Add(this.adultRadioBtn);
            this.groupBox4.Controls.Add(this.childRadioBtn);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(113, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 46);
            this.groupBox4.TabIndex = 135;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "age group";
            // 
            // agedRadioBtn
            // 
            this.agedRadioBtn.AutoSize = true;
            this.agedRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.agedRadioBtn.Location = new System.Drawing.Point(243, 19);
            this.agedRadioBtn.Name = "agedRadioBtn";
            this.agedRadioBtn.Size = new System.Drawing.Size(63, 20);
            this.agedRadioBtn.TabIndex = 2;
            this.agedRadioBtn.TabStop = true;
            this.agedRadioBtn.Text = "Aged";
            this.agedRadioBtn.UseVisualStyleBackColor = false;
            // 
            // adultRadioBtn
            // 
            this.adultRadioBtn.AutoSize = true;
            this.adultRadioBtn.Location = new System.Drawing.Point(120, 19);
            this.adultRadioBtn.Name = "adultRadioBtn";
            this.adultRadioBtn.Size = new System.Drawing.Size(61, 20);
            this.adultRadioBtn.TabIndex = 1;
            this.adultRadioBtn.TabStop = true;
            this.adultRadioBtn.Text = "Adult";
            this.adultRadioBtn.UseVisualStyleBackColor = true;
            // 
            // childRadioBtn
            // 
            this.childRadioBtn.AutoSize = true;
            this.childRadioBtn.Location = new System.Drawing.Point(18, 19);
            this.childRadioBtn.Name = "childRadioBtn";
            this.childRadioBtn.Size = new System.Drawing.Size(61, 20);
            this.childRadioBtn.TabIndex = 0;
            this.childRadioBtn.TabStop = true;
            this.childRadioBtn.Text = "Child";
            this.childRadioBtn.UseVisualStyleBackColor = true;
            // 
            // number_txt
            // 
            this.number_txt.Location = new System.Drawing.Point(119, 160);
            this.number_txt.Multiline = true;
            this.number_txt.Name = "number_txt";
            this.number_txt.Size = new System.Drawing.Size(181, 33);
            this.number_txt.TabIndex = 134;
            this.number_txt.TextChanged += new System.EventHandler(this.number_txt_TextChanged);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(113, 35);
            this.id_txt.Multiline = true;
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(181, 33);
            this.id_txt.TabIndex = 133;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(13, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 132;
            this.label11.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(13, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 131;
            this.label9.Text = "Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 130;
            this.label6.Text = "Visitor number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 129;
            this.label4.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 128;
            this.label2.Text = "Visiotr ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(334, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 28);
            this.label8.TabIndex = 150;
            this.label8.Text = "List of visitors";
            // 
            // visitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 735);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "visitorForm";
            this.Text = "visitorForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem refreshGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ComboBox duration_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox grpMembers_dropdown;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton checkedOutRadioBtn;
        private System.Windows.Forms.RadioButton checkedInRadioBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton weekendRadioBtn;
        private System.Windows.Forms.RadioButton weekdayRadioBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton agedRadioBtn;
        private System.Windows.Forms.RadioButton adultRadioBtn;
        private System.Windows.Forms.RadioButton childRadioBtn;
        private System.Windows.Forms.TextBox number_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}