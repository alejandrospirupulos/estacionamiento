using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estacionamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Creacion de arreglos de datos/ 

        string[] generos = new string[3] { "Terror", "Accion", "Comedia" }; // formacion de la fila (vector)

        string[,] peliculas = new string[3,3] {
          {"T1","T2","T3"},
          {"A1","A2","A3"},
          {"C1","C2","C3"},

        }; //fila 1 con generos 1 y matriz peliculas 1

        string[,] peliculas2 = new string[3,3]; // matriz 2


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < generos.Length; i++)
            {
                cmbGeneros.Items.Add(generos[i]); // vector 1 
                cmbGeneros2.Items.Add(generos[i]); // vector 2
            }

        }

        private void cmbgeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPeliculas.Items.Clear();
            int fila = cmbGeneros.SelectedIndex;
            int columnas = 0;
            while (columnas < peliculas.GetLength(1))
            {
                cmbPeliculas.Items.Add(peliculas[fila,columnas]);
                columnas++;
            } // creacion de bugle para matriz 1 con vector 1
            
        }

        private void btnNuevaPelicula_Click(object sender, EventArgs e)
        {
            int filas2 =cmbGeneros2.SelectedIndex;
            string nuevaPeliculas2 = txtPelicula.Text;
            int columna = 0;
            bool control = true;

            while(columna < peliculas2.GetLength(1) && control == true)
            {
                if (peliculas2[filas2, columna] == null)
                {
                    peliculas2[filas2, columna] = nuevaPeliculas2;
                    control = false;

                } 
                columna++;
            }

            

        }

        private void cmbGeneros2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPeliculas.Items.Clear();    
            int fila = cmbGeneros2.SelectedIndex;
            int columnas = 0;
            bool control = true;
            while (columnas < peliculas2.GetLength(1) && control == true) {

                if (peliculas2[fila, columnas] != null)
                {
                    lstPeliculas.Items.Add(peliculas2[fila, columnas]);
                }
                else
                {
                    control = false;
                }
                columnas++;
            }
        }
    }
}
