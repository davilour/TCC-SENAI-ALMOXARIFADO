﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class CriarAdmin : Form
    {
        public CriarAdmin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CriarAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "NOME")
            {
                txtNome.Text = "";
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "NOME";
            }
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            if (txtCPF.Text == "CPF")
            {
                txtCPF.Text = "";
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtCPF.Text = "CPF";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
            }
        }

        private void txtRSenha_Enter(object sender, EventArgs e)
        {
            if (txtRSenha.Text == "REPETIR SENHA")
            {
                txtRSenha.Text = "";
            }
        }

        private void txtRSenha_Leave(object sender, EventArgs e)
        {
            if (txtRSenha.Text == "")
            {
                txtRSenha.Text = "REPETIR SENHA";
            }
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "TELEFONE")
            {
                txtTelefone.Text = "";
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                txtTelefone.Text = "TELEFONE";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "";
                txtTelefone.Visible = true;
                LinhaTel.Visible = true;
            }

            else
            {
                checkBox1.Text = "Deseja cadastrar um telefone?";
                txtTelefone.Visible = false;
                LinhaTel.Visible = false;
                txtTelefone.Text = "TELEFONE";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao(); //instanciando a classe
            ClassUsuario usu = new ClassUsuario();
            string nome = txtNome.Text, cpf = txtCPF.Text, email = txtEmail.Text, senha = txtSenha.Text, senhaR = txtRSenha.Text;
            if (nome == "")
            {
                MessageBox.Show("Campo NOME está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cpf == "")
            {
                MessageBox.Show("Campo CPF está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (email == "")
            {
                MessageBox.Show("Campo Email está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (senha == "")
            {
                MessageBox.Show("Campo SENHA está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (senhaR == "")
            {
                MessageBox.Show("Campo REPETIR SENHA está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            if(senha != senhaR)
            {
                MessageBox.Show("Confirmação de senha ERRADO, as senhas nao coincidem");
            }


            else
            {
                try
                {
                    MySqlConnection conexao = con.getConexao();
                    //para a segurança dos dados
                    if (txtTelefone.Text == "TELEFONE")
                    {
                        txtTelefone.Text = "";
                    }
                    string sql = "insert into tb_admin(nome_admin,cpf,email,senha,telefone) values" + "('" + txtNome.Text + "','" + txtCPF.Text + "','" + txtEmail.Text + "','" + txtSenha.Text + "','" + txtTelefone.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.ExecuteReader();
                    MessageBox.Show("Cadastro realizado!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message);
                }
                finally
                {
                    con.desconectar();
                }
            }
        }
    }
}