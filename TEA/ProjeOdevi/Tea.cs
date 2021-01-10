using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi
{
	class Tea
	{
		//kurucu method
		public Tea()
		{

		}

		public string Encrypt(string Data, string Key)
		{
			uint[] formattedKey = FormatKey(Key);

			if (Data.Length % 2 != 0) Data += '\0'; // Dizinin esit uzunlukta oldugundan emin olun.
			byte[] dataBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(Data);

			string cipher = string.Empty;
			uint[] tempData = new uint[2];
			for (int i = 0; i < dataBytes.Length; i += 2)
			{
				tempData[0] = dataBytes[i];
				tempData[1] = dataBytes[i + 1];
				code(tempData, formattedKey);
				cipher += Convert.ConvertUIntToString(tempData[0]) +
								  Convert.ConvertUIntToString(tempData[1]);
			}

			return cipher;
		}

		//Encryptte yaptiklarimizin tersini yapalim.
		public string Decrypt(string Data, string Key)
		{

			try
			{
				if (Data.Length % 8 != 0) throw new ArgumentOutOfRangeException();

				uint[] formattedKey = FormatKey(Key);
				int x = 0;
				uint[] tempData = new uint[2];
				byte[] dataBytes = new byte[Data.Length / 8 * 2];

				for (int i = 0; i < Data.Length; i += 8)
				{
					tempData[0] = Convert.ConvertStringToUInt(Data.Substring(i, 4));
					tempData[1] = Convert.ConvertStringToUInt(Data.Substring(i + 4, 4));
					decode(tempData, formattedKey);
					dataBytes[x++] = (byte)tempData[0];
					dataBytes[x++] = (byte)tempData[1];
				}

				string decipheredString =
						System.Text.ASCIIEncoding.ASCII.GetString(dataBytes,
																  0, dataBytes.Length);

				// Sifrelerken bos karakter eklediysek cikaralim.
				if (decipheredString[decipheredString.Length - 1] == '\0')
					decipheredString = decipheredString.Substring(0,
															decipheredString.Length - 1);
				return decipheredString;
			}
			catch (ArgumentOutOfRangeException)
			{
				return "Sifrelenmis veri uzunlugu 8 baytin kati olmalidir.(Farkli bir key kullanabilirsiniz)";
			}


		}
		// TEA icin anahtari formatlayalim.
		public uint[] FormatKey(string Key)
		{
			// Keyi 16 karakterli belirledim.
			Key = Key.PadRight(16, ' ').Substring(0, 16); 
			uint[] formattedKey = new uint[4];

			int j = 0;
			for (int i = 0; i < Key.Length; i += 4)
				formattedKey[j++] = Convert.ConvertStringToUInt(Key.Substring(i, 4));

			return formattedKey;
		}

		//Bu kismi gelen veriyi 64 bitin kati yapmak icin kullanabilirim.
		/*public int NextMultipleOf8(int length)
		{
			// TEA 64 block sifrelemedir, bu yuzden verilerimiz 64 bitin katlari olmali
			return (length + 7) / 8 * 8; // Bu sekilde bize 64 bitin katini verebilir.
		}
		*/

		#region Tea Algoritmasi
		//bu algoritma and , or , xor gibi operatorleri bitsel kaydirma icin <<,>> gibi operatorleri kullanir.
		public void code(uint[] v, uint[] k)
		{
			uint y = v[0];
			uint z = v[1];
			uint sum = 0;
			uint delta = 0x9e3779b9;
			uint n = 32;

			while (n-- > 0)
			{
				sum += delta;
				y += (z << 4) + k[0] ^ z + sum ^ (z >> 5) + k[1];
				z += (y << 4) + k[2] ^ y + sum ^ (y >> 5) + k[3];
			}

			v[0] = y;
			v[1] = z;
		}

		public void decode(uint[] v, uint[] k)
		{
			uint n = 32;
			uint sum;
			uint y = v[0];
			uint z = v[1];
			uint delta = 0x9e3779b9;

			sum = delta << 5;

			while (n-- > 0)
			{
				z -= (y << 4) + k[2] ^ y + sum ^ (y >> 5) + k[3];
				y -= (z << 4) + k[0] ^ z + sum ^ (z >> 5) + k[1];
				sum -= delta;
			}

			v[0] = y;
			v[1] = z;
		}
		#endregion
	}
}
