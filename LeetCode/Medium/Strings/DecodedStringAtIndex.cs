namespace LeetCode.Medium.Strings;

public static class DecodedStringAtIndex
{
    public static string Run(string s, int k) {
        long N = 0;
        int i;
        
        for (i = 0; N < k; i++) {
            if (char.IsDigit(s[i])) {
                N *= s[i] - '0';
            }
            else {
                N++;
            }
        }
        
        while (i-- > 0) {
            if (char.IsDigit(s[i])) {
                N /= s[i] - '0';
                k %= (int)N;
            }
            else if (k % (int)N-- == 0) {
                return s[i].ToString();
            }
        }
        
        return string.Empty;
    }
}