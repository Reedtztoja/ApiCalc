using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, float> _rates = new Dictionary<string, float>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument api = XDocument.Load("http://api.nbp.pl/api/exchangerates/tables/a/?format=xml");
            var rates = api.Descendants("Rate");
            //clear slownik
            _rates.Clear();
            //pars api
            foreach (var rate in rates)
            {
                if (rate.Element("Code") != null && rate.Element("Mid") != null)
                {
                    //skrot nazwy z api
                    string code = rate.Element("Code").Value;
                    //kurs waluty
                    float mid = float.Parse(rate.Element("Mid").Value, System.Globalization.CultureInfo.InvariantCulture);
                    //kurs do slownika
                    _rates.Add(code, mid);
                }


            }
            //kursy na ekran
            rateUSDTextBox.Text = _rates["USD"].ToString();
            rateEuroTextBox.Text = _rates["EUR"].ToString();
            rateCHFTextBox.Text = _rates["CHF"].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exchange(object sender, EventArgs e)
        {
            //pobierz 
            string currency = (sender as RadioButton).Text;
            float ammountPLN = float.Parse(ammountPLNTextBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            float rate = 
 

            }
        }
    }