using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopSecretAgents
{
	public class Encryption
	{
		private static bool Cipher(string input, string oldAlphabet, string newAlphabet, out string output)
		{
			output = string.Empty;

			if (oldAlphabet.Length != newAlphabet.Length)
				return false;

			for (int i = 0; i < input.Length; ++i)
			{
				int oldCharIndex = oldAlphabet.IndexOf(char.ToLower(input[i]));

				if (oldCharIndex >= 0)
					output += char.IsUpper(input[i]) ? char.ToUpper(newAlphabet[oldCharIndex]) : newAlphabet[oldCharIndex];
				else
					output += input[i];
			}

			return true;
		}

		public static bool Encipher(string input, string cipherAlphabet, out string output)
		{
			string plainAlphabet = "abcdefghijklmnopqrstuvwxyz";
			return Cipher(input, plainAlphabet, cipherAlphabet, out output);
		}

		public static bool Decipher(string input, string cipherAlphabet, out string output)
		{
			string plainAlphabet = "abcdefghijklmnopqrstuvwxyz";
			return Cipher(input, cipherAlphabet, plainAlphabet, out output);
		}
	}
}