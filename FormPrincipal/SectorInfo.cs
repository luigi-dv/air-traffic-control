using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class SectorInfo : Form
    {
     
        //Getters & Setters 
        public string SectorID
        {
            get { return idValue.Text; }
            set { idValue.Text = value; }
        }
        public string Capacity
        {
            get { return capacityValue.Text; }
            set { capacityValue.Text = value; }
        }
        public string Ocupation
        {
            get { return ocupationValue.Text; }
            set { ocupationValue.Text = value; }
        }
        public string Origin
        {
            get { return originValue.Text; }
            set { originValue.Text = value; }
        }
        public string Final
        {
            get { return finalValue.Text; }
            set { finalValue.Text = value; }
        }
        public string SectorWidth
        {
            get { return widthValue.Text; }
            set { widthValue.Text = value; }
        }

        public string SectorHeight
        {
            get { return heightValue.Text; }
            set { heightValue.Text = value; }
        }
        public SectorInfo()
        {
            InitializeComponent();
        }

        private void Sector_Load(object sender, EventArgs e)
        {

        }
    }
}
