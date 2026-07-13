namespace EStoreAdminService.Exceptions
{
    public class TypeIdNotNullException : Exception
    {
        public TypeIdNotNullException()
           : base()
        {

        }

        public TypeIdNotNullException(string Message)
            : base(Message) { }
    }
}
