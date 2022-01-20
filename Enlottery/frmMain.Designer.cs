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
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.f3n = new System.Windows.Forms.Label();
			this.f2n = new System.Windows.Forms.Label();
			this.f1n = new System.Windows.Forms.Label();
			this.f3 = new System.Windows.Forms.Label();
			this.f2 = new System.Windows.Forms.Label();
			this.f1 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.spn = new System.Windows.Forms.Label();
			this.sp1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.s5n = new System.Windows.Forms.Label();
			this.s4n = new System.Windows.Forms.Label();
			this.s3n = new System.Windows.Forms.Label();
			this.s2n = new System.Windows.Forms.Label();
			this.s1n = new System.Windows.Forms.Label();
			this.s5 = new System.Windows.Forms.Label();
			this.s4 = new System.Windows.Forms.Label();
			this.s3 = new System.Windows.Forms.Label();
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
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
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
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.AliceBlue;
			this.label2.Location = new System.Drawing.Point(509, 0);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.label2.Size = new System.Drawing.Size(310, 85);
			this.label2.TabIndex = 0;
			this.label2.Text = "EnLottery";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(250, 85);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.btnGenerate);
			this.panel1.Controls.Add(this.picUnits);
			this.panel1.Controls.Add(this.picTens);
			this.panel1.Controls.Add(this.picHundreds);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 91);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1504, 652);
			this.panel1.TabIndex = 2;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.f3n);
			this.groupBox3.Controls.Add(this.f2n);
			this.groupBox3.Controls.Add(this.f1n);
			this.groupBox3.Controls.Add(this.f3);
			this.groupBox3.Controls.Add(this.f2);
			this.groupBox3.Controls.Add(this.f1);
			this.groupBox3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
			this.groupBox3.Location = new System.Drawing.Point(1053, 398);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(307, 231);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "First Prize";
			// 
			// f3n
			// 
			this.f3n.AutoSize = true;
			this.f3n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.f3n.ForeColor = System.Drawing.Color.Maroon;
			this.f3n.Location = new System.Drawing.Point(115, 171);
			this.f3n.Name = "f3n";
			this.f3n.Size = new System.Drawing.Size(180, 56);
			this.f3n.TabIndex = 11;
			this.f3n.Text = "____________";
			// 
			// f2n
			// 
			this.f2n.AutoSize = true;
			this.f2n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.f2n.ForeColor = System.Drawing.Color.Maroon;
			this.f2n.Location = new System.Drawing.Point(114, 106);
			this.f2n.Name = "f2n";
			this.f2n.Size = new System.Drawing.Size(180, 56);
			this.f2n.TabIndex = 10;
			this.f2n.Text = "____________";
			// 
			// f1n
			// 
			this.f1n.AutoSize = true;
			this.f1n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.f1n.ForeColor = System.Drawing.Color.Maroon;
			this.f1n.Location = new System.Drawing.Point(115, 41);
			this.f1n.Name = "f1n";
			this.f1n.Size = new System.Drawing.Size(180, 56);
			this.f1n.TabIndex = 9;
			this.f1n.Text = "____________";
			// 
			// f3
			// 
			this.f3.AutoSize = true;
			this.f3.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.f3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.f3.Location = new System.Drawing.Point(16, 171);
			this.f3.Name = "f3";
			this.f3.Size = new System.Drawing.Size(93, 56);
			this.f3.TabIndex = 8;
			this.f3.Text = "XXX";
			// 
			// f2
			// 
			this.f2.AutoSize = true;
			this.f2.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.f2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.f2.Location = new System.Drawing.Point(15, 106);
			this.f2.Name = "f2";
			this.f2.Size = new System.Drawing.Size(93, 56);
			this.f2.TabIndex = 7;
			this.f2.Text = "XXX";
			// 
			// f1
			// 
			this.f1.AutoSize = true;
			this.f1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.f1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.f1.Location = new System.Drawing.Point(16, 41);
			this.f1.Name = "f1";
			this.f1.Size = new System.Drawing.Size(93, 56);
			this.f1.TabIndex = 5;
			this.f1.Text = "XXX";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.spn);
			this.groupBox4.Controls.Add(this.sp1);
			this.groupBox4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.Color.DodgerBlue;
			this.groupBox4.Location = new System.Drawing.Point(157, 499);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(584, 114);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Special Prize";
			// 
			// spn
			// 
			this.spn.AutoSize = true;
			this.spn.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spn.ForeColor = System.Drawing.Color.Maroon;
			this.spn.Location = new System.Drawing.Point(103, 41);
			this.spn.Name = "spn";
			this.spn.Size = new System.Drawing.Size(180, 56);
			this.spn.TabIndex = 11;
			this.spn.Text = "____________";
			// 
			// sp1
			// 
			this.sp1.AutoSize = true;
			this.sp1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sp1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.sp1.Location = new System.Drawing.Point(15, 41);
			this.sp1.Name = "sp1";
			this.sp1.Size = new System.Drawing.Size(93, 56);
			this.sp1.TabIndex = 10;
			this.sp1.Text = "XXX";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.s5n);
			this.groupBox2.Controls.Add(this.s4n);
			this.groupBox2.Controls.Add(this.s3n);
			this.groupBox2.Controls.Add(this.s2n);
			this.groupBox2.Controls.Add(this.s1n);
			this.groupBox2.Controls.Add(this.s5);
			this.groupBox2.Controls.Add(this.s4);
			this.groupBox2.Controls.Add(this.s3);
			this.groupBox2.Controls.Add(this.s2);
			this.groupBox2.Controls.Add(this.s1);
			this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
			this.groupBox2.Location = new System.Drawing.Point(1053, 30);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(307, 351);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Second Prize";
			// 
			// s5n
			// 
			this.s5n.AutoSize = true;
			this.s5n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s5n.ForeColor = System.Drawing.Color.Maroon;
			this.s5n.Location = new System.Drawing.Point(94, 293);
			this.s5n.Name = "s5n";
			this.s5n.Size = new System.Drawing.Size(180, 56);
			this.s5n.TabIndex = 13;
			this.s5n.Text = "____________";
			// 
			// s4n
			// 
			this.s4n.AutoSize = true;
			this.s4n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s4n.ForeColor = System.Drawing.Color.Maroon;
			this.s4n.Location = new System.Drawing.Point(94, 237);
			this.s4n.Name = "s4n";
			this.s4n.Size = new System.Drawing.Size(180, 56);
			this.s4n.TabIndex = 12;
			this.s4n.Text = "____________";
			// 
			// s3n
			// 
			this.s3n.AutoSize = true;
			this.s3n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s3n.ForeColor = System.Drawing.Color.Maroon;
			this.s3n.Location = new System.Drawing.Point(92, 169);
			this.s3n.Name = "s3n";
			this.s3n.Size = new System.Drawing.Size(180, 56);
			this.s3n.TabIndex = 11;
			this.s3n.Text = "____________";
			// 
			// s2n
			// 
			this.s2n.AutoSize = true;
			this.s2n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s2n.ForeColor = System.Drawing.Color.Maroon;
			this.s2n.Location = new System.Drawing.Point(92, 103);
			this.s2n.Name = "s2n";
			this.s2n.Size = new System.Drawing.Size(180, 56);
			this.s2n.TabIndex = 10;
			this.s2n.Text = "____________";
			// 
			// s1n
			// 
			this.s1n.AutoSize = true;
			this.s1n.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s1n.ForeColor = System.Drawing.Color.Maroon;
			this.s1n.Location = new System.Drawing.Point(92, 41);
			this.s1n.Name = "s1n";
			this.s1n.Size = new System.Drawing.Size(180, 56);
			this.s1n.TabIndex = 9;
			this.s1n.Text = "____________";
			// 
			// s5
			// 
			this.s5.AutoSize = true;
			this.s5.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.s5.Location = new System.Drawing.Point(6, 293);
			this.s5.Name = "s5";
			this.s5.Size = new System.Drawing.Size(93, 56);
			this.s5.TabIndex = 8;
			this.s5.Text = "XXX";
			// 
			// s4
			// 
			this.s4.AutoSize = true;
			this.s4.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.s4.Location = new System.Drawing.Point(6, 237);
			this.s4.Name = "s4";
			this.s4.Size = new System.Drawing.Size(93, 56);
			this.s4.TabIndex = 6;
			this.s4.Text = "XXX";
			// 
			// s3
			// 
			this.s3.AutoSize = true;
			this.s3.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.s3.Location = new System.Drawing.Point(4, 169);
			this.s3.Name = "s3";
			this.s3.Size = new System.Drawing.Size(93, 56);
			this.s3.TabIndex = 4;
			this.s3.Text = "XXX";
			// 
			// s2
			// 
			this.s2.AutoSize = true;
			this.s2.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.s2.Location = new System.Drawing.Point(4, 103);
			this.s2.Name = "s2";
			this.s2.Size = new System.Drawing.Size(93, 56);
			this.s2.TabIndex = 2;
			this.s2.Text = "XXX";
			// 
			// s1
			// 
			this.s1.AutoSize = true;
			this.s1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.s1.Location = new System.Drawing.Point(4, 41);
			this.s1.Name = "s1";
			this.s1.Size = new System.Drawing.Size(93, 56);
			this.s1.TabIndex = 0;
			this.s1.Text = "XXX";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerate.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnGenerate.Location = new System.Drawing.Point(362, 415);
			this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(165, 80);
			this.btnGenerate.TabIndex = 11;
			this.btnGenerate.Text = "GO";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// picUnits
			// 
			this.picUnits.Image = global::Enlottery.Properties.Resources.num0;
			this.picUnits.InitialImage = null;
			this.picUnits.Location = new System.Drawing.Point(571, 30);
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
			this.picTens.Location = new System.Drawing.Point(318, 30);
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
			this.picHundreds.Location = new System.Drawing.Point(29, 30);
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
			this.ClientSize = new System.Drawing.Size(1504, 743);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmMain";
			this.Text = "Enlottery";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
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
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private Label s1;
        private Label s3;
        private Label s2;
        private Label s5;
        private Label s4;
        private Label sp1;
        private Label label2;
        private GroupBox groupBox3;
        private Label f2n;
        private Label f1n;
        private Label f3;
        private Label f2;
        private Label f1;
        private Label spn;
        private Label s5n;
        private Label s4n;
        private Label s3n;
        private Label s2n;
        private Label s1n;
        private Label f3n;
        private PictureBox pictureBox1;
    }
}

