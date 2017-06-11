using System;
using Lab2.Queue;
using System.Threading;
using System.Windows.Forms;

namespace Lab2Difficult
{
    public partial class MainForm : Form
    {
        MQueue queue = new MQueue();
        Mutex mutex = new Mutex();
        Random random = new Random();

        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                int item = random.Next(-10, 10);
                queue.Enqueue(item);
            }

            tmrNewValue.Enabled = true;
            tmrUpdate.Enabled = true;
        }

        private void tmrNewValue_Tick(object sender, EventArgs e)
        {
            tmrNewValue.Enabled = false;
            tmrNewValue.Interval = random.Next(100, 5000);
            NewValue();
            tmrNewValue.Enabled = true;
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            tmrUpdate.Enabled = false;
            Update();
            tmrUpdate.Enabled = true;
        }

        private void Update()
        {
            mutex.WaitOne();
            tbQueue.Text = "";
            foreach (var i in queue)
            {
                tbQueue.Text += i.ToString() + "   ";
            }
            tbMinimum.Text = queue.Min().ToString();
            tbMaximum.Text = queue.Max().ToString();
            mutex.ReleaseMutex();
        }

        private void NewValue()
        {
            mutex.WaitOne();
            int item = random.Next(-10, 10);
            queue.Dequeue();
            queue.Enqueue(item);

            tbLastTen.Text = "";
            foreach (var i in queue)
            {
                tbLastTen.Text += i.ToString() + "   ";
            }

            mutex.ReleaseMutex();
        }
    }
}
