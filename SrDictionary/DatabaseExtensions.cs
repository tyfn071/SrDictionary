using SrDictionary.Commons;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace SrDictionary
{
    public static class DatabaseExtensions
    {
        public static void Execute(this SqlConnection conn, string query, CommandType type = CommandType.Text, params SqlParameter[] parameters)
        {
            using (SqlCommand comm = new SqlCommand(query, conn))
            {
                comm.CommandType = type;
                foreach (var p in parameters)
                    comm.Parameters.Add(p);
                comm.ExecuteNonQuery();
            }
        }
        public static async Task ExecuteAsync(this SqlConnection conn, string query, CommandType type = CommandType.Text, params SqlParameter[] parameters)
        {
            using (SqlCommand comm = new SqlCommand(query, conn))
            {
                comm.CommandType = type;
                foreach (var p in parameters)
                    comm.Parameters.Add(p);
                await comm.ExecuteNonQueryAsync();
            }
        }
        public static void Execute(this SqlConnection conn, string query, object obj, CommandType type = CommandType.Text)
        {
            using (SqlCommand comm = new SqlCommand(query, conn))
            {
                comm.CommandType = type;
                ParseParameters(comm.Parameters, obj);
                comm.ExecuteNonQuery();
            }
        }
        public static async Task ExecuteAsync<T>(this SqlConnection conn, string query, T obj, CommandType type = CommandType.Text)
        {
            using (SqlCommand comm = new SqlCommand(query, conn))
            {
                comm.CommandType = type;
                ParseParameters(comm.Parameters, obj);
                await comm.ExecuteNonQueryAsync();
            }
        }
        public static T GetData<T>(this SqlConnection conn, string query, object obj, CommandType type = CommandType.Text)
        {
            T s;
            using (SqlCommand comm = new SqlCommand(query, conn))
            {
                comm.CommandType = type;
                ParseParameters(comm.Parameters, obj);
                DataTable table = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(comm);
                adapt.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    s = (T)row[0];
                }
                else
                    s = default;
            }

            return s;
        }
        public static SqlParameter GetParam(this object value, string name, SqlDbType type, int length = 0)
        {
            SqlParameter result = null;
            if (length > 0)
                result = new SqlParameter(name, type, length);
            else
                result = new SqlParameter(name, type);

            result.Value = value;

            return result;
        }
        public static T GetData<T>(this SqlConnection conn, string query, CommandType type = CommandType.Text, params SqlParameter[] parameters)
        {
            T s;
            using (SqlCommand comm = new SqlCommand(query, conn))
            {
                foreach (var p in parameters)
                    comm.Parameters.Add(p);
                comm.CommandType = type;
                DataTable table = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(comm);
                adapt.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    s = (T)row[0];
                }
                else
                    s = default;
            }

            return s;
        }
        private static void ParseParameters(SqlParameterCollection collection, object obj)
        {

            PropertyInfo[] props = obj.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {

                object[] attrs = prop.GetCustomAttributes(true);
                foreach (object attr in attrs)
                {
                    if (attr is SParamAttribute)
                    {
                        var sqlAttr = attr as SParamAttribute;
                        if (sqlAttr != null)
                        {
                            if (sqlAttr.Length > 0)
                                collection.Add(new SqlParameter($"{sqlAttr.Name}", sqlAttr.Type, sqlAttr.Length));
                            else
                                collection.Add(new SqlParameter($"{sqlAttr.Name}", sqlAttr.Type));


                            collection[$"{sqlAttr.Name}"].Value = prop.GetValue(obj, null);
                        }

                    }

                }
            }

        }
    }
}
