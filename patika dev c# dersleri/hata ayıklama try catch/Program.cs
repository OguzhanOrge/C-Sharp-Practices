using System;
namespace try_catch
{
    class program
    {
        static void Main(string[]args)
        {
           // //try
           // {
           //     Console.WriteLine("sayı girin");
           //     int sayi=Convert.ToInt32(Console.ReadLine());
           //     Console.WriteLine("grimiş olduğunuz sayı",sayi);
           // }
           // catch(Exception ex)
           // {
           //     Console.WriteLine("hata mesajı:"+ex.Message.ToString());
           // }
            //finally
            //{
            //    Console.WriteLine("işlem tamamlandı");
            //}
            try
            {
               // int a= int.Parse(null);
               // int c= int.Parse("test");
                int b= int.Parse("-2000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("boş değer girdiniz");
                Console.WriteLine(ex);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);
                
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Cok kücük yada cok buyuk");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("işlem başarıyla tamamlandı");
            }
        }

    }
}