using System;
using System.Collections.Generic;
using System.Linq;


//لینک و لامدا زیادن سرچ کنم سمپل های لینک و لامدا


namespace ConsoleApp3_LinqAndLambdaVol2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();

            Person P1 = new Person();

            P1.PersonID = 1;
            P1.Name = "A";
            P1.Family = "a";
            P1.Age = 21;

            People.Add(P1);

            Person P2 = new Person()
            {
                PersonID = 2,
                Name = "B",
                Family = "b",
                Age = 20,
            };//با این روش که اسمش ابجکت اینیشیالایز هست میشه توابع و فیلد ها و پراپرتی ها را همانجا و در لحظه بدون ساخت کانستراکتور مقدار دهی کرد
            //P2.Age = 19;//بعد ها هم میشه باز مقدار داد

            People.Add(P2);

            Person P3 = new Person();
            P3.PersonID = 3;
            P3.Name = "D";
            P3.Family = "d";
            P3.Age = 84;

            People.Add(P3);

            foreach (Person Print in People)//پیپل از جنس پرسن هست میتونیم وَر هم بزاریم
            {
                Console.WriteLine($"PersonID {Print.PersonID}   Name {Print.Name}   Family {Print.Family}   Age {Print.Age}");
                //این کار رو قبلا در متد ها و فیلد ها و کلاس ها ولیست ها و پراپرتی ها کردیم
            }

            Console.WriteLine("-----------------------------------------------------------------------");

            //var Lambda1 = People.ToList();//واقعا نمیدونم چرا وقتی لیست بود دوباره لیستش کردم در واقع برای ریختنش توی یک متغیر دیگر لازم بود که لیستش کنیم

            //foreach(var Print in Lambda1)//ما پیپل را که پرسون بود را لیست کردیم درونلامبدا یک پس لامبدا یک پرسون هست ولی اگر نمیدانستیم چه از وَر استفاده میکنیم
            //{
            //    Console.WriteLine($"PersonID: {Print.PersonID}  Name:{Print.Name}  Family:{Print.Family}  Age:{Print.Age}");
            //}



            //var Lambda2 = People.OrderBy(n => n.Age).ToList();

            //foreach (var Print in Lambda2)
            //{
            //    Console.WriteLine($"PersonID: {Print.PersonID}  Name:{Print.Name}  Family:{Print.Family}  Age:{Print.Age}");
            //}



            //var Lambda3 = People.Where(n => n.Name.ToLower().Contains("a")).ToList();
            ////اِن را که وارد اکسپرشن میکنیم خب اِن پیپل هست و یک لیست هست و پیپل هم خودش یک کلاس با پراپرتی های مختلف هست پس باید مشخص کنیم کدام پراپرتی را از پیپلی که پرسن هست و الان اِن صدا میشود را میخواهیم پس اول همیشه اسم کالکشن در ابتدای دستورات هست و بعد در پرانتز های لامدا اکسپرشن که اِن را به نمایندگی وارد میکنیم و اِن را به کار میگیریم باید مشخص کنیم کجای اِن را به کار میگیریم 

            //foreach (var Print in Lambda3)
            //{
            //    Console.WriteLine($"PersonID: {Print.PersonID}  Name:{Print.Name}  Family:{Print.Family}  Age:{Print.Age}");
            //}


            ////.Where(n => n.Age > 20 && n.Age < 84) //=21
            //var Lambda4 = People.Where(n => n.Age > 21 || n.Age < 21).OrderByDescending(n=>n.Age).ToList();
            ////هربار که در بدنه یا همان پرانتز لامدا اکسپرشن بخواهیم بر روی اِن که به نمایندگی از پیپل امده کاری انجام بدیم خب باید اسمش را صدا کنیم و بگوییم که با کدام قسمت اِن کار داریم مثل بالا که در ور دوبار پشت سر هم با اِن دات ایج صداش کردیم تا دوبار کاری را بهش بگوییم 

            //foreach (var Print in Lambda4)
            //{
            //    Console.WriteLine($"PersonID: {Print.PersonID}  Name:{Print.Name}  Family:{Print.Family}  Age:{Print.Age}");
            //}


            //var lambda5 = People.Select(n => n.Name).ToList();//دستور سلکت . جدید بود ها

            //foreach (var Print in lambda5)
            //{
            //    Console.WriteLine(Print);
            //}

            //////حالا اگر بخواهیم هم اسم هم فامیل باشد چی؟ یا اسم و ای دی؟
            //////باید بگوییم که سلکت ما خروجی جدیدی دارد که میخواهم درون ور بریزمش که بدونه 

            //var Lambda6 = People.Select(n => new { n.Name, n.Family }).ToList();//اگر دات تو لیست یا دات تو اری نزنیم وارد یک نوع دیگری از کالکشن ها و جنریک ها میکندش
            //var Lambda6 = People.Select(n => new { n.Name, n.Family });
            ////کلمه کلیدی نیو در اینجا کالکشنی از جنس ایکیوریلیبل میسازد
            //foreach (var Print in Lambda6)//حتما خروجیش رو ببین
            //{
            //    Console.WriteLine(Print);
            //    Console.WriteLine(Print.Name);
            //    Console.WriteLine(Print.Family);
            //}


            ////new List -----------------------------------------------------------------------------------

            List<PersonCar> CarInfo = new List<PersonCar>();

            PersonCar C1 = new PersonCar();

            C1.PersonId = 1;
            C1.CarNumber = "A1";
            C1.CarName = "Samand";

            CarInfo.Add(C1);

            PersonCar C3 = new PersonCar() { PersonId = 3, CarNumber = "D3", CarName = "AhanQoraze" };

            CarInfo.Add(C3);
            ////فقط سی 1 و سی 3 ماشین دارند یعنی اِی و دی


            //List<PersonCar> CarInfo = new List<PersonCar>()
            //{
            //    new PersonCar(){PersonId=1,CarNumber="A1",CarName="Z"} ,
            //    new PersonCar(){PersonId=2,CarNumber="B2",CarName="X"} ,
            //    new PersonCar(){PersonId=3,CarNumber="C3",CarName="Y"}
            //};
            ////یک نوع دیگر از مقدار دهی لیست هایی که از جنس کلاس با فیلد و پراپرتی اند


            Console.WriteLine("-----------------------------------------------------------------------"); 

            //حالا میخواهیم دوتا لیست را با هم ادقام کنیم با دستور لینک

            var JoinByLinq = (from p in People
                              join c in CarInfo on p.PersonID equals c.PersonId
                              select new
                              {                   //به این روش میگن جوین. به این شکل است که اول میگیم از                                                   
                                  p.PersonID,     //کالکشنی که میخواهیم اطلاعاتش اول چاپ شود و اصلی ان است
                                  p.Name,         // و مرجع ان است پس پرایمری کی ان است شروع میکنیم
                                  p.Family,       //پس فرام پی این کالکشن مرجع <<جوین>> سی در کالکشن خارجی 
                                  p.Age,          //آن>> ایتم یا سطونی که یا پرایمری کی که با هم ایکوال اند>>
                                  c.CarNumber,    //اول هم از کالکشن مرجع شروع میکنیم بعد کلمه کلیدی ایکوالز
                                  c.CarName       // بعد هم سلکت . ولی خب سلکت کدوم کالکشن پس نیو که ایکیوریلیبل
                              }).ToList();        //بسازد. انتخاب میکنیم از هر کالکشن چه چیزی انتخاب شود و با 
                                                  // جدا میکنیمشان و در اخر هم اگر لیست خواستیم و ایکیوریلیبل نه ,
                                                  // دات تو لیست میکنیم
                                                  //این مدل چون از نوع اینر جوین هست در اس کیو ال پس اون رکوردی که
                                                  //ایکوالش وجود ندارد نشان داده نمیشود

            foreach (var Print in JoinByLinq)
            {
                Console.WriteLine(Print);
            }

            Console.WriteLine("-----------------------------------------------------------------------");

            int[] NumbersLast = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9 };

            var Lambda99 = NumbersLast.Distinct().ToArray();//دستور دیستینکت حذف تکراری ها

            var Lambda98 = NumbersLast.OrderByDescending(n => n).Take(3).ToArray();//میاد سه تای اولی را میگیرد بر اساس ترتیبی که ما بهش دادیم به ما برمیگرداند. تکراری ها را هم حساب میکند

            var Lambda97 = NumbersLast.Take(3).ToArray();//سه تای اولی بر اساس ترتیببی که ما دادیم یعنی ترتیب آرایه مان

            var Lambda96 = NumbersLast.Distinct().OrderByDescending(n => n).Take(4).ToArray();//حذف تکراری ها. کاربردش چیه مثلا نشون دادن سه پلیر برتر بازی

            var Lambda95 = NumbersLast.OrderByDescending(n => n).Skip(2).ToArray();//میاد بر اساس ترتیبی که ما دادیم میپرد و تعدادی که ما خواستیم را بر اساس ترتیبی که ما بهش دادیم را میپرد و نشان نمیدهدشان
            
            var Lambda001 = NumbersLast.Distinct().OrderByDescending(n => n).Skip(4).Take(2).ToArray();// حذف تکراری ها و ترتیب و اینهاش دقیقا مشابه تِیک است

        }
    }
}
