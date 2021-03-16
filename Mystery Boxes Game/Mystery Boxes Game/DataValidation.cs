using System;
using System.Collections.Generic;
using System.Text;

namespace Mystery_Boxes_Game
{
    class DataValidation
    {
        public static int CheckInt(int value, int low, int high)
        {
            bool valid = false;
            while (!valid)//!valid is the same as valid == false
            {
                string error = $"Whoops! Please enter an amount between {low} and {high}.";
                try
                {
                    
                    if (value >= low && value <= high)
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(error);

                }
            }
            return -1;
        }
    }
}
