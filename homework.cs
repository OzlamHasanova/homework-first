namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //int a = Convert.ToInt32(Console.ReadLine());
           
            //readline-dan aldigimiz deyeri arrayin uzunlugu ile elaqelendire bilmedim.
            //xeta olaraq sabit deyer girmeli oldugumuzu bildirdi.


            int[] array = new int[6] {1,2,3,4,5,9};
            int sum = 0;
          
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                   
                }
            }
            Console.WriteLine(sum);
        }
    }
}