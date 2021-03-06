//The commonly used alternative to solving this involves the use of for loops
//This creates a time complexity problem that increases the run time exponentially with the input
    
int countSumOfTwoRepresentations2(int n, int l, int r) {
    if(n >= 5 && n <= Math.Pow(10, 9)
        && l >= 1 && r >= l
        && r >= 1 && r <= Math.Pow(10,9) && 
        r - 1 <= Math.Pow(10,9))
    {
        int sucesses = 0;
        int maxSucesses = n/2;
        int gapLower = l - 1; //The gap is 0 at a lower bound of 1. 0 + n is not considered a valid sum
        int gapUpper = n - 1 - r; //-1 since 0 + n is invalid. The gap starts counting at 0 from n-1 = r
        if(gapLower > gapUpper)
        {
            sucesses = maxSucesses - gapLower;
        }
        else
        {
            sucesses = maxSucesses - gapUpper;
        }
        //If sucess is negitive
        if(sucesses < 0)
        {
            sucesses = 0;
        }
        return sucesses;
    }
    else
    {
        return -1;   
    }
}
