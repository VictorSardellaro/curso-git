using System.Globalization;

namespace Aula_42 {
    class Product {

        public string Name;
        public double Price;
        public int Qty;

        public double totalInventoryValue() {
            return Price * Qty;
        }
        
        public void AddProducts (int quantidade) {
            Qty = Qty + quantidade;
        }
        public void RemProducts(int quantidade) {
            Qty = Qty - quantidade;
        }
        
        public override string ToString() {
            return Name + ", $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Qty 
                + " unidades, Total: $ " 
                + totalInventoryValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
