
namespace TDP_Vista_task_1
{
	partial class Form1
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.rollInput = new System.Windows.Forms.TextBox();
			this.show = new System.Windows.Forms.Button();
			this.data = new System.Windows.Forms.DataGridView();
			this.clear = new System.Windows.Forms.Button();
			this.close = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(433, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "Result 2021";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(74, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(295, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Enter the roll no. to get the marksheet:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(126, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(119, 17);
			this.label6.TabIndex = 2;
			this.label6.Text = "(between 1 to 10)";
			// 
			// rollInput
			// 
			this.rollInput.Location = new System.Drawing.Point(499, 82);
			this.rollInput.Name = "rollInput";
			this.rollInput.Size = new System.Drawing.Size(254, 22);
			this.rollInput.TabIndex = 3;
			// 
			// show
			// 
			this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.show.Location = new System.Drawing.Point(827, 72);
			this.show.Name = "show";
			this.show.Size = new System.Drawing.Size(155, 42);
			this.show.TabIndex = 4;
			this.show.Text = "Show";
			this.show.UseVisualStyleBackColor = true;
			this.show.Click += new System.EventHandler(this.show_Click);
			// 
			// data
			// 
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Location = new System.Drawing.Point(164, 162);
			this.data.Name = "data";
			this.data.RowHeadersWidth = 51;
			this.data.RowTemplate.Height = 24;
			this.data.Size = new System.Drawing.Size(641, 211);
			this.data.TabIndex = 5;
			// 
			// clear
			// 
			this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clear.Location = new System.Drawing.Point(827, 141);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(155, 48);
			this.clear.TabIndex = 6;
			this.clear.Text = "Clear Form";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// close
			// 
			this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.close.Location = new System.Drawing.Point(827, 216);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(154, 50);
			this.close.TabIndex = 7;
			this.close.Text = "Close Panel";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(1025, 415);
			this.Controls.Add(this.close);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.data);
			this.Controls.Add(this.show);
			this.Controls.Add(this.rollInput);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Name = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox rollInput;
		private System.Windows.Forms.Button show;
		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button close;
	}
}

