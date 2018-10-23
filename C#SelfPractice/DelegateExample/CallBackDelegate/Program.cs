using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Reuse， 重复使用，也叫“复用”，代码的复用不但可以提高工作效率，
//还可以减少Bug的引入，良好的复用结构是所有优秀软件所追求的共同目标之一。

namespace CallBackDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFactory = new ProductFactory(); //准备ProductFactory
            WrapFactory wrapFactory = new WrapFactory(); //准备WrapFactory

            Logger logger = new Logger(); //实例化一个 外部对象logger
            Action<Product> log = new Action<Product>(logger.Log); //创建logger的委托，封装 logger

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza); //创建productFactory的委托
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);//创建productFactory的委托

            //delegate 类
            //正式调用模板方法.返回值为 Box类，虽然没有直接调用MakePizza()这个方法，但是我们通过委托，间接调
            Box box1 = wrapFactory.WrapProduct(func1,log);
            Box box2 = wrapFactory.WrapProduct(func2,log);

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
    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product'{0}' creat at {1} Price is {2}.",product.Name, DateTime.UtcNow, product.Price);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    // 用Box包装产品
    class Box
    {
        public Product Product { get; set; }
    }

    //用 Factory包装Box
    class WrapFactory  //模板方法  接收委托类型的参数
    {
        //本质：用委托类型的参数封装一个外部方法，再传进另一个方法的内部，再进行间接调用
        public Box WrapProduct(Func<Product> getProduct, Action<Product> logCallback)
        {
            Box box = new Box(); //首先准备了一个Box,下一步就是往box里面装Product
            Product product = getProduct.Invoke(); //所以这步就是获取产品type
            if(product.Price >= 50)
            {
                logCallback(product);
            }
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
            product.Price = 12;
            return product;
        }
        public Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "Toy Car";
            product.Price = 100;
            return product;
        }
    }
}
