using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class NotesStore
    {
        HashSet<string> states = new HashSet<string>() { "completed", "active", "others" };
        Dictionary<string, List<string>> notes = new Dictionary<string, List<string>>();

        public NotesStore() { }

        public void AddNote(String state, String name)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be empty");
            }

            if (!states.Contains(state))
            {
                throw new ArgumentException($"Invalid state {state}");
            }

            if (notes.ContainsKey(state))
            {
                List<string> names = notes.GetValueOrDefault(state);
                names?.Add(name);

                notes.Remove(state);
                notes.Add(state, names);
            }
            else
            {
                notes.Add(state, new List<string> { name });
            }
        }
        public List<String> GetNotes(String state)
        {

            if (!states.Contains(state))
            {
                throw new ArgumentException($"Invalid state {state}");
            }

            if (!notes.ContainsKey(state))
            {
                return new List<String>() { };
            }

            return notes.GetValueOrDefault(state);
        }
    }
}
