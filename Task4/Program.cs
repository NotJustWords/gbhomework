using System;

namespace Task4
{
    class Program
    {
        /*
         * Для полного закрепления понимания простых типов найдите любой чек,
         * либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
         * только за место динамических, по вашему мнению, данных (это может быть дата,
         * название магазина, сумма покупок) подставляйте переменные, которые были заранее
         * заготовлены до вывода на консоль.
         */

        enum Goods
        {
            Number_Nine,
            Number_Nine_Large,
            Number_Six,
            Number_Seven,
            Number_Forty_Fifth,            
            Large_Soda,
        }
      
        static void Main(string[] args)
        {
            float Number_Nine = 6f;
            float Number_Nine_Large = 2.30f;
            float Number_Six = 1.75f;
            float Number_Seven = 1.89f;
            float Number_Forty_Fifth = 3.50f;
            float Large_Soda = 1.2f;

            #region
            Console.WriteLine($"{Goods.Number_Nine, -19}  {Number_Nine,-4}$\n" +
                $"{Goods.Number_Nine, -20} { Number_Nine, -4}$\n" +
                $"{Goods.Number_Nine_Large, -20} {Number_Nine_Large, -4}$\n" +
                $"{Goods.Number_Six, -20} {Number_Six, -4}$\n" +
                $"*with extra dip\n" +
                $"{Goods.Number_Seven,-20} {Number_Seven,-4}$\n" +
                $"{Goods.Number_Forty_Fifth,-20} {Number_Forty_Fifth,-4}$\n" +
                $"{Goods.Large_Soda,-20} {Large_Soda,-4}$\n\n");
            #endregion

            Console.WriteLine($"Outcome\t " +
                $"{Number_Nine*2 + Number_Nine_Large + Number_Six + Number_Seven + Number_Forty_Fifth + Large_Soda}");


        }
    }
}
