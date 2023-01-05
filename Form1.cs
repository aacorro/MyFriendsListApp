using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace MyFriendsListApp
{
	public partial class Form1 : Form
	{

		List<string> myFriends = new List<string>();
		BindingSource bs = new BindingSource();

		public Form1()
		{
			InitializeComponent();
			bs.DataSource = myFriends;
			label1.Text = "";
			txt_newFriend.Text = "Enter name here";
		}

		private void btn_addFriend_Click(object sender, EventArgs e)
		{
			myFriends.Add(txt_newFriend.Text);
			listBox1.DataSource = bs;
			bs.ResetBindings(false);
			label1.Text = $"There are {myFriends.Count} friends in the list.";
			txt_newFriend.Clear();

		}

		private void btn_sortAscending_Click(object sender, EventArgs e)
		{
			myFriends.Sort();
			bs.ResetBindings(false);
		}

		private void btn_sortDescending_Click(object sender, EventArgs e)
		{
			myFriends.Sort();
			myFriends.Reverse();
			bs.ResetBindings(false);
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{

			myFriends.Clear();
			txt_newFriend.Clear();
			label1.Text = "";
			bs.ResetBindings(false);
			txt_newFriend.Text = "Enter name here";
		}


		private void txt_newFriend_MouseDown(object sender, MouseEventArgs e)
		{
			if (txt_newFriend.Text == "Enter name here")
			{
				txt_newFriend.Clear();

			}
		}
	}
}