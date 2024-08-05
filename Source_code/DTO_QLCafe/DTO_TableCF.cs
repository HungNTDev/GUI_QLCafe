namespace DTO_QLCafe
{
    public class DTO_TableCF
    {
        public string idTable;
        public string nameTable;
        public int statusTablePos;
        public string statusTableCF;

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

        public int StatusTablePos
        {
            get { return statusTablePos; }
            set { statusTablePos = value; }
        }

        public string StatusTableCF
        {
            get { return statusTableCF; }
            set { statusTableCF = value; }
        }

        public DTO_TableCF() { }

        public DTO_TableCF(string nameTable)
        {
            this.nameTable = nameTable;
        }

        public DTO_TableCF(string nameTable, string statusTableCF)
        {
            this.nameTable = nameTable;
            this.statusTableCF = statusTableCF;
        }
        public DTO_TableCF(string idTable, string nameTable, int statusTablePos, string statusTableCF)
        {
            this.idTable = idTable;
            this.nameTable = nameTable;
            this.statusTablePos = statusTablePos;
            StatusTableCF = statusTableCF;
        }
    }
}
