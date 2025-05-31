namespace Api.Models
{
    public class GalaDetailsVM
    {
        public int Id { get; set; }
        public required string GalaNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

    public class QualityDetailsVM
    {
        public int Id { get; set; }
        public required string QualityType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }


    public class GalaQualitySerialNoTrackVM
    {
        public int Id { get; set; }
        public int GalaNo { get; set; }
        public int QualityType { get; set; }
        public int SerialNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

    public class GalaQualitySerialNoTrackHistoryVM
    {
        public int Id { get; set; }
        public int GalaNo { get; set; }
        public int QualityType { get; set; }
        public int SerialNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }


    public class InventoryVM
    {
        public int Id { get; set; }
        public int GalaNo { get; set; }
        public int QualityType { get; set; }
        public int SerialNo { get; set; }
        public int LoomNo { get; set; }
        public decimal Meter { get; set; }
        public decimal NetWeight { get; set; }
        public decimal Avg_NetWeight { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}