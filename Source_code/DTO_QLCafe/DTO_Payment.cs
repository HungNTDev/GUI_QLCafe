namespace DTO_QLCafe
{
    public class DTO_Payment
    {
        public string idPayment;

        public string typePayment;

        public int statusPayment;

        public string IdPayment { get => idPayment; set => idPayment = value; }

        public string TypePayment { get => typePayment; set => typePayment = value; }

        public int StatusPayment { get => statusPayment; set => statusPayment = value; }

        public DTO_Payment() { }

        public DTO_Payment(string idPayment, string typePayment, int statusPayment)
        {
            this.idPayment = idPayment;
            this.typePayment = typePayment;
            this.statusPayment = statusPayment;
        }
    }
}
