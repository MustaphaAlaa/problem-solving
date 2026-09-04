class Result_IceCreamParlor
{

    /*
     * Complete the 'icecreamParlor' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER m
     *  2. INTEGER_ARRAY arr
     */
 
    public static List<int> icecreamParlor(int m, List<int> arr)
    {
        var dic = new Dictionary<int,List<int>>();
        var result = new List<int>();
        for (var i= 0; i< arr.Count; i++)
                 if(!dic.ContainsKey(arr[i]))
                        dic[arr[i]] = new List<int>{1+i};
                else dic[arr[i]].Add(1+i);
                 

             
        
        for (var i= 0; i< arr.Count; i++)
            {
                 int comp = m - arr[i];  
                if((dic.ContainsKey(comp))){
                {
                    if(dic[comp].Count == 2)
                     return dic[comp];
                    else {
                        result.Add(dic[comp][0]);
                        result.Add(dic[arr[i]][0]);
                       result = result.Order().ToList();
                         return result;
                    } 
                }
                }
            }
            return result;

    } 
}
