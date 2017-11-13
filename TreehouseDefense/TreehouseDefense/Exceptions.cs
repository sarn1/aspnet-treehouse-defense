namespace TreehouseDefense
{
    //inherits from System.Exception
    class TreehouseDefenseException : System.Exception
    {
        //no base since this is the default constructor and it implies that the base constructor is called
        public TreehouseDefenseException()
        {

        }

        //is a type of systemexception
        public TreehouseDefenseException(string msg) : base(msg)
        {

        }
    }

    //is a type of treehousedefenseexception
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
