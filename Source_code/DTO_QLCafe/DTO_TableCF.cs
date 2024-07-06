namespace DTO_QLCafe
{
    public class DTO_TableCF
    {
        public string idTable { get; set; }
        public string nameTable { get; set; }
        public int statusTable { get; set; }

        public string IdTable { get => idTable; set => idTable = value; }

        public string NameTable { get => nameTable; set => nameTable = value; }

        public int StatusTable { get => statusTable; set => statusTable = value; }

        public DTO_TableCF() { }
        public DTO_TableCF(string idTable, string nameTable, int statusTable)
        {
            this.idTable = idTable;
            this.nameTable = nameTable;
            this.statusTable = statusTable;
        }
    }
}
