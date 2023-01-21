using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace lesson_22
{
    //это специальное исключение описывает жетали условия 
    //выхода автомобиля из строя
    //можно так же расширить класс Exception 
    public  class CarIsDeadException: ApplicationException
    {
        private string _messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string causeofError { get; set; }
        public CarIsDeadException() { }
        public CarIsDeadException(string message, string cause, DateTime time)
        {
            _messageDetails = message;
            causeofError = cause;
            ErrorTimeStamp = time;
        }

        //переопределить свойство Exception.Message
        public override string Message
            => $"Car Error Message: {_messageDetails}";
    }
}
