using DominanteClient.CUT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominanteClient.Forms
{
    public partial class AuthForm : Form
    {
        private MSG msg;
        private Authentificate cutAuth;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            this.msg = new MSG();
            this.cutAuth = new Authentificate();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.infoLabel.Text = "";
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            if (this.txtLogin.Text != "" && this.txtPassword.Text != "")
            {
                this.msg.data = new object[] { this.txtLogin.Text, this.txtPassword.Text };

                this.msg = this.cutAuth.Authentify(this.msg);

                if (this.msg.statutOp)
                {
                    this.Hide();
                    Form uploadForm = new UploadForm();
                    uploadForm.Location = this.Location;
                    uploadForm.StartPosition = FormStartPosition.Manual;
                    uploadForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                this.infoLabel.ForeColor = System.Drawing.Color.Red;
                this.infoLabel.Text = "Veuillez renseigner tous les champs";
            }

        }
    }
}
