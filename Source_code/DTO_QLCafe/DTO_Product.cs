using System.IO;

namespace DTO_QLCafe
{
    public class DTO_Product
    {
        public string idProduct;

        public string nameProduct;

        public float price;

        public string imageProduct;

        public int statusProduct;

        public string idPT;

        public string IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }

        public string NameProduct
        {
            get { return nameProduct; }
            set { nameProduct = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public string ImageProduct
        {
            get { return imageProduct; }
            set { imageProduct = value; }
        }

        public int StatusProduct
        {
            get { return statusProduct; }
            set { statusProduct = value; }
        }

        public string IdPT
        {
            get { return idPT; }
            set { idPT = value; }
        }

        public DTO_Product() { }

        public DTO_Product(string idProduct, string nameProduct, float price, string imageProduct, int statusProduct, string idPT)
        {
            this.idProduct = idProduct;
            this.nameProduct = nameProduct;
            this.price = price;
            this.imageProduct = imageProduct;
            this.statusProduct = statusProduct;
            this.idPT = idPT;
        }

        public DTO_Product(string idProduct, string nameProduct, float price, string imageProduct, int statusProduct)
        {
            this.idProduct = idProduct;
            this.nameProduct = nameProduct;
            this.price = price;
            this.imageProduct = imageProduct;
            this.statusProduct = statusProduct;
        }
    }

}
