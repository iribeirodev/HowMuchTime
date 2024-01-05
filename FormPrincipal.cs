using System.Globalization;

namespace HowMuchTime
{
    public partial class FormPrincipal : Form
    {
        private bool emMinutos = false;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void LoadResources()
        {
            Text = Resources.FormTitle;
            lblHora.Text = Resources.lblHora;
            lblHoraSet.Text = Resources.lblHoraSet;
            lblTempoRestante.Text = Resources.lblTempoRestante;
            btnSet.Text = Resources.btnSet;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadResources();

            ExibirHoraAtual();

            ResetarContagem();
        }

        private void ResetarContagem()
        {
            mskHora.Text = "00:00";
            txtHoraRestante.Text = "0";

            timer2.Enabled = false;
        }

        private void ExibirHoraAtual()
        {
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private bool ValidarHora()
        {
            string formato = "HH:mm";
            if (DateTime.TryParseExact(mskHora.Text, formato, null, DateTimeStyles.None, out DateTime horaConvertida))
            {
                if (horaConvertida <= DateTime.Now)
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        private void GerarContagem()
        {
            string formato = "HH:mm:ss";

            string sHoraFinal = mskHora.Text + ":00";

            DateTime horaFinal = DateTime.ParseExact(sHoraFinal, formato, null);
            DateTime horaInicial = DateTime.Now;

            TimeSpan diferenca = horaFinal - horaInicial;

            if (diferenca <= TimeSpan.Zero)
            {
                timer2.Enabled = false;
                return;
            }

            string valor;

            if (emMinutos)
                valor = diferenca.TotalMinutes.ToString("F2");
            else
                valor = diferenca.TotalSeconds.ToString("F2");

            txtHoraRestante.Text = valor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ExibirHoraAtual();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (btnSet.Text == Resources.btnSet)
            {
                if (ValidarHora())
                {
                    btnSet.Text = Resources.btnSetStop;
                    timer2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Hora inválida.", Resources.FormTitle);
                }
            }
            else
            {
                btnSet.Text = Resources.btnSet;
                ResetarContagem();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            GerarContagem();
        }

        private void panelMostrador_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled)
                emMinutos = !emMinutos;
        }
    }
}
