namespace crud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 59);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(257, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(319, 16);
            label1.Name = "label1";
            label1.Size = new Size(212, 28);
            label1.TabIndex = 0;
            label1.Text = "Inventory System";
            label1.Click += label1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(53, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(564, 253);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Product Name";
            Column1.Name = "Column1";
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(171, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(629, 322);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(-1, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 322);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 114);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 85);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 7;
            label3.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 56);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 6;
            label2.Text = "Product Name:";
            label2.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(113, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 379);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
