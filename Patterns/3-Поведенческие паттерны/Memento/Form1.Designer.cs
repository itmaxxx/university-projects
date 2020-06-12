namespace Memento
{
    partial class TextEditorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTextEditor = new System.Windows.Forms.TextBox();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.labelHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTextEditor
            // 
            this.textBoxTextEditor.Location = new System.Drawing.Point(12, 39);
            this.textBoxTextEditor.Multiline = true;
            this.textBoxTextEditor.Name = "textBoxTextEditor";
            this.textBoxTextEditor.Size = new System.Drawing.Size(776, 399);
            this.textBoxTextEditor.TabIndex = 0;
            this.textBoxTextEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTextEditor_KeyDown);
            this.textBoxTextEditor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxTextEditor_KeyUp);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(12, 10);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(75, 23);
            this.buttonUndo.TabIndex = 1;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Location = new System.Drawing.Point(93, 15);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(105, 13);
            this.labelHelp.TabIndex = 2;
            this.labelHelp.Text = "or press Ctrl + Alt + Z";
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.textBoxTextEditor);
            this.Name = "TextEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTextEditor;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Label labelHelp;
    }
}

