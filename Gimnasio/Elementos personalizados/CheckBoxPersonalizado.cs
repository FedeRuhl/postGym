using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    class CheckBoxPersonalizado : CheckBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (this.Checked == false)
                    this.Checked = true;
                else
                    this.Checked = false;
            }
        }
    }
}
