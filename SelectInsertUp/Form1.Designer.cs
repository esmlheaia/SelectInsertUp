namespace SelectInsertUp
{
    partial class FrmClubRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.cmbprogram = new System.Windows.Forms.ComboBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.datalist = new System.Windows.Forms.DataGridView();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datalist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Middle Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "List Club of Member:";
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(58, 87);
            this.txtstudentid.Multiline = true;
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(222, 27);
            this.txtstudentid.TabIndex = 8;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(58, 167);
            this.txtlastname.Multiline = true;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(222, 27);
            this.txtlastname.TabIndex = 9;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(323, 167);
            this.txtfirstname.Multiline = true;
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(222, 27);
            this.txtfirstname.TabIndex = 10;
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.Location = new System.Drawing.Point(593, 167);
            this.txtmiddlename.Multiline = true;
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(222, 27);
            this.txtmiddlename.TabIndex = 11;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(58, 255);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(81, 27);
            this.txtage.TabIndex = 12;
            // 
            // cmbprogram
            // 
            this.cmbprogram.FormattingEnabled = true;
            this.cmbprogram.Location = new System.Drawing.Point(461, 93);
            this.cmbprogram.Name = "cmbprogram";
            this.cmbprogram.Size = new System.Drawing.Size(289, 21);
            this.cmbprogram.TabIndex = 13;
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Location = new System.Drawing.Point(371, 255);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(121, 21);
            this.cmbgender.TabIndex = 14;
            // 
            // datalist
            // 
            this.datalist.BackgroundColor = System.Drawing.Color.Azure;
            this.datalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalist.Location = new System.Drawing.Point(58, 339);
            this.datalist.Name = "datalist";
            this.datalist.Size = new System.Drawing.Size(763, 173);
            this.datalist.TabIndex = 15;
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.AliceBlue;
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(852, 91);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 36);
            this.btnregister.TabIndex = 16;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.AliceBlue;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(852, 133);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 36);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.AliceBlue;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(852, 339);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 36);
            this.btnrefresh.TabIndex = 18;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // FrmClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SelectInsertUp.Properties.Resources.Blue_Modern_Notes_Linktree_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 566);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.datalist);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.cmbprogram);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtmiddlename);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmClubRegistration";
            this.Text = "FrmClubRegistration";
            this.Load += new System.EventHandler(this.FrmClubRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.ComboBox cmbprogram;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.DataGridView datalist;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnrefresh;
    }
}

