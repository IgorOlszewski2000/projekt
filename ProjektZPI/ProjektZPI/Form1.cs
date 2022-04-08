using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZPI
{
    public partial class Form1 : Form
    {
        MqttObsluga mqttObsluga = new MqttObsluga();
        CardModel cardModel = new CardModel();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> comboBoxZawartosc = new List<string>();
            List<string> comboBoxTags = new List<string>();

            HandleConnection handleConnection = new HandleConnection();
            var dataLoaded = from HandleConnection in handleConnection.Room select HandleConnection;
            foreach (var kursor in dataLoaded)
            {
                comboBoxRoomList.Items.Add(kursor.nazwa);

            }

        }
        private void buttonSEND_Click(object sender, EventArgs e)
        {
            using (var DataStructure = new HandleConnection())
            {
                DataStructure.Card.Add(new CardModel()
                {

                    cardTag = textBoxRFIDtag.Text.ToString(),
                    cardName = textBoxNazwa.Text.ToString()
                });
                DataStructure.SaveChanges();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxRFIDtag.Text = mqttObsluga.subksrybujWiadomosc(textBoxTopic.Text, textBoxIpBroker.Text);
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void textBoxRFIDtag_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonF5_Click(object sender, EventArgs e)
        {
            HandleConnection handleConnection = new HandleConnection();
            var dataLoaded = from HandleConnection in handleConnection.Card select HandleConnection;
            foreach (var kursor in dataLoaded)
            {
                comboBoxTest.Items.Add("ID KARTY: " + kursor.cardID + " RFID: " + kursor.cardTag + " NAZWA KARTY: " + kursor.cardName);

            }
        }

        private void comboBoxTest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDostep_Click(object sender, EventArgs e)
        {string nazwaPokoju = comboBoxRoomList.SelectedItem.ToString();
            string card = textBoxRFIDtag.Text.ToString();
            string cardId = "";
            string cardIDCard = "";
            HandleConnection handleConnection = new HandleConnection();
            var dataLoaded = from HandleConnection in handleConnection.Room select HandleConnection;
            var dataLoaded2 = from HandleConnection in handleConnection.Card select HandleConnection;
            foreach (var kursor in dataLoaded.Where(a=>a.nazwa==nazwaPokoju))
            {
                cardId = kursor.RFIDId;
                
            }
            foreach (var kursor in dataLoaded2.Where(a=>a.cardTag==card))
            {
                cardIDCard = kursor.cardID.ToString();

            }
            if (cardId==cardIDCard)
            {
                labelJestDostep.Text="PRZYZNANO DOSTĘP!!!" + cardId + " " + cardIDCard;
            }
            else
            {
                labelJestDostep.Text = "BRAK DOSTĘPU!!!"+cardId+" "+cardIDCard;
            }

        }
    }
}
