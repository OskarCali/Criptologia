using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Henon
{
    public partial class formHome : Form
    {
        private readonly Henon henon = new Henon();
        private int modo;
        private string text, binText, binCripto;

        public formHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            lblFilename.Text = "";
            toolStripStLblCompact.Text = "";
            toolStripStLblText.Text = "";

            splitContSide.Panel2Collapsed = true;

            radBtnText.Checked = true;
            btnProcess.Enabled = false;
            cmbBxMode.SelectedIndex = 0;

            binCripto = henon.henon(0.75132, 0.01215, 100);
        }

        private void RadBtnText_CheckedChanged(object sender, EventArgs e)
        {
            richTxtBxSource.ReadOnly = false;
            richTxtBxSource.Text = "";

            btnFile.Enabled = false;
            lblFilename.Text = "";

            splitContSide.Panel2Collapsed = true;
        }

        private void RadBtnFile_CheckedChanged(object sender, EventArgs e)
        {
            richTxtBxSource.ReadOnly = true;
            richTxtBxSource.Text = "";

            btnFile.Enabled = true;

            splitContSide.Panel2Collapsed = true;
        }

        private void RichTxtBxSource_TextChanged(object sender, EventArgs e)
        {
            if (!richTxtBxSource.Text.Equals(""))
            {
                btnProcess.Enabled = true;
                return;
            }

            btnProcess.Enabled = false;
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                lblFilename.Text = openFileDialog.FileName;

                richTxtBxSource.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            var cripto = "";

            toolStripStLblText.Text = "";
            toolStripStLblCompact.Text = "PROCESANDO...";
            Application.DoEvents();

            switch (modo)
            {
                case 0:
                    text = richTxtBxSource.Text;
                    binText = text.TextToBin(Encoding.UTF8);

                    binCripto = binCripto.ToEqualize(binText);

                    for (var i = 0; i < binText.Length; i++) cripto += binText[i] != binCripto[i] ? "1" : "0";

                    richTxtBxBinText.Text = binText;
                    richTxtBxBinKey.Text = binCripto;
                    richTxtBxCompact.Text = cripto;
                    toolStripStLblText.Text = text.Length.ToString();
                    toolStripStLblCompact.Text = "caracter(es) encriptado(s)";
                    splitContSide.Panel2Collapsed = false;
                    break;
                case 1:
                    binText = richTxtBxSource.Text;
                    binCripto = binCripto.ToEqualize(binText);

                    for (var i = 0; i < binText.Length; i++) cripto += binText[i] != binCripto[i] ? "1" : "0";

                    richTxtBxBinText.Text = binCripto;
                    richTxtBxBinKey.Text = cripto;
                    richTxtBxCompact.Text = cripto.BinToText(Encoding.UTF8);
                    toolStripStLblText.Text = binText.Length.ToString();
                    toolStripStLblCompact.Text = "bit(s) desencriptado(s)";
                    splitContSide.Panel2Collapsed = false;
                    break;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            splitContSide.Panel2Collapsed = !splitContSide.Panel2Collapsed;
            btnShow.Text = splitContSide.Panel2Collapsed ? "MOSTRAR" : "OCULTAR";
        }

        private void ToolStripStLblAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por: Óskar Calí\n\nOctubre 2019", "ABOUT", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }

        private void cmbBxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;
            modo = cmb.SelectedIndex;
        }
    }
}