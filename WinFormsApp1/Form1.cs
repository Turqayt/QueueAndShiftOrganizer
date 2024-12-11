namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string filePath = "workers.txt"; // Ýsimleri saklayacaðýmýz dosyanýn yolu

        public Form1()
        {
            InitializeComponent();
            LoadWorkersFromFile(); // Uygulama baþlarken iþçileri yükle
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            AddWorker(); // Ýþçi ekleme iþlemini çaðýr
           
        }

        private void SaveWorkerToFile(string workerName)
        {
            // Ýþçi ismini dosyaya ekle
            File.AppendAllText(filePath, workerName + Environment.NewLine);
        }

        private void LoadWorkersFromFile()
        {
            if (File.Exists(filePath))
            {
                // Dosyadan tüm iþçi isimlerini oku
                string[] workers = File.ReadAllLines(filePath);
                lstWorkers.Items.AddRange(workers);
            }

        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            if (lstWorkers.SelectedItem != null) // Seçili bir iþçi var mý kontrol et
            {
                // ListBox'tan seçilen iþçiyi al
                string selectedWorker = lstWorkers.SelectedItem.ToString();

                // ListBox'tan kaldýr
                lstWorkers.Items.Remove(selectedWorker);

                // Güncellenmiþ listeyi dosyaya kaydet
                SaveAllWorkersToFile();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir iþçi seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveAllWorkersToFile()
        {
            // Tüm iþçi isimlerini bir diziye aktar
            string[] workers = new string[lstWorkers.Items.Count];
            lstWorkers.Items.CopyTo(workers, 0);

            // Dosyayý yeni liste ile güncelle
            File.WriteAllLines(filePath, workers);
        }

        private void txtWorkerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter tuþuna basýlmýþsa
            {
                // Ýþçi ekleme iþlemini çaðýr
                AddWorker();

                // Enter tuþunun baþka iþlemler yapmasýný engelle
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void AddWorker()
        {
            string workerName = txtWorkerName.Text.Trim();

            if (!string.IsNullOrEmpty(workerName))
            {
                // Ýþçi ismini ListBox'a ekle
                lstWorkers.Items.Add(workerName);

                // Ýþçi ismini dosyaya kaydet
                SaveWorkerToFile(workerName);

                // TextBox'ý temizle
                txtWorkerName.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen bir iþçi ismi giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
