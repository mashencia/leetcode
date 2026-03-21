//03.21.2026

/*
~ Minimum Window Substring ~

Time Complexity: O(n)
Space Complexity: O(n)

*/

public class Solution {
    public string MinWindow(string s, string t) {
        
        var MapS = new Dictionary<char, int>();
        var MapT = new Dictionary<char, int>();
        for(int i = 0; i<t.Length; i++){
            MapT[t[i]] =MapT.GetValueOrDefault(t[i], 0) + 1;
        }
        
        int CounterT = MapT.Count;
        int CounterS = 0;

        string MinSubstring = "";

        int CurrentLength = 0;
        int MinimumLength = -1;

        int LeftPointer = 0;
        for(int i = 0; i < s.Length; i++){
            MapS[s[i]] = MapS.GetValueOrDefault(s[i], 0) + 1;
            if(MapT.ContainsKey(s[i]) && MapS[s[i]] == MapT[s[i]]){
                CounterS ++;
            }
            while(CounterS == CounterT){
                
                int windowSize = i - LeftPointer + 1;
                if(MinimumLength == -1 || windowSize < MinimumLength){
                    MinimumLength = windowSize;
                    MinSubstring = s.Substring(LeftPointer, MinimumLength);
                }

                char DeleteChar = s[LeftPointer];
                MapS[DeleteChar] --;

                if(MapT.ContainsKey(DeleteChar) && MapS[DeleteChar] < MapT[DeleteChar]){
                    CounterS --;
                }

                LeftPointer++;
            }
        }

       
        if(MinimumLength == -1){
            return "";
        }else{
            Console.WriteLine("I return here");
            return MinSubstring;
        }
        
    }
}