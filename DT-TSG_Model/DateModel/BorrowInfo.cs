using System;
namespace DTTSG_Model
{
	public class BorrowInfo
	{
		public int BorrowId { get; set; }
		public int B_MechanId { get; set; }
		public int R_MechanId { get; set; }
		public int Bo_TypeId { get; set; }
		public int UserId { get; set; }
		public DateTime B_StartTime { get; set; }
		public DateTime B_EndTime { get; set; }
		public DateTime B_ReturnTime { get; set; }
	}
}
