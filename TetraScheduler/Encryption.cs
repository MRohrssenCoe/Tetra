using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TetraScheduler
{
    
    public class Encrypt{
        public void Encryption()
        {
            string tetraFolder = Constants.AppDataFolder;
            string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
            string usernameString = File.ReadAllText(pswdFile);
            string[] token = usernameString.Split(",");
            string newPassword = "";
            char newChar = ' ';
            for(int i = 0; i < token.Length; i++)
            {
                newPassword = "";
                newChar = ' ';
                foreach(char c in token[i + 2])
                {
                    newChar = (char)(c * 3 + 10);
                    newPassword = newPassword + newChar;
                }
                token[i + 2] = newPassword;
            }

            string newString = token[0];
            for (int i = 1; i < token.Length; i++)
            {
                newString = newString + "," + token[i];
            }

            File.WriteAllText(pswdFile, newString);
        }

        public void Decryption()
        {
            string tetraFolder = Constants.AppDataFolder;
            string pswdFile = Path.Combine(tetraFolder, Constants.passwordFileName);
            string usernameString = File.ReadAllText(pswdFile);
            string[] token = usernameString.Split(",");
            string newPassword = "";
            char newChar = ' ';
            for (int i = 0; i < token.Length; i++)
            {
                newPassword = "";
                newChar = ' ';
                foreach (char c in token[i + 2])
                {
                    newChar = (char)(c / 3 - 10);
                    newPassword = newPassword + newChar;
                }
                token[i + 2] = newPassword;
            }

            string newString = token[0];
            for(int i = 1; i < token.Length; i++)
            {
                newString = newString + "," + token[i];
            }

            File.WriteAllText(pswdFile, newString);
        }
    }
}
