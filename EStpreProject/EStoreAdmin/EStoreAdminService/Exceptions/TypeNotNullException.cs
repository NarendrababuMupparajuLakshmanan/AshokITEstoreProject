namespace EStoreAdminService.Exceptions
{
    public class TypeNotNullException : Exception
    {

        public TypeNotNullException()
            : base()
        {
            
        }

        public TypeNotNullException(string Message)
            : base(Message) { }
    }
}
