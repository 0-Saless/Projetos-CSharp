using System;
using System.Drawing;
using System.Windows.Forms;
using Calcular;

namespace Calculadora
{

    public partial class Form1 : Form
    {
        private string operacaoSelecionada = "+"; // Operação padrão (adição)

        private Calculos calculo; // Instância da classe CalculosS
        private List<string> historicoCalculos = new List<string>();
        public Form1()
        {
            InitializeComponent();
            comboBoxTema.SelectedIndex = 0; // Define tema padrão
            calculo = new Calculos(); // Inicializa o objeto da classe Calculos

        }
        // Evento para trocar o tema ao selecionar no ComboBox
        private void comboBoxTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTema.SelectedItem.ToString() == "Claro")
            {
                MudarTema(Color.White, Color.Black, Color.LightGray);
            }
            else if (comboBoxTema.SelectedItem.ToString() == "Escuro")
            {
                MudarTema(Color.Black, Color.White, Color.Gray);
            }
            else if (comboBoxTema.SelectedItem.ToString() == "Neon")
            {
                MudarTema(Color.DarkGreen, Color.HotPink, Color.DarkBlue);
            }
            else if (comboBoxTema.SelectedItem.ToString() == "Personalizar")
            {
                CoresPersonalizadas();
            }
        }

        // Método para mudar a cor dos componentes
        private void MudarTema(Color fundo, Color texto, Color botoes)
        {
            this.BackColor = fundo;
            foreach (Control c in this.Controls)
            {
                if (c is Button || c is RadioButton || c is FlowLayoutPanel)
                {
                    c.ForeColor = texto;
                    c.BackColor = botoes;
                }
                else if (c is Label)
                {
                    c.ForeColor = texto;
                    c.BackColor = fundo;
                }
            }
        }
        private void CoresPersonalizadas()
        {
            ColorDialog colorDialog = new ColorDialog();

            // Escolher a cor de fundo
            MessageBox.Show("Escolha a cor de fundo!", "Personalizar Tema");
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color fundo = colorDialog.Color;

                // Escolher a cor do texto
                MessageBox.Show("Escolha a cor do texto!", "Personalizar Tema");
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color texto = colorDialog.Color;

                    // Escolher a cor dos botões
                    MessageBox.Show("Escolha a cor dos botões!", "Personalizar Tema");
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        Color botoes = colorDialog.Color;

                        // Aplicar o tema personalizado
                        MudarTema(fundo, texto, botoes);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (comboBoxTema.SelectedItem.ToString() == "Claro")
            {
                Pen pen = new Pen(Color.Black, 2);
                e.Graphics.DrawRectangle(pen, 0, 0, flowLayoutPanel1.Width - 1, flowLayoutPanel1.Height - 1);
            }
            else if (comboBoxTema.SelectedItem.ToString() == "Escuro")
            {
                Pen pen = new Pen(Color.White, 2);
                e.Graphics.DrawRectangle(pen, 0, 0, flowLayoutPanel1.Width - 1, flowLayoutPanel1.Height - 1);
            }
            else if (comboBoxTema.SelectedItem.ToString() == "Neon")
            {
                Pen pen = new Pen(Color.HotPink, 2);
                e.Graphics.DrawRectangle(pen, 0, 0, flowLayoutPanel1.Width - 1, flowLayoutPanel1.Height - 1);
            }
        }





        // Eventos dos RadioButtons para definir a operação
        private void radioButton1_CheckedChanged(object sender, EventArgs e)//radioButton Adição
        {
            if (radioButton1.Checked)
            {
                label4.Text = "+";
                operacaoSelecionada = "+";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//radioButton Subtração
        {
            if (radioButton2.Checked)
            {
                label4.Text = "-";
                operacaoSelecionada = "-";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//radioButton Multiplicação
        {
            if (radioButton3.Checked)
            {
                label4.Text = "×";
                operacaoSelecionada = "*";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)//radioButton Divisão
        {
            if (radioButton4.Checked)
            {
                label4.Text = "÷";
                operacaoSelecionada = "/";
            }
        }


        private void button1_Click(object sender, EventArgs e)// Evento do botão Calcular
        {
            try
            {
                // Obter os valores das TextBoxes
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                // Passar os valores para a classe Calculos
                calculo.Num1 = num1;
                calculo.Num2 = num2;

                string resultado = "";

                // Verificar a operação selecionada e chamar o método correspondente
                switch (operacaoSelecionada)
                {
                    case "+":
                        resultado = calculo.Somar();
                        break;
                    case "-":
                        resultado = calculo.Subtrair();
                        break;
                    case "*":
                        resultado = calculo.Multiplicar();
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            // Lista de mensagen engraçadas
                            string[] mensagens =
                            {
                                "Tentando dividir por zero? Achou que eu não ia perceber? ",
                                "Cuidado! Dividir por zero pode abrir um buraco no espaço-tempo! ",
                                "Matematicamente impossível... Tente outra vez! ",
                                "Você desbloqueou um bug do universo!",
                                "Erro 404: Matemática não encontrada! ",
                                "PAROWWWWWWWWWWWWW, por zero não dá amigo!",
                                "Dividir por zero? Essa calculadora faz contas, não mágica...",
                                "Seu computador não está com paciência para isso. Dividir por zero não é permitido!",
                                "Nota do Dev: Eu finjo que não percebo...",
                                "O máximo que você vai conseguir é uma falha na matrix!",
                                "Você não pode dividir pelo nada... tenta mais tarde!"
                            };

                            // Escolher uma mensagem aleatória
                            Random aletorio = new Random();
                            int messageSorteada = aletorio.Next(mensagens.Length);

                            // Exibir mensagem engraçada na MessageBox
                            MessageBox.Show(mensagens[messageSorteada], "Erro Matemático!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                            return; // Sair do método para evitar que continue a execução
                        }
                        else
                        {
                            resultado = calculo.Dividir();
                        }
                        break;
                }
                //Adicionar calculo ao histórico
                historicoCalculos.Add($"{textBox1.Text} {operacaoSelecionada} {textBox2.Text} = {resultado}");

                // Exibir o resultado na Label de saída
                label5.Text = resultado;

            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Digite apenas números válidos!", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)//Evento do botão Limpar
        {
            label5.Text = "---";
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
        private void button3_Click(object sender, EventArgs e)//Evento do botão Sair
        {
            Application.Exit();

        }
        private void button4_Click(object sender, EventArgs e)//Evento do botão Histórico
        {
            if (historicoCalculos.Count == 0)
            {
                MessageBox.Show("Nenhum cálculo realizado ainda.", "Histórico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Junta todos os cálculos e exibe no MessageBox
            string historicoTexto = string.Join("\n", historicoCalculos);
            MessageBox.Show(historicoTexto, "Histórico de Cálculos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
