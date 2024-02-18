namespace SrDictionary.Commons
{
    public class Obj : DBObject
    {
        public Obj()
        {
            Service = 1;
        }
        public Obj(int id) : base(id)
        {
            Service = 1;
        }
        [SParam("@service")]
        public byte Service { get; set; }
        [SParam("@country")]
        public int Country { get; set; }
        [SParam("@codename", System.Data.SqlDbType.VarChar, 129)]
        public string? CodeName128 { get; set; }
        [SParam("@namestr", System.Data.SqlDbType.VarChar, 129)]
        public string? NameStrID128 { get; set; }
        [SParam("@descstr", System.Data.SqlDbType.VarChar, 129)]
        public string? DescStrID128 { get; set; }
    }
}
