using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_JSON_RickAndMorty
{
    public class RickAndMortyAPI
    {

        public Info info { get; set; }

        public List<Character> results { get; set; }

    }

    public class Character
    {
        public string name { get; set; }
        public string image { get; set; }
        //image and picture are not the same thing... must match json 
        public string url { get; set; }
        public string character { get; set; }

    }

    public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }

    }
}
