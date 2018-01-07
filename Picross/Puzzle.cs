using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Picross {
    class Puzzle {

        private string _title = "Untitled";
        private int _width, _height;
        private List<List<int>> _rowClues = new List<List<int>>();
        private List<List<int>> _colClues = new List<List<int>>();
        private PicrossGrid _grid;

        public int Width { get => _width; }
        public int Height { get => _height; }
        public string Title { get => _title; }
        internal PicrossGrid Grid { get => _grid; }
        public List<List<int>> RowClues { get => _rowClues; }
        public List<List<int>> ColClues { get => _colClues; }
        
        public Puzzle(string file) {
            LoadClues(file);
            _width = _colClues.Count;
            _height = _rowClues.Count;
            _grid = new PicrossGrid(_width, _height);
        }

        private void LoadClues(string file) {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);

            if (doc.SelectSingleNode("//title") != null)
                _title = doc.SelectSingleNode("//title").InnerText;


            foreach (XmlNode node in doc.GetElementsByTagName("clues")) {
                List<List<int>> workingList = node.Attributes["type"].Value.Equals("rows") ? _rowClues : _colClues;

                foreach (XmlNode line in node.ChildNodes) {
                    List<int> list = new List<int>();
                    workingList.Add(list);

                    foreach (XmlNode count in line.ChildNodes) {
                        list.Add(int.Parse(count.InnerText));
                    }
                }
            }
        }
    }
}
