using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class WORD_GROUP
    {
        private int word_group_id;
        private string name_word_group;

        public int Word_group_id
        {
            get { return word_group_id;}
            set {word_group_id = value; }
        }

        public string Name_word_group
        {
            get
            {
                return name_word_group;
            }

            set
            {
                name_word_group = value;
            }
        }
        public WORD_GROUP(int _id,string name)
        {
            this.word_group_id = _id;
            this.name_word_group = name;
        }
    }
}
