using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLCafe
{
    public class DTO_ProductType
    {
        public string idPT {  get; set; }
        public string namePT { get; set; }
        public string statusPT { get; set; }

        public string IdPT
        {
            get { return idPT; }
            set { idPT = value; }
        }
        public string NamePT
        {
            get { return namePT; }
            set { namePT = value; }
        }
        public string StatusPT
        {
            get { return statusPT; }
            set { statusPT = value; }
        }
        public DTO_ProductType()
        {
            
        }
    }
}
