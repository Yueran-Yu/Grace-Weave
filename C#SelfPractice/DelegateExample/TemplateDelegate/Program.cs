using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Reuse， 重复使用，也叫“复用”，代码的复用不但可以提高工作效率，
//还可以减少Bug的引入，良好的复用结构是所有优秀软件所追求的共同目标之一。

namespace TemplateDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFactory = new ProductFactory(); //准备ProductFactory
            WrapFactory wrapFactory = new WrapFactory(); //准备WrapFactory

            //如果WrapFactory类 里的 WrapPruduct method 需要包装产品，那必须满足一个条件：有 Product的 delegate类。所以就必须创建 相应的 delegate 类的对象
            //注意：这里delegate 类的作用是 获取Product的type，而产品的type只存在于ProductFactory里
            //所以必须在ProductFactory类里才能 获取不同Prodcut的信息
            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            //delegate 类
            //正式调用模板方法.返回值为 Box类，虽然没有直接调用MakePizza()这个方法，但是我们通过委托，间接调
           Box box1 = wrapFactory.WrapProduct(func1);
           Box box2 = wrapFactory.WrapProduct(func2);

            //最终打印Box的信息
            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);

        }
    }

    //这样写代码的优势：
    //一旦将代码写成这样，Product类， Box类，以及WrapFactory类，都不不用再动
    //我们仅需要不断扩展产品工厂，那我们就能生产各种各样不同的Product
    //而且不管是生产哪种Product的方法，只要我们将 那个Product的方法封装在 delegate的对象里
    //传给我们的模板方法，我们的模板方法，我们的Template method 就一定会按内置步骤，将Product 包装到Box里
    class Product
    {
        public string Name { get; set; }
    }

    // 用Box包装产品
    class Box
    {
        public Product Product { get; set; }
    }

    //用 Factory包装Box
    class WrapFactory  //模板方法  接收委托类型的参数
    {
        public Box WrapProduct(Func<Product> getProduct)
        {
            Box box = new Box(); //首先准备了一个Box,下一步就是往box里面装Product
            Product product = getProduct.Invoke(); //所以这步就是获取产品type
            box.Product = product; //再把Product装到box里
            return box;
        }
    }

    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }
        public Product MakeToyCar()
        {
            Product product = new Product();  
            product.Name = "Toy Car";
            return product;
        }
    }
}
