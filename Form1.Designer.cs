namespace MyFriendsListApp
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.txt_newFriend = new System.Windows.Forms.TextBox();
			this.btn_addFriend = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_sortAscending = new System.Windows.Forms.Button();
			this.btn_sortDescending = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.Window;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
			this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 25;
			this.listBox1.Location = new System.Drawing.Point(360, 49);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(303, 354);
			this.listBox1.TabIndex = 0;
			this.listBox1.UseWaitCursor = true;
			// 
			// txt_newFriend
			// 
			this.txt_newFriend.AcceptsTab = true;
			this.txt_newFriend.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_newFriend.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txt_newFriend.Location = new System.Drawing.Point(15, 63);
			this.txt_newFriend.Name = "txt_newFriend";
			this.txt_newFriend.Size = new System.Drawing.Size(339, 28);
			this.txt_newFriend.TabIndex = 1;
			this.txt_newFriend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_newFriend_MouseDown);
			// 
			// btn_addFriend
			// 
			this.btn_addFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_addFriend.Location = new System.Drawing.Point(116, 113);
			this.btn_addFriend.Name = "btn_addFriend";
			this.btn_addFriend.Size = new System.Drawing.Size(100, 50);
			this.btn_addFriend.TabIndex = 2;
			this.btn_addFriend.Text = "Add Friend";
			this.btn_addFriend.UseVisualStyleBackColor = true;
			this.btn_addFriend.Click += new System.EventHandler(this.btn_addFriend_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(78, 400);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// btn_sortAscending
			// 
			this.btn_sortAscending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sortAscending.Location = new System.Drawing.Point(81, 188);
			this.btn_sortAscending.Name = "btn_sortAscending";
			this.btn_sortAscending.Size = new System.Drawing.Size(75, 38);
			this.btn_sortAscending.TabIndex = 5;
			this.btn_sortAscending.Text = "A -> Z";
			this.btn_sortAscending.UseVisualStyleBackColor = true;
			this.btn_sortAscending.Click += new System.EventHandler(this.btn_sortAscending_Click);
			// 
			// btn_sortDescending
			// 
			this.btn_sortDescending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sortDescending.Location = new System.Drawing.Point(182, 188);
			this.btn_sortDescending.Name = "btn_sortDescending";
			this.btn_sortDescending.Size = new System.Drawing.Size(75, 38);
			this.btn_sortDescending.TabIndex = 6;
			this.btn_sortDescending.Text = "Z -> A";
			this.btn_sortDescending.UseVisualStyleBackColor = true;
			this.btn_sortDescending.Click += new System.EventHandler(this.btn_sortDescending_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clear.Location = new System.Drawing.Point(116, 253);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(100, 41);
			this.btn_clear.TabIndex = 7;
			this.btn_clear.Text = "Clear List";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Menu;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(462, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 24);
			this.label2.TabIndex = 8;
			this.label2.Text = "FRIENDS:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.btn_sortDescending);
			this.Controls.Add(this.btn_sortAscending);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_addFriend);
			this.Controls.Add(this.txt_newFriend);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "My Friends";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txt_newFriend;
		private System.Windows.Forms.Button btn_addFriend;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_sortAscending;
		private System.Windows.Forms.Button btn_sortDescending;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox1;
	}
}

