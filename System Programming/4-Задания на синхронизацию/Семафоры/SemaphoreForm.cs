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
<<<<<<< HEAD
        private static int threadCount = 0;

        private int initialCount = 1;
        private int maxCount = 5;
=======
        private static int THREAD_COUNT = 0;

        private int MAX_INITIAL_COUNT = 3;
        private int MAX_COUNT = 3;
>>>>>>> f97af47efb658675df04534720fd0da4c1b0bc42

        private static object lockObj = new object();

        private static System.Threading.Semaphore semaphore;

        private static List<ThreadObject> threadsCreated = new List<ThreadObject>();
        private static List<ThreadObject> threadsWaiting = new List<ThreadObject>();
        private static List<ThreadObject> threadsWorking = new List<ThreadObject>();

        public class ThreadObject 
        {
            public int Index { get; set; } = 0;
            public int Count { get; set; } = 0;
            public Thread thread { get; set; }

            public ThreadObject() {}
        }

        public SemaphoreForm()
        {
            InitializeComponent();

<<<<<<< HEAD
            semaphore = new System.Threading.Semaphore(initialCount, maxCount);
=======
            semaphore = new System.Threading.Semaphore(MAX_INITIAL_COUNT, MAX_COUNT);

            numericUpDown1.Value = MAX_COUNT;
>>>>>>> f97af47efb658675df04534720fd0da4c1b0bc42
        }

        private void buttonCreateThread_Click(object sender, EventArgs e)
        {
            ThreadObject newThreadObject = new ThreadObject();
            newThreadObject.thread = new Thread(new ThreadStart(DoWork));
            newThreadObject.thread.Name = $"Thread {++threadCount}";
            
            threadsCreated.Add(newThreadObject);
            listBoxCreated.Items.Add(newThreadObject.thread.Name);
        }

        private void UpdateListBoxes()
        {
            listBoxCreated.Items.Clear();
            listBoxWaiting.Items.Clear();

            foreach (ThreadObject thread in threadsCreated)
			{
                listBoxCreated.Items.Add(thread.thread.Name);
			}

            foreach (ThreadObject thread in threadsWaiting)
            {
                listBoxWaiting.Items.Add(thread.thread.Name);
            }
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
                        listBoxWorking.Items[newObject.Index] = $"{newObject.thread.Name} -> {++newObject.Count}"
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

<<<<<<< HEAD
=======
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Поменять максимальное количество потоков в семафоре
            // Проверить есть ли желающие в семафор
            MAX_INITIAL_COUNT = (int)numericUpDown1.Value;
            MAX_COUNT = (int)numericUpDown1.Value;
        }

>>>>>>> f97af47efb658675df04534720fd0da4c1b0bc42
        private void listBoxCreated_MouseDoubleClick(object sender, MouseEventArgs e)
        {
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
