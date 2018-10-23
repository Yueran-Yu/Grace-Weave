using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            var mathScore = stu["Math"];
            Console.WriteLine(mathScore);
        }
    }

    // 建立Student类
    class Student
    {
        //建立一个索引器
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>();

        //这里的int？ 意思是返回可空的int类型
        public int? this[string subject]
        {
            get
            { 
                //检索是否含有该键
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    //返回该键对应的值
                    return this.scoreDictionary[subject];
                }
                else
                {
                    //如不存在 目标 键，返回空
                    return null;
                }
            } 
            set
            {
                //如果值 是空的，抛出异常
                if(value.HasValue == false)
                {
                    throw new Exception("Score cannot be null.");
                }
                //如果存在 目标 键，则返回对应的值
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    this.scoreDictionary[subject] = value.Value;
                }
                //否则添加 键 和 值
                else
                {
                    this.scoreDictionary.Add(subject, value.Value);
                }
            }
        }       
    }
}
