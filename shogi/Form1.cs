using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shogi
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            form_board formBoard = new form_board();
            formBoard.FormClosed += new FormClosedEventHandler(gameClosed);
            formBoard.Show();
            this.Hide();
        }
        private void gameClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Show();
        }
    }
}
