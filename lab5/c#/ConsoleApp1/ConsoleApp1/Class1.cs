public class String
{
    public string data;
    public int counter()
    {
        int count = data.Length;
        return count;
    }
    public String()
    {
    }

}

public class CharString : String
{

    public CharString(string a)
    {
        data = a;
    }

}