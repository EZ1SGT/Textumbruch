using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textumbruch
{
    public class Program
    {
        static void Main(string[] args)
        {

            Program ProgramInstance;
            String Ausganstext;
            String Lösungstext;
            int maxZeichen = 14;

            ProgramInstance = new Program();
            Ausganstext = "Es blaut die Nacht, die Sternlein bliken, Schneeflöcklein leis hernieder sinken.";
            Lösungstext = ProgramInstance.Umbrechen(Ausganstext, maxZeichen);

            Console.WriteLine(Lösungstext);
            Console.ReadKey();

        }

        public string Umbrechen(string text, int maxZeichenlänge)
        {
            String FormattedText = "";

            if (text.Length > maxZeichenlänge)
            {
                while (text.Length > 0)
                {
                    text = text.Trim();
                    FormattedText += (FormattedText.Length != 0 ? System.Environment.NewLine : "");
                    FormattedText += text.Substring(0, GetLengthOfNextLine(text, maxZeichenlänge));
                    text = text.Remove(0, GetLengthOfNextLine(text, maxZeichenlänge));
                }
            } else
            {
                FormattedText = text;
            }

            return FormattedText;
        }

        public int GetLengthOfNextLine(String text, int maxLength)
        {
            int length = 0;
            int position = 0;
            int spaces = -1;
            bool hasNextChar = true;
            if (text.Length > maxLength)
            {
                while (hasNextChar)
                {
                    position = text.IndexOf(" ", length + 1);
                    if (position != -1 && position < maxLength)
                    {
                        length = position;
                        spaces++;
                    }
                    else
                    {
                        hasNextChar = false;
                    }
                }
            } else
            {
                length = text.Length;
            }

            if (length == 0)
            {
                length = maxLength;
            }

            return length;
        }
    }
}
