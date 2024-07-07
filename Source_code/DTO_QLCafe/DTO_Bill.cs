namespace DTO_QLCafe
{
    public class DTO_Bill
    {
        public string idBill;
        public string idTable;
        public string idVoucher;
        public string idPayment;
        public string idStaff;
        public int statusBill;

        public string IdBill { get => idBill; set => idBill = value; }
        public string IdTable { get => idTable; set => idTable = value; }
        public string IdVoucher { get => idVoucher; set => idVoucher = value; }
        public string IdPayment { get => idPayment; set => idPayment = value; }
        public string IdStaff { get => idStaff; set => idStaff = value; }
        public int StatusBill { get => statusBill; set => statusBill = value; }

        public DTO_Bill() { }

        public DTO_Bill(string idBill, string idTable, string idVoucher, string idPayment, string idStaff, int statusBill)
        {
            this.idBill = idBill;
            this.idTable = idTable;
            this.idVoucher = idVoucher;
            this.idPayment = idPayment;
            this.idStaff = idStaff;
            this.statusBill = statusBill;
        }
    }
}
