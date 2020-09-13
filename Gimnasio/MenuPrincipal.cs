using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Gimnasio
{
    public partial class MenuPrincipal : Form
    {
        int lx, ly, sw, sh;
        public MenuPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            OcultarSubMenus();
        }

        #region Funcionalidades Form principal

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(35, 32, 39));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        #endregion

        #region Barra superior

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconMaximizar.Visible = false;
            iconRestaurar.Visible = true;
        }

        #endregion

        private void btnDatosBasicos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuDatos);
        }

        private void btnAltaDatos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuAlta);
        }

        private void btnVisualizacionDatos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuVisualizacion);
        }

        private void btnPersonasEjercicios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MantenimientoPersonasEjercicios>();
            btnPersonasEjercicios.BackColor = Color.FromArgb(241, 221, 56);
        }

        private void btnCrearRutina_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CrearRutina>();
            btnCrearRutina.BackColor = Color.FromArgb(241, 221, 56);
        }

        private void btnAltaEntrenamiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<SubirEntrenamiento>();
            btnAltaEntrenamiento.BackColor = Color.FromArgb(241, 221, 56);
        }

        private void btnAltaCondicion_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ActualizarCondicionFisica>();
            btnAltaCondicion.BackColor = Color.FromArgb(241, 221, 56);
        }

        private void btnVisualizarRutinas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ConsultaRutinas>();
            btnVisualizarRutinas.BackColor = Color.FromArgb(241, 221, 56);
        }

        private void btnVisualizarEntrenamientos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ConsultaEntrenamientos>();
            btnVisualizarEntrenamientos.BackColor = Color.FromArgb(241, 221, 56);
        }

        private void btnVisualizarCondiciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ConsultaCondicionesFisicas>();
            btnVisualizarCondiciones.BackColor = Color.FromArgb(241, 221, 56);
        }

        private void AbrirFormulario<MiForm>() where MiForm:Form, new()
        {
            Form formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.TopLevel = false;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
            }
            formulario.BringToFront();
            ColorDefault();
        }

        private void OcultarSubMenus()
        {
            panelSubMenuDatos.Visible = false;
            panelSubMenuAlta.Visible = false;
            panelSubMenuVisualizacion.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void ColorDefault()
        {
            Color color = Color.FromArgb(36, 1, 38);
            btnPersonasEjercicios.BackColor = color;
            btnCrearRutina.BackColor = color;
            btnAltaEntrenamiento.BackColor = color;
            btnAltaCondicion.BackColor = color;
            btnVisualizarRutinas.BackColor = color;
            btnVisualizarEntrenamientos.BackColor = color;
            btnVisualizarCondiciones.BackColor = color;
        }
    }
}
