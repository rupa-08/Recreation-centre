
namespace Coursework1
{
    partial class settingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.settingGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agedRadioBtn = new System.Windows.Forms.RadioButton();
            this.adultRadioBtn = new System.Windows.Forms.RadioButton();
            this.childRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.weekendRadioBtn = new System.Windows.Forms.RadioButton();
            this.weekdayRadioBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.duration_txt = new System.Windows.Forms.ComboBox();
            this.grpMembers_dropdown = new System.Windows.Forms.ComboBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorFromToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // visitorFromToolStripMenuItem
            // 
            this.visitorFromToolStripMenuItem.Name = "visitorFromToolStripMenuItem";
            this.visitorFromToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.visitorFromToolStripMenuItem.Text = "Visitor from";
            this.visitorFromToolStripMenuItem.Click += new System.EventHandler(this.visitorFromToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.logOutToolStripMenuItem.Text = "Refresh grid";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.logOutToolStripMenuItem1.Text = "Log out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem,
            this.chartToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.gridToolStripMenuItem.Text = "Daily";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem1,
            this.chartToolStripMenuItem1});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.chartToolStripMenuItem.Text = "Weekly";
            // 
            // gridToolStripMenuItem1
            // 
            this.gridToolStripMenuItem1.Name = "gridToolStripMenuItem1";
            this.gridToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.gridToolStripMenuItem1.Text = "Grid";
            this.gridToolStripMenuItem1.Click += new System.EventHandler(this.gridToolStripMenuItem1_Click);
            // 
            // chartToolStripMenuItem1
            // 
            this.chartToolStripMenuItem1.Name = "chartToolStripMenuItem1";
            this.chartToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.chartToolStripMenuItem1.Text = "Chart";
            this.chartToolStripMenuItem1.Click += new System.EventHandler(this.chartToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(164, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ticket Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(657, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "List of tickets";
            // 
            // settingGridView
            // 
            this.settingGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.settingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.settingGridView.Location = new System.Drawing.Point(508, 67);
            this.settingGridView.Name = "settingGridView";
            this.settingGridView.Size = new System.Drawing.Size(474, 342);
            this.settingGridView.TabIndex = 126;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.price_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Controls.Add(this.duration_txt);
            this.groupBox1.Controls.Add(this.grpMembers_dropdown);
            this.groupBox1.Controls.Add(this.id_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 342);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(327, 227);
            this.price_txt.Multiline = true;
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(137, 33);
            this.price_txt.TabIndex = 148;
            this.price_txt.TextChanged += new System.EventHandler(this.price_txt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(10, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 147;
            this.label8.Text = " Age group";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.agedRadioBtn);
            this.groupBox2.Controls.Add(this.adultRadioBtn);
            this.groupBox2.Controls.Add(this.childRadioBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(102, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 46);
            this.groupBox2.TabIndex = 146;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "age group";
            // 
            // agedRadioBtn
            // 
            this.agedRadioBtn.AutoSize = true;
            this.agedRadioBtn.Location = new System.Drawing.Point(243, 19);
            this.agedRadioBtn.Name = "agedRadioBtn";
            this.agedRadioBtn.Size = new System.Drawing.Size(63, 20);
            this.agedRadioBtn.TabIndex = 2;
            this.agedRadioBtn.TabStop = true;
            this.agedRadioBtn.Text = "Aged";
            this.agedRadioBtn.UseVisualStyleBackColor = true;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.weekendRadioBtn);
            this.groupBox3.Controls.Add(this.weekdayRadioBtn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(102, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 46);
            this.groupBox3.TabIndex = 145;
            this.groupBox3.TabStop = false;
            // 
            // weekendRadioBtn
            // 
            this.weekendRadioBtn.AutoSize = true;
            this.weekendRadioBtn.Location = new System.Drawing.Point(136, 19);
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
            this.weekdayRadioBtn.Location = new System.Drawing.Point(18, 16);
            this.weekdayRadioBtn.Name = "weekdayRadioBtn";
            this.weekdayRadioBtn.Size = new System.Drawing.Size(100, 20);
            this.weekdayRadioBtn.TabIndex = 0;
            this.weekdayRadioBtn.TabStop = true;
            this.weekdayRadioBtn.Text = "Weekdays";
            this.weekdayRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(13, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 144;
            this.label7.Text = "Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(269, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 143;
            this.label6.Text = "Price";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.MintCream;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.clearBtn.Location = new System.Drawing.Point(238, 282);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(99, 41);
            this.clearBtn.TabIndex = 142;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click_1);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.MintCream;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitBtn.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold);
            this.submitBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.submitBtn.Location = new System.Drawing.Point(365, 282);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(99, 41);
            this.submitBtn.TabIndex = 141;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click_1);
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
            this.duration_txt.Location = new System.Drawing.Point(102, 239);
            this.duration_txt.Name = "duration_txt";
            this.duration_txt.Size = new System.Drawing.Size(137, 21);
            this.duration_txt.TabIndex = 140;
            this.duration_txt.Text = "-- SELECT DURATION --";
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
            this.grpMembers_dropdown.Location = new System.Drawing.Point(319, 37);
            this.grpMembers_dropdown.Name = "grpMembers_dropdown";
            this.grpMembers_dropdown.Size = new System.Drawing.Size(139, 21);
            this.grpMembers_dropdown.TabIndex = 139;
            this.grpMembers_dropdown.Text = "-- GROUP MEMBERS --";
            this.grpMembers_dropdown.SelectedIndexChanged += new System.EventHandler(this.grpMembers_dropdown_SelectedIndexChanged);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(102, 33);
            this.id_txt.Multiline = true;
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(137, 33);
            this.id_txt.TabIndex = 138;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(10, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 137;
            this.label5.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(263, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 136;
            this.label4.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 135;
            this.label3.Text = "Ticket ID";
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.settingGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "settingForm";
            this.Text = "settingForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView settingGridView;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton agedRadioBtn;
        private System.Windows.Forms.RadioButton adultRadioBtn;
        private System.Windows.Forms.RadioButton childRadioBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton weekendRadioBtn;
        private System.Windows.Forms.RadioButton weekdayRadioBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ComboBox duration_txt;
        private System.Windows.Forms.ComboBox grpMembers_dropdown;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}