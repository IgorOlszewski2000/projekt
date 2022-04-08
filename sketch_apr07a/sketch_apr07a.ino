#include <ESP8266WiFi.h>
#include <PubSubClient.h>
#include <SPI.h>
#include <MFRC522.h>

#define BAUDRATE 115200

constexpr uint8_t RST_PIN = D3;
constexpr uint8_t SS_PIN = D4;
MFRC522 rfid(SS_PIN,RST_PIN);
MFRC522::MIFARE_Key key;

String tag; // RFID TAG

// WIFI AND MQTT CONNECTION
const char* ssid = "ASUS";
const char* pass = "Doktorzec1";
const char* mqttServer = "192.168.1.167";
const int mqttPort = 1883;
const char* topic = "ESP8266-1";

WiFiClient esp_board;
PubSubClient mqtt_client(esp_board);

void setup() {
Serial.begin(BAUDRATE);
SPI.begin(); // Init SPI bus
rfid.PCD_Init(); // Init MFRC522
WiFi.begin(ssid,pass);
Serial.print("Connecting to ");
Serial.print(ssid);
Serial.print("with password ");
Serial.println(pass);
Serial.print("Start connection .");

while(WiFi.status()!=WL_CONNECTED) {
  delay(500);
  Serial.print(".");
}

Serial.print("ESP8266 board IP ");
Serial.println(WiFi.localIP());
mqtt_client.setServer(mqttServer,mqttPort);
//mqtt_client.setCallback(callback);

Serial.println("Connecting to MQTT server/broker ");

while(!mqtt_client.connected()) {
  String client_id = "plytka";

  WiFi.mode(WIFI_STA);
  if(mqtt_client.connect(client_id.c_str())) {
    Serial.println("... connected");  
  } else {
    Serial.print("... failed ");
    Serial.println(mqtt_client.state());
    delay(1000);
  }
}
// publish and subscribe
// mqtt_client.subscribe(topic);
// mqtt_client.publish(topic, "Hello From ESP8266!");
//}

//void callback(char *topic, byte *payload, unsigned int length) {
// Serial.print("Message arrived in topic: ");
// Serial.println(topic);
// Serial.print("Message:");
 
// for (int i = 0; i < length; i++) {
//  Serial.print((char) payload[i]);
// }
 
// Serial.println();
// Serial.println(" - - - - - - - - - - - -");
}

void loop() {
  mqtt_client.loop();
 if ( ! rfid.PICC_IsNewCardPresent())
  return;
 if (rfid.PICC_ReadCardSerial()){
    for (byte i=0; i<4; i++){
        tag += rfid.uid.uidByte[i];
      }
     Serial.println(tag);
     mqtt_client.publish(topic, tag.c_str());
     tag = "";
     rfid.PICC_HaltA();
     rfid.PCD_StopCrypto1();
  } 
 
}
