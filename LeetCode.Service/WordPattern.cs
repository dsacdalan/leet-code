using System.Collections;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public bool WordPattern(string pattern, string str) {
            var hashTable = new Hashtable();
            
            var patternArray = pattern.ToCharArray();
            var strArray = str.Split(' ');
            
            if (patternArray.Length != strArray.Length) return false;
            
            for(int i = 0; i < patternArray.Length; i++)
            {
                if(hashTable.ContainsKey(patternArray[i]))
                {
                    if ((string)hashTable[patternArray[i]] != strArray[i]) return false;
                }
                else if(hashTable.ContainsValue(strArray[i])){
                    return false;
                }
                else {
                    hashTable.Add(patternArray[i], strArray[i]);
                }
            }
            
            return true;
        }
    }
}