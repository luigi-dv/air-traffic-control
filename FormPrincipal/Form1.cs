using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightsLib;

namespace FormPrincipal
{
    public partial class Form1 : Form
    {
        const string IMG = "Resources\\Graphics\\plane.png";
        const string IMGBG = "Resources\\Backgrounds\\spainBg.png";

        //300 flights inside the picture box array
        const int MAX = 300;

        //The flight list
        private FlightsList myFlightList = new FlightsList();

        //The sector
        private Sector mySector = new Sector();

        //A single flight
        private Flight myFlight = new Flight();
        
        private PictureBox[] aircraftVector = new PictureBox[MAX];
       
       
        public Form1()
        {
            InitializeComponent();
        }

        //Strip Menu CARGAR VUELOS
        private void LoadFlightsToolStripMenuItem_Click(object sender, EventArgs e)
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
                    
                   /*   This code for Debug route (bin/debug..)
                        string path = System.IO.Directory.GetCurrentDirectory();
                        string imageFile = path + IMG;
                   */

                    string imageFile = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, IMG);
                    for (int i = 0; i < myFlightList.number; i++)
                    {
                        aircraftVector[i] = new PictureBox();
                        aircraftVector[i].ClientSize = new Size(20, 20);
                        aircraftVector[i].Location = new Point((int)myFlightList.Flights[i].positionX, (int)myFlightList.Flights[i].positionY);
                        aircraftVector[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        aircraftVector[i].Tag = myFlightList.Flights[i];
                        aircraftVector[i].Click += new System.EventHandler(this.AircraftVector_Click);
                        try
                        {
                            Bitmap image = new Bitmap(imageFile);
                            aircraftVector[i].Image = (Image)image;
                            panel1.Controls.Add(aircraftVector[i]);
                        }
                        catch
                        {
                            MessageBox.Show("El fichero " + '"' + imageFile + '"' + " no se ha encontrado, posiblemente la carpeta Resources esté comprometida",
                                             '"' + imageFile + '"', MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }

            }
        }

        //Flight click
        private void AircraftVector_Click(object sender, EventArgs e)
        {
            //Receiving the PictureBox
            PictureBox flightBox = (PictureBox)sender;
            //Declaring the new form
            Form3 f3 = new Form3();
            //On click plane icon background will be green
            flightBox.BackColor = Color.Green;
            //Getting the info from the tag, myFlight declared in line 31
            myFlight = (Flight)flightBox.Tag;
            //Pass Flight info to the f3 form
            f3.SetInfo(myFlight);
            //Show the f3 form
            f3.ShowDialog();
            //When f3 is closed the color returns to transparent
            flightBox.BackColor = Color.Transparent;
        }

        //Strip Menu Cargar Sector
        private void CargarSectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "Selecciona el fichero con la lista de vuelos";
            openFileDialog2.InitialDirectory = @"C:\";
            openFileDialog2.FileName = "";
            openFileDialog2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.Multiselect = false;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog2.FileName;

                int result = mySector.LoadSectorFile(filename);
                if (result != 0)
                {
                    if (result == -1)
                    {
                        MessageBox.Show("Windows no puede encontrar el archivo " + '"' + openFileDialog2.FileName + '"' + ". Asegúrese que el nombre esté bien escrito correctamente e inténtelo de nuevo.",
                                        openFileDialog2.FileName,
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (result == -2)
                        {

                            MessageBox.Show("El fichero " + '"' + openFileDialog2.FileName + '"' + " no tiene el formato deseado, por favor seleccione un fichero con el formato adecuado", '"' + openFileDialog2.FileName + '"',
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
                    panel1.Invalidate();
                }

            }
        }

        //Strip Menu to save our list
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            //Xo,Yo (Left top corner)
            Point x0y0 = new Point(Convert.ToInt32(mySector.positionX), Convert.ToInt32(mySector.positionY));
            //Xo,Yf (Left bottom corner)
            Point x0yF = new Point(Convert.ToInt32(mySector.positionX), Convert.ToInt32(mySector.positionY + mySector.height));
            //Xf,Yf (Right bottom corner)
            Point xFyF = new Point(Convert.ToInt32(mySector.positionX + mySector.width), Convert.ToInt32(mySector.positionY + mySector.height));
            //Xo,Yo (Right top corner)
            Point xFy0 = new Point(Convert.ToInt32(mySector.positionX + mySector.width), Convert.ToInt32(mySector.positionY));

            System.Drawing.Graphics graphics = e.Graphics;
            //Colour to draw the rectangle
            Pen myPen = new Pen(Color.Red);
            // Points that define the rectangle
            Point[] polygonPoints = new Point[4];
            polygonPoints[0] = x0y0;
            polygonPoints[1] = x0yF;
            polygonPoints[2] = xFyF;
            polygonPoints[3] = xFy0;
            //Draw the rectangle
            graphics.DrawPolygon(myPen, polygonPoints);
            myPen.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void listaDeVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
