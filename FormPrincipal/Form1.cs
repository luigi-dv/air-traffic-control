using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightsLib;

namespace FormPrincipal
{
    public partial class Form1 : Form
    {
        const string IMG = "\\Resources\\Graphics\\plane.png";
        const string IMGBG = "\\Resources\\Backgrounds\\spainBg.png";
        const int MAX = 100;

        private FlightsList myFlightList = new FlightsList();
        private Sector mySector = new Sector();

        private PictureBox[] aircraftVector = new PictureBox[MAX];
       
        //for(int i = 0; i<myFlightList.number;i++)MessageBox.Show(myFlightList.Flights[i].flightID);
        public Form1()
        {
            InitializeComponent();

        }

        private void loadFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecciona el fichero con la lista de vuelos";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                int result = myFlightList.LoadFlightsFile(filename);
                if (result != 0)
                {
                    if (result == -1)
                    {
                        MessageBox.Show("Windows no puede encontrar el archivo " + '"' + openFileDialog1.FileName + '"' + ". Asegúrese que el nombre esté bien escrito correctamente e inténtelo de nuevo.",
                                        openFileDialog1.FileName,
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (result == -2)
                        {

                            MessageBox.Show("El fichero " + '"' + openFileDialog1.FileName + '"' + " no tiene el formato deseado, por favor seleccione un fichero con el formato adecuado", '"' + openFileDialog1.FileName + '"',
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Ha habido un problema por favor reinicie el programa.", "Error",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    string path = System.IO.Directory.GetCurrentDirectory();
                    string imageFile = path + IMG;

                    for (int i = 0; i < myFlightList.number; i++)
                    {
                        aircraftVector[i] = new PictureBox();
                        aircraftVector[i].ClientSize = new Size(20, 20);
                        aircraftVector[i].Location = new Point((int)myFlightList.Flights[i].positionX, (int)myFlightList.Flights[i].positionY);
                        aircraftVector[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        try
                        {
                            Bitmap image = new Bitmap(imageFile);
                            aircraftVector[i].Image = (Image)image;
                            panel1.Controls.Add(aircraftVector[i]);
                        }
                        catch
                        {

                            MessageBox.Show("El fichero " + '"' + imageFile + '"' + " no se ha encontrado", '"' + imageFile + '"',
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Check if the first list vector is empty and ask the user ab this
            if (myFlightList.Flights[0] == null)
            {
                var result = MessageBox.Show("¿Esta seguro que desea guardar la lista?", "La lista esta vacia",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);           
                if(result == DialogResult.Yes)
                {
                    saveFileDialog1.Title = "Guardar Como";
                    saveFileDialog1.InitialDirectory = @"C:\";
                    saveFileDialog1.FileName = "";
                    saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                    saveFileDialog1.FilterIndex = 2;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {

                        string filename = saveFileDialog1.FileName;
                        myFlightList.SaveList(filename);
                    }
                }
            }
            //Dada inside the list 
            else
            {
                saveFileDialog1.Title = "Guardar Como";
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog1.FilterIndex = 2;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string filename = saveFileDialog1.FileName;
                    myFlightList.SaveList(filename);
                }
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
