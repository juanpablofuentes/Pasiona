using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    class AllNotes
    {
        public ObservableCollection<Nota> Notes { get; set; } = new ObservableCollection<Nota>();

        public AllNotes() =>
            LoadNotes();

        public void LoadNotes()
        {
            Notes.Clear();

            // Get the folder where the notes are stored.
            string appDataPath = FileSystem.AppDataDirectory;

            // Use Linq extensions to load the *.notes.txt files.
            IEnumerable<Nota> notes = Directory

                                        // Select the file names from the directory
                                        .EnumerateFiles(appDataPath, "*.notes.txt")

                                        // Each file name is used to create a new Nota
                                        .Select(filename => new Nota()
                                        {
                                            Filename = filename,
                                            Text = File.ReadAllText(filename),
                                            Date = File.GetCreationTime(filename)
                                        })

                                        // With the final collection of notes, order them by date
                                        .OrderBy(Nota => Nota.Date);

            // Add each Nota into the ObservableCollection
            foreach (Nota Nota in notes)
                Notes.Add(Nota);
        }
    }
}
