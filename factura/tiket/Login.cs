using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiket
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (CodigoUsuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CodigoUsuarioTextBox, "Ingrese un usuario");
                return;
            }
            errorProvider1.Clear();
            if (ContraseñaTextBox.Text == "")
            {
                errorProvider1.SetError(ContraseñaTextBox, "Ingrese una contraseña");
                return;
            }
            errorProvider1.Clear();


        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.PasswordChar == '*')
            {
                ContraseñaTextBox.PasswordChar = '\0';
            }
            else
            {
                ContraseñaTextBox.PasswordChar = '*';
            }
        }
    }
}
