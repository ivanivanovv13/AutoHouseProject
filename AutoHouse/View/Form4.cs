using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace AutoHouse.View
{
    public partial class Form4 : Form
    {
        Users user;
        List<AutoHouse> autoHouses = new List<AutoHouse>();
        bool flag = false;

        Label[] labelsAH = new Label[5];
        Label[] labelsCars = new Label[5];
        PictureBox[] pictureBoxesCars = new PictureBox[5];
        private int curentAhID;

        int startCar = 0;
        int startAH = 0;


        public Form4(Users user,List<AutoHouse> autoHouse)
        {
            
            this.user = user;
            this.autoHouses = autoHouse;

            flag = false;

            InitializeComponent();
        }

        public Form4(Users user, List<AutoHouse> autoHouse,int curentAH,int startCar,int startAH)
        {
            

            this.user = user;
            this.autoHouses = autoHouse;
            this.curentAhID = curentAH;
            this.startCar = startCar;
            this.startAH = startAH;

            flag = true;

            


            InitializeComponent();
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addLabelAndPictureBox()
        {
            labelsAH[0] = lblAH1;
            labelsAH[1] = lblAH2;
            labelsAH[2] = lblAH3;
            labelsAH[3] = label4;
            labelsAH[4] = lblAH5;

            labelsCars[0] = label2;
            labelsCars[1] = label3;
            labelsCars[2] = label5;
            labelsCars[3] = label6;
            labelsCars[4] = label7;

            pictureBoxesCars[0] = pictureBox1;
            pictureBoxesCars[1] = pictureBox2;
            pictureBoxesCars[2] = pictureBox3;
            pictureBoxesCars[3] = pictureBox4;
            pictureBoxesCars[4] = pictureBox5;

             
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            addLabelAndPictureBox();

            btnPreviousAH.Visible = false;
            btnPreviousCars.Visible = false;
            btnNextCars.Visible = false;
            if (autoHouses.Count() < 5)
            {
                btnNextAH.Visible = false;
            }

            displayAH(startAH);
            if(flag)
            {
                displayCars(startCar, autoHouses[curentAhID]);
            }

        }
        
        private void displayAH(int start)
        {
            int n=0;
            for (int i = start; i < start+5; i++)
            {
                if (i < autoHouses.Count())
                {
                    labelsAH[n].Visible = true;
                    labelsAH[n].Text = i + 1 + " " + autoHouses[i].Name + " " + autoHouses[i].Adres + " " + autoHouses[i].Town;
                }                   
                else
                    labelsAH[n].Visible = false;
                n++;
            }
        }

        private void displayCars(int start, AutoHouse autoHouse)
        {
            int n = 0;
            for (int i = start; i < start+5; i++)
            {
                if(i<autoHouse.CarsForSell.Count())
                {
                    labelsCars[n].Visible = true;
                    pictureBoxesCars[n].Visible = true;
                    labelsCars[n].Text = autoHouse.CarsForSell[i].Brand + " " + autoHouse.CarsForSell[i].Model;
                    pictureBoxesCars[n].Image = autoHouse.CarsForSell[i].Pic;
                }
                else
                {
                    labelsCars[n].Visible = false;
                    pictureBoxesCars[n].Visible = false;
                }
                n++;
            }
            if (start >= autoHouses[curentAhID].CarsForSell.Count() - 5)
            {
                btnNextCars.Visible = false;
            }
            else
            {
                btnNextCars.Visible = true;
            }
            if (start == 0)
            {
                btnPreviousCars.Visible = false;
            }
            else
            {
                btnPreviousCars.Visible = true;
            }

        }

        private void lblAH1_Click(object sender, EventArgs e)
        {
            if (5 < autoHouses[startAH].CarsForSell.Count())
                btnNextCars.Visible = true;
            curentAhID = startAH;
            startCar = 0;
            displayCars(startCar, autoHouses[startAH]);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fm =new  Form2(user,autoHouses);
            fm.Show();
            this.Hide();
        }

        private void lblAH2_Click(object sender, EventArgs e)
        {
            if (5 < autoHouses[startAH+1].CarsForSell.Count())
                btnNextCars.Visible = true;
            curentAhID = startAH+1;
            startCar = 0;
            displayCars(startCar, autoHouses[startAH+1]);
        }

        private void lblAH3_Click(object sender, EventArgs e)
        {
            if (5 < autoHouses[startAH+2].CarsForSell.Count())
                btnNextCars.Visible = true;
            curentAhID = startAH+2;
            startCar = 0;
            displayCars(startCar, autoHouses[startAH+2]);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (5 < autoHouses[startAH+3].CarsForSell.Count())
                btnNextCars.Visible = true;
            curentAhID = startAH+3;
            startCar = 0;
            displayCars(startCar, autoHouses[startAH+3]);
        }

        private void lblAH5_Click(object sender, EventArgs e)
        {
            if (5 < autoHouses[startAH+4].CarsForSell.Count())
                btnNextCars.Visible = true;
            curentAhID = startAH+4;
            startCar = 0;
            displayCars(startCar, autoHouses[startAH+4]);
        }

        private void btnNextAH_Click(object sender, EventArgs e)
        {
            startAH += 5;
            if(startAH>=autoHouses.Count()-5)
            {
                btnNextAH.Visible = false;
            }
            btnPreviousAH.Visible = true;
            displayAH(startAH);
        }

        private void btnPreviousAH_Click(object sender, EventArgs e)
        {
            startAH -= 5;
            if (startAH == 0)
            {
                btnPreviousAH.Visible = false;
            }
            btnNextAH.Visible = true;
            displayAH(startAH);
        }

        private void btnNextCars_Click(object sender, EventArgs e)
        {
            startCar += 5;
            if (startCar >= autoHouses[curentAhID].CarsForSell.Count()-5)
            {
                btnNextCars.Visible = false;
            }
            btnPreviousCars.Visible = true;
            displayCars(startCar, autoHouses[curentAhID]);
        }

        private void btnPreviousCars_Click(object sender, EventArgs e)
        {
            startCar -= 5;
            if (startCar == 0)
            {
                btnPreviousCars.Visible = false;
            }
            btnNextCars.Visible = true;
            displayCars(startCar, autoHouses[curentAhID]);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form fm = new Form10(user, autoHouses[curentAhID], autoHouses[curentAhID].CarsForSell[startCar],autoHouses,curentAhID,startCar,startAH);
            fm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form fm = new Form10(user, autoHouses[curentAhID], autoHouses[curentAhID].CarsForSell[startCar], autoHouses, curentAhID, startCar, startAH);
            fm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form fm = new Form10(user, autoHouses[curentAhID], autoHouses[curentAhID].CarsForSell[startCar+1], autoHouses, curentAhID, startCar, startAH);
            fm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form fm = new Form10(user, autoHouses[curentAhID], autoHouses[curentAhID].CarsForSell[startCar + 1], autoHouses, curentAhID, startCar, startAH);
            fm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form fm = new Form10(user, autoHouses[curentAhID], autoHouses[curentAhID].CarsForSell[startCar + 2], autoHouses, curentAhID, startCar, startAH);
            fm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form fm = new Form10(user, autoHouses[curentAhID], autoHouses[curentAhID].CarsForSell[startCar + 2], autoHouses, curentAhID, startCar, startAH);
            fm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form fm = new Form10(user, autoHouses[curentAhID], autoHouses[curentAhID].CarsForSell[startCar + 3], autoHouses, curentAhID, startCar, startAH);
            fm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form fm = new Form10(user, autoHouses[curentAhID], autoHouses[curentAhID].CarsForSell[startCar + 3], autoHouses, curentAhID, startCar, startAH);
            fm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form fm = new Form10(user, autoHouses[curentAhID], autoHouses[curentAhID].CarsForSell[startCar + 4], autoHouses, curentAhID, startCar, startAH);
            fm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form fm = new Form10(user, autoHouses[curentAhID], autoHouses[curentAhID].CarsForSell[startCar + 4], autoHouses, curentAhID, startCar, startAH);
            fm.Show();
            this.Hide();
        }

        private void lblChose_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
