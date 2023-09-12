namespace AlbumApplication.UI
{
    partial class AlbumList
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            lastaddeddv = new DataGridView();
            label2 = new Label();
            ongo = new DataGridView();
            label3 = new Label();
            notindv = new DataGridView();
            label4 = new Label();
            indiscountdv = new DataGridView();
            label5 = new Label();
            groupBox1 = new GroupBox();
            albumad = new Label();
            adtxt = new TextBox();
            artisttxt = new TextBox();
            label7 = new Label();
            pricetxt = new TextBox();
            label8 = new Label();
            label9 = new Label();
            discounttxt = new TextBox();
            label11 = new Label();
            label10 = new Label();
            checkBox1 = new CheckBox();
            addalbumbuton = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lastaddeddv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ongo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notindv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indiscountdv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Album List";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(441, 223);
            dataGridView1.TabIndex = 2;
            // 
            // lastaddeddv
            // 
            lastaddeddv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lastaddeddv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lastaddeddv.Location = new Point(12, 339);
            lastaddeddv.Name = "lastaddeddv";
            lastaddeddv.RowHeadersWidth = 51;
            lastaddeddv.RowTemplate.Height = 29;
            lastaddeddv.Size = new Size(441, 223);
            lastaddeddv.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 303);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "LastAdded";
            // 
            // ongo
            // 
            ongo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ongo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ongo.Location = new Point(507, 56);
            ongo.Name = "ongo";
            ongo.RowHeadersWidth = 51;
            ongo.RowTemplate.Height = 29;
            ongo.Size = new Size(441, 223);
            ongo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(507, 20);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 5;
            label3.Text = "Ongoing Sale";
            // 
            // notindv
            // 
            notindv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            notindv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notindv.Location = new Point(507, 339);
            notindv.Name = "notindv";
            notindv.RowHeadersWidth = 51;
            notindv.RowTemplate.Height = 29;
            notindv.Size = new Size(441, 223);
            notindv.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 303);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 8;
            label4.Text = "not in SALE";
            // 
            // indiscountdv
            // 
            indiscountdv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            indiscountdv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            indiscountdv.Location = new Point(991, 56);
            indiscountdv.Name = "indiscountdv";
            indiscountdv.RowHeadersWidth = 51;
            indiscountdv.RowTemplate.Height = 29;
            indiscountdv.Size = new Size(441, 223);
            indiscountdv.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(991, 20);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 10;
            label5.Text = "Discount Album";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(addalbumbuton);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(discounttxt);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(pricetxt);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(artisttxt);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(adtxt);
            groupBox1.Controls.Add(albumad);
            groupBox1.Location = new Point(991, 339);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 268);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD ALBUM";
            // 
            // albumad
            // 
            albumad.AutoSize = true;
            albumad.Location = new Point(23, 35);
            albumad.Name = "albumad";
            albumad.Size = new Size(49, 20);
            albumad.TabIndex = 0;
            albumad.Text = "Name";
            // 
            // adtxt
            // 
            adtxt.Location = new Point(161, 32);
            adtxt.Name = "adtxt";
            adtxt.Size = new Size(125, 27);
            adtxt.TabIndex = 1;
            // 
            // artisttxt
            // 
            artisttxt.Location = new Point(161, 61);
            artisttxt.Name = "artisttxt";
            artisttxt.Size = new Size(125, 27);
            artisttxt.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 68);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 2;
            label7.Text = "Artist";
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(161, 134);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(125, 27);
            pricetxt.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 170);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 6;
            label8.Text = "Discount Rate";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 101);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 4;
            label9.Text = "Release Date";
            // 
            // discounttxt
            // 
            discounttxt.AcceptsReturn = true;
            discounttxt.Location = new Point(161, 170);
            discounttxt.Name = "discounttxt";
            discounttxt.Size = new Size(125, 27);
            discounttxt.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 141);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 8;
            label11.Text = "Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 209);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 10;
            label10.Text = "SalesStatu";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(161, 209);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Sales";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // addalbumbuton
            // 
            addalbumbuton.Location = new Point(313, 209);
            addalbumbuton.Name = "addalbumbuton";
            addalbumbuton.Size = new Size(128, 39);
            addalbumbuton.TabIndex = 12;
            addalbumbuton.Text = "ADD ALBUM";
            addalbumbuton.UseVisualStyleBackColor = true;
            addalbumbuton.Click += addalbumbuton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(161, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // AlbumList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 643);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(indiscountdv);
            Controls.Add(label4);
            Controls.Add(notindv);
            Controls.Add(ongo);
            Controls.Add(label3);
            Controls.Add(lastaddeddv);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "AlbumList";
            Text = "AlbumList";
            Load += AlbumList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lastaddeddv).EndInit();
            ((System.ComponentModel.ISupportInitialize)ongo).EndInit();
            ((System.ComponentModel.ISupportInitialize)notindv).EndInit();
            ((System.ComponentModel.ISupportInitialize)indiscountdv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView lastaddeddv;
        private Label label2;
        private DataGridView ongo;
        private Label label3;
        private DataGridView notindv;
        private Label label4;
        private DataGridView indiscountdv;
        private Label label5;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Button addalbumbuton;
        private CheckBox checkBox1;
        private Label label10;
        private TextBox discounttxt;
        private Label label11;
        private TextBox pricetxt;
        private Label label8;
        private Label label9;
        private TextBox artisttxt;
        private Label label7;
        private TextBox adtxt;
        private Label albumad;
    }
}