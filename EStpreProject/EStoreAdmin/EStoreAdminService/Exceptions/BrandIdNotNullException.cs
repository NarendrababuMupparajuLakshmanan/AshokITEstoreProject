using System;
namespace EStoreAdminService.Exceptions
{
    public class BrandIdNotNullException : Exception
    {

        public BrandIdNotNullException()
            : base()
        {
            
        }

        public BrandIdNotNullException(string Message)
            : base(Message) { }
    }
}
