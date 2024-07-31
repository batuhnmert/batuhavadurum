using System.Xml.Linq;

namespace HavaDurumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string request = $"https://api.openweathermap.org/data/2.5/weather?q={comboBox1.Text}&mode=xml&units=metric&appid=a33395d329a4b814710d43730b37a455";
            XDocument havaDurumu = XDocument.Load(request);

            var sehirAdi = havaDurumu.Descendants("city").ElementAt(0).Attribute("name").Value;
            label2.Text = $"City : {sehirAdi.ToString()}";

            var hissedilen = havaDurumu.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
            label3.Text = $"Feels Like : {hissedilen.ToString()} °C";

            var sicaklik = havaDurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            label4.Text = $"Temperature : {sicaklik.ToString()} °C";

            var durum = havaDurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
            label5.Text = $"Weather : {durum.ToString()}";
            var ruzgar = havaDurumu.Descendants("speed").ElementAt(0).Attribute("value").Value;
            label6.Text = $"Speed : {ruzgar.ToString()} m/s";
            
            var nem = havaDurumu.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            label8.Text = $"Humidity : {nem.ToString()} %";

            var icon = "http://openweathermap.org/img/wn/" + havaDurumu.Descendants("weather").ElementAt(0).Attribute("icon").Value + "@4x.png";

            pictureBox1.Load(icon); 

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}



