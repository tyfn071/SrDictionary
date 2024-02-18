namespace SrDictionary.Commons
{
    public interface IDBObject
    {
        int ID { get; }
        void Save();

    }
}
