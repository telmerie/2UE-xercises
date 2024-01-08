using System.Runtime.InteropServices;

class StockPrices
{

    static void Main()
    {
        int[] stockPrices = [7, 1, 5, 3, 6, 4];
        int maxProfit = 0;

        if (stockPrices.Length >= 2)
        {
            for (int i = 0; i < stockPrices.Length - 1; i++)
            {
                int buy = stockPrices[i];

                for(int j = i+1; j < stockPrices.Length; j++){
                    int sell = stockPrices[j], profit = sell-buy;
                    if(profit > maxProfit){
                        maxProfit = profit;
                    }
                }
            }

            Console.WriteLine($"Max profit is : {maxProfit}");
        }


    }



}