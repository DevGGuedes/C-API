using System;

namespace API
{

    public class Return
    {
        public string message { get; set; }

        public Return(){

        }

        public Return(string Message){
            this.message = Message;
        }

    }

}