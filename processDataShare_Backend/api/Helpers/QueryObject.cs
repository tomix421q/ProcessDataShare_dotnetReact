namespace api.Helpers
{
    public class QueryObject
    {
        public ushort? ToolNum { get; set; } = null;
        public string? SortBy { get; set; } = null;
        public bool IsDecsending { get; set; } = false;
        public DateTime? DateFrom { get; set; } = null;
        public DateTime? DateTo { get; set; } = null;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;

        // 
        // ASQ ADD
        public bool? SelectAsq_A { get; set; } = null;
        public bool? SelectAsq_B { get; set; } = null;

    }
}