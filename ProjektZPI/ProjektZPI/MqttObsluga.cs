using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace ProjektZPI
{
    class MqttObsluga
    {
        public static string OdebranaWiadomosc = "";
        public static string subWiadomosc = "";
        public static string mqttKey = Guid.NewGuid().ToString();

        public void publikujWiadomosc(string temat, string tresc, string ipBroker)
        {
            MqttClient client = new MqttClient(ipBroker);
            client.Connect(mqttKey);
            client.Publish(temat, Encoding.Default.GetBytes(tresc));

        }
        private void mqttClient_odbWiadomosci(object sender, MqttMsgPublishEventArgs e)
        {
            OdebranaWiadomosc = System.Text.Encoding.Default.GetString(e.Message);
            if (OdebranaWiadomosc.Length > 0)
            {
                subWiadomosc = OdebranaWiadomosc;
                this.Invoke(new EventHandler(wyswietlWiadomosc));
            }

        }

        private void Invoke(EventHandler eventHandler)
        {
            subWiadomosc = OdebranaWiadomosc;
        }

        private void wyswietlWiadomosc(object sender, EventArgs e)
        {
            subWiadomosc = OdebranaWiadomosc;
        }
  
        public string subksrybujWiadomosc(string temat, string ipBroker)
        {
            //subWiadomosc = "";
            MqttClient mqttClient = new MqttClient(ipBroker);
            mqttClient.MqttMsgPublishReceived += mqttClient_odbWiadomosci;
            mqttClient.Connect(mqttKey);
            mqttClient.Subscribe(new string[] { temat }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            return subWiadomosc ;
        }


    }
}
