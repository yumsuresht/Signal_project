using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;
using System.Data;


namespace Desition
{


	
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		//private int count=1;
		
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;


		private System.Windows.Forms.Timer timer1;
		
		private  int c=0;
		public int max;
		public string max_path;
		
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(248, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(32, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(376, 168);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(32, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(152, 208);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(32, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(112, 104);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(32, 20);
			this.textBox4.TabIndex = 7;
			this.textBox4.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(376, 144);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(32, 20);
			this.textBox5.TabIndex = 9;
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(288, 40);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(32, 20);
			this.textBox6.TabIndex = 10;
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(192, 208);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(32, 20);
			this.textBox7.TabIndex = 11;
			this.textBox7.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(112, 80);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(32, 20);
			this.textBox8.TabIndex = 12;
			this.textBox8.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(184, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "\'A1\' Path";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(424, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "\'B1\' Path";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(104, 248);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "\'C2\' Path";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "\'D2\' Path";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "\'D1\' Path";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(424, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 24);
			this.label6.TabIndex = 14;
			this.label6.Text = "\'B2\' Path";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(296, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 24);
			this.label7.TabIndex = 15;
			this.label7.Text = "\'A2\' Path";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(192, 248);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 32);
			this.label8.TabIndex = 16;
			this.label8.Text = "\'C1\' Path";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(216, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 32);
			this.button1.TabIndex = 8;
			this.button1.Text = "Start";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 5000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 294);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Desition Making";
			this.ResumeLayout(false);

		}


		
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			c++;
			Start_click(c);
			//display(c);
			
			
		}


		private void Start_click(int a)
		{
			int [] desition = new int[3];
			int A1=Int32.Parse(textBox1.Text);
			int A2=Int32.Parse(textBox6.Text);
			int B1=Int32.Parse(textBox2.Text);
			int B2=Int32.Parse(textBox5.Text);
			int C1=Int32.Parse(textBox7.Text);
			int C2=Int32.Parse(textBox3.Text);
			int D1=Int32.Parse(textBox8.Text);
			int D2=Int32.Parse(textBox4.Text);
			if(c<2 )
			{
				try
				{
				


					

					if (A1>A2 & A1>B1 & A1>B2 & A1>C1 & A1>C2 & A1>D1 & A1>D2)
					{
						//campare(A);
						max =A1;
						MessageBox.Show(max.ToString(),"Case 1");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
						max_path ="A1"; 

					}

					else if (A2>A1 & A2>B1 & A2>B2 & A2>C1 & A2>C2 & A2>D1 & A2>D2)
					{
						max =A2;
						MessageBox.Show(max.ToString(),"Case 3");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
						max_path ="A2"; 
					}
					
					else if (B1>A1 & B1>A2 & B1>B2 & B1>C1 & B1>C2 & B1>D1 & B1>D2)
					{
						max =B1;
						MessageBox.Show(max.ToString(),"Case 2");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
						max_path ="B1"; 
					}
					else if (B2>A1 & B2>A2 & B2>B1 & B2>C1 & B2>C2 & B2>D1 & B2>D2)
					{
						max =B2;
						MessageBox.Show(max.ToString(),"Case 4");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
						max_path ="B2"; 
					}
					else if (C1>A1 & C1>A2 & C1>B1 & C1>B2 & C1>C2 & C1>D1 & C1>D2)
					{
						max =C1;
						MessageBox.Show(max.ToString(),"Case 1");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
						max_path ="C1"; 
					}
					else if (C2>A1 & C2>A2 & C2>B1 & C2>B2 & C2>C1 & C2>D1 & C2>D2)
					{
						max =C2;
						MessageBox.Show(max.ToString(),"Case 5");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
						max_path ="C2"; 
					}
					else if (D1>A1 & D1>A2 & D1>B1 & D1>B2 & D1>C1 & D1>C2 & D1>D2)
					{
						max =D1;
						MessageBox.Show(max.ToString(),"Case 2");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
						max_path ="D1"; 
					}
					else if (D2>A1 & D2>A2 & D2>B1 & D2>B2 & D2>C1 & D2>C2 & D2>D1)
					{
						max =D2;
						MessageBox.Show(max.ToString(),"Case 6");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
						max_path ="D2"; 
					}
					else if ((A1==A2) & A1>B1 & A1>B2 & A1>C1 & A1>C2 & A1>D1 & A1>D2)
					{
						MessageBox.Show("A1A2");
						MessageBox.Show(max.ToString(),"Case 3");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
				
					}
                
					else if ((A1==B1) & A1>A2 & A1>B2 & A1>C1 & A1>C2 & A1>D1 & A1>D2)
					{
						MessageBox.Show("A1B1");
						MessageBox.Show(max.ToString(),"Case 1");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
				
					}
					else if ((A1==B2) & A1>A2 & A1>B1 & A1>C1 & A1>C2 & A1>D1 & A1>D2)
					{
						MessageBox.Show("A1B2");
						MessageBox.Show(max.ToString(),"Case 4");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((A1==C1) & A1>A2 & A1>B1 & A1>B2 & A1>C2 & A1>D1 & A1>D2)
					{
						MessageBox.Show("A1C1");
						MessageBox.Show(max.ToString(),"Case 1");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((A1==C2) & A1>A2 & A1>B1 & A1>B2 & A1>C1 & A1>D1 & A1>D2)
					{
						MessageBox.Show("A1C2");
						MessageBox.Show(max.ToString(),"Case 5");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((A1==D1) & A1>A2 & A1>B1 & A1>B2 & A1>C1 & A1>C2 & A1>D2)
					{
						MessageBox.Show("A1D1");
						MessageBox.Show(max.ToString(),"Case 2");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((A1==D2) & A1>A2 & A1>B1 & A1>B2 & A1>C1 & A1>C2 & A1>D1)
					{
						MessageBox.Show("A1D2");
						MessageBox.Show(max.ToString(),"Case 6");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((A2==B1) & A2>A1 & A2>B2 & A2>C1 & A2>C2 & A2>D1 & A2>D2)
					{
						MessageBox.Show("A2B1");
						MessageBox.Show(max.ToString(),"Case 3");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((A2==B2) & A2>A1 & A2>B1 & A2>C1 & A2>C2 & A2>D1 & A2>D2)
					{
						MessageBox.Show("A2B2");
						MessageBox.Show(max.ToString(),"Case 3");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}

					else if ((A2==C1) & A2>A1 & A2>B1 & A2>B2 & A2>C2 & A2>D1 & A2>D2)
					{
						MessageBox.Show("A2C1");
						MessageBox.Show(max.ToString(),"Case 1");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((A2==C2) & A2>A1 & A2>B1 & A2>B2 & A2>C1 & A2>D1 & A2>D2)
					{
						MessageBox.Show("A2C2");
						MessageBox.Show(max.ToString(),"Case 5");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((A2==D1) & A2>A1 & A2>B1 & A2>B2 & A2>C1 & A2>C2 & A2>D2)
					{
						MessageBox.Show("A2D1");
						MessageBox.Show(max.ToString(),"Case 2");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((A2==D2) & A2>A1 & A2>B1 & A2>B2 & A2>C1 & A2>C2 & A2>D1)
					{
						MessageBox.Show("A2D2");
						MessageBox.Show(max.ToString(),"Case 6");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((B1==B2) & B1>A1 & B1>A2 &B1>C1 &B1>C2 &B1>D1 & B1>D2)
					{
						MessageBox.Show("B1B2");
						MessageBox.Show(max.ToString(),"Case 2");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((B1==C1) & B1>A1 & B1>A2 & B1>B2 & B1>C2 & B1>D1 & B1>D2)
					{
						MessageBox.Show("B1C1");
						MessageBox.Show(max.ToString(),"Case 4");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((B1==C2) & B1>A1 & B1>A2 & B1>B2 & B1>C1 & B1>D1 & B1>D2)
					{
						MessageBox.Show("B1C2");
						MessageBox.Show(max.ToString(),"Case 5");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((B1==D1) & B1>A1 & B1>A2 & B1>B2 & B1>C1 & B1>C2 & B1>D2)
					{
						MessageBox.Show("B1D1");
						MessageBox.Show(max.ToString(),"Case 2");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((B1==D2) & B1>A1 & B1>A2 & B1>B2 & B1>C1 & B1>C2 & B1>D1)
					{
						MessageBox.Show("B1D2");
						MessageBox.Show(max.ToString(),"Case 6");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((B2==C1) & B2>A1 & B2>A2 & B2>B1 & B2>C2 & B2>D1 & B2>D2)
					{
						MessageBox.Show("B2C1");
						MessageBox.Show(max.ToString(),"Case 6");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((B2==C2) & B2>A1 & B2>A2 & B2>B1 & B2>C1 & B2>D1 & B2>D2)
					{
						MessageBox.Show("B2C2");
						MessageBox.Show(max.ToString(),"Case 5");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((B2==D1) & B2>A1 & B2>A2 & B2>B1 & B2>C1 & B2>C2 & B2>D2)
					{
						MessageBox.Show("B2D1");
						MessageBox.Show(max.ToString(),"Case 2");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((B2==D2) & B2>A1 & B2>A2 & B2>B1 & B2>C1 & B2>C2 & B2>D1)
					{
						MessageBox.Show("B2D2");
						MessageBox.Show(max.ToString(),"Case 6");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((C1==C2) & C1>A1 & C1>A2 & C1>B1 & C1>B2 & C1>D1 & C1>D2)
					{
						MessageBox.Show("C1C2");
						MessageBox.Show(max.ToString(),"Case 5");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
					}

					else if ((C1==D1) & C1>A1 & C1>A2 & C1>B1 & C1>B2 & C1>C2 & C1>D2)
					{
						MessageBox.Show("C1D1");
						MessageBox.Show(max.ToString(),"Case 1");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;


					}
					else if ((C1==D2) & C1>A1 & C1>A2 & C1>B1 & C1>B2 & C1>C2 & C1>D1)
					{
						MessageBox.Show("C1D2");
						MessageBox.Show(max.ToString(),"Case 6");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((C2==D1) & C2>A1 & C2>A2 & C2>B1 & C2>B2 & C2>C1 & C2>D2)
					{
						MessageBox.Show("C2D1");
						MessageBox.Show(max.ToString(),"Case 5");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((C2==D2) & C2>A1 & C2>A2 & C2>B1 & C2>B2 & C2>C1 & C2>D1)
					{
						MessageBox.Show("C2D2");
						MessageBox.Show(max.ToString(),"Case 6");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((D1==D2) & D1>A1 &D1>A2 &D1>B1 &D1>B2 & D1>C1 & D1>C2)
					{
						MessageBox.Show("D1D2");
						MessageBox.Show(max.ToString(),"Case 6");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;

					}
					else if ((A1==A2)& (A2==B1) & (A1==B1) & A1>B2 & A1>C1 & A1>C2 & A1>D1 & A1>D2)
					{
						MessageBox.Show(max.ToString(),"Case 6");
						if (max == 15)
							this.timer1.Interval = 15000;
						if (max == (14 | 13))
							this.timer1.Interval = 13000;
						if (max == (12 | 11))
							this.timer1.Interval = 12000;
						if (max == (09 | 10))
							this.timer1.Interval = 10000;
						if (max == (06 | 07 | 08))
							this.timer1.Interval = 8000;
						if (max == (01 | 02 | 03 | 04 | 05))
							this.timer1.Interval = 5000;
					}
						//need to add code here

					else if (((A1==A2)& (B1==B2)& (C1==C2)& (A1 ==B1) & (A1== C1)) & A1>D1 & A1>D2)
					{
						MessageBox.Show("A1A2B1B2C1C2");
					}
					else if (((A1==A2)& (B1==B2)& (C1==D1)& (A1==B1) & (A1==C1)) & A1>C2 & A1>D2)
					{
						MessageBox.Show("A1A2B1B2C1D1");
					}
					else if (((A1==A2)& (B1==B2)& (C1==D2)& (A1==B1) & (A1==C1)) & A1>C2 & A1>D1)
					{
						MessageBox.Show("A1A2B1B2C1D2");
					}
					else if (((A1==A2)& (B1==B2)& (C2==D1)& (A1==B1) & (A1==C2)) & A1>C1 & A1>D2)
					{
						MessageBox.Show("A1A2B1B2C2D1");
					}
					else if (((A1==A2)& (B1==B2)& (C2==D2)& (A1==B1) & (A1==C2)) & A1>C1 & A1>D1)
					{
						MessageBox.Show("A1A2B1B2C1D2");
					}
					else if (((A1==A2)& (B1==B2)& (D1==D2)& (A1==B1) & (A1==D1)) & A1>C1 & A1>C2)
					{
						MessageBox.Show("A1A2B1B2D1D2");
					}
					else if (((A1==A2)& (B1==C1)& (C2==D1)& (A1==B1) & (A1==C2)) & A1>B2 & A1>D2)
					{
						MessageBox.Show("A1A2B1C1C2D1");
					}
					else if (((A1==A2)& (B1==C1)& (C2==D2)& (A1==B1) & (A1==C2)) & A1>B2 & A1>D1)
					{
						MessageBox.Show("A1A2B1C1C2D2");
					}
					else if (((A1==A2)& (B1==C1)& (D1==D2)& (A1==B1) & (A1==D1)) & A1>B2 & A1>C2)
					{
						MessageBox.Show("A1A2B1C1D1D2");
					}
					else if (((A1==A2)& (B1==C2)& (D1==D2)& (A1==B1) & (A1==D1)) & A1>B2 & A1>C1)
					{
						MessageBox.Show("A1A2B1C2D1D2");
					}
					else if (((A1==A2)& (B2==C1)& (C2==D1)& (A1==B2) & (A1==C2)) & A1>B1 & A1>D2)
					{
						MessageBox.Show("A1A2B2C1C2D1");
					}
					else if (((A1==A2)& (B2==C1)& (C2==D2)& (A1==B2) & (A1==C2)) & A1>B1 & A1>D1)
					{
						MessageBox.Show("A1A2B2C1C2D2");
					}
					else if (((A1==A2)& (B2==C1)& (D1==D2)& (A1==B2) & (A1==D1)) & A1>B1 & A1>C2)
					{
						MessageBox.Show("A1A2B2C1D1D2");
					}
					else if (((A1==A2)& (B2==C2)& (D1==D2)& (A1==B2) & (A1==D1)) & A1>B1 & A1>C1)
					{
						MessageBox.Show("A1A2B2C2D1D2");
					}
					else if (((A1==A2)& (C1==C2)& (D1==D2)& (A1==C1) & (A1==D1)) & A1>B1 & A1>B2)
					{
						MessageBox.Show("A1A2C1C2D1D2");
					}
					else if (((A1==B1)& (B2==C1)& (C2==D1)& (A1==B2) & (A1==C2)) & A1>A2 & A1>D2)
					{
						MessageBox.Show("A1B1B2C1C2D1");
					}
					else if (((A1==B1)& (B2==C1)& (C2==D2)& (A1==B2) & (A1==C2)) & A1>A2 & A1>D1)
					{
						MessageBox.Show("A1B1B2C1C2D2");
					}
					else if (((A1==B1)& (B2==C2)& (D1==D2)& (A1==B2) & (A1==D1)) & A1>A2 & A1>C1)
					{
						MessageBox.Show("A1B1B2C2D1D2");
					}
					else if (((A1==B1)& (C1==C2)& (D1==D2)& (A1==C1) & (A1==D1)) & A1>A2 & A1>B2)
					{
						MessageBox.Show("A1B1C1C2D1D2");
					}
					else if (((A1==B2)& (C1==C2)& (D1==D2)& (A1==C1) & (A1==D1)) & A1>A2 & A1>B1)
					{
						MessageBox.Show("A1B2C1C2D1D2");
					}
					else if (((A2==B1)& (B2==C1)& (C2==D1)& (A2==B2) & (A2==C2)) & A2>A1 & A1>D2)
					{
						MessageBox.Show("A2B1B2C1C2D1");
					}
					else if (((A2==B1)& (B2==C1)& (C2==D2)& (A2==B2) & (A2==C2)) & A2>A1 & A1>D1)
					{
						MessageBox.Show("A2B1B2C1C2D2");
					}
					else if (((A2==B1)& (B2==C2)& (D1==D2)& (A2==B2) & (A2==D1)) & A2>A1 & A1>C1)
					{
						MessageBox.Show("A2B1B2C2D1D2");
					}
					else if (((A2==B1)& (C1==C2)& (D1==D2)& (A2==C1) & (A2==D1)) & A2>A1 & A1>B2)
					{
						MessageBox.Show("A2B1C1C2D1D2");
					}
					else if (((A2==B2)& (C1==C2)& (D1==D2)& (A2==C1) & (A2==D1)) & A2>A1 & A1>B1)
					{
						MessageBox.Show("A2B2C1C2D1D2");
					}
					else if (((B1==B2)& (C1==C2)& (D1==D2)& (B1==C1) & (B1==D1)) & B1>A1 & B1>A2)
					{
						MessageBox.Show("B1B2C1C2D1D2");
					}

					else if (((A1==A2)& (B1==B2)& (C1==C2)& (A1==B1) & (A1==C1) & (A1==D1))  & A1>D2)
					{
						MessageBox.Show("A1A2B1B2C1C2D1");
					}
					else if (((A1==A2)& (B1==B2)& (C1==C2)& (A1==B1) & (A1==C1) & (A1==D2))  & A1>D1)
					{
						MessageBox.Show("A1A2B1B2C1C2D2");
					}
					else if (((A1==A2)& (B1==B2)& (C1==D1)& (A1==B1) & (A1==C1) & (A1==D2))  & A1>C2)
					{
						MessageBox.Show("A1A2B1B2C1D1D2");
					}
					else if (((A1==A2)& (B1==B2)& (C2==D1)& (A1==B1) & (A1==C2) & (A1==D2))  & A1>C1)
					{
						MessageBox.Show("A1A2B1B2C2D1D2");
					}
					else if (((A1==A2)& (B1==C1)& (C2==D1)& (A1==B1) & (A1==C2) & (A1==D2))  & A1>B2)
					{
						MessageBox.Show("A1A2B2C1C2D1D2");
					}
					else if (((A1==A2)& (B2==C1)& (C2==D1)& (A1==B2) & (A1==C2) & (A1==D2))  & A1>B1)
					{
						MessageBox.Show("A1A2B2C1C2D1D2");
					}
					else if (((A1==B1)& (B2==C1)& (C2==D1)& (A1==B2) & (A1==C2) & (A1==D2))  & A1>A2)
					{
						MessageBox.Show("A1B1B2C1C2D1D2");
					}
					else if (((A2==B1)& (B2==C1)& (C2==D1)& (A2==B2) & (A2==C2) & (A2==D2))  & A2>A1)
					{
						MessageBox.Show("A1B1B2C1C2D1D2");
					}
					else if ((A1==A2) &(B1==B2) &(C1==C2) &(D1==D2) & (A1==B1) &(A1==C1) &(A1==D1))
					{
						MessageBox.Show("All");
					}



		
					else
					{
						MessageBox.Show("others");
					}

				

				}

				

	/*	private void label4_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
		
		}*/
	
				catch(Exception)
				{
					MessageBox.Show("Invalid Input");
				}
				timer1.Start ();
			}
			else
			{
				c=0;
				Start_click(c);
				
			}
	
			/*int vehi1=2;
			int vehi2=4;
			int vehi3=6;
			int vehi4=8;
			int vehi5=10;
			int vehi6=12;
			int vehi7=14;
			int vehi8=16;
			int vehi9=18;
			int vehi10=20;
			int vehi11=22;
			int vehi12=24;
			int vehi13=26;
			int vehi14=28;
			int vehi15=30;
			int vehi16=32;
			int vehi17=34;
			int vehi18=36;
			int vehi19=38;
			int time;
			//int count=2;
			if(count = 1)
				time=2;
			else if(count = 2)
				time = 4;
			else if (count = 3)
				time = 6;
			else if (count = 4)
				time = 8;
			else if (count = 5)
				time = 10;
			else if (count = 6)
				time = 12;
			else if (count = 7)
				time = 14;
			else if (count = 8)
				time = 16;
			else if (count = 9)
				time = 18;
			else if (count = 10)
				time = 20;
			else if (count = 11)
				time = 22;
			else if (count = 12)
				time = 24;
			else if (count =13 )
				time = 26;
			else if (count = 14)
				time =28;
			else if (count = 15)
				time = 30;
			else if (count = 16)
				time = 32;
			else if (count =17)
				time = 34;
			else if (count = 18)
				time = 36;
			else if (count = 19)
				time = 38;
			else if (count = 20)
				time = 40;
			*/
			
		
		}


		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Start_click(c);
			
		}

		private void campare(int m)
		{
			int e=m;
			

		}
	}
}
