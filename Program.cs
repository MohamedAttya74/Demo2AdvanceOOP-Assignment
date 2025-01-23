using System.Collections;

namespace Demo2AdvanceOOP__Assignment
{
    internal class Program
    {



        public static int SumArrayList(ArrayList Numbers)
        {
            int sum = 0;
            if (Numbers is not null)
                for (int i = 0; i < Numbers.Count; i++)
                {
                    sum += (int?)Numbers[i] ?? 0; // Casting from Object[Referance Type ] To int[Value Type ]  --> UnBoxing [UnSafe Casting : May Throw InvalidCastExecption]

                }
            return sum;
        } 
        public static int SumOfList(List<int> Numbers)
        {
            int sum = 0;
            if (Numbers?.Count > 0) //  اكبر من ال 0 ولا لا  Count  ولا لا ومنها بتشوف ال  null  ب Numbers  علي ال  check  دي افضل ويعتبر بتضرب عصفورين بحجر منها انك ب 
                for (int i = 0; i < Numbers.Count; i++)
                {
                  sum += (int?)Numbers[i] ?? 0; // ولا حاجه  UnBoxing  هنا مش بعمل 
                }
            return sum;
        }
        static void Main(string[] args)
        {
            #region Non Genaric Collections - ArrayList 

            ///  ArrayList Numbers = new ArrayList(); //    ودي حاجه مش كويسه  Boxing and UnBoxing    وبكدا هيحصل  Object  بتعتمد علي ال 
            ///  //ArrayList Numbers = new ArrayList() {1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 ,9  };  //  AddMethod كدا واسهل من ان استخدم ال  Add ممكن اعمل 
            /// 
            ///  Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            /// 
            ///  Numbers.Add(1);
            ///  Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            /// 
            ///  Numbers.Add(2);
            ///  Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            /// 
            ///  Numbers.AddRange( new int[] { 3, 4 });
            ///  Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            /// 
            ///  Numbers.Add(5);
            ///  Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            /// 
            /// 
            ///  Numbers.TrimToSize(); // Free | Delete | Release | Deallocate  Unused Bytes  = 12 Bytes 
            ///  Console.WriteLine("------ After Trimming ");
            ///  Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            ///  ArrayList Numbers = new ArrayList(5) { 1, 2 , 3 , 4 , 5 };
            /// 
            ///   Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            /// 
            /// 
            ///  //Numbers.EnsureCapacity();  : List بس موجوده فال     ArrayList دي مش موجوده فال  Method    بس للاسف ال     Loop  قبل ما ادخل ال  Capacity علي ال  Check  ب 
            ///  if ( Numbers.Capacity  < 21  ) 
            ///           Numbers.Capacity = 21;
            ///  
            ///  for (int i = 6; i <= 21; i++)
            ///  {
            ///      Numbers.Add(i);
            /// 
            ///  }
            ///   Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            ///   // Problem in ArrayList :   List  فاضي ودا مش منطق ودا هتلاقيه فال  Array  مثلا  وفاضيه كل مره هيروح يحجز 20   ArrayList    لو عندي 20
            /// 
            ///   // Problem in  Non Genaric Collections : 
            ///   // 1-  ==>    Boxing and UnBoxing  علشان ال  Object  انها بتعتمد علي ال 
            ///   ArrayList Numbers = new ArrayList(5);
            ///   Numbers.Add(1) ; // Casting Fron int[Value Type] To Object[Referance Type ] ==> Boxing 
            ///   Numbers.Add(2) ; // Casting Fron int[Value Type] To Object[Referance Type ] ==> Boxing 
            ///   Numbers.Add(3) ; // Casting Fron int[Value Type] To Object[Referance Type ] ==> Boxing 
            ///   Numbers.Add(4) ; // Casting Fron int[Value Type] To Object[Referance Type ] ==> Boxing 
            ///   Numbers.Add(5) ; // Casting Fron int[Value Type] To Object[Referance Type ] ==> Boxing 
            ///   // 2-  ==> UnBoxing : 
            ///   Numbers.Add("Hamada"); // Compiler Can`t Enforce Type Safty  
            ///   // واحد  Type  يعني مش كله  Type   فيها اكتر من  Array  ممكن يكون ليها ميزه وهي ان ممكن يكون عندي 
            /// 
            ///    int Result = SumArrayList(Numbers);
            ///   Console.WriteLine($"Result = {Result} ");
            ///   

            #endregion

            #region Genaric Collextions - List 

            /// List<int> Numbers = new List<int>();
            /// Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///    Numbers.Add(1);  // int   ومستنيه   Genaric  ولا حاجه علشان هي  Boxing  محصلش 
            ///    Numbers.Add(2);
            ///    Numbers.AddRange([3  , 4  ]);
            ///    Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///    Numbers.Add(5);
            ///    Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            ///     
            ///    Numbers.TrimExcess();  //  Free | Deallocte | Release Unused Bytes => 12 Bytes  
            ///    Console.WriteLine("---------- After Trimming ---------- ");
            ///    Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            ///    List<int> Numbers = new List<int>(5) { 1 , 2 , 3 , 4  };
            /// 
            ///    Numbers[0] = 100;
            ///    //Numbers[4] = 500; // Invalid Becouse Out Of Indexer 
            ///  /// for (int i = 0; i < Numbers.Count; i++) 
            /// {
            ///     Console.WriteLine(Numbers[i]); 
            /// }
            ///   
            ///    foreach (int Number in Numbers) {
            ///        Console.WriteLine(Number);
            ///    }

            ///  List<int> Numbers = new List<int>(5) { 1, 2, 3, 4 , 5  };
            /// 
            ///  Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");
            /// 
            ///  Numbers.EnsureCapacity(21);
            ///  for (int i = 6; i <= 21; i++)
            ///  { 
            ///  Numbers.Add(i);
            ///  }
            ///  Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            List<int> Numbers = new List<int>() ;

            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.Add(3);
            Numbers.Add(4);
           //  Numbers.Add("Hamada"); // Compiler can Enforce Type Safty  

            int Result = SumOfList(Numbers);
            Console.WriteLine($" Result = {Result} ");



            #endregion


        }
    }
}
