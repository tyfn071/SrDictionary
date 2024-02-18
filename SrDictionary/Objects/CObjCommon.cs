using SrDictionary.Commons;

namespace SrDictionary.Objects
{

    public class ObjCommon : Obj
    {
        public ObjCommon() : base()
        {
        }
        public ObjCommon(int id) : base(id)
        {
            AssocFileObj128 = "xxx";
            AssocFileDrop128 = "xxx";
            AssocFileIcon128 = "xxx";
            AssocFile1_128 = "xxx";
            AssocFile2_128 = "xxx";
            OrgObjCodeName128 = "xxx";
            ObjName128 = "xxx";
        }
        public string? ObjName128 { get; set; }
        public string? OrgObjCodeName128 { get; set; }
        public byte CashItem { get; set; }
        public byte Bionic { get; set; }
        public byte TypeID1 { get; set; }
        public byte TypeID2 { get; set; }
        public byte TypeID3 { get; set; }
        public byte TypeID4 { get; set; }
        public int DecayTime { get; set; }
        public byte Rarity { get; set; }
        public byte CanTrade { get; set; }
        public byte CanSell { get; set; }
        public byte CanBuy { get; set; }
        public byte CanBorrow { get; set; }
        public byte CanDrop { get; set; }
        public byte CanPick { get; set; }
        public byte CanRepair { get; set; }
        public byte CanRevive { get; set; }
        public byte CanUse { get; set; }
        public byte CanThrow { get; set; }
        public int Price { get; set; }
        public int CostRepair { get; set; }
        public int CostRevive { get; set; }
        public int CostBorrow { get; set; }
        public int KeepingFee { get; set; }
        public int SellPrice { get; set; }
        public int ReqLevelType1 { get; set; }
        public byte ReqLevel1 { get; set; }
        public int ReqLevelType2 { get; set; }
        public byte ReqLevel2 { get; set; }
        public int ReqLevelType3 { get; set; }
        public byte ReqLevel3 { get; set; }
        public int ReqLevelType4 { get; set; }
        public byte ReqLevel4 { get; set; }
        public int MaxContain { get; set; }
        public int RegionID { get; set; }
        public int Dir { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public int OffsetZ { get; set; }
        public int Speed1 { get; set; }
        public int Speed2 { get; set; }
        public int Scale { get; set; }
        public int BCHeight { get; set; }
        public int BCRadius { get; set; }
        public int EventID { get; set; }
        public string? AssocFileObj128 { get; set; }
        public string? AssocFileDrop128 { get; set; }
        public string? AssocFileIcon128 { get; set; }
        public string? AssocFile1_128 { get; set; }
        public string? AssocFile2_128 { get; set; }
        public int Link { get; set; }
    }
}
