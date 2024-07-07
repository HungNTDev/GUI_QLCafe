namespace DTO_QLCafe
{
    public class DTO_DetailBill
    {
        public string idBill;

        public string idProduct;

        public float totalPrice;

        public int amount;

        public string IdBill { get => idBill; set => idBill = value; }

        public string IdProduct { get => idProduct; set => idProduct = value; }

        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

        public int Amount { get => amount; set => amount = value; }

        public DTO_DetailBill() { }

        public DTO_DetailBill(string idBill, string idProduct, float totalPrice, int amount)
        {
            this.idBill = idBill;
            this.idProduct = idProduct;
            this.totalPrice = totalPrice;
            this.amount = amount;
        }
    }
}
