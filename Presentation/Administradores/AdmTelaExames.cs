﻿using App.Controllers;
using Domain.Entities;
using Infra.IoC;
using System;
using System.Windows.Forms;

namespace Presentation.Administradores
{
    public partial class AdmTelaExames : Form
    {
        private readonly ExamesController _exameController;
        public AdmTelaExames()
        {
            InitializeComponent();
            _exameController = DependenciesResolve.Resolve<ExamesController>();
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Medico_Click(object sender, EventArgs e)
        {

        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void BoxSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            /*if ((textNomeExame.Text != String.Empty) && (textDescricao.Text != String.Empty))
            {
                Exame exame = new Exame(textNomeExame.Text, textDescricao.Text);
                _exameController.Cadastrar(exame);

                if (!exame.)
                {
                    user.Validation.Erros.Select(erro => erro.Message);
                    textEndereco.Text = string.Empty;
                    BoxSenha.Text = string.Empty;
                }
                else
                {
                    idUser = user.Id;
                }
            }*/
            if ((textNomeExame.Text != string.Empty))
            {
                if (textDescricao.Text != string.Empty)
                {
                    Exame exame = new Exame(textNomeExame.Text,textDescricao.Text);                
                    _exameController.Cadastrar(exame);
                    textNomeExame.Clear();
                    textDescricao.Clear();
                }
                else msgError("Digite a Descrição");
            }
            else msgError("Digite o nome");
        }

        private void msgError(String msg)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            textNomeExame.Clear();
            textDescricao.Clear();
        }

        private void AdmTelaExames_Load(object sender, EventArgs e)
        {

        }

        private void ListarMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
