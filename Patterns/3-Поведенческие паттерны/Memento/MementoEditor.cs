using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    // Client for memento
    public class EditorClient
    {
        private TextEditor textEditor = new TextEditor();
        private EditorHistory editorHistory = new EditorHistory();

        public void FixUpdates(TextBox textBox)
        {
            if (textEditor.DoesTextChanged(textBox.Text))
            {
                textEditor.SetText(textBox.Text);

                editorHistory.AddState(textEditor.SaveState());
            }
        }

        public void Undo(TextBox textBox)
        {
            if (editorHistory.States.Count > 0)
            {
                textBox.Text = textEditor.RestoreState(editorHistory.PopLastState());
            }
        }
    }

    // Originator
    public class TextEditor
    {
        public string Text { get; private set; }

        public bool DoesTextChanged(string newText)
        {
            return Text != newText;
        }

        public void SetText(string newText)
        {
            Text = newText;
        }

        public EditorState SaveState()
        {
            return new EditorState(Text);
        }

        public string RestoreState(EditorState memento)
        {
            Text = memento.Text;

            return Text;
        }
    }

    // Memento
    public class EditorState
    {
        public string Text { get; private set; }

        public EditorState(string text)
        {
            Text = text;
        }
    }

    // Caretaker
    public class EditorHistory
    {
        public LinkedList<EditorState> States { get; private set; }

        public EditorHistory()
        {
            States = new LinkedList<EditorState>();
        }

        public void AddState(EditorState state)
        {
            States.AddFirst(state);

            if (States.Count >= 256)
            {
                States.RemoveLast();
            }
        }

        public EditorState PopLastState()
        {
            var state = States.First.Value;

            States.RemoveFirst();

            return state;
        }
    }
}
