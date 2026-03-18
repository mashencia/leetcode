//03.18.2026

/*
~ ProductOfArrayExceptSelf ~
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //initializing the first prefix product as 1 since no prefix
        int [] PreProduct = new int[nums.Length];
        
        //Prefix Product Calculation
        for(int i=0; i< nums.Length; i++){
            if(i == 0){
                //Base case for the very first prefix
                PreProduct[i] = 1;
            }else{
                PreProduct[i] = PreProduct[i-1]*nums[i-1];
            }
        }

        //Postfix Product Calculation
        int ProductBefore = 1;
        for(int i=0; i<nums.Length; i++){
            if(i==0){
                continue;
            }else{
                int length = nums.Length;
                ProductBefore=ProductBefore*nums[length-i];
            }  
            PreProduct[nums.Length-1-i] *= ProductBefore;
        }

        return PreProduct;
    }
}

/*
Solved via prefix and postfix products. Time complexity of O(n) was achieved via implementing 2 loops. First loop calculates 
the prefix product, and the second calculates the postfix product and overall product except self. The logic for calculating
the prefix product consists of a base case, element at the first index contains no prefex product, hence the pre. product is 1.
For the next iterations, the prefix product equals theproduct of the previous element's prefix product and the value of that 
element. Notice, the previous element was the "self" in the previous iteration. In terms of the postfix product, the logic is 
almost the same, but in reverse. Implementation wise, instead of using an array like with the pre. product, a temporary variable
will hold the current postfix product. This reduces the space complexity, since another array would increase it to linear space,
but also simplifies the calculation for the actual product except self, with answer array being the PreProduct array. All of the
calculations concerning the asnwer are done in the second loop as we are computing the postfix product.
*/

