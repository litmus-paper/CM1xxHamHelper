using HidLibrary;

namespace CM1xxHamHelper
{
    public partial class Form1 : Form
    {
        private int soundVendorId, soundProductId;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPTTPush_Click(object sender, EventArgs e)
        {
            var device = HidDevices.Enumerate(soundVendorId, soundProductId).FirstOrDefault();
            device.OpenDevice();
            var startReport = new HidReport(4);
            startReport.ReportId = 0x00;
            startReport.Data = new byte[] { 0x00,
                0x04, // H/L
                0x04, // 0=input ; 1=output
                0x00 };
            device.WriteReport(startReport);
            device.CloseDevice();
        }

        private void buttonPTTRelease_Click(object sender, EventArgs e)
        {
            var device = HidDevices.Enumerate(soundVendorId, soundProductId).FirstOrDefault();
            device.OpenDevice();
            var stopReport = new HidReport(4);
            stopReport.ReportId = 0x00;
            stopReport.Data = new byte[] {  0x00,
                0x00, // H/L
                0x04, // 0=input ; 1=output
                0x00 };
            device.WriteReport(stopReport);
            device.CloseDevice();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            textBoxRead.Text = "Waiting for an event";
            (new Thread(() => {
                var device = HidDevices.Enumerate(soundVendorId, soundProductId).FirstOrDefault();
                device.OpenDevice();

                do
                {
                    HidReport readReport = device.ReadReport();

                    if (readReport.Exists)
                    {
                        // Process the report data
                        byte[] data = readReport.Data;
                        textBoxRead.Invoke(() => { textBoxRead.Text = "Received data: " + BitConverter.ToString(data); }) ;
                    }
                    
                } while (true);
            })).Start();

        }

        private void buttonInitialize_Click(object sender, EventArgs e)
        {
            // Enumerate all HID devices
            var devices = HidDevices.Enumerate();
            textBoxRead.Text = "No compatible device detected.";
            foreach (var device in devices)
            {
                var vendorId = device.Attributes.VendorId;
                var productId = device.Attributes.ProductId;


                // Check for CM108/108B/109/119/119A/119B
                if (vendorId == 0x0D8C
                    && ((productId >= 0x0008 && productId <= 0x000F)
                        || productId == 0x0012
                        || productId == 0x013A
                        || productId == 0x013C
                        || productId == 0x0013))
                {
                    textBoxRead.Text = "CM108 compatible device detected.";
                    soundProductId = productId;
                    soundVendorId = vendorId;
                    buttonPTTPush.Enabled = true;
                    buttonPTTRelease.Enabled = true;
                    buttonRead.Enabled = true;
                }
                // Check for SSS1621/23
                else if (vendorId == 0x0C76
                         && (productId == 0x1605
                             || productId == 0x1607
                             || productId == 0x160B))
                {
                    textBoxRead.Text = "SSS1621/23 compatible device detected.";
                    soundProductId = productId;
                    soundVendorId = vendorId;
                    buttonPTTPush.Enabled = true;
                    buttonPTTRelease.Enabled = true;
                    buttonRead.Enabled = true;
                }

            }
        }
    }
}