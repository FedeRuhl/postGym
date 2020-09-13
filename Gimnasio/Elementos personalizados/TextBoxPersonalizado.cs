using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Gimnasio
{
    class TextBoxPersonalizado : TextBox
    {
        protected String nombre;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            nombre = this.Text;
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (this.Text == nombre)
                this.Text = "";
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if(this.Text == "")
                this.Text = nombre;
        }
    }
}
