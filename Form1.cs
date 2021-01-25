using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PuzzleDGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] vAux = new int[16];
  
        private void button1_Click(object sender, EventArgs e)
        {
            swo.Reset(); dataGridView1.Enabled = true; dataGridView1.Rows.Clear();
            textBox1.Text = "00";
            textBox2.Text = "00";
            textBox3.Text = "00";
            Puzzle obj = new Puzzle(); swo.Start(); timer1.Enabled = true;
            dataGridView1.Columns.Clear();
            DataGridViewImageColumn colum1 = new DataGridViewImageColumn();
            DataGridViewImageColumn colum2 = new DataGridViewImageColumn();
            DataGridViewImageColumn colum3 = new DataGridViewImageColumn();
            DataGridViewImageColumn colum4 = new DataGridViewImageColumn();
            dataGridView1.Columns.Add(colum1);
            dataGridView1.Columns.Add(colum2);
            dataGridView1.Columns.Add(colum3);
            dataGridView1.Columns.Add(colum4);
            vAux=obj.Posiciones;
            dataGridView1.Rows.Add(); dataGridView1.Rows.Add(); dataGridView1.Rows.Add(); 
            dataGridView1.Rows[0].Cells[0].Value = imlImagenes.Images[obj.Posiciones[0]]; //imagen1
            dataGridView1.Rows[0].Cells[1].Value = imlImagenes.Images[obj.Posiciones[1]]; //imagen2
            dataGridView1.Rows[0].Cells[2].Value = imlImagenes.Images[obj.Posiciones[2]]; //imagen3
            dataGridView1.Rows[0].Cells[3].Value = imlImagenes.Images[obj.Posiciones[3]]; //imagen4

            dataGridView1.Rows[1].Cells[0].Value = imlImagenes.Images[obj.Posiciones[4]]; //imagen5
            dataGridView1.Rows[1].Cells[1].Value = imlImagenes.Images[obj.Posiciones[5]]; //imagen6
            dataGridView1.Rows[1].Cells[2].Value = imlImagenes.Images[obj.Posiciones[6]]; //imagen7
            dataGridView1.Rows[1].Cells[3].Value = imlImagenes.Images[obj.Posiciones[7]]; //imagen8
            

            dataGridView1.Rows[2].Cells[0].Value = imlImagenes.Images[obj.Posiciones[8]]; //imagen9
            dataGridView1.Rows[2].Cells[1].Value = imlImagenes.Images[obj.Posiciones[9]]; //imagen10
            dataGridView1.Rows[2].Cells[2].Value = imlImagenes.Images[obj.Posiciones[10]]; //imagen11
            dataGridView1.Rows[2].Cells[3].Value = imlImagenes.Images[obj.Posiciones[11]]; //imagen12

            dataGridView1.Rows[3].Cells[0].Value = imlImagenes.Images[obj.Posiciones[12]];//imagen13
            dataGridView1.Rows[3].Cells[1].Value = imlImagenes.Images[obj.Posiciones[13]];//imagen14
            dataGridView1.Rows[3].Cells[2].Value = imlImagenes.Images[obj.Posiciones[14]];//imagen15
            dataGridView1.Rows[3].Cells[3].Value = imlImagenes.Images[obj.Posiciones[15]];//imagen16
            dataGridView1.Focus();

        }

        //funcion para ganar

        bool ganar()
        {
            bool a = false;
            if (vAux[0] == 1)
                if (vAux[1] == 2)
                    if (vAux[2] == 3)
                        if (vAux[3] == 4)
                            if (vAux[4] == 5)
                                if (vAux[5] == 6)
                                    if (vAux[6] == 7)
                                        if (vAux[7] == 8)
                                            if (vAux[8] == 9)
                                                if (vAux[9] == 10)
                                                    if (vAux[10] == 11)
                                                        if (vAux[11] == 12)
                                                            if (vAux[12] == 13)
                                                                if (vAux[13] == 14)
                                                                    if (vAux[14] == 15)
                                                                        if (vAux[15] == 0)
                                                                        {
                                                                            a = true;
                                                                        }
            return a;

        }

        public void mensajeganador()
        {
            swo.Stop();
            
            MessageBox.Show("Felicitaciones ha ganado el juego!!!"); timer1.Enabled = false; 
            MessageBox.Show("Su tiempo fue: " + textBox1.Text.ToString() + ":" + textBox2.Text.ToString() + ":" + textBox3.Text.ToString());
            swo.Reset();
            textBox1.Text = "00";
            textBox2.Text = "00";
            textBox3.Text = "00";
        }

        //Uso de clicks

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==3&&e.ColumnIndex==2)
            {
                if (vAux[15] == 0)
                {
                    dataGridView1.Rows[3].Cells[3].Value = dataGridView1.Rows[3].Cells[2].Value;
                    dataGridView1.Rows[3].Cells[2].Value = imlImagenes.Images[0];
                    vAux[15] = vAux[14];
                    vAux[14] = 0;
                }

                if (vAux[13] == 0)
                {
                    dataGridView1.Rows[3].Cells[1].Value = dataGridView1.Rows[3].Cells[2].Value;
                    dataGridView1.Rows[3].Cells[2].Value = imlImagenes.Images[0];
                    vAux[13] = vAux[14];
                    vAux[14] = 0;
                    
                }
                if (vAux[10] == 0)
                {
                    dataGridView1.Rows[2].Cells[2].Value = dataGridView1.Rows[3].Cells[2].Value;
                    dataGridView1.Rows[3].Cells[2].Value = imlImagenes.Images[0];
                    vAux[10] = vAux[14];
                    vAux[14] = 0;
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 3 && e.ColumnIndex == 3) 
            {
                if (vAux[11] == 0)
                {
                    dataGridView1.Rows[2].Cells[3].Value = dataGridView1.Rows[3].Cells[3].Value;
                    dataGridView1.Rows[3].Cells[3].Value = imlImagenes.Images[0];
                    vAux[11] = vAux[15];
                    vAux[15] = 0;
                }

                if (vAux[14] == 0)
                {
                    dataGridView1.Rows[3].Cells[2].Value = dataGridView1.Rows[3].Cells[3].Value;
                    dataGridView1.Rows[3].Cells[3].Value = imlImagenes.Images[0];
                    vAux[14] = vAux[15];
                    vAux[15] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 3 && e.ColumnIndex == 1)
            {
                if (vAux[9] == 0)
                {
                    dataGridView1.Rows[2].Cells[1].Value = dataGridView1.Rows[3].Cells[1].Value;
                    dataGridView1.Rows[3].Cells[1].Value = imlImagenes.Images[0];
                    vAux[9] = vAux[13];
                    vAux[13] = 0; 
                }

                if (vAux[14] == 0)
                {
                    dataGridView1.Rows[3].Cells[2].Value = dataGridView1.Rows[3].Cells[1].Value;
                    dataGridView1.Rows[3].Cells[1].Value = imlImagenes.Images[0];
                    vAux[14] = vAux[13];
                    vAux[13] = 0; 
                }
                if (vAux[12] == 0)
                {
                    dataGridView1.Rows[3].Cells[0].Value = dataGridView1.Rows[3].Cells[1].Value;
                    dataGridView1.Rows[3].Cells[1].Value = imlImagenes.Images[0];
                    vAux[12] = vAux[13];
                    vAux[13] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 3 && e.ColumnIndex == 0)
            {
                if (vAux[8] == 0)
                {
                    dataGridView1.Rows[2].Cells[0].Value = dataGridView1.Rows[3].Cells[0].Value;
                    dataGridView1.Rows[3].Cells[0].Value = imlImagenes.Images[0];
                    vAux[8] = vAux[12];
                    vAux[12] = 0; 
                }

                if (vAux[13] == 0)
                {
                    dataGridView1.Rows[3].Cells[1].Value = dataGridView1.Rows[3].Cells[0].Value;
                    dataGridView1.Rows[3].Cells[0].Value = imlImagenes.Images[0];
                    vAux[13] = vAux[12];
                    vAux[12] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 2 && e.ColumnIndex == 3)
            {
                if (vAux[15] == 0)
                {
                    dataGridView1.Rows[3].Cells[3].Value = dataGridView1.Rows[2].Cells[3].Value;
                    dataGridView1.Rows[2].Cells[3].Value = imlImagenes.Images[0];
                    vAux[15] = vAux[11];
                    vAux[11] = 0; 
                }

                if (vAux[7] == 0)
                {
                    dataGridView1.Rows[1].Cells[3].Value = dataGridView1.Rows[2].Cells[3].Value;
                    dataGridView1.Rows[2].Cells[3].Value = imlImagenes.Images[0];
                    vAux[7] = vAux[11];
                    vAux[11] = 0; 
                }
                if (vAux[10] == 0)
                {
                    dataGridView1.Rows[2].Cells[2].Value = dataGridView1.Rows[2].Cells[3].Value;
                    dataGridView1.Rows[2].Cells[3].Value = imlImagenes.Images[0];
                    vAux[10] = vAux[11];
                    vAux[11] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 2 && e.ColumnIndex == 2)
            {
                if (vAux[6] == 0)
                {
                    dataGridView1.Rows[1].Cells[2].Value = dataGridView1.Rows[2].Cells[2].Value;
                    dataGridView1.Rows[2].Cells[2].Value = imlImagenes.Images[0];
                    vAux[6] = vAux[10];
                    vAux[10] = 0; 
                }

                if (vAux[9] == 0)
                {
                    dataGridView1.Rows[2].Cells[1].Value = dataGridView1.Rows[2].Cells[2].Value;
                    dataGridView1.Rows[2].Cells[2].Value = imlImagenes.Images[0];
                    vAux[9] = vAux[10];
                    vAux[10] = 0; 
                }
                if (vAux[11] == 0)
                {
                    dataGridView1.Rows[2].Cells[3].Value = dataGridView1.Rows[2].Cells[2].Value;
                    dataGridView1.Rows[2].Cells[2].Value = imlImagenes.Images[0];
                    vAux[11] = vAux[10];
                    vAux[10] = 0; 
                }
                if (vAux[14] == 0)
                {
                    dataGridView1.Rows[3].Cells[2].Value = dataGridView1.Rows[2].Cells[2].Value;
                    dataGridView1.Rows[2].Cells[2].Value = imlImagenes.Images[0];
                    vAux[14] = vAux[10];
                    vAux[10] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 2 && e.ColumnIndex == 1)
            {
                if (vAux[5] == 0)
                {
                    dataGridView1.Rows[1].Cells[1].Value = dataGridView1.Rows[2].Cells[1].Value;
                    dataGridView1.Rows[2].Cells[1].Value = imlImagenes.Images[0];
                    vAux[5] = vAux[9];
                    vAux[9] = 0; 
                }

                if (vAux[8] == 0)
                {
                    dataGridView1.Rows[2].Cells[0].Value = dataGridView1.Rows[2].Cells[1].Value;
                    dataGridView1.Rows[2].Cells[1].Value = imlImagenes.Images[0];
                    vAux[8] = vAux[9];
                    vAux[9] = 0; 
                }
                if (vAux[10] == 0)
                {
                    dataGridView1.Rows[2].Cells[2].Value = dataGridView1.Rows[2].Cells[1].Value;
                    dataGridView1.Rows[2].Cells[1].Value = imlImagenes.Images[0];
                    vAux[10] = vAux[9];
                    vAux[9] = 0; 
                }
                if (vAux[13] == 0)
                {
                    dataGridView1.Rows[3].Cells[1].Value = dataGridView1.Rows[2].Cells[1].Value;
                    dataGridView1.Rows[2].Cells[1].Value = imlImagenes.Images[0];
                    vAux[13] = vAux[9];
                    vAux[9] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 2 && e.ColumnIndex == 0)
            {
                if (vAux[4] == 0)
                {
                    dataGridView1.Rows[1].Cells[0].Value = dataGridView1.Rows[2].Cells[0].Value;
                    dataGridView1.Rows[2].Cells[0].Value = imlImagenes.Images[0];
                    vAux[4] = vAux[8];
                    vAux[8] = 0; 
                }

                if (vAux[12] == 0)
                {
                    dataGridView1.Rows[3].Cells[0].Value = dataGridView1.Rows[2].Cells[0].Value;
                    dataGridView1.Rows[2].Cells[0].Value = imlImagenes.Images[0];
                    vAux[12] = vAux[8];
                    vAux[8] = 0; 
                }
                if (vAux[9] == 0)
                {
                    dataGridView1.Rows[2].Cells[1].Value = dataGridView1.Rows[2].Cells[0].Value;
                    dataGridView1.Rows[2].Cells[0].Value = imlImagenes.Images[0];
                    vAux[9] = vAux[8];
                    vAux[8] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 1 && e.ColumnIndex == 3)
            {
                if (vAux[3] == 0)
                {
                    dataGridView1.Rows[0].Cells[3].Value = dataGridView1.Rows[1].Cells[3].Value;
                    dataGridView1.Rows[1].Cells[3].Value = imlImagenes.Images[0];
                    vAux[3] = vAux[7];
                    vAux[7] = 0; 
                }

                if (vAux[6] == 0)
                {
                    dataGridView1.Rows[1].Cells[2].Value = dataGridView1.Rows[1].Cells[3].Value;
                    dataGridView1.Rows[1].Cells[3].Value = imlImagenes.Images[0];
                    vAux[6] = vAux[7];
                    vAux[7] = 0; 
                }
                if (vAux[11] == 0)
                {
                    dataGridView1.Rows[2].Cells[3].Value = dataGridView1.Rows[1].Cells[3].Value;
                    dataGridView1.Rows[1].Cells[3].Value = imlImagenes.Images[0];
                    vAux[11] = vAux[7];
                    vAux[7] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 1 && e.ColumnIndex == 2)
            {
                if (vAux[2] == 0)
                {
                    dataGridView1.Rows[0].Cells[2].Value = dataGridView1.Rows[1].Cells[2].Value;
                    dataGridView1.Rows[1].Cells[2].Value = imlImagenes.Images[0];
                    vAux[2] = vAux[6];
                    vAux[6] = 0;
                }

                if (vAux[5] == 0)
                {
                    dataGridView1.Rows[1].Cells[1].Value = dataGridView1.Rows[1].Cells[2].Value;
                    dataGridView1.Rows[1].Cells[2].Value = imlImagenes.Images[0];
                    vAux[5] = vAux[6];
                    vAux[6] = 0; 
                }
                if (vAux[7] == 0)
                {
                    dataGridView1.Rows[1].Cells[3].Value = dataGridView1.Rows[1].Cells[2].Value;
                    dataGridView1.Rows[1].Cells[2].Value = imlImagenes.Images[0];
                    vAux[7] = vAux[6];
                    vAux[6] = 0;
                }
                if (vAux[10] == 0)
                {
                    dataGridView1.Rows[2].Cells[2].Value = dataGridView1.Rows[1].Cells[2].Value;
                    dataGridView1.Rows[1].Cells[2].Value = imlImagenes.Images[0];
                    vAux[10] = vAux[6];
                    vAux[6] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 1 && e.ColumnIndex == 1)
            {
                if (vAux[1] == 0)
                {
                    dataGridView1.Rows[0].Cells[1].Value = dataGridView1.Rows[1].Cells[1].Value;
                    dataGridView1.Rows[1].Cells[1].Value = imlImagenes.Images[0];
                    vAux[1] = vAux[5];
                    vAux[5] = 0; 
                }

                if (vAux[4] == 0)
                {
                    dataGridView1.Rows[1].Cells[0].Value = dataGridView1.Rows[1].Cells[1].Value;
                    dataGridView1.Rows[1].Cells[1].Value = imlImagenes.Images[0];
                    vAux[4] = vAux[5];
                    vAux[5] = 0; 
                }
                if (vAux[6] == 0)
                {
                    dataGridView1.Rows[1].Cells[2].Value = dataGridView1.Rows[1].Cells[1].Value;
                    dataGridView1.Rows[1].Cells[1].Value = imlImagenes.Images[0];
                    vAux[6] = vAux[5];
                    vAux[5] = 0; 
                }
                if (vAux[9] == 0)
                {
                    dataGridView1.Rows[2].Cells[1].Value = dataGridView1.Rows[1].Cells[1].Value;
                    dataGridView1.Rows[1].Cells[1].Value = imlImagenes.Images[0];
                    vAux[9] = vAux[5];
                    vAux[5] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 1 && e.ColumnIndex == 0)
            {
                if (vAux[0] == 0)
                {
                    dataGridView1.Rows[0].Cells[0].Value = dataGridView1.Rows[1].Cells[0].Value;
                    dataGridView1.Rows[1].Cells[0].Value = imlImagenes.Images[0];
                    vAux[0] = vAux[4];
                    vAux[4] = 0; 
                }

                if (vAux[5] == 0)
                {
                    dataGridView1.Rows[1].Cells[1].Value = dataGridView1.Rows[1].Cells[0].Value;
                    dataGridView1.Rows[1].Cells[0].Value = imlImagenes.Images[0];
                    vAux[5] = vAux[4];
                    vAux[4] = 0; 
                }
                if (vAux[8] == 0)
                {
                    dataGridView1.Rows[2].Cells[0].Value = dataGridView1.Rows[1].Cells[0].Value;
                    dataGridView1.Rows[1].Cells[0].Value = imlImagenes.Images[0];
                    vAux[8] = vAux[4];
                    vAux[4] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 0 && e.ColumnIndex == 3)
            {
                if (vAux[2] == 0)
                {
                    dataGridView1.Rows[0].Cells[2].Value = dataGridView1.Rows[0].Cells[3].Value;
                    dataGridView1.Rows[0].Cells[3].Value = imlImagenes.Images[0];
                    vAux[2] = vAux[3];
                    vAux[3] = 0; 
                }

                if (vAux[7] == 0)
                {
                    dataGridView1.Rows[1].Cells[3].Value = dataGridView1.Rows[0].Cells[3].Value;
                    dataGridView1.Rows[0].Cells[3].Value = imlImagenes.Images[0];
                    vAux[7] = vAux[3];
                    vAux[3] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 0 && e.ColumnIndex == 2)
            {
                if (vAux[1] == 0)
                {
                    dataGridView1.Rows[0].Cells[1].Value = dataGridView1.Rows[0].Cells[2].Value;
                    dataGridView1.Rows[0].Cells[2].Value = imlImagenes.Images[0];
                    vAux[1] = vAux[2];
                    vAux[2] = 0; 
                }

                if (vAux[3] == 0)
                {
                    dataGridView1.Rows[0].Cells[3].Value = dataGridView1.Rows[0].Cells[2].Value;
                    dataGridView1.Rows[0].Cells[2].Value = imlImagenes.Images[0];
                    vAux[3] = vAux[2];
                    vAux[2] = 0; 
                }
                if (vAux[6] == 0)
                {
                    dataGridView1.Rows[1].Cells[2].Value = dataGridView1.Rows[0].Cells[2].Value;
                    dataGridView1.Rows[0].Cells[2].Value = imlImagenes.Images[0];
                    vAux[6] = vAux[2];
                    vAux[2] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 0 && e.ColumnIndex == 1)
            {
                if (vAux[0] == 0)
                {
                    dataGridView1.Rows[0].Cells[0].Value = dataGridView1.Rows[0].Cells[1].Value;
                    dataGridView1.Rows[0].Cells[1].Value = imlImagenes.Images[0];
                    vAux[0] = vAux[1];
                    vAux[1] = 0; 
                }

                if (vAux[2] == 0)
                {
                    dataGridView1.Rows[0].Cells[2].Value = dataGridView1.Rows[0].Cells[1].Value;
                    dataGridView1.Rows[0].Cells[1].Value = imlImagenes.Images[0];
                    vAux[2] = vAux[1];
                    vAux[1] = 0; 
                }
                if (vAux[5] == 0)
                {
                    dataGridView1.Rows[1].Cells[1].Value = dataGridView1.Rows[0].Cells[1].Value;
                    dataGridView1.Rows[0].Cells[1].Value = imlImagenes.Images[0];
                    vAux[5] = vAux[1];
                    vAux[1] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            if (e.RowIndex == 0 && e.ColumnIndex == 0)
            {
                if (vAux[1] == 0)
                {
                    dataGridView1.Rows[0].Cells[1].Value = dataGridView1.Rows[0].Cells[0].Value;
                    dataGridView1.Rows[0].Cells[0].Value = imlImagenes.Images[0];
                    vAux[1] = vAux[0];
                    vAux[0] = 0; 
                }

                if (vAux[4] == 0)
                {
                    dataGridView1.Rows[1].Cells[0].Value = dataGridView1.Rows[0].Cells[0].Value;
                    dataGridView1.Rows[0].Cells[0].Value = imlImagenes.Images[0];
                    vAux[4] = vAux[0];
                    vAux[0] = 0; 
                }

                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
        }
       
        //Uso de teclas

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (vAux[15] == 0)
            {
                if (e.KeyCode == Keys.Right)
                {
                    
                    dataGridView1.Rows[3].Cells[3].Value = dataGridView1.Rows[3].Cells[2].Value;
                    dataGridView1.Rows[3].Cells[2].Value = imlImagenes.Images[0];
                    vAux[15] = vAux[14];
                    vAux[14] = 0;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[3].Cells[3].Value = dataGridView1.Rows[2].Cells[3].Value;
                    dataGridView1.Rows[2].Cells[3].Value = imlImagenes.Images[0];
                    vAux[15] = vAux[11];
                    vAux[11] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[14] == 0)
            {
                if (e.KeyCode == Keys.Right)
                {
                    dataGridView1.Rows[3].Cells[2].Value = dataGridView1.Rows[3].Cells[1].Value;
                    dataGridView1.Rows[3].Cells[1].Value = imlImagenes.Images[0];
                    vAux[14] = vAux[13];
                    vAux[13] = 0; 
                }
                else if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[3].Cells[2].Value = dataGridView1.Rows[3].Cells[3].Value;
                    dataGridView1.Rows[3].Cells[3].Value = imlImagenes.Images[0];
                    vAux[14] = vAux[15];
                    vAux[15] = 0; 
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[3].Cells[2].Value = dataGridView1.Rows[2].Cells[2].Value;
                    dataGridView1.Rows[2].Cells[2].Value = imlImagenes.Images[0];
                    vAux[14] = vAux[10];
                    vAux[10] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[13] == 0)
            {
                if (e.KeyCode == Keys.Right)
                {
                    dataGridView1.Rows[3].Cells[1].Value = dataGridView1.Rows[3].Cells[0].Value;
                    dataGridView1.Rows[3].Cells[0].Value = imlImagenes.Images[0];
                    vAux[13] = vAux[12];
                    vAux[12] = 0; 
                }
                else if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[3].Cells[1].Value = dataGridView1.Rows[3].Cells[2].Value;
                    dataGridView1.Rows[3].Cells[2].Value = imlImagenes.Images[0];
                    vAux[13] = vAux[14];
                    vAux[14] = 0; 
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[3].Cells[1].Value = dataGridView1.Rows[2].Cells[1].Value;
                    dataGridView1.Rows[2].Cells[1].Value = imlImagenes.Images[0];
                    vAux[13] = vAux[9];
                    vAux[9] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[12] == 0)
            {
                if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[3].Cells[0].Value = dataGridView1.Rows[3].Cells[1].Value;
                    dataGridView1.Rows[3].Cells[1].Value = imlImagenes.Images[0];
                    vAux[12] = vAux[13];
                    vAux[13] = 0; 
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[3].Cells[0].Value = dataGridView1.Rows[2].Cells[0].Value;
                    dataGridView1.Rows[2].Cells[0].Value = imlImagenes.Images[0];
                    vAux[12] = vAux[8];
                    vAux[8] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[11] == 0)
            {
                if (e.KeyCode == Keys.Right)
                {
                    dataGridView1.Rows[2].Cells[3].Value = dataGridView1.Rows[2].Cells[2].Value;
                    dataGridView1.Rows[2].Cells[2].Value = imlImagenes.Images[0];
                    vAux[11] = vAux[10];
                    vAux[10] = 0; 
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[2].Cells[3].Value = dataGridView1.Rows[3].Cells[3].Value;
                    dataGridView1.Rows[3].Cells[3].Value = imlImagenes.Images[0];
                    vAux[11] = vAux[15];
                    vAux[15] = 0; 
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[2].Cells[3].Value = dataGridView1.Rows[1].Cells[3].Value;
                    dataGridView1.Rows[1].Cells[3].Value = imlImagenes.Images[0];
                    vAux[11] = vAux[7];
                    vAux[7] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[10] == 0)
            {
                if (e.KeyCode == Keys.Right)
                {
                    dataGridView1.Rows[2].Cells[2].Value = dataGridView1.Rows[2].Cells[1].Value;
                    dataGridView1.Rows[2].Cells[1].Value = imlImagenes.Images[0];
                    vAux[10] = vAux[9];
                    vAux[9] = 0; 
                }
                else if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[2].Cells[2].Value = dataGridView1.Rows[2].Cells[3].Value;
                    dataGridView1.Rows[2].Cells[3].Value = imlImagenes.Images[0];
                    vAux[10] = vAux[11];
                    vAux[11] = 0; 
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[2].Cells[2].Value = dataGridView1.Rows[3].Cells[2].Value;
                    dataGridView1.Rows[3].Cells[2].Value = imlImagenes.Images[0];
                    vAux[10] = vAux[14];
                    vAux[14] = 0; 
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[2].Cells[2].Value = dataGridView1.Rows[1].Cells[2].Value;
                    dataGridView1.Rows[1].Cells[2].Value = imlImagenes.Images[0];
                    vAux[10] = vAux[6];
                    vAux[6] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[9] == 0)
            {
                if (e.KeyCode == Keys.Right)
                {
                    dataGridView1.Rows[2].Cells[1].Value = dataGridView1.Rows[2].Cells[0].Value;
                    dataGridView1.Rows[2].Cells[0].Value = imlImagenes.Images[0];
                    vAux[9] = vAux[8];
                    vAux[8] = 0; 
                }
                else if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[2].Cells[1].Value = dataGridView1.Rows[2].Cells[2].Value;
                    dataGridView1.Rows[2].Cells[2].Value = imlImagenes.Images[0];
                    vAux[9] = vAux[10];
                    vAux[10] = 0; 

                }
                else if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[2].Cells[1].Value = dataGridView1.Rows[3].Cells[1].Value;
                    dataGridView1.Rows[3].Cells[1].Value = imlImagenes.Images[0];
                    vAux[9] = vAux[13];
                    vAux[13] = 0; 
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[2].Cells[1].Value = dataGridView1.Rows[1].Cells[1].Value;
                    dataGridView1.Rows[1].Cells[1].Value = imlImagenes.Images[0];
                    vAux[9] = vAux[5];
                    vAux[5] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[8] == 0)
            {
                if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[2].Cells[0].Value = dataGridView1.Rows[2].Cells[1].Value;
                    dataGridView1.Rows[2].Cells[1].Value = imlImagenes.Images[0];
                    vAux[8] = vAux[9];
                    vAux[9] = 0; 
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[2].Cells[0].Value = dataGridView1.Rows[1].Cells[0].Value;
                    dataGridView1.Rows[1].Cells[0].Value = imlImagenes.Images[0];
                    vAux[8] = vAux[4];
                    vAux[4] = 0; 
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[2].Cells[0].Value = dataGridView1.Rows[3].Cells[0].Value;
                    dataGridView1.Rows[3].Cells[0].Value = imlImagenes.Images[0];
                    vAux[8] = vAux[12];
                    vAux[12] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[7] == 0)
            {
                if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[1].Cells[3].Value = dataGridView1.Rows[2].Cells[3].Value;
                    dataGridView1.Rows[2].Cells[3].Value = imlImagenes.Images[0];
                    vAux[7] = vAux[11];
                    vAux[11] = 0; 
                }
                else if (e.KeyCode == Keys.Right)
                {
                    dataGridView1.Rows[1].Cells[3].Value = dataGridView1.Rows[1].Cells[2].Value;
                    dataGridView1.Rows[1].Cells[2].Value = imlImagenes.Images[0];
                    vAux[7] = vAux[6];
                    vAux[6] = 0; 
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[1].Cells[3].Value = dataGridView1.Rows[0].Cells[3].Value;
                    dataGridView1.Rows[0].Cells[3].Value = imlImagenes.Images[0];
                    vAux[7] = vAux[3];
                    vAux[3] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[6] == 0)
            {
                if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[1].Cells[2].Value = dataGridView1.Rows[0].Cells[2].Value;
                    dataGridView1.Rows[0].Cells[2].Value = imlImagenes.Images[0];
                    vAux[6] = vAux[2];
                    vAux[2] = 0; 
                }
                else if (e.KeyCode == Keys.Right)
                {
                    dataGridView1.Rows[1].Cells[2].Value = dataGridView1.Rows[1].Cells[1].Value;
                    dataGridView1.Rows[1].Cells[1].Value = imlImagenes.Images[0];
                    vAux[6] = vAux[5];
                    vAux[5] = 0; 
                }
                else if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[1].Cells[2].Value = dataGridView1.Rows[1].Cells[3].Value;
                    dataGridView1.Rows[1].Cells[3].Value = imlImagenes.Images[0];
                    vAux[6] = vAux[7];
                    vAux[7] = 0; 
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[1].Cells[2].Value = dataGridView1.Rows[2].Cells[2].Value;
                    dataGridView1.Rows[2].Cells[2].Value = imlImagenes.Images[0];
                    vAux[6] = vAux[10];
                    vAux[10] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[5] == 0)
            {
                if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[1].Cells[1].Value = dataGridView1.Rows[2].Cells[1].Value;
                    dataGridView1.Rows[2].Cells[1].Value = imlImagenes.Images[0];
                    vAux[5] = vAux[9];
                    vAux[9] = 0; 
                } 
                else if (e.KeyCode == Keys.Right)
                {
                    dataGridView1.Rows[1].Cells[1].Value = dataGridView1.Rows[1].Cells[0].Value;
                    dataGridView1.Rows[1].Cells[0].Value = imlImagenes.Images[0];
                    vAux[5] = vAux[4];
                    vAux[4] = 0; 
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[1].Cells[1].Value = dataGridView1.Rows[0].Cells[1].Value;
                    dataGridView1.Rows[0].Cells[1].Value = imlImagenes.Images[0];
                    vAux[5] = vAux[1];
                    vAux[1] = 0; 
                }
                else if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[1].Cells[1].Value = dataGridView1.Rows[1].Cells[2].Value;
                    dataGridView1.Rows[1].Cells[2].Value = imlImagenes.Images[0];
                    vAux[5] = vAux[6];
                    vAux[6] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[4] == 0)
            {
                if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[1].Cells[0].Value = dataGridView1.Rows[1].Cells[1].Value;
                    dataGridView1.Rows[1].Cells[1].Value = imlImagenes.Images[0];
                    vAux[4] = vAux[5];
                    vAux[5] = 0; 
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dataGridView1.Rows[1].Cells[0].Value = dataGridView1.Rows[0].Cells[0].Value;
                    dataGridView1.Rows[0].Cells[0].Value = imlImagenes.Images[0];
                    vAux[4] = vAux[0];
                    vAux[0] = 0; 
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[1].Cells[0].Value = dataGridView1.Rows[2].Cells[0].Value;
                    dataGridView1.Rows[2].Cells[0].Value = imlImagenes.Images[0];
                    vAux[4] = vAux[8];
                    vAux[8] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[3] == 0)
            {
                if (e.KeyCode == Keys.Right)
                {
                    dataGridView1.Rows[0].Cells[3].Value = dataGridView1.Rows[0].Cells[2].Value;
                    dataGridView1.Rows[0].Cells[2].Value = imlImagenes.Images[0];
                    vAux[3] = vAux[2];
                    vAux[2] = 0; 
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[0].Cells[3].Value = dataGridView1.Rows[1].Cells[3].Value;
                    dataGridView1.Rows[1].Cells[3].Value = imlImagenes.Images[0];
                    vAux[3] = vAux[7];
                    vAux[7] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[2] == 0)
            {
                if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[0].Cells[2].Value = dataGridView1.Rows[1].Cells[2].Value;
                    dataGridView1.Rows[1].Cells[2].Value = imlImagenes.Images[0];
                    vAux[2] = vAux[6];
                    vAux[6] = 0; 
                }
                else if (e.KeyCode == Keys.Right)
                {
                    dataGridView1.Rows[0].Cells[2].Value = dataGridView1.Rows[0].Cells[1].Value;
                    dataGridView1.Rows[0].Cells[1].Value = imlImagenes.Images[0];
                    vAux[2] = vAux[1];
                    vAux[1] = 0; 
                }
                else if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[0].Cells[2].Value = dataGridView1.Rows[0].Cells[3].Value;
                    dataGridView1.Rows[0].Cells[3].Value = imlImagenes.Images[0];
                    vAux[2] = vAux[3];
                    vAux[3] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[1] == 0)
            {
                if (e.KeyCode == Keys.Right)
                {
                    dataGridView1.Rows[0].Cells[1].Value = dataGridView1.Rows[0].Cells[0].Value;
                    dataGridView1.Rows[0].Cells[0].Value = imlImagenes.Images[0];
                    vAux[1] = vAux[0];
                    vAux[0] = 0; 
                }
                else if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[0].Cells[1].Value = dataGridView1.Rows[0].Cells[2].Value;
                    dataGridView1.Rows[0].Cells[2].Value = imlImagenes.Images[0];
                    vAux[1] = vAux[2];
                    vAux[2] = 0; 
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[0].Cells[1].Value = dataGridView1.Rows[1].Cells[1].Value;
                    dataGridView1.Rows[1].Cells[1].Value = imlImagenes.Images[0];
                    vAux[1] = vAux[5];
                    vAux[5] = 0;
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
            else if (vAux[0] == 0)
            {
                if (e.KeyCode == Keys.Left)
                {
                    dataGridView1.Rows[0].Cells[0].Value = dataGridView1.Rows[0].Cells[1].Value;
                    dataGridView1.Rows[0].Cells[1].Value = imlImagenes.Images[0];
                    vAux[0] = vAux[1];
                    vAux[1] = 0; 
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dataGridView1.Rows[0].Cells[0].Value = dataGridView1.Rows[1].Cells[0].Value;
                    dataGridView1.Rows[1].Cells[0].Value = imlImagenes.Images[0];
                    vAux[0] = vAux[4];
                    vAux[4] = 0; 
                }
                if (ganar() == true)
                {
                    mensajeganador();
                }
            }
        }

        //TIEMPO

        Stopwatch swo = new Stopwatch();

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0,0,0,0,(int)swo.ElapsedMilliseconds);
            textBox1.Text = ts.Hours.ToString().Length < 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();
            textBox2.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            textBox3.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             swo.Stop();
            dataGridView1.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            swo.Start();
            dataGridView1.Enabled = true;
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
            //MessageBox.Show(e.ColumnIndex.ToString());
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

    }
}
