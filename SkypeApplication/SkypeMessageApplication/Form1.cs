using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SKYPE4COMLib;

namespace SkypeMessageApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Skype skypeInstant;
        private void btnKetNoiSkype_Click(object sender, EventArgs e)
        {
            skypeInstant = new Skype();
            if (!skypeInstant.Client.IsRunning)
            {
                // start minimized with no splash screen
                skypeInstant.Client.Start(true, true);
            }
            skypeInstant.Attach(6, true);
        }

        private void btnGuiTin_Click(object sender, EventArgs e)
        {
            string[] users = new string[] { "endyquach", "dongnv92" };

            for (int i = 0; i < users.Length; i++)
            {
                skypeInstant.SendMessage(users[i], "bot sent");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(loadContacts));
            thread.IsBackground = true;
            thread.Priority = System.Threading.ThreadPriority.AboveNormal;
            thread.Name = "Load Skype Contacts";
            thread.Start();
        }

        List<string> alleKontakte = new List<string>();
        public void loadContacts() // Radiobutton2 = online | radiobutton1 = alle
        {
            alleKontakte.Clear();
            if (radioButton1.Checked)
            {
                foreach (User user in skypeInstant.Friends)
                {
                    alleKontakte.Add(user.Handle);
                }
            }
            else if (radioButton2.Checked)
            {
                foreach (User user in skypeInstant.Friends)
                {
                    if (user.OnlineStatus == TOnlineStatus.olsOnline | user.OnlineStatus == TOnlineStatus.olsNotAvailable | user.OnlineStatus == TOnlineStatus.olsDoNotDisturb | user.OnlineStatus == TOnlineStatus.olsAway)
                    {
                        alleKontakte.Add(user.Handle);
                    }
                }
            }

            MethodInvoker lvUpdate = delegate
            {
                listView1.Items.Clear();

                foreach (var user in alleKontakte)
                {
                    listView1.Items.Add(user);
                }
                listView1.Sorting = SortOrder.Ascending;
                if (radioButton2.Checked)
                    radioButton2.Text = String.Format("nur online Kontakte ({0})", listView1.Items.Count);
                else if (radioButton1.Checked)
                    radioButton1.Text = String.Format("alle Kontakte ({0})", listView1.Items.Count);
            };

            Invoke(lvUpdate);
        }
    }
}
