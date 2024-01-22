namespace Lotto.Client
{
    partial class LottoView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("By");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ru");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("All countries", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("a5of35");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("a6of45");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("All types", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.lwData = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.Country = new System.Windows.Forms.ColumnHeader();
            this.Balls = new System.Windows.Forms.ColumnHeader();
            this.Won = new System.Windows.Forms.ColumnHeader();
            this.Profit = new System.Windows.Forms.ColumnHeader();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.btnFind = new System.Windows.Forms.Button();
            this.tdId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tstSelectedItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lwData
            // 
            this.lwData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lwData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Date,
            this.Type,
            this.Country,
            this.Balls,
            this.Won,
            this.Profit});
            this.lwData.Location = new System.Drawing.Point(122, 73);
            this.lwData.Name = "lwData";
            this.lwData.Size = new System.Drawing.Size(625, 295);
            this.lwData.TabIndex = 1;
            this.lwData.UseCompatibleStateImageBehavior = false;
            this.lwData.View = System.Windows.Forms.View.Details;
            this.lwData.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LwDataColumnClick);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 118;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.Width = 76;
            // 
            // Balls
            // 
            this.Balls.Text = "Balls";
            this.Balls.Width = 111;
            // 
            // Won
            // 
            this.Won.Text = "Won";
            this.Won.Width = 93;
            // 
            // Profit
            // 
            this.Profit.Text = "Profit";
            this.Profit.Width = 104;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 73);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "By";
            treeNode1.Text = "By";
            treeNode2.Name = "Ru";
            treeNode2.Text = "Ru";
            treeNode3.Name = "Country";
            treeNode3.Text = "All countries";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(92, 54);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(12, 142);
            this.treeView2.Name = "treeView2";
            treeNode4.Name = "a5of35";
            treeNode4.Text = "a5of35";
            treeNode5.Name = "a6of45";
            treeNode5.Text = "a6of45";
            treeNode6.Name = "Types";
            treeNode6.Text = "All types";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView2.Size = new System.Drawing.Size(92, 54);
            this.treeView2.TabIndex = 3;
            this.treeView2.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView2_NodeMouseDoubleClick);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(645, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tdId
            // 
            this.tdId.Location = new System.Drawing.Point(96, 16);
            this.tdId.Name = "tdId";
            this.tdId.Size = new System.Drawing.Size(41, 20);
            this.tdId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // dateStart
            // 
            this.dateStart.Checked = false;
            this.dateStart.Location = new System.Drawing.Point(253, 17);
            this.dateStart.Name = "dateStart";
            this.dateStart.ShowCheckBox = true;
            this.dateStart.Size = new System.Drawing.Size(129, 20);
            this.dateStart.TabIndex = 7;
            // 
            // dateEnd
            // 
            this.dateEnd.Checked = false;
            this.dateEnd.Location = new System.Drawing.Point(456, 18);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.ShowCheckBox = true;
            this.dateEnd.Size = new System.Drawing.Size(129, 20);
            this.dateEnd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Min date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Max date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tdId);
            this.groupBox1.Controls.Add(this.dateEnd);
            this.groupBox1.Controls.Add(this.dateStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 55);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(510, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(591, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(672, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tstSelectedItem
            // 
            this.tstSelectedItem.Name = "tstSelectedItem";
            this.tstSelectedItem.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstSelectedItem});
            this.statusStrip.Location = new System.Drawing.Point(0, 408);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(759, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // LottoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 430);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lwData);
            this.Controls.Add(this.statusStrip);
            this.Name = "LottoView";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwData;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader Balls;
        private System.Windows.Forms.ColumnHeader Won;
        private System.Windows.Forms.ColumnHeader Profit;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tdId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripStatusLabel tstSelectedItem;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}

