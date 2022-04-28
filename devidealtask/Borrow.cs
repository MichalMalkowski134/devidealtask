using System;

namespace devildealtask
{
	public class Borrow
	{
		private int type;
		private DateTime borrow_date;
		private DateTime return_date;
		private int days;
		private int fee;
		private string[] types;

		public Borrow(int t, string bd, string rd)
		{
			types = new string[] { "IT", "History", "Classics", "Law", "Medical", "Philosophy" };
			type = t;
			if (type == 1)
				fee = 5;
			else if (type == 2)
				fee = 3;
			else
				fee = 2;
			borrow_date = Convert.ToDateTime(bd);
			return_date = Convert.ToDateTime(rd);
			TimeSpan d = return_date - borrow_date;
			days = (int)d.TotalDays;

		}

		public int penalty_fee()
		{
			if (days > 1)
				return fee * (days - 1);
			return 0;
		}

		public string get_book_type()
        {
			return types[type - 1];
        }
	}
}