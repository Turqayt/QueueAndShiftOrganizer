namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string filePath = "workers.txt"; // �simleri saklayaca��m�z dosyan�n yolu

        public Form1()
        {
            InitializeComponent();
            LoadWorkersFromFile(); // Uygulama ba�larken i��ileri y�kle
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            AddWorker(); // ���i ekleme i�lemini �a��r
           
        }

        private void SaveWorkerToFile(string workerName)
        {
            // ���i ismini dosyaya ekle
            File.AppendAllText(filePath, workerName + Environment.NewLine);
        }

        private void LoadWorkersFromFile()
        {
            if (File.Exists(filePath))
            {
                // Dosyadan t�m i��i isimlerini oku
                string[] workers = File.ReadAllLines(filePath);
                lstWorkers.Items.AddRange(workers);
            }

        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            if (lstWorkers.SelectedItem != null) // Se�ili bir i��i var m� kontrol et
            {
                // ListBox'tan se�ilen i��iyi al
                string selectedWorker = lstWorkers.SelectedItem.ToString();

                // ListBox'tan kald�r
                lstWorkers.Items.Remove(selectedWorker);

                // G�ncellenmi� listeyi dosyaya kaydet
                SaveAllWorkersToFile();
            }
            else
            {
                MessageBox.Show("L�tfen silmek i�in bir i��i se�iniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveAllWorkersToFile()
        {
            // T�m i��i isimlerini bir diziye aktar
            string[] workers = new string[lstWorkers.Items.Count];
            lstWorkers.Items.CopyTo(workers, 0);

            // Dosyay� yeni liste ile g�ncelle
            File.WriteAllLines(filePath, workers);
        }

        private void txtWorkerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter tu�una bas�lm��sa
            {
                // ���i ekleme i�lemini �a��r
                AddWorker();

                // Enter tu�unun ba�ka i�lemler yapmas�n� engelle
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void AddWorker()
        {
            string workerName = txtWorkerName.Text.Trim();

            if (!string.IsNullOrEmpty(workerName))
            {
                // ���i ismini ListBox'a ekle
                lstWorkers.Items.Add(workerName);

                // ���i ismini dosyaya kaydet
                SaveWorkerToFile(workerName);

                // TextBox'� temizle
                txtWorkerName.Clear();
            }
            else
            {
                MessageBox.Show("L�tfen bir i��i ismi giriniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
