using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Shop_CW.Db
{
	public class Json<T>
	{
		string filePath;
		public Json(string filePath)
		{
			this.filePath = filePath;
		}
		public void Write(List<T> obj)
		{
			string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
			File.WriteAllText(filePath, json);
		}
		public List<T> Read()
		{
			string jsonData = File.ReadAllText(filePath);
			var jsonObjects = JsonConvert.DeserializeObject<List<T>>(jsonData);
			return jsonObjects;
		}
	}
}
