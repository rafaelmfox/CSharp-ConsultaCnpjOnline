using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ConsultaCnpjOnline
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtCnpj.Focus();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtBairro.Text = "";
            txtCep.Text = "";
            txtCnpj.Text = "";
            txtComplemento.Text = "";
            txtEmail.Text = "";
            txtLogradouro.Text = "";
            txtMunicipio.Text = "";
            txtNaturezaJuridica.Text = "";
            txtNome.Text = "";
            txtNomeFantasia.Text = "";
            txtNumero.Text = "";
            txtPorte.Text = "";
            txtSituacao.Text = "";
            txtStatus.Text = "";
            txtTelefone.Text = "";
            txtTipo.Text = "";
            txtUf.Text = "";

            txtCnpj.Focus();


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            string vCnpjParaConsultar = txtCnpj.Text.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if (vCnpjParaConsultar.Length == 14)
            {

                string vStringConsulta = @"https://www.receitaws.com.br/v1/cnpj/" + vCnpjParaConsultar;

                WebClient vClientDownload = new WebClient();
                vClientDownload.Encoding = Encoding.UTF8;
                var vDados = vClientDownload.DownloadString(vStringConsulta);

                JObject jSon = JObject.Parse(vDados);

                txtBairro.Text = jSon["bairro"].ToString();
                txtCep.Text = jSon["cep"].ToString();
                txtCnpj.Text = jSon["cnpj"].ToString();
                txtComplemento.Text = jSon["complemento"].ToString();
                txtEmail.Text = jSon["email"].ToString();
                txtLogradouro.Text = jSon["logradouro"].ToString();
                txtMunicipio.Text = jSon["municipio"].ToString();
                txtNaturezaJuridica.Text = jSon["natureza_juridica"].ToString();
                txtNome.Text = jSon["nome"].ToString();
                txtNomeFantasia.Text = jSon["fantasia"].ToString();
                txtNumero.Text = jSon["numero"].ToString();
                txtPorte.Text = jSon["porte"].ToString();
                txtSituacao.Text = jSon["situacao"].ToString();

                if (txtSituacao.Text == "ATIVA")
                    txtSituacao.ForeColor = Color.Green;
                else
                    txtSituacao.ForeColor = Color.Red;


                txtStatus.Text = jSon["status"].ToString();

                if (txtStatus.Text == "OK")
                    txtStatus.ForeColor = Color.Green;
                else
                    txtStatus.ForeColor = Color.Red;


                txtTelefone.Text = jSon["telefone"].ToString();
                txtTipo.Text = jSon["tipo"].ToString();
                txtUf.Text = jSon["uf"].ToString();

            }
            else
                MessageBox.Show("Verifique se o cnpj foi digitado corretamente","Aviso:",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }


    }
}
