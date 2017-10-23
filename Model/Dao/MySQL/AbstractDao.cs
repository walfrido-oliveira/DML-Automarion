using MySql.Data.MySqlClient;
namespace Walfrido.DML.Automation.Model.Dao.MySQL
{
    class AbstractDao
    {
        protected MySqlConnection conn;
        public AbstractDao(MySqlConnection conn)
        {
            this.conn = conn;
        }
    }
}
