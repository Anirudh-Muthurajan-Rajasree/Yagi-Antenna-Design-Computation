using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpaceSeva_Innovators_Yagi_Antenna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //********** YAGI ANTENNA CALCULATION *****
            richTextBox1.AppendText("Date : " + DateTime.Now.ToString("dddd, dd MMMM yyyy")); //Local date
            richTextBox1.AppendText("\t\tTime : " + DateTime.Now.ToString("hh:mm:ss tt")); //Local time 12 hr format with AM/PM);
            double Freq = 0.0000;  //frequency // Hz
            double lambda = 0.0000;  // wavelength in m
            double lambda_mm = 0.0000; // wavelength in mm
            double c;  //wave speed in m/s, 
            c = 299792458;  //Speed of light in free space m/s

            double.TryParse(textBox1.Text, out Freq); //if any error returns zero

            int a;
            a = comboBox1.SelectedIndex;
            if (a > 0) richTextBox1.AppendText("\n\nFrequency : " + Freq.ToString() + " " + comboBox1.Text + "\n");

            if (a == 1) Freq = Freq * 1000;  //kHz
            if (a == 2) Freq = Freq * 1000000;  //MHz
            if (a == 3) Freq = Freq * 1000000000;  //GHz
            if (a == 4) Freq = Freq * 1000000000000; //THz
                                                     //
            lambda = c / Freq;
            lambda_mm = lambda * 1000;
            richTextBox1.AppendText("Yagi Antenna Design Calculations:");
            richTextBox1.AppendText("\n\nFrequency : " + Freq.ToString() + " Hz");

            richTextBox1.AppendText("\nWavelength (λ) : " + lambda.ToString() + " meter");

            if (lambda <= 0.01)
                richTextBox1.AppendText("\nWavelength (λ) : " + (lambda * 100).ToString() + " cm");

            richTextBox1.AppendText("\nWavelength (λ) : " + lambda_mm.ToString() + " mm");

            if (lambda <= 0.0000001)
                richTextBox1.AppendText("\nWavelength (λ) : " + (lambda * 1000000).ToString() + " µm");

            double lambda_reflector;
            double lambda_dipole;
            double lambda_director;

            double.TryParse(textBox6.Text, out lambda_reflector); //if any error returns zero
            double.TryParse(textBox7.Text, out lambda_dipole); //if any error returns zero
            double.TryParse(textBox8.Text, out lambda_director); //if any error returns zero

            double reflector_mm;
            double dipole_mm;
            double director_mm;

            reflector_mm = lambda_reflector * lambda_mm; // 0.5 * lambda_mm;
            dipole_mm = lambda_dipole * lambda_mm;  // 0.47 * lambda_mm;
            director_mm = lambda_director * lambda_mm;  // 0.406 * lambda_mm;

            richTextBox1.AppendText("\n\nLength of Reflector : " + reflector_mm.ToString("###,###.00") + " mm [ "
                 + lambda_reflector.ToString() + " λ ]");
            richTextBox1.AppendText("\nLength of Dipole : " + dipole_mm.ToString("###,###.00") + " mm [ "
                + lambda_dipole.ToString() + " λ ]");
            richTextBox1.AppendText("\nLength of Director : " + director_mm.ToString("###,###.00") + " mm [ "
                + lambda_director.ToString() + " λ ]");


            double lambda_space_reflector_dipole;
            double lambda_space_director;
            double lambda_radius_director;

            double.TryParse(textBox4.Text, out lambda_space_reflector_dipole); //if any error returns zero
            double.TryParse(textBox5.Text, out lambda_space_director); //if any error returns zero
            double.TryParse(textBox9.Text, out lambda_radius_director); //if any error returns zero

            double space_reflector_dipole_mm;
            double space_director_mm;
            double radius_director_mm;

            space_reflector_dipole_mm = lambda_space_reflector_dipole * lambda_mm; // 0.25 * lambda_mm;
            space_director_mm = lambda_space_director * lambda_mm; // 0.34 * lambda_mm;
            radius_director_mm = lambda_radius_director * lambda_mm; // 0.003 * lambda_mm;

            richTextBox1.AppendText("\n\nSpace between Reflector and Dipole : " +
                space_reflector_dipole_mm.ToString("###,###.00") + " mm [ "
                + lambda_space_reflector_dipole.ToString() + " λ ]");

            richTextBox1.AppendText("\nSpace between Director : " +
                space_director_mm.ToString("###,###.00") + " mm [ "
                + lambda_space_director.ToString() + " λ ]");


            richTextBox1.AppendText("\nRadius of Elements : " +
                radius_director_mm.ToString("###,###.00") + " mm [ "
                + lambda_radius_director.ToString() + " λ ]");

            richTextBox1.AppendText("\n\n************ End of Yagi Antenna Calculation ************\n\n");
            richTextBox1.ScrollToCaret();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
