using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaphore
{
    public partial class SemaphoreForm : Form
    {
        public static int THREAD_COUNT = 0;

        public int MAX_INITIAL_COUNT = 2;
        public int MAX_COUNT = 2;

        private static object lockObj = new object();

        private static System.Threading.Semaphore semaphore;

        public static List<ThreadObject> threadsCreated = new List<ThreadObject>();
        public static List<ThreadObject> threadsWaiting = new List<ThreadObject>();
        public static List<ThreadObject> threadsWorking = new List<ThreadObject>();
        public class ThreadObject 
        {
            public int Index { get; set; } = 0;
            public int Count { get; set; } = 0;
            public Thread thread { get; set; }

            public ThreadObject() 
            {
            }
        }
        public SemaphoreForm()
        {
            InitializeComponent();
            semaphore = new System.Threading.Semaphore(MAX_INITIAL_COUNT, MAX_COUNT);
        }

        private void buttonCreateThread_Click(object sender, EventArgs e)
        {
            ThreadObject newThreadObject = new ThreadObject();
            newThreadObject.thread = new Thread(new ThreadStart(DoWork));
            newThreadObject.thread.Name = $"Поток №{++THREAD_COUNT}";
            
            threadsCreated.Add(newThreadObject);
            listBoxCreated.Items.Add(newThreadObject.thread.Name);
        }

        private void UpdateListBoxes()
        {
            listBoxCreated.Items.Clear();
            listBoxWaiting.Items.Clear();

            foreach (ThreadObject t in threadsCreated)
                listBoxCreated.Items.Add(t.thread.Name);
            foreach (ThreadObject t in threadsWaiting)
                listBoxWaiting.Items.Add(t.thread.Name);
        }
        public void DoWork() 
        {
            semaphore.WaitOne();

            threadsWaiting.RemoveAt(0);

            listBoxWaiting.BeginInvoke((MethodInvoker)(() =>
            listBoxWaiting.Items.RemoveAt(0)
            ));
            

            ThreadObject newObject = new ThreadObject
            {
                thread = Thread.CurrentThread,
                Index = listBoxWorking.Items.Count
            };

            threadsWorking.Add(newObject);


            listBoxWorking.BeginInvoke((MethodInvoker)(() =>
            listBoxWorking.Items.Add(newObject.thread.Name)
            ));

            while (Thread.CurrentThread.IsAlive) 
            {
                lock (lockObj)
                {
                    listBoxWorking.BeginInvoke((MethodInvoker)(() =>
                    listBoxWorking.Items[newObject.Index] = $"{newObject.thread.Name} - {++newObject.Count}"
                    ));
                }
                Thread.Sleep(1000);
            }
        }
        private void UpdateWorkingThreadsIndexes() 
        {
            lock (lockObj) 
            {
               for (int i = 0; i < listBoxWorking.Items.Count; i++) 
                {
                    threadsWorking[i].Index = i;
                }
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Поменять максимальное количество потоков в семафоре
            // Проверить есть ли желающие в семафор
        }
        private void listBoxCreated_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Выбираю из созданных, какой поток должен стартовать как только в семафоре появится место
            if (listBoxCreated.SelectedIndex != -1) 
            {
                threadsWaiting.Add(threadsCreated[listBoxCreated.SelectedIndex]);
                threadsCreated.RemoveAt(listBoxCreated.SelectedIndex);

                UpdateListBoxes();

                threadsWaiting[threadsWaiting.Count - 1].thread.Start();
            }
        }
        private void listBoxWorking_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxWorking.SelectedIndex != -1)
            {
                threadsWorking[listBoxWorking.SelectedIndex].thread.Abort();

                threadsWorking.RemoveAt(listBoxWorking.SelectedIndex);
                listBoxWorking.Items.RemoveAt(listBoxWorking.SelectedIndex);

                UpdateWorkingThreadsIndexes();
                semaphore.Release();
            }
        }
    }
}
