﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis_Organizer.NET_2014
{
	public partial class AcceptNotification : Notification
	{
		public AcceptNotification(int duelID, String firstName, String lastName, DateTime date)
		{
			InitializeComponent();
			PlayerName.Text = firstName + " " + lastName;
			Date.Text = date.ToShortDateString();
			Hour.Text = "godzina " + date.ToShortTimeString();
			DuelID = duelID;
		}

		private void Ok_Click(object sender, EventArgs e)
		{
			SendEevent(new PlayerDecision(DuelID, true));
		}
	}
}
