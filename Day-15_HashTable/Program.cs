// See https://aka.ms/new-console-template for more information
using Day_15_HashTable;

Console.WriteLine("Hash Tables");


bool flag = true;
while (flag)
{
    Console.WriteLine("\nEnter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            MyMapNode<string, string> hashtable = new MyMapNode<string, string>(5);
            hashtable.Add("0", "Hi");
            hashtable.Add("1", "Hello");
            hashtable.Add("2", "How");
            hashtable.Add("3", "Are");
            hashtable.Add("4", "You");
            hashtable.Add("5", "Dear");
            Console.ReadLine();
            break;
        case 2:
            MyMapNode1<string, int> hashtable1 = new MyMapNode1<string, int>(5);
            string input = "Paranoids are are not paranoid because they are paranoid but because they \n    keep putting themselves deliberately into paranoid avoidable situations\n";
            Console.WriteLine($"Statement is:- {input}");
            try
            {
                string[] inputArray = input.Split();
                foreach (string word in inputArray)
                {
                    if (hashtable1.Get(word) == 0)
                    {
                        hashtable1.Add(word, 1);
                    }
                    else
                    {
                        int value = hashtable1.Get(word) + 1;
                        hashtable1.Set(word, value);
                    }
                }
                string[] newInputArray = inputArray.Distinct().ToArray();
                foreach (var word in newInputArray)
                {
                    Console.WriteLine("Frequency of Word occurrence :- \"" + word + "\" is :- " + hashtable1.Get(word));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            break;
        case 3:
            MyMapNode1<string, int> hashtable11 = new MyMapNode1<string, int>(5);
            string input11 = "Paranoids are are not paranoid because they are paranoid but because they \n    keep putting themselves deliberately into paranoid avoidable situations\n";
            Console.WriteLine($"Statement is:- {input11}");
            try
            {
                string[] inputArray = input11.Split();
                foreach (string word in inputArray)
                {
                    if (hashtable11.Get(word) == 0)
                    {
                        hashtable11.Add(word, 1);
                    }
                    else
                    {
                        int value = hashtable11.Get(word) + 1;
                        hashtable11.Set(word, value);
                    }
                }
                string[] newInputArray = inputArray.Distinct().ToArray();
                foreach (var word in newInputArray)
                {
                    Console.WriteLine("Frequency of Word occurrence :- \"" + word + "\" is :- " + hashtable11.Get(word));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            string input1 = "Paranoids are are not paranoid because they are paranoid but because they \n               keep putting themselves deliberately into paranoid avoidable situations\n";
            Console.WriteLine($"Statement is:- {input11}");
            hashtable11.Display();
            try
            {

                string[] inputArray = input11.Split();

                foreach (string word in inputArray)
                {
                    if (hashtable11.Get(word) == 0)
                    {
                        hashtable11.Add(word, 1);
                    }
                    else
                    {
                        int value = hashtable11.Get(word) + 1;
                        hashtable11.Set(word, value);
                    }
                }
                string[] newInputArray = inputArray.Distinct().ToArray();
                foreach (var word in newInputArray)
                {
                    Console.WriteLine("Frequency of Word ccurrence :- \"" + word + "\" is :- " + hashtable11.Get(word));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            hashtable11.Remove("avoidable");

            Console.ReadLine();
            break;
        case 4:
            flag = false;
            break;
    }
}