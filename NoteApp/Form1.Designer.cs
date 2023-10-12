namespace NoteApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newNoteButton = new Button();
            saveNoteButton = new Button();
            deleteNoteButton = new Button();
            notesListBox = new ListBox();
            noteTextBox = new TextBox();
            changeFontButton = new Button();
            label1 = new Label();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // newNoteButton
            // 
            newNoteButton.BackColor = Color.Yellow;
            newNoteButton.Location = new Point(12, 28);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(94, 29);
            newNoteButton.TabIndex = 0;
            newNoteButton.Text = "Создать";
            newNoteButton.UseVisualStyleBackColor = false;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // saveNoteButton
            // 
            saveNoteButton.BackColor = Color.FromArgb(0, 192, 0);
            saveNoteButton.Location = new Point(12, 276);
            saveNoteButton.Name = "saveNoteButton";
            saveNoteButton.Size = new Size(94, 29);
            saveNoteButton.TabIndex = 1;
            saveNoteButton.Text = "Сохранить";
            saveNoteButton.UseVisualStyleBackColor = false;
            saveNoteButton.Click += saveNoteButton_Click;
            // 
            // deleteNoteButton
            // 
            deleteNoteButton.BackColor = Color.Red;
            deleteNoteButton.Location = new Point(530, 276);
            deleteNoteButton.Name = "deleteNoteButton";
            deleteNoteButton.Size = new Size(94, 29);
            deleteNoteButton.TabIndex = 2;
            deleteNoteButton.Text = "Удалить";
            deleteNoteButton.UseVisualStyleBackColor = false;
            deleteNoteButton.Click += deleteNoteButton_Click;
            // 
            // notesListBox
            // 
            notesListBox.FormattingEnabled = true;
            notesListBox.ItemHeight = 20;
            notesListBox.Location = new Point(530, 63);
            notesListBox.Name = "notesListBox";
            notesListBox.Size = new Size(267, 204);
            notesListBox.TabIndex = 3;
            notesListBox.SelectedIndexChanged += notesListBox_SelectedIndexChanged;
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(12, 63);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(302, 207);
            noteTextBox.TabIndex = 4;
            // 
            // changeFontButton
            // 
            changeFontButton.BackColor = Color.FromArgb(0, 192, 192);
            changeFontButton.Location = new Point(220, 28);
            changeFontButton.Name = "changeFontButton";
            changeFontButton.Size = new Size(94, 29);
            changeFontButton.TabIndex = 6;
            changeFontButton.Text = "Шрифт";
            changeFontButton.UseVisualStyleBackColor = false;
            changeFontButton.Click += changeFontButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 7;
            label1.Text = "Текст заметки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(600, 9);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 8;
            label2.Text = "Список заметок";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(326, 63);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(811, 309);
            Controls.Add(monthCalendar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(changeFontButton);
            Controls.Add(noteTextBox);
            Controls.Add(notesListBox);
            Controls.Add(deleteNoteButton);
            Controls.Add(saveNoteButton);
            Controls.Add(newNoteButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newNoteButton;
        private Button saveNoteButton;
        private Button deleteNoteButton;
        private ListBox notesListBox;
        private TextBox noteTextBox;
        private Button changeFontButton;
        private Label label1;
        private Label label2;
        private MonthCalendar monthCalendar1;
    }
}