namespace Algorithm._925
{
    public class Solution01
    {
        public static bool IsLongPressedName(string name, string typed) {
            int i=0,j=0;

            while(j< typed.Length){
                if(i< name.Length && name[i]==typed[j])
                {
                    i ++;
                    j ++;
                }
                else if(j>0 && typed[j] == typed[j-1])
                {
                    j ++;
                }
                else
                {
                    return false;
                }
            }
            return i==name.Length;
        }
    }
}