using System;

namespace Course17_CustomExceptions.Entities.Exceptions {
    class DomainException : ApplicationException {

        public DomainException(string message) : base(message) { }
    }
}
