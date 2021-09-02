using System;
using System.Collections.Generic;

namespace CHAYANON004
{
    class Program
    {
        static void Main(string[] args)
        {
            Address
                addressJame = new Address("131/75" ,"พุทธมณฑล จ.นครปฐม", "10180");
            Shoppingcart
                shoppingJame = new Shoppingcart(addressJame);
            User
                userjame = new User("jame watson","jame@gmail.com");
            Tshirt ts1 = new Tshirt("L", "Red", 500f, "image1");
            Tshirt ts2 = new Tshirt("M", "Black", 750f, "image2");
            Tshirt ts3 = new Tshirt("S", "Blue", 625f, "image3");
            userjame.ShoppingCart.addTshirt(ts1);
            userjame.ShoppingCart.addTshirt(ts2);
            userjame.ShoppingCart.addTshirt(ts3);
            userjame.ShoppingCart.total1();
        }
    }
}
class User
{
    public string name;
    public string email;
    public string ShoppingCart;
    public User(string valueName, string valueEmail, string valueShoppingCart)
    {
        name = valueName;
        email = valueEmail;
        ShoppingCart = valueShoppingCart;
    }
}
class Tshirt
{
    public string size;
    public string color;
    public float price;
    public string image;
    public Tshirt (string valueSize, string valueColor, float valuePrice, string valueImage)
    {
        size = valueSize;
        color = valueColor;
        price = valuePrice;
        image = valueImage;

    }
}
class Address
{
    public string street;
    public string city;
    public string zipcode;
    public Address(string valueStreet, string valuecity, string valuezipcode)
    {
        street = valueStreet;
        city = valuecity;
        zipcode = valuezipcode;
    }
}
class Shoppingcart
{
    public float totalcost = 0;
    public Address address;
    private List<Tshirt> orderTshirt;
    public Shoppingcart(Address valueAddress)
    {
        orderTshirt = new List<Tshirt>();
        address = valueAddress;
    }
    public void addTshirt(Tshirt ts);

    orderTshirt.Add(Tshirt)
}
    public void totalcost()
    foreach (Tshirt ts in orderTshirt)
    {
        totalcost += tshirt.price;
    }
Console.WriteLine(totalcost);

//พยายามสุดๆแล้วครับพี่ ขอส่งหน่อยนะครับกลัวไม่ทันเวลา/เลท ยังหาไม่ถูกเลยครับว่าทำไมถึง error

    