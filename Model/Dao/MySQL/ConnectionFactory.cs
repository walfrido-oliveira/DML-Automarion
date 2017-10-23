using MySql.Data.MySqlClient;
namespace Walfrido.DML.Automation.Model.Dao.MySQL
{
    class ConnectionFactory
    {
        private IURL url;

        public ConnectionFactory(IURL url)
        {
            this.url = url;
        }

        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(this.url.GetURL());
            conn.Open();
            return conn;
        }
    }
}
