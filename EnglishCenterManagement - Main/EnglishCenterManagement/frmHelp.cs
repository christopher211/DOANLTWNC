using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EnglishCenterManagement
{
    public partial class frmHelp : DevExpress.XtraEditors.XtraForm
    {
        private bool mouseDown;
        private Point lastLocation;
        #region MoveFormWithoutBorder
      
        private void frmHelp_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmHelp_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmHelp_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}