using ProductProject;
using System.Collections;
using System.Collections.Immutable;
using System.Collections.Generic;
using System;
using static ProductProject.Product;

//Task 0.0
Console.WriteLine("Task 0.0");
ArrayList list = new ArrayList();
try
{
    object s = list[18];
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

//Task 0.1
Console.WriteLine("Task 0.1");
var words = new Dictionary<int, string>()
{
    {1,"yksi" },
    {2,"kaksi" },
    {3,"kolme" },
    {4,"neljä" },
    {5,"viisi" },
    {6,"kuusi" },
    {7,"seitsemän" },
    {8,"kahdeksan" },
    {9,"yhdeksän" },
    {10,"kymmenen" }
};
foreach (var word in words)
    Console.WriteLine(word);


//Task 0.2
Console.WriteLine("Task 0.2");
string str = Console.ReadLine();
string[] strArray = str.Split(',');


var list1 = strArray.ToList().Distinct();
foreach (var item in list1)
    Console.WriteLine(item);

//Task 1
Console.WriteLine("Task 1");
List<Product> productList = new List<Product>();


string nameb = "batchdfsdf";
double priceb = 33;
DateTime expdateb = new DateTime(2024, 3, 1, 8, 30, 52);
DateTime prodtimeb = new DateTime(2008, 5, 1, 8, 30, 52);
int amountb = 13567;

string names = "setsetset";
double prices = 453543;

string name1 = "hjkhvjkhjkfyjk";
double price1 = 2;
DateTime expdate1 = new DateTime(2024, 12, 12, 9, 28, 50);
DateTime prodtime1 = new DateTime(2018, 4, 2, 5, 8, 52);


string name2 = "fghfgsdfasdf346356";
double price2 = 3000;
DateTime expdate2 = new DateTime(2024, 2, 3, 10, 29, 51);
DateTime prodtime2 = new DateTime(2019, 4, 2, 5, 8, 52);


string name3 = "lkdlkd00";
double price3 = 4;
DateTime expdate3 = new DateTime(2024, 12, 5, 10, 29, 51);
DateTime prodtime3 = new DateTime(2020, 4, 3, 6, 8, 54);


var product1 = new Product(name1, price1, prodtime1, expdate1);
var product2 = new Product(name2, price2, prodtime2, expdate2);
var product3 = new Product(name3, price3, prodtime3, expdate3);

productList.Add(product1);
productList.Add(product2);
productList.Add(product3);


productList.FirstOrDefault().Price = 100;
productList.Remove(productList.Last());

foreach (var product in productList)
{
    Console.WriteLine($"Prod name {product.Name}, prod price {product.Price}, prodtime {product.ProductionDate}, expdate {product.ExpireDate}");
}
Console.WriteLine("prodArray:");
Product[] prodArray = productList.ToArray();
int j = 0;
foreach (var product in prodArray)
{
    Console.WriteLine($"Prod name {prodArray[j].Name}, prod price {prodArray[j].Price}, prodtime {prodArray[j].ProductionDate}, expdate {prodArray[j].ExpireDate}");
    j++;
}

Console.WriteLine("prodArray2:");
Product[] prodArray2 = new Product[productList.Count];
int i = 0;
foreach (var product in productList)
{
    prodArray2[i] = product;
    Console.WriteLine($"Prod name {prodArray2[i].Name}, prod price {prodArray2[i].Price}, prodtime {prodArray2[i].ProductionDate}, expdate {prodArray2[i].ExpireDate}");
    i++;
}
productList.Clear(); // Remove all the items from the List.


//Task 2
Console.WriteLine("Task 2");
Console.WriteLine("prodList2:");
var prodList2 = new SortedSet<Product>(new ProductComparer()) { product1, product2, product3 };
foreach (var product in prodList2)
{
    Console.WriteLine($"Prod name {product.Name}, prod price {product.Price}, prodtime {product.ProductionDate}, expdate {product.ExpireDate}");
}



//Task 4
Console.WriteLine("Task 4.1");
string name4 = "testprod3name";
double price4 = 210;
int count4 = 44;


string name5 = "testprod4name";
double price5 = 32;
int count5 = 55;


string name6 = "testprod5name";
double price6 = 430;
int count6 = 66;

var product4 = new Product(name4, price4, count4);
var product5 = new Product(name5, price5, count5);
var product6 = new Product(name6, price6, count6);


var productDictionary = new Dictionary<string, int>()
{
    {product4.Name, product4.Count},
    {product5.Name, product5.Count},
    {product6.Name, product6.Count}
};

new Product().PrintNameAndCountPair(productDictionary);
Console.WriteLine();

new Product().PrintName(productDictionary);
Console.WriteLine();

new Product().PrintCount(productDictionary);
Console.WriteLine();


//Task 5.1
Console.WriteLine("Task 5.1");
List<Product> products = new List<Product>() { product4, product5, product6 };

List<string> listName = new List<string>();
listName = productDictionary.Keys.ToList();

List<int> listCount = new List<int>();
listCount = productDictionary.Values.ToList();

List<object> listOfProductsValues = new List<object>();


for (int m = 0; m < listName.Count; m++)
{
    listOfProductsValues.Add(listName[m]);
    listOfProductsValues.Add(listCount[m]);
    listOfProductsValues.Add(products[m].Price);
}
foreach (object productVal in listOfProductsValues)
{
    Console.WriteLine(productVal);
}






//Task 3

Console.WriteLine("Task 3");
List<Product> productsp = new List<Product>();
productsp.Add(product1);
productsp.Add(product2);
productsp.Add(product3);
productsp.Add(product4);
productsp.Add(product5);
productsp.Add(product6);

List<Product> exp_products = new Product().ExpensiveProducts(productsp);
foreach (var product in exp_products)
{
    Console.WriteLine($"Prod name {product.Name}, prod price {product.Price}");
}



//Task 5.2
Console.WriteLine("Task 5.2");
Dictionary<string, double> dictExpProd = new Dictionary<string, double>();

dictExpProd = exp_products.ToDictionary(l => l.Name, s => s.Price);

new Product().PrintNameAndPricePair(dictExpProd);
Console.WriteLine();





