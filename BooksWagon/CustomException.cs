using System;
using System.Collections.Generic;
using System.Text;

namespace BooksWagon
{
    public class CustomException:Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            NULL_EXCEPTION, CLASS_NOT_FOUND, METHOD_NOT_FOUND, WebDriverException, NoSuchElementException, NoSuchWindowException, InvalidSelectorException, NoSuchSessionException, FileNotFoundException,
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
