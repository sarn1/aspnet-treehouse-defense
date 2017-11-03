namespace TreehouseDefense
{
    //inherits from System.Exception
    class TreehouseDefenseException : System.Exception
    {
        //no base since this is the default constructor and it implies that the base constructor is called
        public TreehouseDefenseException()
        {

        }

        public TreehouseDefenseException(string msg) : base(msg)
        {

        }
    }

    class OutOfBoundsException : TreehouseDefenseException
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string msg) : base(msg)
        {

        }
    }
}
