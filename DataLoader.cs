using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo
{
	public class DataLoader
	{
		public class EachSearchResult
		{
			public string Description { get; set; }
			public int TestNumber { get; set; }
			public string TestFacility { get; set; }

		}

		public List<EachSearchResult> SearchResults { get; set; }

		public DataLoader()
		{
			SearchResults = new List<EachSearchResult>();
			for (int i = 1; i < 10; i++)
			{
				EachSearchResult sr = new EachSearchResult();
				sr.Description = "Description" + (i*i+4).ToString();
				sr.TestNumber = i * i + 23 * i + 358;
				sr.TestFacility = "Facility" + (2*(10-i)+3).ToString();
				SearchResults.Add(sr);
			}
		}
	}
}
