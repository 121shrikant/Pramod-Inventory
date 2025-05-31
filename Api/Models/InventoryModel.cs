namespace Api.Models
{
    public class GalaDetails
    {
        public int Id { get; set; }
        public required string GalaNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

    public class QualityDetails
    {
        public int Id { get; set; }
        public required string QualityType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }


    public class GalaQualitySerialNoTrack
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

    public class GalaQualitySerialNoTrackHistory
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


    public class Inventory
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