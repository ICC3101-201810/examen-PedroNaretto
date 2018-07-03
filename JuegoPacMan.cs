using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

//Keys.Up, Keys.Down, Keys.Left, Keys.right

namespace WindowsFormsApp4
{
    public partial class JuegoPacMan : Form
    {
        static System.Windows.Forms.Timer myTimer1 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimer2 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimer3 = new System.Windows.Forms.Timer();
        string nombre;

        public JuegoPacMan(string nombre)
        {
            InitializeComponent();

            this.nombre = nombre;

            // se genera el pacman con el nombre del jugador
            Pacman jugador = new Pacman(0, nombre, Pacman);

            // se crean los dos fantasms
            Fantasmas rojo = new Fantasmas("Rojo", FantasmaRojo, jugador);
            Fantasmas rosado = new Fantasmas("Rosado", FantasmaRosado, jugador);

            // se crean las frutas con sus tiempos
            Frutas cherry = new Frutas(30, Cherry);
            Frutas uva = new Frutas(10, Uva);

            KeyDown += new KeyEventHandler(jugador.MovimientoPacman);

            myTimer1.Tick += new EventHandler(rojo.MovimientoFantasmas);
            myTimer1.Tick += new EventHandler(rosado.MovimientoFantasmas);
            myTimer1.Interval = 500;
            myTimer1.Start();

            myTimer2.Tick += new EventHandler(cherry.EntradaFrutas);
            myTimer2.Interval = 30000;
            myTimer2.Start();



        }

        private void JuegoPacMan_Load(object sender, EventArgs e)
        {
            //textBox1.Text = nombre;
            //textBox2.Text = "0";
        }
    }
}
