using System;

namespace DTO_QLCafe
{
    public class DTO_Bill
    {
        public int idBill;
        public string idTable;
        public string idVoucher;
        public string idPayment;
        public string idStaff;
        public int statusBill;
        public DateTime dateCheckIn;
        public DateTime dateCheckOut;


        public string idProduct;

        public int amount;

        public float price;

        public float totalPrice;



        public string IdProduct { get => idProduct; set => idProduct = value; }

        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

        public int Amount { get => amount; set => amount = value; }
        public float Price { get => price; set => price = value; }

        public int IdBill { get => idBill; set => idBill = value; }
        public string IdTable { get => idTable; set => idTable = value; }
        public string IdVoucher { get => idVoucher; set => idVoucher = value; }
        public string IdPayment { get => idPayment; set => idPayment = value; }
        public string IdStaff { get => idStaff; set => idStaff = value; }
        public int StatusBill { get => statusBill; set => statusBill = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }

        public DTO_Bill() { }

        public DTO_Bill(int idBill, string idTable, string idVoucher, string idPayment, string idStaff, int statusBill, DateTime dateCheckIn, DateTime dateCheckOut)
        {
            this.idBill = idBill;
            this.idTable = idTable;
            this.idVoucher = idVoucher;
            this.idPayment = idPayment;
            this.idStaff = idStaff;
            this.statusBill = statusBill;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
        }
    }
}
