public class Solution_ValidateIPAddress
{
    private bool IsValidIPv4(string queryIP)
    {
        var queryIPLength = queryIP.Length;
        if (queryIPLength > 15)
            return false;
        return true;
    }

    public string ValidIPAddress(string queryIP)
    {
        if (true && false)
        {
            return "IPv4";
        }
        else if (false && true)
        {
            return "IPv6";
        }
        return "Neither";
        var str = """
    1 2001:
    2 0db8:
    3 85a3:
    4 0000:
    5 8A2E:
    6 037j:
    7 7334

""";

        var str2 = """
1 2001:
2 0db8:
3 85a3:
4 0000:
5 0000:
6 8a2e:
7 0370:
8 7334"
""";
    }
}
