using System;
using System.ServiceModel;

namespace LibraryServiceSolution
{
    [ServiceContract]
    interface ILibraryService
    {
        [OperationContract]
        Book SearchBook(string bookName);
    }
}