using System;
using System.Collections.Generic;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> preLettersMale = new List<string>() {"S","Sp","Sk","St","T"};
            List<string> vocals = new List<string>() {"a","e","i","o","u","y" };
            List<string> middleLettersMale = new List<string>() {"r","t","p","d","f","j","k","l","v","b","n","m" };
            List<string> endLettersMale = new List<string>() {"q","p","k","ck","l" };
            string femaleStart = "T'";
            List<string> preLettersFemale = new List<string>() { "P", "K", "Q" };
            List<string> endLettersFemale = new List<string>() { "r", "j", "'p", "k", "l" };
            List<string> namesMale = new List<string>();
            List<string> namesFemale = new List<string>();

            foreach (var letter in preLettersMale)
            {
                string pre = "";
                pre = letter;
                foreach (var vocal in vocals)
                {
                    string preVocal;
                    preVocal = pre + vocal;
                    foreach (var middleLetter in middleLettersMale)
                    {
                        string preVocalMiddle;
                        preVocalMiddle = preVocal + middleLetter;
                        foreach (var endVocal in vocals)
                        {
                            string preVocalMiddleEndVocal;
                            preVocalMiddleEndVocal = preVocalMiddle + endVocal;
                            foreach (var endLetter in endLettersMale)
                            {
                                string preVocalMiddleEndVocalEndLetter;
                                preVocalMiddleEndVocalEndLetter = preVocalMiddleEndVocal + endLetter;
                                namesMale.Add(preVocalMiddleEndVocalEndLetter);
                            }
                        }
                    }
                }
            }

            foreach (var preLetter in preLettersMale)
            {
                string pre = "";
                pre = preLetter;
                foreach (var vocal in vocals)
                {
                    string preVocal;
                    preVocal = pre + vocal;
                    foreach (var endLetter in endLettersMale)
                    {
                        string preVocalEndLetter;
                        preVocalEndLetter = preVocal + endLetter;
                        namesMale.Add(preVocalEndLetter);
                    }
                }
            }

            foreach (var preLetter in preLettersFemale)
            {
                string pre;
                pre = femaleStart + preLetter;
                foreach (var vocal in vocals)
                {
                    string preVocal;
                    preVocal = pre + vocal;
                    foreach (var endLetter in endLettersFemale)
                    {
                        string preVocalEndLetter;
                        preVocalEndLetter = preVocal + endLetter;
                        namesFemale.Add(preVocalEndLetter);
                    }
                }
            }

        }
    }
}
