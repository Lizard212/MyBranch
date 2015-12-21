namespace LearnNewWords
{
    partial class formWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formWord));
            this.dgvListWordGroup = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtAddGroup = new System.Windows.Forms.TextBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.txtPhonetic = new System.Windows.Forms.TextBox();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.comboBoxWordGroup = new System.Windows.Forms.ComboBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnClearText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListWord = new System.Windows.Forms.DataGridView();
            this.list_words = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select_group = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListWordGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListWord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListWordGroup
            // 
            this.dgvListWordGroup.AllowUserToAddRows = false;
            this.dgvListWordGroup.AllowUserToDeleteRows = false;
            this.dgvListWordGroup.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            this.dgvListWordGroup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListWordGroup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(254)))));
            this.dgvListWordGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListWordGroup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListWordGroup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(14)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListWordGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListWordGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListWordGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_group,
            this.name_group,
            this.select_group});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListWordGroup.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListWordGroup.GridColor = System.Drawing.Color.Black;
            this.dgvListWordGroup.Location = new System.Drawing.Point(3, 71);
            this.dgvListWordGroup.MultiSelect = false;
            this.dgvListWordGroup.Name = "dgvListWordGroup";
            this.dgvListWordGroup.RowHeadersVisible = false;
            this.dgvListWordGroup.Size = new System.Drawing.Size(256, 385);
            this.dgvListWordGroup.TabIndex = 0;
            this.dgvListWordGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListWordGroup_CellClick);
            this.dgvListWordGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListWordGroup_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(44, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 15);
            this.txtSearch.TabIndex = 1;
            // 
            // txtAddGroup
            // 
            this.txtAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddGroup.Location = new System.Drawing.Point(12, 462);
            this.txtAddGroup.Name = "txtAddGroup";
            this.txtAddGroup.Size = new System.Drawing.Size(247, 26);
            this.txtAddGroup.TabIndex = 1;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(76, 494);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(90, 40);
            this.btnAddGroup.TabIndex = 2;
            this.btnAddGroup.Text = "Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(613, 113);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(265, 20);
            this.txtWord.TabIndex = 5;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(613, 153);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(265, 20);
            this.txtCategory.TabIndex = 5;
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(613, 234);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(265, 20);
            this.txtMean.TabIndex = 5;
            // 
            // txtPhonetic
            // 
            this.txtPhonetic.Location = new System.Drawing.Point(613, 194);
            this.txtPhonetic.Name = "txtPhonetic";
            this.txtPhonetic.Size = new System.Drawing.Size(265, 20);
            this.txtPhonetic.TabIndex = 5;
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(613, 282);
            this.txtSentence.Multiline = true;
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(265, 65);
            this.txtSentence.TabIndex = 5;
            // 
            // comboBoxWordGroup
            // 
            this.comboBoxWordGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWordGroup.FormattingEnabled = true;
            this.comboBoxWordGroup.Location = new System.Drawing.Point(613, 71);
            this.comboBoxWordGroup.Name = "comboBoxWordGroup";
            this.comboBoxWordGroup.Size = new System.Drawing.Size(265, 21);
            this.comboBoxWordGroup.TabIndex = 6;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(613, 383);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(90, 40);
            this.btnAddWord.TabIndex = 7;
            this.btnAddWord.Text = "Add";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(770, 383);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(90, 40);
            this.btnClearText.TabIndex = 7;
            this.btnClearText.Text = "Clear";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phonetic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sentence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mean";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Category";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 25);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Word";
            // 
            // dgvListWord
            // 
            this.dgvListWord.AllowUserToAddRows = false;
            this.dgvListWord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(254)))));
            this.dgvListWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListWord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.list_words});
            this.dgvListWord.Location = new System.Drawing.Point(265, 71);
            this.dgvListWord.Name = "dgvListWord";
            this.dgvListWord.ReadOnly = true;
            this.dgvListWord.RowHeadersVisible = false;
            this.dgvListWord.Size = new System.Drawing.Size(250, 470);
            this.dgvListWord.TabIndex = 10;
            // 
            // list_words
            // 
            this.list_words.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.list_words.HeaderText = "";
            this.list_words.Name = "list_words";
            this.list_words.ReadOnly = true;
            // 
            // num_group
            // 
            this.num_group.HeaderText = "";
            this.num_group.Name = "num_group";
            this.num_group.ReadOnly = true;
            this.num_group.Width = 30;
            // 
            // name_group
            // 
            this.name_group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_group.HeaderText = "Word group";
            this.name_group.Name = "name_group";
            this.name_group.ReadOnly = true;
            // 
            // select_group
            // 
            this.select_group.HeaderText = "Select";
            this.select_group.Name = "select_group";
            this.select_group.Width = 80;
            // 
            // formWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(163)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(907, 541);
            this.Controls.Add(this.dgvListWord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.comboBoxWordGroup);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.txtPhonetic);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.txtAddGroup);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvListWordGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formWord";
            this.Text = "T_WORD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListWordGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListWordGroup;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtAddGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.TextBox txtPhonetic;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.ComboBox comboBoxWordGroup;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_words;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_group;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select_group;
    }
}

