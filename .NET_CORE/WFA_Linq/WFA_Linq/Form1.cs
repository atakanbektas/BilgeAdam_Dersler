using WFA_Linq.CustomDesigner;

namespace WFA_Linq
{
    public partial class Form1 : Form
    {
        private List<Product> _products = new List<Product>()
        {
            new Product(1,"Kalem","Kýrtasiye"),
            new Product(2,"Çilek","Meyve"),
            new Product(3,"Elma","Meyve"),
            new Product(4,"Armut","Meyve")
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int GetLength(string str)
        {
            return str.Length;
        }
        private int GetLength2(string str)
        {
            return str.Length;
        }
        private string GetInfo(string str)
        {
            return str + " " + GetLength(str).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Func<string,int> func1 = GetLength;
            func1 = GetLength2;
            Func<string,string> func2 = GetInfo;
            Func<string,string> func3 = new Func<string, string>(GetInfo);
            Func<string,string> func4 = str => str + " " + GetLength(str).ToString();

            label1.Text = func2.Invoke("test").ToString();
            label1.Text = func1.Invoke("test").ToString();

            Calistir("ahmet",GetLength);
            GetLength("ahmet");
            Calistir("ahmet",GetInfo);
            GetInfo("ahmet");

            List<int> sayilar1 = new List<int>() { 2,3,4,5,6,7,8};
            List<int> sayilar2 = new List<int>() { 3,4};

            string info = "çift";
            //sayilar1.Sil(x => (info == "tek" ? x % 2 != 0 : x % 2 == 0));
            sayilar1.Sil(sayi => sayilar2.Contains(sayi));
            dataGridView1.DataSource = null;
            listBox1.DataSource = sayilar1;
        }

        private static void Calistir<T,R>(T str, Func<T,R> func)
        {
            func(str);
            
        }

        
    }
}