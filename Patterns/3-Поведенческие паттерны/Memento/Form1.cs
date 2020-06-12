using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public partial class TextEditorForm : Form
    {
        private EditorClient editorClient = new EditorClient();

        public TextEditorForm()
        {
            InitializeComponent();
        }

        private void textBoxTextEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.Z)
            {
                editorClient.Undo(textBoxTextEditor);
            }
        }

        private void textBoxTextEditor_KeyUp(object sender, KeyEventArgs e)
        {
            editorClient.FixUpdates(textBoxTextEditor);
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            editorClient.Undo(textBoxTextEditor);
        }
    }
}
