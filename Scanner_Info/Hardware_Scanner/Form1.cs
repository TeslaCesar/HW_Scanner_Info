using Hardware.Info;
using System.Management;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;
using ToastNotifications.Core;
using System.Windows.Forms;
using System.Diagnostics;


namespace Hardware_Scanner
{
    public partial class frmInfoScanner : Form
    {


        private Notifier notifier;

        public frmInfoScanner()
        {
            InitializeComponent();


        }

        private void frmInfoScanner_Load(object sender, EventArgs e)
        {
            GetSNMotherboard();
            GetCPUModel();
            txtBIOSversion.Text = "Firmware Version: " + BiosFWVersion();
            MACAdress();
        }

        public string GetBIOSNumber()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["SerialNumber"]?.ToString() ?? "No disponible";
                }
            }
            return "No disponible";
        }

        public void GetCPUModel()
        {
            // Usar ManagementObjectSearcher para consultar Win32_Processor
            var searcher = new ManagementObjectSearcher("select Name from Win32_Processor");

            foreach (var obj in searcher.Get())
            {
                txtCPUModel.Text = obj["Name"].ToString();
            }

        }

        public string BiosFWVersion()
        {
            var searcher = new ManagementObjectSearcher("select SMBIOSBIOSVersion from Win32_BIOS");

            foreach (var obj in searcher.Get())
            {
                //Console.WriteLine($"Fabricante: {obj["Manufacturer"]}");
                return obj["SMBIOSBIOSVersion"]?.ToString() ?? "No se encontro";
                //Console.WriteLine($"Versión del BIOS: {obj["Version"]}");
                //Console.WriteLine($"Fecha de liberación: {obj["ReleaseDate"]}");
            }
            return "No se pudo obtener la versión del BIOS";
        }

        public void GetSNMotherboard()
        {
            var MotherboardSearcher = new ManagementObjectSearcher("select Manufacturer, Product, SerialNumber from Win32_BaseBoard");

            foreach (var obj in MotherboardSearcher.Get())
            {

                txtMBManufacturer.Text = obj["Manufacturer"]?.ToString() ?? "No disponible";
                txtMBModel.Text = obj["Product"]?.ToString() ?? "No disponible";
                txtBIOSnumber.Text = obj["SerialNumber"]?.ToString() ?? "No disponible";
            }

        }

        public void MACAdress()
        {

            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");

            foreach (ManagementObject obj in searcher.Get())
            {
                string adapterName = obj["Name"]?.ToString();
                string macAddress = obj["MACAddress"]?.ToString();

                // Filtrar los adaptadores virtuales o no físicos
                // Solo agregamos la dirección MAC si no es nula y no es un adaptador virtual
                if (!string.IsNullOrEmpty(macAddress) && !adapterName.Contains("Virtual"))
                {
                    if (adapterName.Contains("Wi-Fi"))
                    {
                        txtWIFImac.Text = macAddress;
                    }
                    else if (adapterName.Contains("Ethernet"))
                    {
                        txtMACethernet.Text = macAddress;
                    }
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por TeslaCesar / NET 6.0 and WinForms","GRACIAS",MessageBoxButtons.OK);
        }

        private void txtBIOSnumber_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBIOSnumber.Text);
            NotificationClipboard(txtBIOSnumber.Text);
        }

        private void txtWIFImac_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtWIFImac.Text);
            NotificationClipboard(txtWIFImac.Text);

        }

        private void txtMACethernet_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMACethernet.Text);
            NotificationClipboard(txtMACethernet.Text);
        }

        public void NotificationClipboard(string valor)
        {

            notifyIcon1.Icon = SystemIcons.Information; // Usa un icono predeterminado o uno personalizado
            notifyIcon1.BalloonTipTitle = "Realizado";
            notifyIcon1.BalloonTipText = $"Se ha copiado {valor} al portapapeles";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info; // Info, Warning o Error
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(4000); // Duración de la notificación (en milisegundos)
        }

        private void lblGIThub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/TeslaCesar") { UseShellExecute = true });
        }

       
    }

}
