
    public class Checkers
        {
    public bool CheckInputForSQL ( string StrInput )
        {
        if (StrInput.IndexOf("'") > 0
            | StrInput.IndexOf("%") > 0
            | StrInput.IndexOf("!") > 0
            | StrInput.IndexOf("*") > 0
            | StrInput.ToLower().IndexOf("drop") > 0
            | StrInput.ToLower().IndexOf("select") > 0
            | StrInput.ToLower().IndexOf("delete") > 0
            | StrInput.ToLower().IndexOf("insert") > 0)
            {
            return false;
            }
        return true;
        }

    }
