namespace DTO_QLCafe
{
    public class DTO_TableCF
    {
        public string idTable;
        public string nameTable;
        public int statusTable;

        public string IdTable
        {
            get { return idTable; }
            set { idTable = value; }
        }

        public string NameTable
        {
            get { return nameTable; }
            set { nameTable = value; }
        }

        public int StatusTable
        {
            get { return statusTable; }
            set { statusTable = value; }
        }

        public DTO_TableCF() { }

        public DTO_TableCF(string idTable, string nameTable)
        {
            this.idTable = idTable;
            this.nameTable = nameTable;
        }
        public DTO_TableCF(string idTable, string nameTable, int statusTable)
        {
            this.idTable = idTable;
            this.nameTable = nameTable;
            this.statusTable = statusTable;
        }
    }
}
