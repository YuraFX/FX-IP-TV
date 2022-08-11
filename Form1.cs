//  Foobar is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  Foobar is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with Foobar.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FX_IP_TV
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cB1_CheckedChanged(object sender, EventArgs e)
        {
            if (cB1.Checked == true) // Это нужно Вам для банального удобства и поэтому можно скрыть ToolBar.
            {
                pbEmpty.Visible = false;
            }
            else 
            {
                pbEmpty.Visible = true;
            }
        }

        private void списокСсылокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List f = new List(); // Открытие списка ссылок на ТВ каналы.
            f.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f = new About(); // Открытие окна "О программе".
            f.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            WMP.URL = tbUrl.Text; // Это нужно для корректной работы IP-TV вещания, так что лучше это не трогать!
        }

        private void btnClose_Click(object sender, EventArgs e) // Закрытие уже открытого канала.
        {
            tbUrl.Text = "";
            WMP.URL = tbUrl.Text;
        }
    }
}
