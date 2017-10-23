namespace Walfrido.DML.Automation.Model.Dao
{
    interface IURL
    {
        string User { get; set; }
        string Password { get; set; }
        string DataBase { get; set; }
        string Hostname { get; set; }
        string Port { get; set; }
        string GetURL();
    }
}
