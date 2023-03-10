using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_abstract
{
    internal class Program
    {
        public interface ICanFly
        {
            void Fly();

        }

        public interface IQuark
        {
            void Quark();
            
        }

        public abstract class Duck  //抽象類別能繼承介面 但介面不能繼承抽象類別
        {                           //動物是個概念(抽象類別) 貓是實體(類別)
                                    //植物是個概念(抽象類別) 竹子是實體(類別)
                                    //生長是共同行為(介面) 不是因為會生長所以才是動物或植物 而是因為是動物或植物才會生長
            // 抽象方法不可使用 Private
            public abstract void Swim(); //繼承的子類別要實作所有「抽象」辦法
            
            public void BelongTo()      //繼承的子類別非抽象方法可以不做
            {
                Console.WriteLine("I belong to Duck.");
            }

            
        }

        // 塑膠鴨
        public class RubberDuck : Duck
        {
            public override void Swim()
            {
                Console.WriteLine("I am RubberDuck, I can Swim!");
            }
        }

        // 屬鴨科的天鵝
        // 只能繼承一個抽象類別，但可繼承很多介面
        public class Swan : Duck, ICanFly, IQuark
        {
            public void Fly()
            {
                Console.WriteLine("I am swam, I can fly!");
            }

            public void Quark()
            {
                Console.WriteLine("I am swam, I can quark!");
            }

            public override void Swim()
            {
                Console.WriteLine("I am swam, I can Swim!");
            }
        }

        private static void Main(string[] args)
        {
            //Duck duck = new Duck();   // [錯誤]無法建立抽象類別的執行個體
            //                          //動物是個概念 不具指定性「幫我餵動物...是指天上的鳥?路上的狗?海裡的魚?」
            RubberDuck rubberDuck = new RubberDuck();
            Swan swan = new Swan();
            rubberDuck.Swim();
            rubberDuck.BelongTo();
            swan.Fly();
            swan.Quark();
            swan.Swim();
            swan.BelongTo();
            Console.ReadLine();
        }
    }
}
    