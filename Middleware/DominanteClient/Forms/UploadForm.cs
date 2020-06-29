using DominanteClient.CUT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominanteClient.Forms
{
    public partial class UploadForm : Form
    {
        private MSG msg;
        private UploadFile cutUpload;
        public UploadForm()
        {
            InitializeComponent();
        }

        private void UploadForm_Load(object sender, EventArgs e)
        {
            this.msg = new MSG();
            this.cutUpload = new UploadFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "TXT files (*.txt)|*.txt";

            int index = 0;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.msg.data = new object[openFileDialog.FileNames.Length];
                foreach (string fileName in openFileDialog.FileNames)
                {
                    this.msg.data[index] = File.ReadAllBytes(fileName);
                    index++;
                }
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            this.infoLabel.Text = "";
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            if (this.msg.data != null)
            {
                this.msg = this.cutUpload.Upload(this.msg);
                this.infoLabel.Text = "Opération en cours";
                this.infoLabel.ForeColor = System.Drawing.Color.Green;

                if (this.msg.statutOp)
                {
                    this.infoLabel.Text = "Fichier déchiffré avec succes !";
                }


            } else {
                this.infoLabel.Text = "Veuillez selectionner des fichiers";
                this.infoLabel.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
