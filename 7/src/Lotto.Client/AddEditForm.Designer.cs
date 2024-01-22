namespace Lotto.Client
{
    partial class AddEditForm
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlCountry = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBalls = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbWon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbProfit = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Checked = false;
            this.date.Location = new System.Drawing.Point(94, 16);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(129, 20);
            this.date.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date";
            // 
            // ddlType
            // 
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Items.AddRange(new object[] {
            "a5of35",
            "a6of45"});
            this.ddlType.Location = new System.Drawing.Point(94, 43);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(121, 21);
            this.ddlType.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Country";
            // 
            // ddlCountry
            // 
            this.ddlCountry.FormattingEnabled = true;
            this.ddlCountry.Items.AddRange(new object[] {
            "By",
            "Ru"});
            this.ddlCountry.Location = new System.Drawing.Point(94, 70);
            this.ddlCountry.Name = "ddlCountry";
            this.ddlCountry.Size = new System.Drawing.Size(121, 21);
            this.ddlCountry.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Balls";
            // 
            // tbBalls
            // 
            this.tbBalls.Location = new System.Drawing.Point(94, 97);
            this.tbBalls.Name = "tbBalls";
            this.tbBalls.Size = new System.Drawing.Size(121, 20);
            this.tbBalls.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Won";
            // 
            // tbWon
            // 
            this.tbWon.Location = new System.Drawing.Point(94, 123);
            this.tbWon.Name = "tbWon";
            this.tbWon.Size = new System.Drawing.Size(121, 20);
            this.tbWon.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Profit";
            // 
            // tbProfit
            // 
            this.tbProfit.Location = new System.Drawing.Point(94, 149);
            this.tbProfit.Name = "tbProfit";
            this.tbProfit.Size = new System.Drawing.Size(121, 20);
            this.tbProfit.TabIndex = 20;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(148, 184);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 22;
            this.btnFind.Text = "Save";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFindClick);
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 223);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbProfit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbWon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBalls);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddlCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Name = "AddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBalls;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbWon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProfit;
        private System.Windows.Forms.Button btnFind;
    }
}