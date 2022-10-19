using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID

{
    public class PopulateCatalogs
    {
         private  List<Product> productCatalog;

        private  List<Equipment> equipmentCatalog;

        public PopulateCatalogs()
        {
            productCatalog = new List<Product>();
            equipmentCatalog = new List<Equipment>();
            // Para ya tener el programa
            AddProductToCatalog("Café", 100);
            AddProductToCatalog("Leche", 200);
            AddProductToCatalog("Café con leche", 300);

            AddEquipmentToCatalog("Cafetera", 1000);
            AddEquipmentToCatalog("Hervidor", 2000);

        }
    

        private  void AddProductToCatalog(string description, double unitCost)
        {
            productCatalog.Add(new Product(description, unitCost));
        }

        private  void AddEquipmentToCatalog(string description, double hourlyCost)
        {
            equipmentCatalog.Add(new Equipment(description, hourlyCost));
        }

        private  Product ProductAt(int index)
        {
            return productCatalog[index] as Product;
        }

        private  Equipment EquipmentAt(int index)
        {
            return equipmentCatalog[index] as Equipment;
        }

        public  Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }

        public  Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }

    }
}