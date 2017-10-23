namespace Walfrido.DML.Automation.Model
{
    class Column : IColumn
    {
        public string Name {get; set;}
        public int? Size { get; set; }
        public Types.Values TypeValue { get; set; }
        public int Index { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
