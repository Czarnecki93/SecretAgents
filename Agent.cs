using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopSecretAgents
{
    public class Agent
    {
        // Instance variables
        private int id;
        private string real_name;
        private string code_name;
        protected ArrayList languages = new ArrayList();

        // Constructor
        public Agent(int id, string real_name, string code_name, string[] languages)
        {
            Id = id;
            Real_name = real_name;
            Code_name = code_name;
            this.languages.Add(languages[0]);
            this.languages.Add(languages[1]);
        }

        // Properties
        public int Id { get => id; set => id = value; }
        public string Real_name { get => real_name; set => real_name = value; }
        public string Code_name { get => code_name; set => code_name = value; }

        public void updateLanguages(string firstLang, string secondLang)
        {
            languages[0] = firstLang;
            languages[1] = secondLang;
        }

        // ToString
        public override string ToString()
        {
            return "Hi, I'm " + real_name + " and I speak " + languages[0] + " and " + languages[1];
        }
    }
}