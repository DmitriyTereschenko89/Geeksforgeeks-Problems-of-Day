namespace Validate_an_IP_Address
{
    internal class Solution
    {
        public bool IsValid(string str)
        {
            string[] parts = str.Split('.');
            if (parts.Length != 4)
            {
                return false;
            }

            foreach (string part in parts)
            {
                if (part.Length == 0 || (part.Length > 1 &&part[0] == '0'))
                {
                    return false;
                }

                int power = 10;
                int address = part[0] - '0';
                for (int i = 1; i < part.Length; i++)
                {
                    
                    address = address * power + (part[i] - '0');
                }

                if (address > 255)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
