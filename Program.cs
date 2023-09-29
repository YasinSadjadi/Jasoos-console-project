namespace Jasoos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // شیء تعریف شده در هنگام فراخوانی میتواند به ما در این پروژه عددی تصادفی در بازه ی دلخواه بدهد
            var random = new Random();

            int a;

            Console.WriteLine("please enter number of players");
            int NumPlayer = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter number of spies");
            int NumSpy = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter playTime(minuts)");
            double NumMin = double.Parse(Console.ReadLine());
            Console.Clear();

            // ارایه ای از اشیائی از جنس کلاس مورد نظر که جاسوس بودن یا نبودن را در خود ذخیره کرده است
            var Players =
                new SpyOrNot[NumPlayer];
            //در این حلقه که به تعداد تمام بازیکنان تکرار میشود به جاسوس بودن یا نبودن مقداردهی میشود
            for (int i = 0; i < Players.Length; i++)
            {
                // لازم به ذکر هست که برای نداشتن نوعی خطای خاص مجبوریم حلقه را به تعدادی فراتر از نیاز منطقی اجرا کنیم
                Players[i] = new SpyOrNot(spy: false);
            }

            // حلقه ی زیر میتواند جاسوسانی را به شکل تصادفی انتخاب کند
            for (int i = 0; i < NumSpy; i++)
            {
                a = random.Next(Players.Length);
                Players[a] = new SpyOrNot(spy: true);
            }

            //در ارایه ی زیر کلماتی قرار دارند که میتوان بدون هیچگونه تغییر در ساختار برنامه به انها اضافه نمود
            var Words = new string[]
            {
                "asemoon",
                "mashin",
                "sefid",
                "siah",
            };
            
            //در مرحله ی زیر عددی تصادفی برای انتخاب کلمه انتخاب مینماییم
            int WordChooser = random.Next(Words.Length);

            //در حلقه ی زیر کلمات به افراد عادی و جاسوس بودن به جاسوسان اطلاع رسانی میشود
            for (int i = 0; i < Players.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("press any key to collect the word");
                Console.ReadKey();

                if (Players[i].Spy == true)
                {
                    Console.Beep();
                    Console.WriteLine("You are Spy");
                    Console.ReadKey();
                }
                else
                {
                    Console.Beep();
                    Console.WriteLine($"{Words[WordChooser]}");
                    Console.ReadKey();                    
                }
            }

            Console.Clear();
            Console.ReadKey();

            // در این مرحله دقیقه و ثانیه ی زمان مشخص شده را محاسبه میکنیم
            int EstimatedTime = Convert.ToInt32(NumMin * 60);
            int Seconds = EstimatedTime % 60;
            int Minuts = (EstimatedTime - Seconds);

            // در حلقه ی زیر شاهد کانتر زمانی هستیم که زمان باقی مانده را به ما میگوید
            for (int i = (EstimatedTime); i > 0; i--)
            {
                Console.WriteLine($"{Minuts} : {Seconds}");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}