using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjeOdevi
{
    class Convert
    {
		public Convert()
		{
		}

		/// <summary>
		/// 4 uzunluklu bir stringi 32-bit unsigned integera cevirir.
		/// </summary>
		/// <param name="Input">Dönüştürülecek 4 uzunluklu string.</param>
		/// <returns>4 uzunluğunda bir dizeyi temsil eden kodlanmış bir string değeri.</returns>
		public static uint ConvertStringToUInt(string Input)
		{
			uint output;
			output = ((uint)Input[0]);
			output += ((uint)Input[1] << 8);
			output += ((uint)Input[2] << 16);
			output += ((uint)Input[3] << 24);
			return output;
		}

		/// <summary>
		///  32-bit unsigned integeri  4 uzunluklu stringe cevirir.
		/// </summary>
		/// <param name="Input">donusturulecek unsigned integer </param>
		/// <returns>Kodlanmis uint tarafından temsil edilen bir string degeri.</returns>
		public static string ConvertUIntToString(uint Input)
		{
			System.Text.StringBuilder output = new System.Text.StringBuilder();
			output.Append((char)((Input & 0xFF)));
			output.Append((char)((Input >> 8) & 0xFF));
			output.Append((char)((Input >> 16) & 0xFF));
			output.Append((char)((Input >> 24) & 0xFF));
			return output.ToString();
		}
	}
}
