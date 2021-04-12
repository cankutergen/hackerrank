static int maximumToys(int[] prices, int k) {
        Array.Sort(prices);
        
        int budget = k;
        int numberOfToys = 0;
        foreach(var price in prices){
            if(budget - price < 0)
                break;
            
            budget -= price;
            numberOfToys++;
        }
        
        return numberOfToys;
    }
