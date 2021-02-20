#include <DHT.h>
#include <DHT_U.h>

// Incluimos librería
#include <dht.h>

// Definimos el pin digital donde se conecta el sensor
#define DHTPIN 2
// Dependiendo del tipo de sensor
#define DHTTYPE DHT11
//Variables acumuladores de datos
float temp = 0;
float hume = 0; 
int vez = 0;
String mensaje;
// Inicializamos el sensor DHT11
DHT dht(DHTPIN, DHTTYPE);

void setup() {
// Inicializamos comunicación serie
Serial.begin(9600);
// Comenzamos el sensor DHT
dht.begin();
}

void loop() {
// Esperamos 5 segundos entre medidas
delay(1000);
// Leemos la humedad relativa
float h = dht.readHumidity();
// Leemos la temperatura en grados centígrados (por defecto)
float t = dht.readTemperature();
// Leemos la temperatura en grados Fahreheit

if (isnan(h) || isnan(t)) {
Serial.println("Error obteniendo los datos del sensor DHT11");
return;
}

// Calcular el índice de calor en grados centígrados
float hic = dht.computeHeatIndex(t, h, false);
// Imprime la temperatura y humedad solo si cambiaron
vez++;
if (temp != t || hume != h) {

mensaje= mensaje + t + "|" + h + "|";
Serial.println(mensaje);
   mensaje="";
temp = t;
hume = h;
} 
}
