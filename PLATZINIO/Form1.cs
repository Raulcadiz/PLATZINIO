using System.Windows.Forms;
using System;
using System.Threading;
using System.Runtime.InteropServices;

namespace PLATZINIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        int totalJugador = 0;
        int totalDealer = 0;
        int num = 0;
        int platziCoins = 5;
        string message = "";
        int jugador = 0;
        int casino = 0;
        
        System.Random random = new System.Random();
        private void Newnumero()
        {
            num = random.Next(1, 12);
            totalJugador = totalJugador + num;
            labelCartaJugador.Text = totalJugador.ToString();

        }

        private void NewnumeroCasino()
        {
            
            num = random.Next(1, 12);
            totalDealer = totalDealer + num;
            lblCartaCasino.Text = totalDealer.ToString();

        }

        private void ResetCartas()
        {
            totalJugador = 0;
            totalDealer = 0;
            lblCartaCasino.Text = totalDealer.ToString();
            labelCartaJugador.Text = totalJugador.ToString();

        }

        private void Win()
        {
            message = $"Ganaste la partida:\nJugador:{totalJugador} - Casino:{totalDealer}";
            textBoxResult.Text = (message);
            MessageBox.Show(message, "Platzino", MessageBoxButtons.OK);
            totalJugador = 0;
            jugador++;
            labelJugador.Text = jugador.ToString();
            ResetCartas();
            btnPlay.Text = "JUGAR";
        }

        private void Lose()
        {
            message = $"Perdiste te pasaste\nJugador:{totalJugador} - Casino:{totalDealer}";
            MessageBox.Show(message, "Platzino", MessageBoxButtons.OK);
            textBoxResult.Text = (message);
            casino++;
            labelCasino.Text = casino.ToString();
            ResetCartas();
            btnPlay.Text = "JUGAR";
        }
        private void PlayGame()
        {
            btnPlay.Text = "CANCELAR";
            textBoxResult.Text = "Turno del jugador";
            ResetCartas();
            Newnumero();
            var loose = false;
            while (!loose && MessageBox.Show("Quiere otra carta?","Platzino",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Newnumero();
                if (totalJugador > 21)
                {
                    Lose();
                    loose = true;
                }

            }
            if (!loose && totalJugador <= 21)
            {
                textBoxResult.Text = "Turno del Casino";

                NewnumeroCasino();
                
                while (totalDealer < totalJugador ? true : false)
                {
                    NewnumeroCasino();
                    
                }
                if (totalDealer > 21 || totalJugador>=totalDealer)
                {
                    Win();
                }
                else {
                    Lose();
                }
            }
            

        }
        
        private void btnGredit_Click(object sender, EventArgs e)
        {

            platziCoins = Convert.ToInt32(textBoxCredit.Text);
            labelCredit.Text = platziCoins.ToString();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Text == "CANCELAR")
            {
                DialogResult check = MessageBox.Show("¿Seguro que quieres cancelar la partida?", "Platzinio", MessageBoxButtons.YesNo);
                if (check == DialogResult.Yes)
                {
                    btnPlay.Text = "JUGAR";
                    ResetCartas();
                }
            }
            else
            {
                if (platziCoins == 0)
                {
                    DialogResult check = MessageBox.Show("No tienes creditos para jugar, si quiere jugar cargue credito primero.\n ¿Quiere salir de la aplicacion?", "Platzinio", MessageBoxButtons.YesNo);
                    if (check == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }else
                {
                    PlayGame();
                    platziCoins--;
                    labelCredit.Text = platziCoins.ToString();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}