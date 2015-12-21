using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
  public  class WORD
    {

        private int word_id;
        private string word;
        private string category;
        private string mean;
        private string phonetic;
        private string sentence;
        private int word_group_id;
        public string Word
        {
            get
            {
                return word;
            }

            set
            {
                word = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string Mean
        {
            get
            {
                return mean;
            }

            set
            {
                mean = value;
            }
        }

        public string Phonetic
        {
            get
            {
                return phonetic;
            }

            set
            {
                phonetic = value;
            }
        }

        public string Sentence
        {
            get
            {
                return sentence;
            }

            set
            {
                sentence = value;
            }
        }

        public int Word_id
        {
            get
            {
                return word_id;
            }

            set
            {
                word_id = value;
            }
        }

        public int Word_group_id
        {
            get
            {
                return word_group_id;
            }

            set
            {
                word_group_id = value;
            }
        }


    }
}
