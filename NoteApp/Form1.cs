namespace NoteApp
{
    public partial class Form1 : Form
    {
        private List<string> notes;
        private int selectedNoteIndex = -1;

        public Form1()
        {
            InitializeComponent();
            notes = new List<string>();
            LoadNotes();
            UpdateNotesList();
        }

        private void LoadNotes()
        {
            if (File.Exists("notes.txt"))
            {
                string[] lines = File.ReadAllLines("notes.txt");

                if (lines.Length > 0)
                {
                    // Попробуйте загрузить шрифт из первой строки
                    try
                    {
                        noteTextBox.Font = (Font)new FontConverter().ConvertFromString(lines[0]);
                    }
                    catch (NotSupportedException)
                    {
                        // В случае ошибки загрузки шрифта, используйте стандартный шрифт
                        noteTextBox.Font = new Font("Arial", 12);
                    }

                    if (lines.Length > 1)
                    {
                        noteTextBox.Text = string.Join(Environment.NewLine, lines, 1, lines.Length - 1);
                    }
                }
            }
        }

        private void SaveNotes()
        {
            List<string> lines = new List<string>
            {
                new FontConverter().ConvertToString(noteTextBox.Font)
            };
            lines.AddRange(notes);
            File.WriteAllLines("notes.txt", lines);
        }

        private void UpdateNotesList()
        {
            notesListBox.Items.Clear();
            notesListBox.Items.AddRange(notes.ToArray());
        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            notes.Add("Новая заметка");
            selectedNoteIndex = notes.Count - 1;
            UpdateNotesList();
        }

        private void notesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNoteIndex = notesListBox.SelectedIndex;
            if (selectedNoteIndex >= 0)
            {
                noteTextBox.Text = notes[selectedNoteIndex];
            }
            else
            {
                noteTextBox.Clear();

            }
        }

        private void saveNoteButton_Click(object sender, EventArgs e)
        {
            if (selectedNoteIndex >= 0)
            {
                notes[selectedNoteIndex] = noteTextBox.Text;
                SaveNotes();
                UpdateNotesList();
            }
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            if (selectedNoteIndex >= 0)
            {
                notes.RemoveAt(selectedNoteIndex);
                SaveNotes();
                selectedNoteIndex = -1;
                noteTextBox.Text = "";
                UpdateNotesList();
            }
        }

        private void changeFontButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                noteTextBox.Font = fontDialog.Font;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveNotes();
        }
    }
}