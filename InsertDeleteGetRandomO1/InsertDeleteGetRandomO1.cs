public class RandomizedSet {
    Dictionary<int, int> dicValues;
    List<int> listValues;
    Random randomNo;

    public RandomizedSet() {
        dicValues = new Dictionary<int, int> ();
        listValues = new List<int>();
        randomNo= new Random();
    }
    
    public bool Insert(int val) {
        if(dicValues.ContainsKey(val))
            return false;

        listValues.Add(val);
        dicValues.Add(val,listValues.Count - 1);
        return true;   
    }
    
    public bool Remove(int val) {
        if(!dicValues.ContainsKey(val))
            return false;
        int index = dicValues[val];
        int lastIndex = listValues.Count - 1;
        //Swap val will deleted to last index in list using Tuple
        (listValues[index],listValues[lastIndex]) = (listValues[lastIndex],listValues[index]);
        //Update index of last element in dicValues
        dicValues[listValues[index]] = index;

        listValues.RemoveAt(lastIndex);
        dicValues.Remove(val);
        return true;
    }
    
    public int GetRandom() {
        int randomIndex = randomNo.Next(0,listValues.Count);
        return listValues[randomIndex];
    }
}
