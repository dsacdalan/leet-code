using System.Collections.Generic;

namespace leetcode
{
public class MyHashSet {

    List<int>[] hashSet;
    int size = 10000;
    
    /** Initialize your data structure here. */
    public MyHashSet() {
        hashSet = new List<int>[size];
    }
    
    private int Hash(int key) {
        return key % size;
    }
    
    public void Add(int key) {
        var index = Hash(key);
        
        // If new
        if (hashSet[index] == null)
            hashSet[index] = new List<int>();
        
        if (!hashSet[index].Contains(key))
            hashSet[index].Add(key);
    }
    
    public void Remove(int key) {
        var index = Hash(key);
        
        if (hashSet[index] != null) {
            hashSet[index].Remove(key);
        }
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        var index = Hash(key);
        
        if (hashSet[index] != null) {
            return hashSet[index].Contains(key);
        }
        
        return false;
    }
}
}
