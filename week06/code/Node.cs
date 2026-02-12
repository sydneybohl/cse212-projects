public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value == Data)
        {
            return; // this will help prevent duplicates
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            // Search the left subtree
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else // this would be value > Data
        {
            // Search the right subtree
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // Starts by assuming both subtree heights are 0
        int leftHeight = 0;
        int rightHeight = 0;

        // Recursively get the height of the left subtree
        if (Left != null)
            leftHeight = Left.GetHeight();

        // Recursively get the height of the right subtree
        if (Right != null)
            rightHeight = Right.GetHeight();

        // Compares the two subtree heights and returns
        // the larger one with +1 for the root
        if (leftHeight > rightHeight)
            return leftHeight + 1;
        else 
            return rightHeight + 1;
    }
}