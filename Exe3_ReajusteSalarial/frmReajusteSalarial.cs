using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe3_ReajusteSalarial
{
    public partial class frmReajusteSalarial : Form
    {
        public frmReajusteSalarial()
        {
            InitializeComponent();
        }

        private void RealizarProcessamento(RadioButton rdbTurno, RadioButton rdbCategoria, double horasTrabalhadas, double valorSalarioMinimo)
        {
            double valorCoeficiente = GetCoeficiente(rdbTurno, valorSalarioMinimo);
            double valorSalarioBruto = GetSalarioBruto(valorCoeficiente, horasTrabalhadas);
            double valorImposto = GetImposto(rdbCategoria, valorSalarioBruto);
            double valorGratificacao = GetGratificacao(rdbTurno, horasTrabalhadas);
            double valorAlimentacao = GetAlimentacao(rdbCategoria, valorSalarioBruto, valorSalarioMinimo);
            double valorSalarioLiquido = GetSalarioLiquido(valorSalarioBruto, valorImposto, valorGratificacao, valorAlimentacao);
            string situacaoSalarial = GetSituacaoSalarial(valorSalarioLiquido);

            ApresentarResultados(valorCoeficiente, valorSalarioBruto, valorImposto, valorGratificacao, valorAlimentacao, valorSalarioLiquido, situacaoSalarial);
        }

        private void ApresentarResultados(double valorCoeficiente, double valorSalarioBruto, double valorImposto, double valorGratificacao, double valorAlimentacao, double valorSalarioLiquido, string situacaoSalarial)
        {
            lbxResume.Items.Clear();
            lbxResume.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor do Coeficiente:", valorCoeficiente));
            lbxResume.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor do Salário Bruto:", valorSalarioBruto));
            lbxResume.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor do Imposto:", valorImposto));
            lbxResume.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor de Gratificação:", valorGratificacao));
            lbxResume.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor de Alimentação:", valorAlimentacao));
            lbxResume.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor do Salário Líquido:", valorSalarioLiquido));
            lblSituacaoSalarial.Text = situacaoSalarial;
        }
        private double GetCoeficiente(RadioButton rdbTurno, double valorSalarioMinimo)
        {
            double valorCoeficiente = 0;

            switch (rdbTurno.Text)
            {
                case "Matutino":
                    valorCoeficiente = valorSalarioMinimo * 0.01;
                    break;
                case "Vespertino":
                    valorCoeficiente = valorSalarioMinimo * 0.02;
                    break;
                case "Noturno":
                    valorCoeficiente = valorSalarioMinimo * 0.03;
                    break;
            }

            return valorCoeficiente;
        }

        private double GetSalarioBruto(double valorCoeficiente, double horasTrabalhadas)
        {
            double valorSalarioBruto = 0;

            valorSalarioBruto = valorCoeficiente * horasTrabalhadas;

            return valorSalarioBruto;
        }

        private double GetImposto(RadioButton rdbCategoria, double valorSalarioBruto)
        {
            double valorImposto = 0;

            switch (rdbCategoria.Text)
            {
                case "Calouro":
                    if(valorSalarioBruto < 300)
                        valorImposto = valorSalarioBruto * 0.01; 
                    else
                        valorImposto = valorSalarioBruto * 0.02;
                    break;

                case "Veterano":
                    if(valorSalarioBruto < 400)
                        valorImposto = valorSalarioBruto * 0.03;
                    else
                        valorImposto = valorSalarioBruto * 0.04;
                    break;
            }

            return valorImposto;
        }

        private double GetGratificacao(RadioButton rdbTurno, double horasTrabalhadas)
        {
            double valorGratificacao = 0;

            if (rdbTurno.Text.Equals("Noturno") && horasTrabalhadas > 80)
                valorGratificacao = 50;
            else
                valorGratificacao = 30;

            return valorGratificacao;
        }

        private double GetSalarioLiquido(double valorSalarioBruto, double valorImposto, double valorGratificacao, double valorAlimentacao)
        {
            double valorSalarioLiquido = valorSalarioBruto + valorGratificacao + valorAlimentacao - valorImposto;

            return valorSalarioLiquido;
        }

        private double GetAlimentacao(RadioButton rdbCategoria, double valorSalarioBruto, double valorSalarioMinimo)
        {
            double valorAlimentacao = 0;

            if (rdbCategoria.Text.Equals("Calouro") || valorSalarioBruto < valorSalarioMinimo / 2)
                valorAlimentacao = valorSalarioBruto / 3;
            else
                valorAlimentacao = (valorSalarioBruto / 3) / 2;

            return valorAlimentacao;
        }

        private string GetSituacaoSalarial(double valorSalarioLiquido)
        {
            string situacaoSalarial = "";

            if (valorSalarioLiquido < 350)
                situacaoSalarial = "Mal remunerado";
            else
                if (valorSalarioLiquido <= 600)
                situacaoSalarial = "Remuneração normal";
            else
                situacaoSalarial = "Bem remunerado";

            return situacaoSalarial;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            RadioButton rdbTurno = gbxTurno.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            RadioButton rdbCategoria = gbxCategoria.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);

            RealizarProcessamento(rdbTurno, rdbCategoria, Convert.ToDouble(txtHorasTrabalhadas.Text), Convert.ToDouble(txtSalarioMinimo.Text));

        }
    }
}
