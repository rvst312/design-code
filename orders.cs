using System;
public class Orders {
    private int numOrder;
    private string dateOrder;
    private int idprod;
    private string dni; 

    private AddProduct() {
        return null;
    }
    private AddShopCart() {
        return null;
    }

    private class Cart : Orders {
        private string products;
        private int amount;
        private float totalamount;

        private PlaceOrder() {
            return null;
        }
    }
    private class WishList : Cart {
        private string products;
        private int amount;

        AddShoppingCart() {
            return null;
        }
        
    }

}

