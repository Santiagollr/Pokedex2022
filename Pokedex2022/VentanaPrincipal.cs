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

namespace Pokedex2022
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 0; //guarda el id del pokemon que se esta viendo

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                idActual--;
                misPokemons = miConexion.getPokemonPorId(idActual);
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                label2.Text = misPokemons.Rows[0]["altura"].ToString();
                label1.Text = misPokemons.Rows[0]["id"].ToString();
                label3.Text = misPokemons.Rows[0]["peso"].ToString();
                label11.Text = misPokemons.Rows[0]["descripcion"].ToString();
                label12.Text = misPokemons.Rows[0]["tipo1"].ToString();
                label13.Text = misPokemons.Rows[0]["tipo2"].ToString();
                label14.Text = misPokemons.Rows[0]["especie"].ToString();
                label15.Text = misPokemons.Rows[0]["habitat"].ToString();
                label4.Text = misPokemons.Rows[0]["movimiento1"].ToString();
                label5.Text = misPokemons.Rows[0]["movimiento2"].ToString();
                label6.Text = misPokemons.Rows[0]["movimiento3"].ToString();
                label7.Text = misPokemons.Rows[0]["movimiento4"].ToString();
                label8.Text = misPokemons.Rows[0]["preEvolucion"].ToString();
                label9.Text = misPokemons.Rows[0]["posEvolucion"].ToString();
                pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            idActual++;
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            label2.Text = misPokemons.Rows[0]["altura"].ToString();
            label1.Text = misPokemons.Rows[0]["id"].ToString();
            label3.Text = misPokemons.Rows[0]["peso"].ToString();
            label11.Text = misPokemons.Rows[0]["descripcion"].ToString();
            label12.Text = misPokemons.Rows[0]["tipo1"].ToString();
            label13.Text = misPokemons.Rows[0]["tipo2"].ToString();
            label14.Text = misPokemons.Rows[0]["especie"].ToString();
            label15.Text = misPokemons.Rows[0]["habitat"].ToString();
            label4.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            label5.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            label6.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            label7.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            label8.Text = misPokemons.Rows[0]["preEvolucion"].ToString();
            label9.Text = misPokemons.Rows[0]["posEvolucion"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void evol_Click(object sender, EventArgs e)
        {
            Form1 evoluciones = new Form1();
            evoluciones.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            idActual++;
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            label2.Text = misPokemons.Rows[0]["altura"].ToString();
            label1.Text = misPokemons.Rows[0]["id"].ToString();
            label3.Text = misPokemons.Rows[0]["peso"].ToString();
            label11.Text = misPokemons.Rows[0]["descripcion"].ToString();
            label12.Text = misPokemons.Rows[0]["tipo1"].ToString();
            label13.Text = misPokemons.Rows[0]["tipo2"].ToString();
            label14.Text = misPokemons.Rows[0]["especie"].ToString();
            label15.Text = misPokemons.Rows[0]["habitat"].ToString();
            label4.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            label5.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            label6.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            label7.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            label8.Text = misPokemons.Rows[0]["preEvolucion"].ToString();
            label9.Text = misPokemons.Rows[0]["posEvolucion"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            button1.Hide();
        }
    }
}
