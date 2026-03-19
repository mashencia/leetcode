//03.18.2026

/*
~ Best Time to Buy or Sell Stock ~
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = prices[0];
        int profit = 0;
        for(int i = 1; i < prices.Length; i++){
            if(buy > prices[i]){
                buy = prices[i];
            }
            if((prices[i]-buy) > profit){
                profit = prices[i]-buy;
            }
        }
        return profit;
    }
}

/*
Solved by implementing an iterating loop over each element post the initial imitating
a real trace of the problem. The price at which the stocked was bought is tracked as 
it determines the profit. The selling price is not tracked, since its meaning is consumed 
by the profit. We can change the buying price, but this does not guarantee that the max
profit will change. The buying price changes if there is a lower price, the profit changes
only if there is a price at which the profit will exceed its previous mark. This ensures
only the maximum is recorded. 
*/