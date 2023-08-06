using System;
namespace Transkript
{
	public class Islem
	{
		public Islem()
		{
		}

		public double NotOrtalama(double _vize, double _final, int _akt)
		{
			double hesap = _vize * 0.4 + _final * 0.7;

			if (hesap>100)
			{
				hesap = 100;
			}

			return hesap * _akt ;
		}
	}
}

