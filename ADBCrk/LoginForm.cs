using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBCrk
{
    public partial class LoginForm : Form
    {
        private readonly string kw = "Xiryl";
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private int i = 3;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(i == 0 || i < 0)
            {
                MessageBox.Show("TENTATIVI ESAURITI. IL PROGRAMMA VERRA CHIUSO", "info", MessageBoxButtons.OK);
            }
            if (txtCode.Text == "ADBcrk" && txtPwd.Text == kw)
            {
                this.Visible = false;
                MainForm mf = new MainForm();
                mf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("CODE O PASSWORD ERRATA.");
                i--;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1_Click(sender, e);
            }
        }
    }
}
