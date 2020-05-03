using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CoreSudoku.Data
{
    public class Persistence
    {
        public void Save(GridData data, string filename)
        {
            string jsonString;
            jsonString = JsonSerializer.Serialize<GridData>(data);
            File.WriteAllText(filename, jsonString);
        }

        public GridData Load(string filename)
        {
            GridData data;

            string jsonString;
            jsonString = File.ReadAllText(filename);

            data = JsonSerializer.Deserialize<GridData>(jsonString);

            return data;
        }
    }
}
