using System;
namespace DTTSG_Model
{
	public class LibrarianInfo
	{
		public int LibId { get; set; }
		public int ImageId { get; set; }
		public string LibPwd { get; set; }
		public string LibName { get; set; }
		public bool LibSex { get; set; }
		public string LibAddress { get; set; }
		public string LibPhone { get; set; }
		public bool IsValid { get; set; }
	}
}
