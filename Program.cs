namespace G_NET_26_OOP_5
{
    internal class Program
    {
        public interface IPrintable
        {
            void Print();
        }
        public interface IBookable
        {
            bool Book();
            bool Cancel();
            bool IsBooked { get; }
        }
        public static void PrintAll(IPrintable[] tickets)
        {
            foreach (var ticket in tickets)
            {
                ticket.Print();
            }
        }
        static void Main(string[] args)
        {
            #region Q1
            /*
             What is an Interface in C?
            الـ Interface هو عقد (Contract) يحدد مجموعة من methods أو properties
                                 لكن بدون كتابة التنفيذ.


                                    يعني هو يقول للكلاس: لازم تنفذ الميثود  دى لكن ما بيكتبش الكودجواه 
                                        interface IAnimal
                                        {
                                       void Speak();
                                         }     ::  مثلا          
                                                   هتختلف بقى من كلاس للتانى على حسب 
                                                  class Dog : IAnimal
            {
                                           public void Speak()
                                                          {
                                                    Console.WriteLine("Bark");
                                                            }
            لان الInterfaces  ومنظم اكترابيخلى الكود مرن 
            بدل أن يعتمد الكود على Class محدد
            يعتمد على Interface.

            Benefits of Using Interfaces

                                        - Loose Coupling
                                    بيخلى لكود غير مرتبط بكلاس معين
                                   فيمكن تغييره بسهولة
            .
            - Flexibility & Extensibility
            نقدر نغير implementation بدون تغيير الكود الأساسي.

                       -  Polymorphism
            نقدر نتعامل مع أنواع مختلفة باستخدام نفس الـ interface.
            مثلا
            List<IAnimal> animals  >>>>>>>>>>>>اوDogCatاوBirdهممكن يكون

            */
            #endregion
            #region Q2
            /*المشكله ان الـالـ Interface الاثنين عندهم نفس الميثود 
             * لكن الكلاس كتب تنفيذ واحد فقط وهنستخدمه لكلا الـ interfaces.

            إذًا لا يمكن التمييز بين   English greeting
            Arabic greeting   
                                                            طيب ازاى احل المشكله 


                       Explicit Interface Implementation      هستخدم ا ل
            فهتبقى كد                               
            class Translator : IEnglishSpeaker, IArabicSpeaker
            {
                void IEnglishSpeaker.Greet()
                {
                    Console.WriteLine("Hello");
                }

                void IArabicSpeaker.Greet()
                {
                    Console.WriteLine("Ahlan");
                }
            }دلوقتى كل واحد عندهحاجه مختلفه ينفذها


                        -c)After applying your fix, can you call Greet() directly on a Translator object (e.g. translator.Greet())? Why or why not? How do you call each version?
                           لأن الميثود أصبحت مرتبطة بالـ Interface فقط.  لا 
            }                              Translator t = new Translator();

            ((IEnglishSpeaker)t).Greet();
            ((IArabicSpeaker)t).Greet();   الطريقه الصحيحه
            }
            }*/
            #endregion
            #region Q3
            /*  Explain the difference between a shallow copy and a deep copy.
                             Shallow Copy	                Deep Copy
            Reference Fields	Shared	                    Duplicated
            Safety	             Risky	                      Safe
            Performance	         Fast	                     Slower
            Memory Usage	     Lower	                     Higher

                        When to Use
            Shallow → object is immutable, no nested reference state, performance is critical
            Deep → objects must be isolated, modifications should not affect original
              */
            #endregion
            #region Q4
            /*   
             *   Output:    Dev - Testing
                            QA - Testing
               تشارك بين النسختين، لذلك لما اتغير اسم القسم اتغير عند الاتنين Department objectف الShallow Copy  لأننا استخدمنا الـ */
            #endregion



            StandardTicket t1 = new StandardTicket
            {
                MovieName = "Avengers",
                Price = 100
            };

            VIPTicket t2 = new VIPTicket
            {
                MovieName = "Batman",
                Price = 200
            };

            ImaxTicket t3 = new ImaxTicket
            {
                MovieName = "Avatar",
                Price = 250
            };

            t1.Book();
            t2.Book();

            IPrintable[] tickets = { t1, t2, t3 };

              PrintAll(tickets);

            VIPTicket cloned = (VIPTicket)t2.Clone();
            cloned.Print();
        }

       
        
    }
}