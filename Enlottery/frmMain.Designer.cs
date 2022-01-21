using System.ComponentModel;
using System.Windows.Forms;

namespace Enlottery
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t4n = new System.Windows.Forms.Label();
            this.t3n = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.Label();
            this.t2n = new System.Windows.Forms.Label();
            this.t1n = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Label();
            this.picThousand = new System.Windows.Forms.PictureBox();
            this.picTenThousand = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.f1n = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.s2n = new System.Windows.Forms.Label();
            this.s1n = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.picUnits = new System.Windows.Forms.PictureBox();
            this.picTens = new System.Windows.Forms.PictureBox();
            this.picHundreds = new System.Windows.Forms.PictureBox();
            this.imgListTens = new System.Windows.Forms.ImageList(this.components);
            this.imgListHundreds = new System.Windows.Forms.ImageList(this.components);
            this.imgListUnits = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThousand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenThousand)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHundreds)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.64312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.41264F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.8513F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1504, 91);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(509, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(466, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "EnLottery";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Enlottery.Properties.Resources.Enlab_Primary_Logo_Horizontal_On_Dark_4x__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(981, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(520, 91);
            this.label2.TabIndex = 0;
            this.label2.Text = "v2.0 - 2018 © Luc Nguyen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.picThousand);
            this.panel1.Controls.Add(this.picTenThousand);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.picUnits);
            this.panel1.Controls.Add(this.picTens);
            this.panel1.Controls.Add(this.picHundreds);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 820);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t4n);
            this.groupBox1.Controls.Add(this.t3n);
            this.groupBox1.Controls.Add(this.t4);
            this.groupBox1.Controls.Add(this.t3);
            this.groupBox1.Controls.Add(this.t2n);
            this.groupBox1.Controls.Add(this.t1n);
            this.groupBox1.Controls.Add(this.t2);
            this.groupBox1.Controls.Add(this.t1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(759, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 302);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Third Prize";
            // 
            // t4n
            // 
            this.t4n.AutoSize = true;
            this.t4n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4n.ForeColor = System.Drawing.Color.Maroon;
            this.t4n.Location = new System.Drawing.Point(136, 243);
            this.t4n.Name = "t4n";
            this.t4n.Size = new System.Drawing.Size(336, 56);
            this.t4n.TabIndex = 15;
            this.t4n.Text = "________________________";
            this.t4n.Visible = false;
            // 
            // t3n
            // 
            this.t3n.AutoSize = true;
            this.t3n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3n.ForeColor = System.Drawing.Color.Maroon;
            this.t3n.Location = new System.Drawing.Point(136, 180);
            this.t3n.Name = "t3n";
            this.t3n.Size = new System.Drawing.Size(336, 56);
            this.t3n.TabIndex = 14;
            this.t3n.Text = "________________________";
            this.t3n.Visible = false;
            // 
            // t4
            // 
            this.t4.AutoSize = true;
            this.t4.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.t4.Location = new System.Drawing.Point(6, 243);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(139, 56);
            this.t4.TabIndex = 13;
            this.t4.Text = "XXXXX";
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.t3.Location = new System.Drawing.Point(6, 180);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(139, 56);
            this.t3.TabIndex = 12;
            this.t3.Text = "XXXXX";
            // 
            // t2n
            // 
            this.t2n.AutoSize = true;
            this.t2n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2n.ForeColor = System.Drawing.Color.Maroon;
            this.t2n.Location = new System.Drawing.Point(136, 120);
            this.t2n.Name = "t2n";
            this.t2n.Size = new System.Drawing.Size(336, 56);
            this.t2n.TabIndex = 11;
            this.t2n.Text = "________________________";
            this.t2n.Visible = false;
            // 
            // t1n
            // 
            this.t1n.AutoSize = true;
            this.t1n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1n.ForeColor = System.Drawing.Color.Maroon;
            this.t1n.Location = new System.Drawing.Point(136, 53);
            this.t1n.Name = "t1n";
            this.t1n.Size = new System.Drawing.Size(336, 56);
            this.t1n.TabIndex = 10;
            this.t1n.Text = "________________________";
            this.t1n.Visible = false;
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.t2.Location = new System.Drawing.Point(6, 120);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(139, 56);
            this.t2.TabIndex = 7;
            this.t2.Text = "XXXXX";
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.t1.Location = new System.Drawing.Point(6, 53);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(139, 56);
            this.t1.TabIndex = 6;
            this.t1.Text = "XXXXX";
            // 
            // picThousand
            // 
            this.picThousand.Image = global::Enlottery.Properties.Resources.num0;
            this.picThousand.InitialImage = null;
            this.picThousand.Location = new System.Drawing.Point(344, 30);
            this.picThousand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picThousand.Name = "picThousand";
            this.picThousand.Size = new System.Drawing.Size(268, 338);
            this.picThousand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThousand.TabIndex = 17;
            this.picThousand.TabStop = false;
            // 
            // picTenThousand
            // 
            this.picTenThousand.Image = global::Enlottery.Properties.Resources.num0;
            this.picTenThousand.InitialImage = null;
            this.picTenThousand.Location = new System.Drawing.Point(68, 30);
            this.picTenThousand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTenThousand.Name = "picTenThousand";
            this.picTenThousand.Size = new System.Drawing.Size(268, 338);
            this.picTenThousand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTenThousand.TabIndex = 16;
            this.picTenThousand.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.f1n);
            this.groupBox3.Controls.Add(this.f1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(29, 492);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 114);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "First Prize";
            // 
            // f1n
            // 
            this.f1n.AutoSize = true;
            this.f1n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1n.ForeColor = System.Drawing.Color.Maroon;
            this.f1n.Location = new System.Drawing.Point(136, 41);
            this.f1n.Name = "f1n";
            this.f1n.Size = new System.Drawing.Size(336, 56);
            this.f1n.TabIndex = 9;
            this.f1n.Text = "________________________";
            this.f1n.Visible = false;
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.f1.Location = new System.Drawing.Point(6, 41);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(139, 56);
            this.f1.TabIndex = 5;
            this.f1.Text = "XXXXX";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.s2n);
            this.groupBox2.Controls.Add(this.s1n);
            this.groupBox2.Controls.Add(this.s2);
            this.groupBox2.Controls.Add(this.s1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(29, 624);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 170);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Second Prize";
            // 
            // s2n
            // 
            this.s2n.AutoSize = true;
            this.s2n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s2n.ForeColor = System.Drawing.Color.Maroon;
            this.s2n.Location = new System.Drawing.Point(136, 111);
            this.s2n.Name = "s2n";
            this.s2n.Size = new System.Drawing.Size(336, 56);
            this.s2n.TabIndex = 11;
            this.s2n.Text = "________________________";
            this.s2n.Visible = false;
            // 
            // s1n
            // 
            this.s1n.AutoSize = true;
            this.s1n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s1n.ForeColor = System.Drawing.Color.Maroon;
            this.s1n.Location = new System.Drawing.Point(136, 48);
            this.s1n.Name = "s1n";
            this.s1n.Size = new System.Drawing.Size(336, 56);
            this.s1n.TabIndex = 10;
            this.s1n.Text = "________________________";
            this.s1n.Visible = false;
            // 
            // s2
            // 
            this.s2.AutoSize = true;
            this.s2.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.s2.Location = new System.Drawing.Point(6, 111);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(139, 56);
            this.s2.TabIndex = 7;
            this.s2.Text = "XXXXX";
            // 
            // s1
            // 
            this.s1.AutoSize = true;
            this.s1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.s1.Location = new System.Drawing.Point(6, 48);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(139, 56);
            this.s1.TabIndex = 6;
            this.s1.Text = "XXXXX";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.Location = new System.Drawing.Point(524, 391);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(466, 80);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "GO";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // picUnits
            // 
            this.picUnits.Image = global::Enlottery.Properties.Resources.num0;
            this.picUnits.InitialImage = null;
            this.picUnits.Location = new System.Drawing.Point(1162, 30);
            this.picUnits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picUnits.Name = "picUnits";
            this.picUnits.Size = new System.Drawing.Size(268, 338);
            this.picUnits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUnits.TabIndex = 3;
            this.picUnits.TabStop = false;
            // 
            // picTens
            // 
            this.picTens.Image = global::Enlottery.Properties.Resources.num0;
            this.picTens.InitialImage = global::Enlottery.Properties.Resources.num0;
            this.picTens.Location = new System.Drawing.Point(909, 30);
            this.picTens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTens.Name = "picTens";
            this.picTens.Size = new System.Drawing.Size(245, 338);
            this.picTens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTens.TabIndex = 4;
            this.picTens.TabStop = false;
            // 
            // picHundreds
            // 
            this.picHundreds.Image = global::Enlottery.Properties.Resources.num0;
            this.picHundreds.InitialImage = global::Enlottery.Properties.Resources.num0;
            this.picHundreds.Location = new System.Drawing.Point(620, 30);
            this.picHundreds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picHundreds.Name = "picHundreds";
            this.picHundreds.Size = new System.Drawing.Size(281, 338);
            this.picHundreds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHundreds.TabIndex = 5;
            this.picHundreds.TabStop = false;
            // 
            // imgListTens
            // 
            this.imgListTens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListTens.ImageStream")));
            this.imgListTens.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListTens.Images.SetKeyName(0, "num2.png");
            this.imgListTens.Images.SetKeyName(1, "num8.png");
            this.imgListTens.Images.SetKeyName(2, "num0.png");
            this.imgListTens.Images.SetKeyName(3, "num5.png");
            this.imgListTens.Images.SetKeyName(4, "num1.png");
            this.imgListTens.Images.SetKeyName(5, "num6.png");
            this.imgListTens.Images.SetKeyName(6, "num9.png");
            this.imgListTens.Images.SetKeyName(7, "num3.png");
            this.imgListTens.Images.SetKeyName(8, "num7.png");
            this.imgListTens.Images.SetKeyName(9, "num4.png");
            // 
            // imgListHundreds
            // 
            this.imgListHundreds.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListHundreds.ImageStream")));
            this.imgListHundreds.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListHundreds.Images.SetKeyName(0, "num0.png");
            this.imgListHundreds.Images.SetKeyName(1, "num6.png");
            this.imgListHundreds.Images.SetKeyName(2, "num2.png");
            this.imgListHundreds.Images.SetKeyName(3, "num1.png");
            this.imgListHundreds.Images.SetKeyName(4, "num5.png");
            this.imgListHundreds.Images.SetKeyName(5, "num8.png");
            this.imgListHundreds.Images.SetKeyName(6, "num3.png");
            this.imgListHundreds.Images.SetKeyName(7, "num9.png");
            this.imgListHundreds.Images.SetKeyName(8, "num7.png");
            this.imgListHundreds.Images.SetKeyName(9, "num4.png");
            // 
            // imgListUnits
            // 
            this.imgListUnits.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListUnits.ImageStream")));
            this.imgListUnits.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListUnits.Images.SetKeyName(0, "num1.png");
            this.imgListUnits.Images.SetKeyName(1, "num3.png");
            this.imgListUnits.Images.SetKeyName(2, "num2.png");
            this.imgListUnits.Images.SetKeyName(3, "num7.png");
            this.imgListUnits.Images.SetKeyName(4, "num4.png");
            this.imgListUnits.Images.SetKeyName(5, "num9.png");
            this.imgListUnits.Images.SetKeyName(6, "num6.png");
            this.imgListUnits.Images.SetKeyName(7, "num0.png");
            this.imgListUnits.Images.SetKeyName(8, "num5.png");
            this.imgListUnits.Images.SetKeyName(9, "num8.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 911);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1520, 950);
            this.MinimumSize = new System.Drawing.Size(1520, 950);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enlottery";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThousand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenThousand)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHundreds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnGenerate;
        private PictureBox picUnits;
        private PictureBox picTens;
        private PictureBox picHundreds;
        private ImageList imgListUnits;
        private ImageList imgListTens;
        private ImageList imgListHundreds;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox3;
        private Label f1n;
        private Label f1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label t4n;
        private Label t3n;
        private Label t4;
        private Label t3;
        private Label t2n;
        private Label t1n;
        private Label t2;
        private Label t1;
        private PictureBox picThousand;
        private PictureBox picTenThousand;
        private Label s2n;
        private Label s1n;
        private Label s2;
        private Label s1;
        private Label label1;
    }
}

