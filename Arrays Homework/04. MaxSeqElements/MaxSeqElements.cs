using System;


class MaxSeqElements
    {
        static void Main()
        {
            int[] myArr = new int[] { 3, 3, 3, 2, 2, 3, 2, 1, 1, 1, 1};

            int counter = 1;
            int maxCounter = 0;

            int maxElement = 0;

            for (int i = 0; i < myArr.Length-1; i++)
            {
                if (myArr[i] == myArr[i+1])
                {
                    counter++;
                }

                else
                {
                    if (counter>maxCounter)
                    {
                        maxCounter = counter;
                        maxElement = myArr[i];
                    }
                    
                    counter = 1;
                }
                
            }

            if (counter > maxCounter)
            {
                maxCounter = counter;
                maxElement = myArr[myArr.Length - 1];
            }



            int[] result = new int[maxCounter];

            Console.WriteLine("The maximum sequence of equal elements is: ");
            
            for (int i = 0; i < maxCounter; i++)
            {
                result[i] = maxElement;
                Console.WriteLine(result[i]);
            }


        }
    }
