namespace BookManagement.FormApp
{
    partial class GanresForm
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
            listBox1 = new ListBox();
            btnPrevious = new Button();
            btnNext = new Button();
            lblPageInfo = new Label();
            panel1 = new Panel();
            label1 = new Label();
            rdBtnDesc = new RadioButton();
            rdBtnAsc = new RadioButton();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(665, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(399, 480);
            listBox1.TabIndex = 0;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(690, 637);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(95, 59);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(809, 637);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(95, 59);
            btnNext.TabIndex = 2;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Location = new Point(931, 652);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(65, 28);
            lblPageInfo.TabIndex = 3;
            lblPageInfo.Text = "label1";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rdBtnDesc);
            panel1.Controls.Add(rdBtnAsc);
            panel1.Location = new Point(666, 565);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 56);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 17);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 2;
            label1.Text = "Sort: ";
            // 
            // rdBtnDesc
            // 
            rdBtnDesc.AutoSize = true;
            rdBtnDesc.Location = new Point(244, 13);
            rdBtnDesc.Name = "rdBtnDesc";
            rdBtnDesc.Size = new Size(74, 32);
            rdBtnDesc.TabIndex = 1;
            rdBtnDesc.TabStop = true;
            rdBtnDesc.Text = "Desc";
            rdBtnDesc.UseVisualStyleBackColor = true;
            rdBtnDesc.CheckedChanged += rdBtnDesc_CheckedChanged;
            // 
            // rdBtnAsc
            // 
            rdBtnAsc.AutoSize = true;
            rdBtnAsc.Location = new Point(143, 13);
            rdBtnAsc.Name = "rdBtnAsc";
            rdBtnAsc.Size = new Size(63, 32);
            rdBtnAsc.TabIndex = 0;
            rdBtnAsc.TabStop = true;
            rdBtnAsc.Text = "Asc";
            rdBtnAsc.UseVisualStyleBackColor = true;
            rdBtnAsc.CheckedChanged += rdBtnAsc_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5", "10", "15", "20" });
            comboBox1.Location = new Point(1019, 644);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(69, 36);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // GanresForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 718);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(lblPageInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "GanresForm";
            Text = "GanresForm";
            Load += GanresForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblPageInfo;
        private Panel panel1;
        private RadioButton rdBtnDesc;
        private RadioButton rdBtnAsc;
        private Label label1;
        private ComboBox comboBox1;
    }
}