namespace SrDictionary.Commons
{
    public class DBObject : IDBObject
    {
        public DBObject()
        {

        }
        public DBObject(int id)
        {
            ID = id;
        }
        [SParam("@id")]
        public int ID { get; private set; }

        public void Save()
        {

        }
    }
}
