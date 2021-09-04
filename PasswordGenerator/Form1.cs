using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : MetroForm
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string password = Membership.GeneratePassword(12, 5);

            passwordTextBox.Text = password;
            
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {

        }
    }
}
